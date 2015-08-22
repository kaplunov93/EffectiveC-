using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework
{
    namespace ParallelException
    {

        /// <summary>
        /// This new code that work with exceptions in some Threads Tasks(Like 1 task one algorithm)
        /// </summary>
        class Program
        {


            static void Main(string[] args)
            {
                try
                {
                    Parallel.Invoke(
                        () =>
                        {
                            Console.WriteLine("Start Task 1");
                            Thread.Sleep(5000);
                            Console.WriteLine("Compelete Task 1");
                        },
                        () =>
                        {
                            Console.WriteLine("Start Task 2");
                            int i = 0;
                            Console.WriteLine(1 / i);
                        },
                        () =>
                        {
                            Console.WriteLine("Start Task 3");
                            Thread.Sleep(1000);
                            throw new InvalidOperationException("Task 3 tes Excepion");
                        });
                }
                catch (AggregateException e)
                {
                    Console.WriteLine("\nOops We have ERRORs\n");
                    foreach (var ex in e.InnerExceptions)
                        Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
            }

        }




        /*
        class Client
        {
            internal Func< object, object, object> DownloadDataComleted;

            internal void DownloadDataAsync(Uri uri, TaskCompletionSource<byte[]> tcs)
            {
                throw new NotImplementedException();
            }
        }

        class MuliDownlod
        {
            private static Task<byte[]> startDownload(string url)
            {
                var tcs = new TaskCompletionSource<byte[]>(url);
                var c = new Client();

                c.DownloadDataComleted += (sender, e) =>
                  {
                      if (e.UserState == tcs)
                      {
                          if (e.Cancelled)
                              tcs.TrySetCanceled();
                          else if (e.Error != null)
                          {
                              if (e.Error is DownloadException)
                                  tcs.TrySetResult(new byte[0]);
                              else
                                  tcs.TrySetException(e.Error);
                          }
                          else
                              tcs.TrySetResult(e.Result);
                      }
                  };
                c.DownloadDataAsync(new Uri(url), tcs);
                return tcs.Task;
            }
        }

        internal class DownloadException
        {
        }
        */


    }
}
