using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any alphabet");
            char x= Convert.ToChar(Console.ReadLine());
            if(x=='a' || x=='e' || x=='i' || x=='o' || x=='u' || x=='A' || x=='E' || x=='I' || x=='O' || x=='U')
                Console.WriteLine("Its vowel");
            else
                Console.WriteLine("It is consonant");
        }
    }
}
