using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyCollection
{
    // Queu<> Examples
    class Q
    {
        public Q(string dname, int did)
        {
            Dname = dname;
            Did = did;
        }
        public Q()
        {

        }
        public String Dname { get; set; }
        public int Did { get; set; }

    }

    class Test8
    {
        static void Main(string[] args)
        {
            Queue<Q> n1 = new Queue<Q>();
            n1.Enqueue(new Q("Ajay", 101));
            n1.Enqueue(new Q("Ramesh", 201));
            n1.Enqueue(new Q("Suresh", 301));
            n1.Enqueue(new Q("Jayesh",401));
            n1.Enqueue(new Q("Yogesh", 501));
            n1.Enqueue(new Q("Naresh", 601));
            n1.Enqueue(new Q("Somesh", 701));

            foreach (Q item in n1)
            {
                Console.WriteLine($"Doctor Name= {item.Dname}, Id={item.Did}");
            }
            Console.WriteLine("**********************************");
            n1.Dequeue();
            n1.Dequeue();

            foreach (Q item in n1)
            {
                Console.WriteLine($"Doctor Name= {item.Dname}, Id={item.Did}");
            }
        }
    }

}
