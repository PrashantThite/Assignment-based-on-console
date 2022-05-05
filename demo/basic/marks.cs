using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class marks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Name="+name);

            Console.WriteLine("Enter English marks");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter maths marks");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Science marks");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Histroy marks");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter geography marks");
            int g = Convert.ToInt32(Console.ReadLine());
            int avg = (e + m + s + h + g)/5;
           
            Console.WriteLine("Avg marks="+avg);
        }

    }
}
