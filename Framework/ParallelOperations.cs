using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework
{
    namespace ParallelOperations
    {
        static class ParallelAsync
        {
            //run asynchoronous operation
            public static void RunAsync<T, TResult>
                (this IEnumerable<T> taskParms, 
                Func<T, Task<TResult>> taskStarter, 
                Action<Task<TResult>> taskFinisher)
            {
                taskParms.Select(parm => taskStarter(parm)).AsParallel().
                    ForAll(t => t.ContinueWith(t2 => taskFinisher(t2)));
            }
        }

        class Parallele
        {
            public void Loop<T>(List<T> table)
            {
                Parallel.ForEach<T>(table, item =>
                 {
                     Console.WriteLine(item.ToString());
                 });
            }

            public void pLinq<T>(List<T> table)
            {
                table.ForEach(item=>Console.WriteLine(item));
            }
        }
    }
}
