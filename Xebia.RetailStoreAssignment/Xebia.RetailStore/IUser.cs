using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.RetailStore
{
    public interface IUser
    {
        string Name { get; set; }
        DateTime JoiningDate { get; set; }
        bool IsEmployee { get; }
        bool IsAffiliate { get; }
    }
}
