using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class MethodOverloading
    {
        
        public void Square(int a)
        {
            Console.WriteLine("area of square"+a*a);
        }
        public void Square(float a)
        {
            Console.WriteLine("area of square= "+a*a);
        }
        public void Rectangle(int a,int b)
        {
            Console.WriteLine("area of rectangle=" + a*b);
        }
        public void Rectangle(double a, double b)
        {
            Console.WriteLine("area of rectangle=" + a * b);
        }
        public void Rectangle(double a, int b)
        {
            Console.WriteLine("area of rectangle=" + a * b);
        }
        public void Rectangle(int a, double b)
        {
            Console.WriteLine("area of rectangle=" + a * b);
        }
        static void Main(string[] args)
        {
            MethodOverloading a = new MethodOverloading();
            a.Square(10);
            a.Square(9.5f);
            a.Rectangle(5.2, 7.5);
            a.Rectangle(2.5, 15);
        }
    }
}
