using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Core;

namespace Xebia.OnlineStore
{
    public sealed class PercentageDiscount : IPercentageDiscount
    {
        private static readonly Lazy<PercentageDiscount> defaultCalc = new Lazy<PercentageDiscount>(() => new PercentageDiscount());

        public static PercentageDiscount Instance => defaultCalc.Value;

        private PercentageDiscount()
        { }

        public decimal Calculate(IOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
