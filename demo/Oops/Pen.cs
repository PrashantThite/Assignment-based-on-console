using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Containment
    class Pen
    {
        string refile, brand;
        int caplength;
        refile refilee = new refile();

        public string Refile { get => refile; set => refile = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Caplength { get => caplength; set => caplength = value; }
        internal refile Refilee { get => refilee; set => refilee = value; }
    }
    class refile
    {
        string color;
        int length;
        float nib;
        nib nibb = new nib();

        public string Color { get => color; set => color = value; }
        public int Length { get => length; set => length = value; }
        public float Nib { get => nib; set => nib = value; }
        internal nib Nibb { get => nibb; set => nibb = value; }
    }
    class nib
    {
        string materialtype;
        int width;

        public string Materialtype { get => materialtype; set => materialtype = value; }
        public int Width { get => width; set => width = value; }
    }
    class Test2
    {
        static void Main(string[] args)
        {
            Pen a = new Pen();
            a.Brand = "Cello";
            a.Caplength = 5;
            a.Refile = "AA";
            a.Refilee.Color="blue";
            a.Refilee.Length = 4;
            a.Refilee.Nib = 3.5f;
            a.Refilee.Nibb.Materialtype = "Metalic";
            a.Refilee.Nibb.Width = 1;
            Console.WriteLine($"Brand={a.Brand}, Cap Length={a.Caplength}, Refile={a.Refile}");
            Console.WriteLine($"Refile color={a.Refilee.Color}, Refile Length={a.Refilee.Length}, Nib={a.Refilee.Nib}");
            Console.WriteLine($"Nib type={a.Refilee.Nibb.Materialtype}, Nib width={a.Refilee.Nibb.Width}");
        }

    }
}
