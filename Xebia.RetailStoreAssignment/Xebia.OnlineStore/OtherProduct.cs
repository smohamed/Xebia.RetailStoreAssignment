using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Core;

namespace Xebia.OnlineStore
{
    public sealed class OtherProduct : Product
    {
        public OtherProduct(string name, IProductType productType = null) : base(name, productType?? new NonGrocery("NonGrocery"))
        {
            Price = 100;
            AvailableStock = 1001;
        }
    }
}
