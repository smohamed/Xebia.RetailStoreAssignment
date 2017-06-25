using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Core
{
    public interface IProduct
    {
        string Name { get; }
        IProductType ProductType { get; }
        decimal Price { get; }
        int AvailableStock { get; }
    }
}
