using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace Const
    {
        
        class Program
        {
            /// <summary>
            /// Right, because more flexebility, this is run-time implementation
            /// </summary>
            public readonly string developer = "Alex Kaplunov";
            /// <summary>
            /// Wrong, this is compile time implemetation.
            /// </summary>
            public const string dev = "Alex Kaplunov";
        }
    }
}
