using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace CastsOperators
    {
        /// <summary>
        /// Cast class
        /// </summary>
        class CastOperators
        {
            /// <summary>
            /// Correct Cast operation
            /// </summary>
            /// <param name="o">input Object</param>
            /// <returns> MyClass object</returns>
            public MyClass cast(Object o)
            {
                if(o is MyClass)
                    return o as MyClass;
                return null;
            }
        }
        /// <summary>
        /// Cast Class
        /// </summary>
        class Cast
        {
            /// <summary>
            /// Wrong Cast
            /// </summary>
            /// <param name="o">input Object</param>
            /// <returns> MyClass object</returns>
            public MyClass cast(Object o)
            {
                try
                {
                    MyClass m = (MyClass)o;
                    return m;
                }
                catch
                {
                    //catch a broblem
                    return null;
                }
                
            }
            
        }

        class MyClass
        {

        }
    }
}
