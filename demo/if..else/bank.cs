using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class bank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            int a = amount / 2000;
            amount = amount % 2000;
            Console.WriteLine(a+ "Notes of 2000");
            a = amount / 500;
            amount = amount % 500;
            Console.WriteLine(a+ "notes of 500");
            a = amount / 200;
            amount = amount % 200;
            Console.WriteLine(a+ "Notes of 200");
            a = amount / 100;
            amount = amount % 100;
            Console.WriteLine(a+ "Notes of 100");
            a = amount / 50;
            amount = amount % 50;
            Console.WriteLine(a+ "Notes of 50");
            a = amount / 20;
            amount = amount % 20;
            Console.WriteLine(a+ "Notes of 20");
            a = amount / 10;
            amount = amount % 10;
            Console.WriteLine(a+ "notes of 10");
            a = amount / 5;
            amount = amount % 5;
            Console.WriteLine(a+ "coin of 5");
            a = amount / 2;
            amount = amount % 2;
            Console.WriteLine(a+ "coin of 2");
            a = amount / 1;
            amount = amount % 1;
            Console.WriteLine(a+ "coins of 1");

        }

    }
}
