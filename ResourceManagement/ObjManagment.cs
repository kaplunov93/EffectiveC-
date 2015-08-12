using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace ObjManagment
    {
        class Wrong
        {
            public void Method()
            {
                using (MyObject my = new MyObject())
                {
                    my.DoSomething();
                    string msg = "hello";
                    msg += " My name";
                    msg += " is Alex";
                    Console.WriteLine(msg);
                }
            }
        }

        class Right
        {
            private static MyObject my =null;
            public static MyObject My
            {
                get
                {
                    if (my == null)
                        my = new MyObject();
                    return my;
                }
            }

            public void Method()
            {
                My.DoSomething();
                //for string use:
                string msg1 = string.Format("Hello, my {1} is {0}","Alex","name");
                //or
                StringBuilder msg2 = new StringBuilder();
                msg2.Append("Hello, ");
                msg2.Append("my name ");
                msg2.Append("is Alex");
                Console.WriteLine(msg2.ToString());
            }
        }

        class MyObject : IDisposable
        {
            public void DoSomething()
            { } 
            
            public void Dispose()
            {
                //Disposing
            }
        }
        
    }
}
