using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    namespace ParLinq
    {
        /// <summary>
        /// Parallel execution
        /// </summary>
        class LinqP
        {
            void main()
            {
                var numbers = from n in ParallelEnumerable.Range(0, 100)
                              where n % 5 == 0
                              select n;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        class Linq
        {
            void main()
            {
                var numbers = from n in Enumerable.Range(0, 100)
                              where n % 5 == 0
                              select n;
            }

        }
    }
}
