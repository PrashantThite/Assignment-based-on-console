using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class switch_formula
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press : 1=Area of circle, 2=Area of square, 3=Area of right angle traingle, 4=Area of rectangle" +
                "5=circumference of circle, 6=perimeter of square");
            
            int result = Convert.ToInt32(Console.ReadLine());
            switch(result)
            {
                 
                case 1: Console.WriteLine("Enter Radius");
                int radius = Convert.ToInt32(Console.ReadLine());
                    float circle = 3.14f * radius;   
                Console.WriteLine("Area of circle=" + circle*circle);
                    break;
                case 2: Console.WriteLine("Enter side");
                    int side = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of square=" +(side*side));
                    break;
                case 3: Console.WriteLine("Enter sides");
                    int side1 = Convert.ToInt32(Console.ReadLine());
                    int side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of right angle traingle=" +(side1*side2)/2);
                    break;
                case 4: Console.WriteLine("Areaof rectangle");
                    int length = Convert.ToInt32(Console.ReadLine());
                    int bredth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of retangle=" +length*bredth);
                    break;
                case 5: Console.WriteLine("Circumference of circle");
                    int radius1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Circumference of circle=" +(2*3.14)*radius1);
                    break;
                case 6: Console.WriteLine("Enter sides");
                    int side3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("perimeter of square=" +4*side3);
                    break;
            }

        }

        }
    }
