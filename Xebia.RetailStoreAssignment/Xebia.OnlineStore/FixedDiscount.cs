using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Core;

namespace Xebia.OnlineStore
{
    public sealed class FixedDiscount : IFixedDiscount
    {
        private static readonly Lazy<FixedDiscount> defaultCalc = new Lazy<FixedDiscount>(() => new FixedDiscount());

        public static FixedDiscount Instance => defaultCalc.Value;

        public decimal DiscountAppliedForEach { get; private set; }

        public decimal DiscountValue { get; private set; }

        private FixedDiscount()
        {
            DiscountAppliedForEach = 100;
            DiscountValue = 5;
        }

        public decimal Calculate(decimal billAmount)
        {
            return ((int)(billAmount / DiscountAppliedForEach)) * DiscountValue;
        }
    }
}
