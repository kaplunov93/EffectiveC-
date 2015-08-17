using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    namespace Event
    {
        class Window
        {
            public virtual void OnAction(EventArgs e)
            {
                //Do Some Actions
            }
        }

        class Window1 : Window
        {
            public Window1()
            {
                //initiliaze new Window
            }

            public override void OnAction(EventArgs e)
            {
                //Do Some Actions
                base.OnAction(e);
            }
        }
    }
}
