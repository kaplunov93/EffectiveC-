using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    namespace Clonable
    {
        class Base
        {
            private string label;
            private int[] value; 

            public Base()
            {
                label = "Label Base";
                value = new int[] {1,2,3,4,5,6,7,8,9,0 };
            }

            protected Base(Base right)
            {
                label = right.label;
                value = right.value.Clone() as int[];
            }
        }

        sealed class Derived : Base, ICloneable
        {
            private double[] dvalue;

            public Derived()
            {
                dvalue = new double[10];
            }

            private Derived(Derived right):base(right)
            {
                dvalue = right.dvalue.Clone() as double[];
            }

            public object Clone()
            {
                Derived der = new Derived(this);
                return der;
            }
        }
    }
}
