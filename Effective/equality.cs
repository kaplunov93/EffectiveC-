using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace equality
    {
        class Program
        {
            void Main()
            {

                // Class A & B have overriding of Equals() and implementing IEquatable<T> 

                A a = new A();
                B b = new B();

                if (a.Equals(b))
                    Console.WriteLine("Equals");
                else Console.WriteLine("Not Equals");

                //Can't do this Error. Because Base class can't cast to derived
                if(b.Equals(a))
                    Console.WriteLine("Equals");
                else Console.WriteLine("Not Equals");
            }
        }

        class A : IEquatable<A>
        {
            public override bool Equals(object obj)
            {
                if (Object.ReferenceEquals(obj, null))
                    return false;
                if (Object.ReferenceEquals(this, obj))
                    return true;

                A objA = obj as A;

                if (objA == null)
                    return false;
                return this.Equals(objA);
            }

            public bool Equals(A other)
            {
                return true;
            }
        }

        class B : A,IEquatable<A>
        {
            public override bool Equals(object obj)
            {
                if (Object.ReferenceEquals(obj, null))
                    return false;
                if (Object.ReferenceEquals(this, obj))
                    return true;

                B objB = obj as B;

                if (objB == null)
                    return false;
                return this.Equals(objB);
            }

            public bool Equals(B other)
            {
                return true;
            }
        }
    }
}
