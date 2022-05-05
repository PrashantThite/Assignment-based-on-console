using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyLinq
{
    class studd
    {
        public int RollNo { get; set; }
        public int Percent { get; set; }
        public string Name { get; set; }
        public string  Branch { get; set; }
    }
    class Test13
    {
        static void Main(string[] args)
        {
            List<studd> students = new List<studd>()
            {
                new studd{RollNo=10,Name="Kunal",Branch="Science",Percent=60},
                new studd{RollNo=16,Name="Darshan",Branch="Commerce",Percent=75},
                new studd{RollNo=14,Name="Akash",Branch="Arts",Percent=65},
                 new studd{RollNo=25,Name="Ashish",Branch="Science",Percent=50},
                new studd{RollNo=35,Name="Pranav",Branch="Commerce",Percent=75},
                new studd{RollNo=24,Name="Rohit",Branch="Arts",Percent=80},
                new studd{RollNo=15,Name="Suresh",Branch="Science",Percent=60},
                new studd{RollNo=29,Name="Prajwa;",Branch="Commerce",Percent=85},
                new studd{RollNo=30,Name="Sumit",Branch="Arts",Percent=65},
            };

            var list1 = from a in students
                         orderby a.RollNo
                         select a;

            var list2= from a in students
                         orderby a.Branch.Contains("Science")
                         select a;

            var list3 = from a in students
                        where a.Percent>70
                         orderby a.Percent descending
                         select a;
            var list4 = from a in students
                        where a.Name.StartsWith('A')
                        select a;
            foreach (studd i in list3)
            {
                Console.WriteLine($"Roll No={i.RollNo}, Name= {i.Name}, Branch= {i.Branch}, Percentages= {i.Percent}");
            }
        }
    }
}
