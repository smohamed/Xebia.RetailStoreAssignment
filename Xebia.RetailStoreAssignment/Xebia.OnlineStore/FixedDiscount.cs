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

        private FixedDiscount()
        { }

        public decimal Calculate(decimal billAmount)
        {
            throw new NotImplementedException();
        }
    }
}
