using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace Properties
    {
        /// <summary>
        /// Right implement class with Property
        /// </summary>
        class Class
        {
            private string name;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (value != "")
                        name = value;
                }
            }
        }
        /// <summary>
        /// Wrong implement class with public variety
        /// </summary>
        class BadClass
        {
            public string Name;
        }
    }
}
