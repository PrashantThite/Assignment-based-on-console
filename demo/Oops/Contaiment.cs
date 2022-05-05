using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Containment
    class Contaiment
    {
        
        Company company = new Company();
        Dept department = new Dept();

        public int Eid
        
        { get; set; }
        

        public int Salary
        { get; set; }

        public string Ename
        { get; set; }
        public Company Company { get => company; set => company = value; }
        public Dept Department { get => department; set => department = value; }
    }
    class Dept
    {
       

        public int Did
        { get; set; }

        public string Dname
        { get; set; }
        public string Manager
        { get; set; }
    }

    class Company
    {
       

        public string Cname
        { get; set; }
        public string Addr
        { get; set; }
        public int Rank
        { get; set; }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Contaiment a = new Contaiment();
            a.Eid =101;
            a.Ename = "prashant";
            a.Salary = 25000;
            a.Company.Cname = "TQ";
            a.Company.Addr = "pune";
            a.Company.Rank = 3;
            a.Department.Did = 02;
            a.Department.Dname = "technical";
            a.Department.Manager = "nadir";

            Console.WriteLine(a.Eid+""+a.Ename+""+ a.Company.Cname+""+ a.Department.Dname);
        }
    }
}
