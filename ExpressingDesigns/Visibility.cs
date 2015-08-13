using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressingDesigns
{
    namespace Visibility
    {
        public class PhoneNumber { }

        //Wrong Idea
        public class PhoneValidator
        {
            public bool PhoneValidate(PhoneNumber ph)
            {
                //Number Validate
                return true;
            }
        }

        //Right Idea
        public interface IPhoneValidator
        {
            bool Validate(PhoneNumber ph);
        }

        internal class UsaPhoneValidator : IPhoneValidator
        {
            public bool Validate(PhoneNumber ph)
            {
                //validate Usa phone number
                return true;
            }
        }

        internal class UkrainePhoneValidator : IPhoneValidator
        {
            public bool Validate(PhoneNumber ph)
            {
                //validate Ukrainian phone number
                return true;
            }
        }

        internal class InternationalPhoneValidator : IPhoneValidator
        {
            public bool Validate(PhoneNumber ph)
            {
                //validate International phone number
                return true;
            }
        }
    }
}
