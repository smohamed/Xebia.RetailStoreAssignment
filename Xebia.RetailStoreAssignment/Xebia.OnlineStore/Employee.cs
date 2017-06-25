using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore
{
    public sealed class Employee : User
    {
        public Employee(string name, DateTime joinDate, Employee manager = null) : base(name, joinDate)
        {
            Manager = manager;
        }

        public override bool IsEmployee => true;

        public override bool IsAffiliate => false;

        public Employee Manager { get; private set; }
    }
}
