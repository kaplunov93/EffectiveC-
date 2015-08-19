using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;

namespace DynamicProgramming
{
    namespace Understanding
    {
        class Program
        {


            static void Main(string[] args)
            {
                int my2 = Operators<int>.Add(10, 15);
                double my3 = Operators<double>.Add(10.5, 11.5);
                Console.WriteLine(my2.ToString());
                Console.WriteLine(my3.ToString());

                Console.ReadKey();

            }

            public static class Operators<T>
            {
                static Func<T, T, T> compiledExpr;

                public static T Add(T left, T right)
                {
                    if (compiledExpr == null)
                        createFunc();
                    return compiledExpr(left, right);
                }

                private static void createFunc()
                {
                    var leftOperand = Expression.Parameter(typeof(T), "left");
                    var rightOperand = Expression.Parameter(typeof(T), "right");
                    var body = Expression.Add(leftOperand, rightOperand);
                    var adder = Expression.Lambda<Func<T, T, T>>(body, leftOperand, rightOperand);
                    compiledExpr = adder.Compile();

                }
            }
        }
}
