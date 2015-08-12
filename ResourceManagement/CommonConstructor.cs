using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace CommonConstructor
    {
        class Wrong
        {
            private int age;
            private string name;

            public Wrong()
            {
                age = 0;
                name = string.Empty;
            }

            public Wrong(int Age)
            {
                age = Age;
                name = string.Empty;
            }

            public Wrong(int Age, string Name)
            {
                age = Age;
                name = Name;
            }
        }

        class Right
        {
            private int age;
            private string name;
            
            public Right()
            {
                CommonConstructor(0, string.Empty);
            }

            public Right(int Age)
            {
                CommonConstructor(Age, string.Empty);
            }

            public Right(int Age, string Name)
            {
                CommonConstructor(Age, Name);
            }

            private void CommonConstructor(int Age, string Name)
            {
                age = Age;
                name = Name;
            }
        }

        class RightOneConstructor
        {
            private int age;
            private readonly string name;

            public string Name { get { return name; } }

            public RightOneConstructor(int Age=0, string Name="")
            {
                age = Age;
                name = Name;
            }
        }
    }
}
