using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneos
{
    namespace NoExitException
    {
        class Program
        {


            static void Main(string[] args)
            {
                PersonList obj = new PersonList();
                obj.Add("Aliona");
                obj.Add("Anna");
                Console.WriteLine(obj.ToString());

                obj.Update(MyWork);
                Console.WriteLine(obj.ToString());

                Console.ReadKey();
            }


            static IList MyWork()
            {
                IList temp = new List<object>();
                temp.Add(new Person("Alex"));

                temp.Add(new Person("Sergey"));

                temp.Add("Error");
                return temp;
            }

            class PersonList
            {
                private List<Person> data = new List<Person>();
                public IList Persons
                {
                    get { return data; }
                }

                public void Add(string Name)
                {
                    data.Add(new Person(Name));
                }

                public void Update(Func<IList> work)
                {
                    var temp = work();
                    var temp1 = data.ToArray<Person>();
                    //data.Clear();
                    try
                    {
                        foreach (var item in temp)
                            if (item is Person)
                                data.Add(item as Person);
                            else throw new Exception();
                    }
                    catch
                    {
                        data = temp1.ToList<Person>();
                    }
                }

                public override string ToString()
                {
                    StringWriter message = new StringWriter();
                    foreach (Person obj in data)
                        message.WriteLine(obj.ToString());
                    return message.ToString();
                }
            }

            class Person
            {
                public string Name { get; set; }
                public Person(string name = "Person")
                {
                    Name = name;
                }
                public override string ToString()
                {
                    return Name.ToString();
                }
            }


        }
    }
}
