#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Effective
{
    namespace conditional
    {
        class Class
        {
            private string someText;

            public string SomeText
            {
                get
                {
                    CheckState();
                    return someText;
                }
                set
                {
                    CheckState();
                    someText = value;
                    CheckState();
                }
            }

            void CheckStateBad()
            {
#if DEBUG
                //checking something
#endif
            }

            [Conditional("DEBUG")]
            void CheckState()
            {
                //checking something
            }
        }
    }
}
