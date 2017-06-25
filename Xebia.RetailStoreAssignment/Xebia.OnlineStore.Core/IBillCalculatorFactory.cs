using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Core
{
    public interface IBillCalculatorFactory
    {
        IBillCalculator Create(IPercentageDiscount percentageDiscountCalculator, IFixedDiscount fixedDiscountCalculator);
    }
}
