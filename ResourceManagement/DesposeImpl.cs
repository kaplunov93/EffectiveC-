using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace DesposeImpl
    {
        class Right : IDisposable
        {
            private bool IsDisposed = false;

            public virtual void Dispose(bool disposing)
            {
                if (!IsDisposed)
                {
                    if (disposing)
                    {
                        //free managed resources
                    }
                    //free unmanaged resources
                    IsDisposed = true;
                }
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            ~Right()
            {
                Dispose(false);
            }
        }

        class RightDerived :Right
        {
            private bool isDisposed = false;

            public override void Dispose(bool disposing)
            {
                if(!isDisposed)
                {
                    if(disposing)
                    {
                        //free managed resources
                    }
                    //free unmanaged resources
                    isDisposed = true;
                }
                base.Dispose(disposing);
            }
        }
    }
}
