using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Basics of method
    class Calci
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int SimpleInterest(int p,int r,int n)
        {
            int SI = (p * r * n) / 100;
            return SI;
        }
         
        public bool ly(int yr)
        {
            if (yr % 4 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Calci a = new Calci();
            int Sum = a.Add(10, 20);
            int SI = a.SimpleInterest(20, 40, 60);
            bool leapyear = a.ly(2008);
            Console.WriteLine($"Sum={Sum} SI={SI} Leap Year={leapyear}");

            Calci b = new Calci();
            int Sum1 = b.Add(10, 40);
            int SI1 = b.SimpleInterest(50, 40, 60);
            bool leapyear1 = b.ly(2012);
            Console.WriteLine($"Sum={Sum1} SI={SI1} Leap Year={leapyear1}");

            Calci c = new Calci();
            Console.WriteLine("Enter 2 number to sum");
            int sum2 = c.Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(" Enter Principle, rate, amount");
            int SI2=c.SimpleInterest(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter a year");
            bool leapyear2 = c.ly(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Sum={sum2} SI={SI2} Leap Year={leapyear2}");


        }

    }

}
