using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    namespace newModifier
    {
        class BaseClass
        {
            public void DoSomething()
            {
                //doing.........
            }
        }

        class DerivedClass:BaseClass
        {
            public new void  DoSomething()
            {
                base.DoSomething();
                //doing......
            }
        }
    }
}
