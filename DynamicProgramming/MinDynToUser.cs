using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    namespace MinDynToUser
    {
        class Program
        {


            static void Main(string[] args)
            {
                int a = Add<int, double, int>(5, 5.5);
                double b = Add<int, double, double>(5, 5.5);
                Console.WriteLine("{0}\n{1}", a, b);

                Console.ReadKey();
            }

            static dynamic DynamicAdd(dynamic left, dynamic right)
            {
                return left + right;
            }

            static TResult Add<T1, T2, TResult>(T1 left, T2 right)
            {
                return (TResult)DynamicAdd(left, right);
            }
        }
    }
}
