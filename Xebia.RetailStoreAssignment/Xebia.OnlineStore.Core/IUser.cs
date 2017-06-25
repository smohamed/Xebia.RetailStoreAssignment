using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Core
{
    public interface IUser
    {
        string Name { get; }
        DateTime JoiningDate { get; }
        bool IsEmployee { get; }
        bool IsAffiliate { get; }
    }
}
