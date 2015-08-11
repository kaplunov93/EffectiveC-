using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace hashCode
    {
        class RightClass
        {
            private string field;

            public RightClass(string field)
            {
                this.field = field;
            }

            public string Field
            {
                get { return field; }
            }

            public override int GetHashCode()
            {
                return field.GetHashCode();
            }

            public RightClass ChangeField(string field)
            {
                return new RightClass(field);
            }
        }

        class WrongClass
        {
            private string field;

            public string Field
            {
                get { return field; }
                set { field = value; }
            }

            public override int GetHashCode()
            {
                return field.GetHashCode();
            }
        }
    }
}
