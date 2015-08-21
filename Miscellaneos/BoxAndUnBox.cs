using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneos
{
    namespace BoxAndUnBox
    {
        class Program
        {


            static void Main(string[] args)
            {
                //Boxing ints to objects
                Console.WriteLine("{0}\t{1}\t{2}", 10, 20, 30);
                //This operation without Boxing
                Console.WriteLine("{0}\t{1}\t{2}", 10.ToString(), 20.ToString(), 30.ToString());

                Console.ReadKey();
            }


        }
    }
}
