using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace StaticObj
    {
        class Wrong
        {
            private static readonly Wrong obj = new Wrong();

            public Wrong Obj { get { return obj; } }

            private Wrong()
            { }
        }

        class Right
        {
            private static readonly Right obj;

            static Right()
            { obj = new Right(); }

            public Right Obj { get { return obj; } }

            private Right()
            { }
        }
    }
}
