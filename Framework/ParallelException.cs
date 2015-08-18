using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    namespace ParallelException
    {
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
