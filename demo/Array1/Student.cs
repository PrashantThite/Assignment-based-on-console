using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Array1
{
    class Student
    {
        int rolln;
        string name;

        public int Rolln { get => rolln; set => rolln = value; }
        public string Name { get => name; set => name = value; }
    }
    class Course
    {
        int id;
        string name;
        Student[] student;        

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Student[] Student { get => student; set => student = value; }
        public Course(int id, string name, Student[] student)
        {
            this.id = id;
            this.name = name;
            this.student = student;
        }
    }
    class Show
    {
        static void Main(string[] args)
        {
            Student[] list = new Student[5]
            {
                new Student{Name="a",Rolln=1},
                new Student{Name="b",Rolln=2},
                new Student{Name="c",Rolln=3},
                new Student{Name="d",Rolln=4},
                new Student{Name="e",Rolln=5}
            };
            Student[] javas = new Student[5]
           {
                new Student{Name="aa",Rolln=10},
                new Student{Name="bb",Rolln=20},
                new Student{Name="cc",Rolln=30},
                new Student{Name="dd",Rolln=40},
                new Student{Name="ee",Rolln=50}
           };
            Student[] cs = new Student[5]
          {
                new Student{Name="aaa",Rolln=60},
                new Student{Name="bbb",Rolln=70},
                new Student{Name="ccc",Rolln=80},
                new Student{Name="ddd",Rolln=90},
                new Student{Name="eee",Rolln=100}
          };
            Console.WriteLine("Enter 1 to watch c# student list, 2 to java and 3 to c");
            int j = Convert.ToInt32(Console.ReadLine());
            switch (j)
            {
                case (1):
                    {
                        Course c1 = new Course(101, "c#", list);
                        Console.WriteLine($"Course Id={c1.Id}, Course Name={c1.Name}");
                        for (int i = 0; i < list.Length; i++)
                        {
                            Console.WriteLine($"Name={list[0].Name}, Roll Number={list[0].Rolln}");
                        }
                    }
                    break;
                case (2):
                    {
                        Course c1 = new Course(101, "java", javas);
                        Console.WriteLine($"Course Id={c1.Id}, Course Name={c1.Name}");

                        for (int i = 0; i < javas.Length; i++)
                        {
                            Console.WriteLine($"Name={javas[0].Name}, Roll Number={javas[0].Rolln}");
                        }
                    }
                    break;
                case (3):
                    {
                        Course c1 = new Course(101, "c", cs);
                        Console.WriteLine($"Course Id={c1.Id}, Course Name={c1.Name}");

                        for (int i = 0; i < cs.Length; i++)
                        {
                            Console.WriteLine($"Name={cs[0].Name}, Roll Number={cs[0].Rolln}");
                        }
                    }
                    break;
                default:
                    break;

            }   
        }
    }
}
