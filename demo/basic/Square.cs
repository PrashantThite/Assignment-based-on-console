using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given");
            Console.WriteLine("enter value of side");
            int side= Convert.ToInt32(Console.ReadLine());
            int areaofsquare = side * side;
            Console.WriteLine("area of square="+areaofsquare);
            int perimeterofsquare = 4 * side;
            Console.WriteLine("perimeter of square="+perimeterofsquare);
        }
    }
}
