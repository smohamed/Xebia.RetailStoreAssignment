using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Core
{
    public interface IBillCalculator
    {
        decimal CalculateNetPayableAmount(IBill bill);

        IFixedDiscount FixedDiscountCalculator { get; }
        IPercentageDiscount PercentageDiscountCalculator { get; }
    }
}
