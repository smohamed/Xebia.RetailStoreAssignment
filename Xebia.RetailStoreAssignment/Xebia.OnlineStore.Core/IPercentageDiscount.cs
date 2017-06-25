using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Core
{
    public interface IPercentageDiscount
    {
        decimal DiscountForEmployee { get; }
        decimal DiscountForAffiliate { get; }
        decimal DiscountForCustomer { get; }
        int CustomerLoyaltyMinimumYears { get; }

        decimal Calculate(IOrder order);
    }
}
