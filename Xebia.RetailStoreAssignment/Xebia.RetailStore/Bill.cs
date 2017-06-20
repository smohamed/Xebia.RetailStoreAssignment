﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public sealed class Bill
    {
        public DateTime BillDate { get; set; }

        public IUser User { get; set; }

        public Order OrderDetails { get; set; }
    }
}
