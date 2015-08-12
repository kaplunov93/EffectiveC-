using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace ReferenceVersusValue
    {
        // Values types
        struct MyStruct
        {
            public string Name
            {
                get;
                set;
            }

            public string SurnameName
            {
                get;
                set;
            }

            public void Change(string name="",string surname="")
            {
                if (name != "")
                    Name = name;
                if (surname != "")
                    SurnameName = surname;
            }
        }

        //References types 
        //better to use this variant
        class MyClass
        {
            public string Name
            {
                get;
                set;
            }

            public string SurnameName
            {
                get;
                set;
            }

            public void Change(string name = "", string surname = "")
            {
                if (name != "")
                    Name = name;
                if (surname != "")
                    SurnameName = surname;
            }
        }
    }
}
