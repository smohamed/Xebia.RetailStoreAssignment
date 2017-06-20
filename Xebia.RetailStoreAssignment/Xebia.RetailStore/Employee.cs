using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public sealed class Employee : Customer
    {
        public override bool IsEmployee
        {
            get
            {
                return true;
            }
        }
    }
}
