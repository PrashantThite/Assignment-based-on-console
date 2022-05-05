using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Method Overloading
    class Volume
    {
        public double volume(double r)
        {
            return (4 / 3) * (22 / 7) * (r * r * r);
        }
        public double volume(double radius, double hight)
        {
            return (22 / 7) * (radius * radius) * hight;
        }
        public double volume(double length, double bredth, double height)
        {
            return length * bredth * height;
        }
    }
    class Test4
    {
        static void Main(string[] args)
        {
            Volume a = new Volume();
            char ch = 'Y';
            do
            {
                Console.WriteLine("Press 1-cuboid,2-Cylinder,3-Sphere");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter double");
                        double sphere = a.volume(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Volume of Cylindre= " + sphere);
                        break;
                    case 2:
                        Console.WriteLine("Enter two double");

                        double cyliendre = a.volume(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Volume of Cylindre= " + cyliendre);
                        break;
                    case 3:


                        Console.WriteLine("Enter Three double");
                        double cuboid = a.volume(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

                        Console.WriteLine("Volume of Sphere=" + cuboid);

                        break;
                }

                Console.WriteLine("Press y to continue,N to exit");
                ch = Convert.ToChar(Console.Read());

            } while (ch == 'Y' || ch == 'y');
        

        }
    }
}