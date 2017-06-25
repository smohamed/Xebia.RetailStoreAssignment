using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Core;

namespace Xebia.OnlineStore
{
    public sealed class BillCalculator : IBillCalculator
    {
        public IFixedDiscount FixedDiscountCalculator { get; private set; }

        public IPercentageDiscount PercentageDiscountCalculator { get; private set; }

        private BillCalculator()
        {
            FixedDiscountCalculator = FixedDiscount.Instance;
            PercentageDiscountCalculator = PercentageDiscount.Instance;
        }

        internal BillCalculator(IPercentageDiscount percentageDiscountCalculator, IFixedDiscount fixedDiscountCalculator)
        {
            FixedDiscountCalculator = fixedDiscountCalculator;
            PercentageDiscountCalculator = percentageDiscountCalculator;
        }

        public decimal CalculateNetPayableAmount(IBill bill)
        {
            var percentageDiscount = PercentageDiscountCalculator.Calculate(bill.Order);
            var fixedDiscount = FixedDiscountCalculator.Calculate(bill.BillAmount - percentageDiscount);

            return bill.BillAmount - percentageDiscount - fixedDiscount;
        }
    }
}
