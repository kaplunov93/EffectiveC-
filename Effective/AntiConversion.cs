using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace AntiConversion
    {
        class Shape
        {
            public void DoSomethingWithCircle(Circle c)
            {
                Elipse e = new Elipse(c);
                e.DoSomething();
            }
        }

        class Elipse :Shape
        {
            int x,y,r1, r2;

            public Elipse(int x,int y,int r1,int r2)
            {
                this.x = x;
                this.y = y;
                this.r1 = r1;
                this.r2 = r2;
            }

            public Elipse (Circle c)
            {
                this.x = c.x;
                this.y = c.y;
                this.r1 = c.r;
                this.r2 = c.r;
            }

            public void DoSomething()
            {
                //algorithm
            }
        }

        class Circle:Shape
        {
           public int x, y, r;
        }
    }
}
