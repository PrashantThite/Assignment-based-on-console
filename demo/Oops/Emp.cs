
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class Emp
    {
        int eid;
        string ename;

        public int Eid { get => eid; set => eid = value; }
        public string Ename { get => ename; set => ename = value; }
    }
    class permanentEmp:Emp
    {
        int salary;
        int deptid;

        public int Deptid { get => deptid; set => deptid = value; }

        public void Salary()
        {
            Console.WriteLine("salary of permanent employeee="+salary);
        }
    }
    class TempEmp:Emp        
    {
        int days;
        int deptid;

        public int Deptid { get => deptid; set => deptid = value; }

        public void Tsalary()
        {
            Console.WriteLine("Salary of Temporary employee="+days*500);
        }
    }
    class Test5
    {
        static void Main(string[] args)
        {
            permanentEmp a = new permanentEmp();
            a.Eid = 101;
            a.Ename = "Abc";
            a.Deptid = 1;
            a.Salary();

            TempEmp b = new TempEmp();
            b.Eid = 501;
            b.Deptid = 2;
            b.Ename="xyz";
            b.Tsalary();

        }
    }
}
