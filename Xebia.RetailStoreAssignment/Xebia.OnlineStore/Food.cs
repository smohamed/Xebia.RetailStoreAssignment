using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Core;

namespace Xebia.OnlineStore
{
    public sealed class Food : Product
    {
        public Food(string name) : base(name, Grocery.Instance)
        {
            Price = 100;
            AvailableStock = 230;
        }
    }
}
