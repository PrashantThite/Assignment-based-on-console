using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Aception
{
    class Null
    {
        static void Main(string[] args)
        {
            try
            {
                string s = null;

                string s1 = s.ToLower();
                Console.WriteLine(s1);
            }
            catch(NullReferenceException a)
            {
                Console.WriteLine(a.Message);
            }
            catch(Exception a)
            {
                Console.WriteLine(a.Message);

            }
            Console.WriteLine("class End");
        }
    }
}
