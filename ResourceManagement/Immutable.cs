using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace Immutable
    {
        struct Wrong
        {
            public string Line1;
            public string Line2;
            public string City;
            public string State;
            public int ZIP;
            
        }

        struct Right
        {
            public string Line1
            { get { return Line1; } }
            private readonly string line1;

            public string Line2
            { get { return Line2; } }
            private readonly string line2;

            public string City
            { get { return city; } }
            private readonly string city;

            public string State
            { get { return state; } }
            private readonly string state;

            public int ZIP
            { get { return zip; } }
            private readonly int zip;

            public Right(string line1,string line2,string city,string state,int zip)
            {
                this.line1 = line1;
                this.line2 = line2;
                this.city = city;
                this.state = state;
                this.zip = zip;
            }
        }
    }
}
