using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public sealed class Bill
    {
        public DateTime BillDate { get; set; }

        public User Customer { get; set; }

        public Order OrderDetails { get; set; }

        public BillAmount AmountBeforeAnyDiscount
        {
            get
            {
                var amount = new BillAmount();

                if (OrderDetails != null && OrderDetails.OrderItems != null && OrderDetails.OrderItems.Count > 0)
                {
                    var gTypes = from oi in OrderDetails.OrderItems
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
        }

        public decimal PercentageDiscountAmount
        {
            get
            {
                var amount = AmountBeforeAnyDiscount;

                if (amount.Other.HasValue)
                {

                    if (Customer.IsEmployee)
                    {
                        return amount.Other.Value * 0.3m;
                    }
                    else if (Customer.IsAffiliate)
                    {
                        return amount.Other.Value * 0.1m;
                    }
                    else if (DateTime.UtcNow.Date >= Customer.JoiningDate.AddYears(2).ToUniversalTime().Date)
                    {
                        return amount.Other.Value * 0.05m;
                    }

                    return 0;
                }

                return 0;
            }
        }

        public decimal? TotalAfterPercentageDiscount
        {
            get
            {
                return AmountBeforeAnyDiscount.Total - PercentageDiscountAmount;
            }
        }

        public int FixedDiscountAmount
        {
            get
            {
                if (TotalAfterPercentageDiscount.HasValue)
                {
                    return ((int)(TotalAfterPercentageDiscount / 100).Value) * 5;
                }

                return 0;
            }
        }

        public decimal TotalApplicableDiscount
        {
            get
            {
                return PercentageDiscountAmount + FixedDiscountAmount;
            }
        }

        public decimal? NetPayable
        {
            get
            {
                return AmountBeforeAnyDiscount.Total - TotalApplicableDiscount;
            }
        }
    }

    public struct BillAmount
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
