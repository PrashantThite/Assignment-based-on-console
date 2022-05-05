using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyLinq
{
    class Course
    {
        public  int Cid { get; set; }
        public string Cname { get; set; }
        public int Cfees { get; set; }
    }
    class Tesst13
    {
        static void Main(string[] args)
        {
            List<Course> course = new List<Course>()
            {
                new Course{Cname="java",Cid=111,Cfees=20000},
                new Course{Cname="C#",Cid=112,Cfees=25000},
                new Course{Cname="Python",Cid=113,Cfees=27000},
                new Course{Cname="java",Cid=114,Cfees=30000},
                new Course{Cname="C#",Cid=115,Cfees=35000},
                new Course{Cname="Python",Cid=116,Cfees=23000},
                new Course{Cname="java",Cid=117,Cfees=40000},
                new Course{Cname="C#",Cid=118,Cfees=45000},
             new Course{Cname="Python",Cid=119,Cfees=15000}
             };
            var list1 = from a in course
                        where a.Cname.Contains("java")
                        select a;

            var list2 = from a in course
                        where a.Cname.Contains("C#")
                        select a;

            var list3 = from a in course
                        where a.Cname.Contains("Python")
                        select a;

            var list4= from a in course
                        where a.Cfees<30000 && a.Cname.Contains("C#")
                                                select a;
            var list5 = from a in course
                        orderby a.Cfees
                        select a;
            foreach (Course i in list5)
            {
                Console.WriteLine($"Course= {i.Cname}, Id= {i.Cid}, Fees= {i.Cfees}");
            }
        }
    }
}
