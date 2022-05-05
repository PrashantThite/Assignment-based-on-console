using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class Movie
    {
        string movieName, director, producer, maleactor;
        float rating;

        public void SetmovieName(string Mname)
        {
            movieName = Mname;
        }
        public string getmovieName()
        {
            return movieName;
        }
        public void Setdirector(string Dname)
        {
            director = Dname;
        }
        public string getdirector()
        {
            return director;
        }
        public void Setproducer(string Pname)
        {
            producer = Pname;
        }
        public string getproducer()
        {
            return producer;
        }
        public void Setmaleactor(string Aname)
        {
            maleactor = Aname;
        }
        public string getmaleactor()
        {
            return maleactor;
        }
        public void Setrating(float rates)
        {
            rating = rates;
        }
        public float getrating()
        {
            return rating;
        }
        
        
        public Movie()
        {
            Console.WriteLine("In movie constructor");
        }
    }
    class MovieA
    {
        
        static void Main(string[] args)
        {
            Movie a = new Movie();
            a.SetmovieName("RRR");
            a.Setproducer("RajMauli");
            a.Setdirector("karan");
            a.Setmaleactor("Ram");
            a.Setrating(4.5f);

            string Mname = a.getmovieName();
            string Dname = a.getdirector();
            string Pname = a.getproducer();
            string Aname = a.getmaleactor();
            float rating = a.getrating();
            Console.WriteLine($"movie name={Mname},Producer={Pname}, direcotor={Dname}, Actor={Aname}, Rating={rating}");


            Movie b = new Movie();
            Console.WriteLine("Enter Movie, Direcotor, Producer, Actor, Ratings");
            b.SetmovieName(Console.ReadLine());
            b.Setproducer(Console.ReadLine());
            b.Setdirector(Console.ReadLine());
            b.Setmaleactor(Console.ReadLine());
            b.Setrating(Convert.ToSingle(Console.ReadLine()));

            string Mname1 = b.getmovieName();
            string Dname1= b.getdirector();
            string Pname1 = b.getproducer();
            string Aname1= b.getmaleactor();
            float rating1= b.getrating();
            Console.WriteLine($"movie name={Mname1},Producer={Pname1}, direcotor={Dname1}, Actor={Aname1}, Rating={rating1}");

        }
    }
}
