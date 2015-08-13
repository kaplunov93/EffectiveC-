using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace ZeroAsState
    {
        class Wrong
        {
            [Flags]
            public enum Worker
            {
                Alex = 1,
                Sergey = 2,
                Valera = 3,
                Aliona = 4
            }

            private string msg;

            public string Msg
            {
                get { return msg; }
                set { msg = value; }
            }
        }

        class Right
        {
            [Flags]
            public enum Worker
            {
                None=0,
                Alex=1,
                Sergey=2,
                Valera=3,
                Aliona=4
            }

            private string msg;

            public string Msg
            {
                get  { return (msg != null) ? msg : string.Empty; }
                set  { msg = value; }
            }
        }
    }
}
