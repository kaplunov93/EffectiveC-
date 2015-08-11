using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    class QueryVersusLoop
    {
        //Right
        public IEnumerable<Tuple<int,int>> Query(int start,int end)
        {
            return from x in Enumerable.Range(start, end)
                   from y in Enumerable.Range(start, end)
                   select Tuple.Create(x, y);

        }
        //wrong
        public IEnumerable<Tuple<int,int>> Loops(int start, int end)
        {
            for (int x = start; x <= end; x++)
                for (int y = start; y <= end; y++)
                    yield return Tuple.Create(x, y);
        }
    }
}
