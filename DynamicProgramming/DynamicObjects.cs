using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Dynamic;

namespace DynamicProgramming
{
    namespace DynamicObjects
    {
        class Program
        {


            static void Main(string[] args)
            {
                dynamic bag = new DynamicPropertyBag();
                bag.Contact = new Contact();
                bag.Contact.Name = "Alex";
                bag.Contact.LastName = "Kaplunov";
                string message = bag.ToString();
                Console.WriteLine(message);

                Console.ReadKey();
            }



        }

        class Contact
        {
            public string Name { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return string.Format("{0}, {1}", Name, LastName);
            }
        }

        class DynamicPropertyBag : DynamicObject
        {
            private Dictionary<string, object> storage = new Dictionary<string, object>();

            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                if (storage.ContainsKey(binder.Name))
                {
                    result = storage[binder.Name];
                    return true;
                }

                result = null;
                return false;
            }

            public override bool TrySetMember(SetMemberBinder binder, object value)
            {
                string key = binder.Name;
                if (storage.ContainsKey(key))
                    storage[key] = value;
                else
                    storage.Add(key, value);
                return true;
            }

            public override string ToString()
            {
                StringWriter message = new StringWriter();
                foreach (var item in storage)
                    message.WriteLine("{0}:\t{1}", item.Key, item.Value.ToString());
                return message.ToString();
            }
        }
    }
}
