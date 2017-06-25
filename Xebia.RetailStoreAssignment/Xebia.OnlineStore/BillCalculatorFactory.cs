using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Core;

namespace Xebia.OnlineStore
{
    public sealed class BillCalculatorFactory : IBillCalculatorFactory
    {
        private static readonly Lazy<BillCalculatorFactory> defaultFactory = new Lazy<BillCalculatorFactory>(() => new BillCalculatorFactory());
        public static BillCalculatorFactory Instance => defaultFactory.Value;

        private BillCalculatorFactory()
        { }

        public IBillCalculator Create(IPercentageDiscount percentageDiscountCalculator, IFixedDiscount fixedDiscountCalculator)
        {
            return new BillCalculator(percentageDiscountCalculator, fixedDiscountCalculator);
        }
    }
}
