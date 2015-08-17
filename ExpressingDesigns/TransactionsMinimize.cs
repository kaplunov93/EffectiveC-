using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressingDesigns
{
    namespace TransactionsMinimize
    {
        class Client
        {
            static Server server = new Server();

            static private Customer newCustomer { get; set; }

            void BadSetCustomer()
            {
                Customer c = server.newCustomer;
                //transaction 1
                c.Name = "Name";
                //transaction 2
                c.Address = "Address";
                //transaction 3
                c.CreditCardInfo = "CreditCard";
                //transaction 4
                server.BadAddCustomer();
            }

            void GoodSetCustomer()
            {
                newCustomer = new Customer();
                newCustomer.Name = "Name";
                newCustomer.Address = "Address";
                newCustomer.CreditCardInfo = "CreditCard";
                // Only one transaction
                server.GoodAddCustomer(newCustomer);
            }
        }

        class Server
        {
            public Customer newCustomer { get; set; }
            static private List<Customer> Customers = new List<Customer>();

            static private List<Order> Orders = new List<Order>();

            public void BadAddCustomer()
            {
                Customers.Add(newCustomer);
            }

            public void GoodAddCustomer(Customer customer)
            {
                Customers.Add(customer);
            }

            //Bad IDea
            //Because List can been gigant and we will have long transaction
            public List<Order> GetOrders(string Name)
            {
                return Orders.FindAll(n=>n.Name==Name);
            }

            // This one more effective transaction
            public List<Order> GetOpenOrders(string Name)
            {
                return Orders.FindAll(n => n.Name == Name && n.Open==true);
            }
        }

        class Customer
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string CreditCardInfo { get; set; }
        }

        class Order
        {
            public string Name { get; set; }
            public bool Open { get; set; }
        }
    }
}
