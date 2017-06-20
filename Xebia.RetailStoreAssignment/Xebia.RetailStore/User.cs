using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public sealed class User
    {
        public string Name { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsAffiliate { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
