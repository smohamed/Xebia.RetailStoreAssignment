using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Common
{
    public interface IOrderItem
    {
        IProduct Product { get; }
        int ItemQuantity { get; }
        decimal TotalPrice { get; }
    }
}
