using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Inheritance
  public class Teacher
    {
        int tid;
        string tname;
        long mobileNo;

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public long MobileNo { get => mobileNo; set => mobileNo = value; }
        public Teacher()
        {

            Console.WriteLine("in constructor of Teacher class");
        }
        
   
    }
    class Hourlybased:Teacher
    {
        int rateperhour,hrs;

        public int Rateperhour { get => rateperhour; set => rateperhour = value; }
        public int Hrs { get => hrs; set => hrs = value; }

        public void Salary()
        {
            Console.WriteLine("salary= "+(Rateperhour*Hrs));          
        }

    }
    class SalaryBased:Teacher
    {
        int salary;
        public int Salary { get => salary; set => salary = value; }
        public void Salary1()
        {
            Console.WriteLine("Salary="+Salary);
        }
    }
    class Test1
    {
        static void Main(string[] args)
        {
            Hourlybased a = new Hourlybased();
            a.Tid = 101;
            a.Tname = "abc";
            a.MobileNo = 1234567890;
            a.Rateperhour = 1000;
            a.Hrs = 40;
            a.Salary();

            SalaryBased b = new SalaryBased();
            b.Tid = 102;
            b.Tname = "xyz";
            b.MobileNo = 54546515318;
            b.Salary = 35000;
            b.Salary1();

        }
        
    }
}
