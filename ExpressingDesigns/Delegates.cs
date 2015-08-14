using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressingDesigns
{
    namespace Delegates
    {
        //Can use code like this to find something in List<T>.
        /*class Program
        {
            static void Main(string[] args)
            {
                List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
                foreach (int r in ints.FindAll(n => n % 2 == 0))
                    Console.WriteLine(r);
                Console.ReadKey();
            }
        }*/
        // Or can something like this
        class Program
        {
            static void Main(string[] args)
            {
                My s = new My();
                s.Doing((int n) => n % 2 != 0,(int i)=>i*i);
                s.Print();
                Console.ReadKey();
            }
        }

        class My
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            public void Doing(Func<int, bool> fn,Func<int,int> Operation)
            {
                for (int i = 0; i < ints.Count; i++)
                {
                    if (fn(ints[i]))
                    {
                        ints[i] = Operation(ints[i]);
                    }
                }
            }

            public void Print()
            {
                foreach (int i in ints)
                    Console.WriteLine(i);
            }
        }
    }
}
