using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressingDesigns
{
    namespace DataMode
    {
        class Program
        {
            static void Main(string[] args)
            {
                Data data = new Data();
                //now create data1 like new class object with information from data
                Data data1 = data.GetData();
                //Change only data1
                data1.Doing((int n) => n % 2 != 0, (int i) => i * i);
                //I set object data to Read Write mode
                data.SetReadWrite();
                //Now data2 create like reference to data
                Data data2 = data.GetData();
                //Change data2 and data
                data2.Doing((int n) => n % 2 == 0, (int i) => i * i);

            }
        }

        class Data
        {
            private List<int> ints;

            private bool Readonly = true;

            public Data(List<int> data)
            {
                ints = new List<int>(data);
            }

            public Data()
            {
                ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            }

            public bool ReadOnly
            {
                get { return Readonly; }
            }

            public void SetReadOnly()
            {
                Readonly = true;
            }

            public void SetReadWrite()
            {
                Readonly = false;
            }

            public Data GetData()
            {
                if (Readonly)
                    return new Data(ints);
                else return this;
            }

            public void Doing(Func<int, bool> fn, Func<int, int> Operation)
            {
                for (int i = 0; i < ints.Count; i++)
                {
                    if (fn(ints[i]))
                    {
                        ints[i] = Operation(ints[i]);
                    }
                }
            }
        }
    }
}
