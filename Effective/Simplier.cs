using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace Simplier
    {
        class Wrong
        {
            public void Work(bool What)
            {
                if (What)
                    // Do something one
                    //....
                    return;
                else
                    // Do something else
                    //.....
                    return;

            }
        }

        class Right
        {
            public void Work(bool What)
            {
                if (What)
                    DoSomeOne();
                else
                    DoSomeElse();

            }

            private void DoSomeOne()
            {
                //Do something
            }

            private void DoSomeElse()
            {
                //Do something
            }
        }
    }
}
