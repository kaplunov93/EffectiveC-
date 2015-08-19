using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    namespace DynamicAsParam
    {
        class Program
        {


            static void Main(string[] args)
            {
                Product p = new Product();
                p.Name = "Iphone";
                p.Price = 800;
                DiscountProduct p1 = new DiscountProduct();
                p1.Name = "Iphone";
                p1.Price = 800;
                p1.Discount = 10;

                Print(p);
                Print(p1);

                Console.ReadKey();
            }

            static void Print(dynamic d)
            {
                Console.WriteLine("Price for one {0} is {1}$ from {2}s", d.Name, d.Price, d.GetType().Name);
            }

        }

        class Product
        {
            private string name;
            private double price;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Price
            {
                get { return price; }
                set { price = value; }
            }

        }

        class DiscountProduct
        {
            private string name;
            private double price;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Price
            {
                get { return price - price * discount / 100; }
                set { price = value; }
            }

            private int discount;
            public int Discount
            {
                get { return discount; }
                set { discount = value; }
            }
        }
    }
}
