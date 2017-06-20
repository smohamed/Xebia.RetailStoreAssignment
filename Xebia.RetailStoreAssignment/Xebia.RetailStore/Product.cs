using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public sealed class Product
    {
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public decimal Price { get; set; }
    }
}
