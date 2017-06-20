using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public class Customer : IUser
    {
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }

        public virtual bool IsEmployee
        {
            get
            {
                return false;
            }
        }

        public virtual bool IsAffiliate
        {
            get
            {
                return false;
            }
        }
    }
}
