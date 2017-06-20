using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public sealed class Affiliate : Customer
    {
        public override bool IsAffiliate
        {
            get
            {
                return true;
            }
        }
    }
}
