using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressingDesigns
{
    namespace Variance
    {
        //Covariant
        interface My1<out T>
        {
            T Get();
            Func<T> GetLater();
            void GiveLater(Action<T> Doing);
        }

        //Contrvariant
        interface My2<in T>
        {
            void Act(T item);
            void GetLater(Func<T> item);
            Action<T> ActLater();
        }
    }
}
