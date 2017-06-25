using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Core
{
    public interface IBill
    {
        string BillNumber { get; }
        DateTime BillDate { get; }
        IOrder Order { get; }
        decimal BillAmount { get; }
    }
}
