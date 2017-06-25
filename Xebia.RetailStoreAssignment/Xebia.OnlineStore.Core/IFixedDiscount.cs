using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Core
{
    public interface IFixedDiscount
    {
        decimal DiscountAppliedForEach { get; }
        decimal DiscountValue { get; }

        decimal Calculate(decimal billAmount);
    }
}
