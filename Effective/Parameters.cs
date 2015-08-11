using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace Parameters
    {
        class Data
        {
            public string Name, Surname;
            public int age;

        }

        class Wrong:Data
        {
            public Wrong()
            {
                Name = "Unknown";
                Surname = "Unknown";
                age = 0;
            }

            public Wrong(string name)
            {
                Name = name;
                Surname = "Unknown";
                age = 0;
            }

            // ........... 

        }

        class Right:Data
        {
            public Right(string name= "Unknown",string surname= "Unknown",int Age=0)
            {
                Name = name;
                Surname = surname;
                age = Age;
            }
        }
    }
}
