using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class Properties
    {
        // Method properties
        string countryName, capital;
        int noOfStates, noOfLanguage;

        public string CountryName
        {
            set { countryName = value; }
            get { return countryName; }
        }
        public string Capital
        {
            set { capital = value; }
            get { return capital; }
        }
        public int NoOfStates
        {
            set { noOfStates = value; }
            get { return noOfStates; }
        }
        public int NoOfLanguage
        {
            set { noOfLanguage = value; }
            get { return noOfLanguage; }
        }
    }
    class Country
    {
        static void Main(string[] args)
        {
            Properties a = new Properties();
            a.CountryName = "India";
            a.Capital = "Delhi";
            a.NoOfStates = 29;
            a.NoOfLanguage = 1000;
            Console.WriteLine($"Country Name={a.CountryName}, Capital={a.Capital}, States={a.NoOfStates}, languages={a.NoOfLanguage}");


            Properties b = new Properties();
            Console.WriteLine("Enter Country, Capital, No of states, No of languages");
            b.CountryName = Console.ReadLine();
            b.Capital = Console.ReadLine();
            b.NoOfStates = Convert.ToInt32(Console.ReadLine());
            b.NoOfLanguage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Country Name={b.CountryName}, Capital={b.Capital}, States={b.NoOfStates}, languages={b.NoOfLanguage}");





        }
    }
}