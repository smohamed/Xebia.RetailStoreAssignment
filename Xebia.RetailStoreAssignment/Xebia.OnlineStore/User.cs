using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Core;

namespace Xebia.OnlineStore
{
    public abstract class User : IUser
    {
        private User()
        { }

        public User(string name, DateTime joinDate)
        {
            Name = name;
            JoiningDate = joinDate;
        }

        public string Name { get; protected set; }

        public DateTime JoiningDate { get; protected set; }

        public abstract bool IsEmployee { get; }

        public abstract bool IsAffiliate { get; }
    }
}
