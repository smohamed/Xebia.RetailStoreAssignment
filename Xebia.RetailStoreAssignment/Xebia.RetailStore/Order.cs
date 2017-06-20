﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public sealed class Order
    {
        public DateTime OrderDate { get; set; }
        public List<Product> OrderItems { get; set; }
    }
}
