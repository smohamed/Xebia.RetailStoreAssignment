using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public class BillCalculator
    {
        private BillAmount AmountBeforeAnyDiscount(Bill bill)
        {
            var amount = new BillAmount();

            if (bill.OrderDetails != null && bill.OrderDetails.OrderItems != null && bill.OrderDetails.OrderItems.Count > 0)
            {
                var gTypes = from oi in bill.OrderDetails.OrderItems
                             group oi by oi.ProductType into pt
                             select pt;

                foreach (var g in gTypes)
                {
                    if (g.Key == ProductType.Grocery)
                    {
                        amount.Grocery = g.Sum(i => i.Price);
                    }
                    else
                    {
                        amount.Other = g.Sum(i => i.Price);
                    }
                }
            }

            return amount;
        }

        private decimal PercentageDiscountAmount(Bill bill, BillAmount amount)
        {
            if (amount.Other.HasValue)
            {

                if (bill.User.IsEmployee)
                {
                    return amount.Other.Value * 0.3m;
                }
                else if (bill.User.IsAffiliate)
                {
                    return amount.Other.Value * 0.1m;
                }
                else if (DateTime.UtcNow.Date >= bill.User.JoiningDate.AddYears(2).ToUniversalTime().Date)
                {
                    return amount.Other.Value * 0.05m;
                }

                return 0;
            }

            return 0;
        }

        private int FixedDiscountAmount(decimal? total)
        {
            if (total.HasValue)
            {
                return ((int)(total / 100).Value) * 5;
            }

            return 0;
        }

        public decimal? CalculateNetPayable(Bill bill)
        {
            var amountBeforeAnyDiscount = AmountBeforeAnyDiscount(bill);
            var percentageDiscountAmount = PercentageDiscountAmount(bill, amountBeforeAnyDiscount);

            var runningTotal = amountBeforeAnyDiscount.Total - percentageDiscountAmount;
            var fixedDiscountAmount = FixedDiscountAmount(runningTotal);

            return runningTotal - fixedDiscountAmount;
        }
    }

    public sealed class BillAmount
    {
        public decimal? Grocery { get; set; }

        public decimal? Other { get; set; }

        public decimal? Total
        {
            get
            {
                return (Grocery ?? 0) + (Other ?? 0);
            }
        }
    }
}
