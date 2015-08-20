using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Dynamic;

namespace DynamicProgramming
{
    namespace ExpressionAPI
    {
        static class Program
        {


            static void Main(string[] args)
            {
                string my = Dynamic<string>.CallInterface(n => n.DoWork("Hello World"));
                Console.WriteLine(my);

                Console.ReadKey();
            }

            public static string DoWork(this string m, string n)
            {
                return n;
            }

        }

        static class Dynamic<T>
        {
            static public TResult CallInterface<TResult>(Expression<Func<T, TResult>> op)
            {
                var exp = op.Body as MethodCallExpression;
                var methodName = exp.Method.Name;
                var methodInfo = exp.Method;
                var allParameters = from element in exp.Arguments select processArgument(element);

                Console.WriteLine("Calling {0}", methodName);

                foreach (var par in allParameters)
                    Console.WriteLine("\tParameter type - {0}, Value - {1}", par.Item1, par.Item2);
                return default(TResult);
            }

            static private Tuple<object, object> processArgument(Expression element)
            {
                object argument = default(object);
                LambdaExpression l = Expression.Lambda(Expression.Convert(element, element.Type));


                //Необработанное исключение типа 
                //"System.InvalidOperationException" в System.Core.dll
                //Дополнительные сведения: На переменную "n" 
                //типа "System.String" имеется ссылка из области "", 
                //но она не определена
                var parmType = l.Compile().DynamicInvoke();

                return Tuple.Create(parmType, argument);
            }
        }
    }
}
