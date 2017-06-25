using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xebia.OnlineStore.Common;

namespace Xebia.OnlineStore
{
    public sealed class Grocery : ProductType
    {
        private static readonly Lazy<Grocery> defaultGrocery = new Lazy<Grocery>(() => new Grocery());

        public static Grocery Instance { get { return defaultGrocery.Value; } }

        private Grocery() : base("Grocery", true)
        { }
    }
}
