using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressingDesigns
{
    namespace InterfaceMethods
    {
        interface Iwork
        {
            void Work();
        }

        class Worker : Iwork
        {
            internal virtual void Job()
            {
                // What doing Worker
            }
            public void Work()
            {
                Console.WriteLine("Start Work by {0}",this.GetType().Name);
                Job();
                Console.WriteLine("End Work by {0}", this.GetType().Name);
            }
        }

        class Worker1:Worker,Iwork
        {
            internal override void Job()
            {
                //What doing Worker1
            }
        }

        class Worker2 : Worker, Iwork
        {
            internal override void Job()
            {
                //What doing Worker2
            }
        }
    }
}
