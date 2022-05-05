using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyCollection
{
    public class Stud
    {
        public Stud(string name, int rollNo, int percent)
        {
            Name = name;
            RollNo = rollNo;
            Percent = percent;
        }
        public Stud()
        {

        }

        public String Name { get; set; }
        public  int RollNo { get; set; }
        public int Percent { get; set; }

    }
    class test1
    {
        static void Main(string[] args)
        {
            Stack<Stud> x = new Stack<Stud>();            

            x.Push(new Stud { Name = "abhi", RollNo = 10,Percent=70 }) ;
           x.Push(new Stud { Name = "aniket", RollNo = 20, Percent = 79 });
          x.Push(new Stud { Name = "joy", RollNo = 31, Percent = 80 });
          x.Push(new Stud { Name = "roy", RollNo = 22, Percent = 67 });
            x.Push(new Stud { Name = "suresh", RollNo = 29, Percent =77 });
            x.Push(new Stud { Name = "amit", RollNo = 36, Percent = 45});

            foreach(Stud s in x)
            {
                Console.WriteLine($"Name= {s.Name}, Roll Number= {s.RollNo}, Percentage= {s.Percent}");
            }
            Console.WriteLine("-------------------------------------------------------------------");

            x.Pop();
            x.Pop();
            foreach (Stud s in x)
            {
                Console.WriteLine($"Name= {s.Name}, Roll Number= {s.RollNo}, Percentage= {s.Percent}");
            }
        }
    }
}
