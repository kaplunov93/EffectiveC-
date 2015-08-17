using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    namespace Overloads
    {
        class Base
        {
            void Method()
            {
                //body of method
            }

            void BaseMethod()
            {
                //body of method
            }

            virtual public void BaseMethod1() { }
        }

        class Derieved : Base
        {
            /// <summary>
            /// Wrong 
            /// </summary>
            void Method()
            {
                //body of method
            }
            /// <summary>
            /// Right
            /// </summary>
            void DerivedMethod()
            {
                //body of method
            }
            /// <summary>
            /// Right
            /// </summary>
            public override void BaseMethod1()
            {
                base.BaseMethod1();
            }
        }
    }
}
