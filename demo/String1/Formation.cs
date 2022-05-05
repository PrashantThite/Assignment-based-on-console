using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.String1
{
    //from string1 string2 can be form or not
    class Formation
    {
        public static int freq(string s,char a)
        {
            int c = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(a==s[i])
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            string str1 = "Think";
            string str2 = "Ink";

            string s1 = str1.ToLower();
            string s2 = str2.ToLower();

            int a = 0; 
            for(int i=0;i<s2.Length;i++)
            {
                int ori = freq(s1, s2[i]);
                int ser = freq(s2, s2[i]);
                if (ser > ori)
                {
                    a++;
                    break;
                }               
            }
            if(a==0)
                Console.WriteLine("it can be form");
            else
                Console.WriteLine("cant be form");
            
        }
    }
}
