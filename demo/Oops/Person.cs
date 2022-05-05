using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Containment, inheritance, override, sealed
    class Person
    {
        int pid;
        string name;
        Vehicale v = new Vehicale();

        public int Pid { get => pid; set => pid = value; }
        public string Name { get => name; set => name = value; }
        internal Vehicale V { get => v; set => v = value; }
        public virtual void Veh(int x)
        {
            Console.WriteLine(x);
        }
    }
    class Vehicale:Person
    {
        int vid;
        string vname;

        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }
        public override void Veh(int y)
        {
            Console.WriteLine(y);
        }
    }
    class Test3:Vehicale
    {
        public sealed override void Veh(int z)
        {
            Console.WriteLine(z);
        }
        static void Main(string[] args)
        {
            Person a = new Person();
            a.Pid = 101;
            a.Name="rushi";
            a.V.Vid = 555;
            a.V.Vname = "Hero";
            Console.WriteLine($"Person Id={a.Pid}, Person Name={a.Name}, Vehical Id={a.V.Vid}, vehical Name={a.V.Vname}");

            Person b = new Person();
            b.Pid = 105;
            b.Name = "Nile";
            b.V.Vid = 233;
            b.V.Vname = "Yamaha";
            Console.WriteLine($"Person Id={b.Pid}, Person Name={b.Name}, Vehical Id={b.V.Vid}, vehical Name={b.V.Vname}");


        }
    }
}
