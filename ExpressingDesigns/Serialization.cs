using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

namespace ExpressingDesigns
{
    namespace Serialization
    {
        class Program
        {
            static void Main(string[] args)
            {
                Contact my = new Contact("Alex", "Kaplunov", 22, "+380-50-50-38-222", "Ukraine, Odessa");
                ContactList Contacts = new ContactList();
                Contacts.Add(my);
                Contacts.Add(my);
                Contacts.Add(my);
                Contacts.Add(my);

                XmlSerializer xml = new XmlSerializer(typeof(ContactList));
                using (var fStream = new FileStream("./ContactList.xml", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    xml.Serialize(fStream, Contacts);
                }

            }
        }

        [Serializable]
        public class Contact
        {
            public string FirstNmae;
            public string LastName;
            [NonSerialized]
            public int Age;
            public string Number;
            public string Address;

            public Contact()
            { }
            public Contact(string FirstNmae, string LastName, int Age, string Number, string Address)
            {
                this.FirstNmae = FirstNmae;
                this.LastName = LastName;
                this.Age = Age;
                this.Number = Number;
                this.Address = Address;
            }
        }

        [Serializable]
        public class ContactList
        {
            public List<Contact> Contacts;

            public void Add(Contact contact)
            {
                Contacts.Add(contact);
            }

            public void Remove(Contact contact)
            {
                Contacts.Remove(contact);
            }

            public ContactList()
            {
                Contacts = new List<Contact>();
            }
        }
    }
}
