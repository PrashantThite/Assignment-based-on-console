using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.String1
{
    class Annagram
    {
        static void Main(string[] args)
        {
            string str = "keep";
            Console.WriteLine("Enter a string");
            string str1 = Console.ReadLine();

            string s1 = str.ToLower();
            string s2 = str1.ToLower();

            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            string new1 = new string(c1);
            string new2 = new string(c2);

            if(new1==new2)
            {
                Console.WriteLine("anagram");               
            }
            else
            {
                Console.WriteLine("Not anagram");
            }
        }
    }
}
