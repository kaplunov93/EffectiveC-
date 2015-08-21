using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneos
{
    namespace PersonalException
    {
        class Program
        {


            static void Main(string[] args)
            {
                try
                {
                    MyWork();
                }
                catch (MyException e)
                {
                    ReportErrorAndContinue(e);
                }

                Console.ReadKey();
            }

            private static void ReportErrorAndContinue(Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message.ToString());
            }

            static void MyWork()
            {
                throw new MyException();
            }


        }

        class MyException : Exception
        {
            public MyException()
            {
            }

            public MyException(string message) : base(message)
            {
            }

            public MyException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected MyException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
