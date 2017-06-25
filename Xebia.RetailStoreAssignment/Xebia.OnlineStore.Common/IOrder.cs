using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Common
{
    public interface IOrder : IEnumerable<IOrderItem>
    {
        string OrderNumber { get; }
        DateTime OrderDate { get; }
        decimal GroceriesAmount { get; }
        decimal NonGroceriesAmount { get; }

        void AddItem(IOrderItem item);
        void RemoveItem(IOrderItem item);
    }
}
