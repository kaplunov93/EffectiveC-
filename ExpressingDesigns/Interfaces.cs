using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressingDesigns
{
    namespace Interfaces
    {
        interface IContactInfo
        {
            string Name { get; }
            PhoneNumber Number { get; }
            Address Address { get; }
        }

        public class Address
        {
        }

        public class PhoneNumber
        {
        }

        class Teacher : IContactInfo
        {
            private string FirstName;
            private string LastName;

            public Address Address
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public string Name
            {
                get
                {
                    return string.Format("{0} {1}",LastName,FirstName);
                }
            }

            public PhoneNumber Number
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
        }

        class Student : IContactInfo
        {
            private string FirstName;
            private string LastName;

            public Address Address
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public string Name
            {
                get
                {
                    return string.Format("{0} {1}", LastName, FirstName);
                }
            }

            public PhoneNumber Number
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
        }

        class School : IContactInfo
        {
            public string Name
            {
                get
                {
                    return SchoolName;
                }
            }

            public PhoneNumber Number
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public Address Address
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            private string SchoolName;
        }

        /// <summary>
        /// This Class used to print information about: Teachers, Students & Schools.
        /// We can do it because they have same fields which implemented in IContactInfo interface.
        /// This is right idea
        /// </summary>
        static class ContactInfo
        {
            public static void PrintContactInfo(IContactInfo contact)
            {
                Console.WriteLine("Type: {3} contact\nName: {0}\nAddress: {1}\nPhone: {2}",contact.Name,contact.Address,contact.Number,contact.GetType().Name);
            }
        }

        // But don' make this
        static class BadContactInfo
        {
            public static void PrintContactInfo(Teacher contact)
            {
                Console.WriteLine("Type: Teacher contact\nName: {0}\nAddress: {1}\nPhone: {2}", contact.Name, contact.Address, contact.Number);
            }
            public static void PrintContactInfo(Student contact)
            {
                Console.WriteLine("Type: Studdent contact\nName: {0}\nAddress: {1}\nPhone: {2}", contact.Name, contact.Address, contact.Number);
            }
            public static void PrintContactInfo(School contact)
            {
                Console.WriteLine("Type: School contact\nName: {0}\nAddress: {1}\nPhone: {2}", contact.Name, contact.Address, contact.Number);
            }
        }
    }
}
