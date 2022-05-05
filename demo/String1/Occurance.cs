using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.String1
{
    // To check frequency of string in string.
    class Occurance
    {
        static void Main(string[] args)
        {
            string s = "India is my country and India is best";
           string [] s1 = s.Split();
            string word = "India";            

            int c = 0;
           
            for(int i=0;i<s1.Length;i++)
            {
             if(word==s1[i])   
                {
                    c++;
                }
            }
            Console.WriteLine("Occurance of "+word+"in string is "+c);
        }
    }
}
