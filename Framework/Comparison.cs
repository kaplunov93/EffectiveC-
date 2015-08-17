using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    namespace Comparison
    {
        struct MyType : IComparable<MyType>,IComparable
        {
            private readonly string name;
            private int value;

            public MyType(string Name,int Value)
            {
                name = Name;
                value = Value;
            }

            #region IComparable<MyType> Members
            public int CompareTo(MyType other)
            {
                return name.CompareTo(other.name);
            }
            #endregion

            #region IComparable Members
            int IComparable.CompareTo(object obj)
            {
                if (!(obj is MyType))
                    throw new ArgumentException("Argument is not a MyType", "obj");
                MyType otherMyType = (MyType)obj;
                return this.CompareTo(otherMyType);

            }
            #endregion

            #region Comaprison operations 
            public static bool operator <(MyType left, MyType right)
            {
                return left.CompareTo(right) < 0;
            }

            public static bool operator <=(MyType left, MyType right)
            {
                return left.CompareTo(right) <= 0;
            }

            public static bool operator >(MyType left, MyType right)
            {
                return left.CompareTo(right) > 0;
            }

            public static bool operator >=(MyType left, MyType right)
            {
                return left.CompareTo(right) >= 0;
            }
            #endregion

            #region Value Comarison
            private static ValueComparer valComp = null;

            public static IComparer<MyType> ValueCompare
            {
                get
                {
                    if (valComp == null)
                        valComp = new ValueComparer();
                    return valComp;
                }
            }

            public static Comparison<MyType> CompareByReview
            {
                get
                {
                    return (left, right) => left.value.CompareTo(right.value);
                }
            }

            private class ValueComparer : IComparer<MyType>
            {
                int IComparer<MyType>.Compare(MyType left, MyType right)
                {
                    return left.value.CompareTo(right.value);
                }
            }
            #endregion
        }
    }
}
