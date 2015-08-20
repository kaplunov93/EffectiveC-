using System;
using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    namespace Inotify
    {
        class Program
        {


            static void Main(string[] args)
            {
                Customer cust = Customer.CreateNewCustomer();

                cust.PropertyChanged += Cust_PropertyChanged;

                cust.CompanyName = "InfoSoftPlus";
                cust.PhoneNumber = "+1.......";


                Console.ReadKey();
            }

            private static void Cust_PropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                Console.WriteLine("Changed {0}", e.PropertyName);
            }
        }



        public class Customer : INotifyPropertyChanged
        {

            private Guid idValue = Guid.NewGuid();
            private string customerName = String.Empty;
            private string companyNameValue = String.Empty;
            private string phoneNumberValue = String.Empty;

            public event PropertyChangedEventHandler PropertyChanged;

            private void NotifyPropertyChanged(String info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }


            private Customer()
            {
                customerName = "no data";
                companyNameValue = "no data";
                phoneNumberValue = "no data";
            }


            public static Customer CreateNewCustomer()
            {
                return new Customer();
            }


            public Guid ID
            {
                get
                {
                    return this.idValue;
                }
            }

            public string CompanyName
            {
                get
                {
                    return this.companyNameValue;
                }

                set
                {
                    if (value != this.companyNameValue)
                    {
                        this.companyNameValue = value;
                        NotifyPropertyChanged("CompanyName");
                    }
                }
            }

            public string PhoneNumber
            {
                get
                {
                    return this.phoneNumberValue;
                }

                set
                {
                    if (value != this.phoneNumberValue)
                    {
                        this.phoneNumberValue = value;
                        NotifyPropertyChanged("PhoneNumber");
                    }
                }
            }
        }
    }
}
