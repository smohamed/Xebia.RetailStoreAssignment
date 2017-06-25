using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Common;

namespace Xebia.OnlineStore
{
    public sealed class OrderItem : IOrderItem
    {
        private OrderItem()
        { }

        public OrderItem(IProduct product, int saleQuantity)
        {
            Product = product;
            ItemQuantity = saleQuantity;
        }

        public IProduct Product { get; private set; }

        public int ItemQuantity { get; private set; }

        public decimal TotalPrice => Product.Price * ItemQuantity;
    }
}
