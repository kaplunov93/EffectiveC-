using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace Initializers
    {
        class Wrong
        {
            private List<string> labels = new List<string>();

            public Wrong()
            {
                labels=new List<string>();
            }

            public Wrong(int size)
            {
                labels = new List<string>(size);
            }
        }

        class Right
        {
            private List<string> labels;

            public Right()
            {
                labels = new List<string>();
            }

            public Right(int size)
            {
                labels = new List<string>(size);
            }
        }
    }
}
