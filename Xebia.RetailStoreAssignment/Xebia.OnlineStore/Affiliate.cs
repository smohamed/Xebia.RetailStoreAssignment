using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore
{
    public sealed class Affiliate : User
    {
        public Affiliate(string name, DateTime joinDate, string companyName) : base(name, joinDate)
        {
            CompanyName = companyName;
        }

        public override bool IsEmployee => false;

        public override bool IsAffiliate => true;

        public string CompanyName { get; private set; }
    }
}
