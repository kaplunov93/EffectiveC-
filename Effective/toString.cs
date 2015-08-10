using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective
{
    namespace toString
    {
        /// <summary>
        /// Base Contact
        /// </summary>
        abstract class Contact
        {
            public string Name;
            public string SurName;
            public string Phone;
            public string Email;
            public string Adress; 
        }
        /// <summary>
        /// Right class with override ToString()
        /// </summary>
        class GoodContact: Contact
        {
            public override string ToString()
            {
                return "Name: "+Name+"\nSurname: "+SurName+"\nPhone: "+Phone+"\nEmail: "+Email+"\nAdress: "+Adress;
            }
        }
        /// <summary>
        /// Wrong because you don't know what you have where use ToString() to object of your class
        /// </summary>
        class BadContact:Contact
        {

        }
    }
}
