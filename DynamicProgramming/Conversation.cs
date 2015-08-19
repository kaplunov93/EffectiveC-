using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    namespace Conversation
    {
        static class Program
        {


            static void Main(string[] args)
            {
                List<string> strings = new List<string> { "Hello", "World", "Friends" };
                IEnumerable<string> str = Convert<string>(strings);
                foreach (string s in str)
                {
                    Console.WriteLine(s);
                }

                Console.ReadKey();

            }

            static IEnumerable<TResult> Convert<TResult>(this System.Collections.IEnumerable sequence)
            {
                foreach (var item in sequence)
                {
                    dynamic coercion = (dynamic)item;
                    yield return (TResult)coercion;
                }
            }

        }
    }
}
