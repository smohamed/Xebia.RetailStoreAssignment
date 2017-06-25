using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xebia.OnlineStore.Common
{
    public interface IProductType
    {
        string Name { get; }
        bool IsGrocery { get; }
    }
}
