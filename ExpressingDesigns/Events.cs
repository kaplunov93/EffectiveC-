using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressingDesigns
{
    namespace Events
    {
        class Program
        {
            static void Main(string[] args)
            {
                Subject my = new Subject();
                my.Add(new Observer("First"));
                my.Add(new Observer("Second", 1));
                my.Add(new Observer("Third", 2));
                my.Work(new int[] { 0 });
                my.Work1();
                my.Work(new int[] { 2 });
                my.Work();
                Console.ReadKey();
            }
        }

        class Observer
        {
            private int priority;
            private string name;

            public int Priority { get { return priority; } }
            public string Name { get { return name; } }

            public Observer(string Name, int priority = 0)
            {
                this.priority = priority;
                this.name = Name;
            }

            public /*abstract*/ void Update(string message) { Console.WriteLine(message); }
        }

        class Subject
        {
            private List<Observer> clients = new List<Observer>();

            public void Add(Observer client)
            {
                clients.Add(client);
            }

            public void Remove(Observer client)
            {
                clients.Remove(client);
            }

            private void Notify(string message, int[] priority = null)
            {
                foreach (Observer client in clients)
                {
                    if (priority == null)
                    {
                        Console.Write("Notify to {0}:\t", client.Name);
                        client.Update(message);
                    }
                    else
                    if (priority.Contains(client.Priority))
                    {
                        Console.Write("Notify to {0}:\t", client.Name);
                        client.Update(message);
                    }
                }
            }

            //Event which can Notify all or to Loggers thats in parametr 
            public void Work(int[] priority = null)
            {
                Notify("Start Work", priority);
                //Do something
                Notify("End Work", priority);
            }

            //Event which notify Loogers with priority 1
            public void Work1()
            {
                int[] priority = new int[] { 1 };
                Notify("Start Work 1", priority);
                //Do something
                Notify("End Work 1", priority);
            }

        }
    }
}
