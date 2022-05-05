using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Constructor
    class Account2
    {
        public string Name;
        public long AccNo;

        Account2()
        {
            Console.WriteLine("I am in default constructor");
            Console.WriteLine("Enter Name and Account number");
            Name = Console.ReadLine();
            AccNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Name={Name}, Account Number={AccNo}");
        }
        Account2(string Name)
        {

            this.Name = Name;
            Console.WriteLine("in parameterised constructor Name="+Name);
        }

        Account2(long AccNo)
        {
            this.AccNo = AccNo;
            Console.WriteLine("in parameterised constructor Account Name=" + AccNo);

        }
        static void Main(string[] args)
        {
            Account2 a = new Account2();
            Console.WriteLine("Enter Name");
            Account2 b = new Account2(Console.ReadLine());
            Account2 c = new Account2(5215487958);

        }
    }
    
    
}
