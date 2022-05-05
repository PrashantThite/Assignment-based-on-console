using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Aception
{
    class Class1
    {
        static void Main(string[] args)
        {
            string s;
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
            }
            catch(FormatException a)
            {
                Console.WriteLine("Enter no");
            }
            catch(DivideByZeroException b)
            {
                Console.WriteLine("Cant divide by zero");
            }
            catch(Exception c)
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("End");

        }

    }
    class Invalid:ApplicationException
    {
        public Invalid(string a):base(a)
        {

        }
    }
    class MobileA
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter mobile number");
                long m = Convert.ToInt32(Console.ReadLine());
                int c = 0;
                while(m>0)
                {
                    c++;
                    m = m / 10;
                }
            try{ 
                if (c != 10)
                    throw new Invalid("plese put 10 digit number");
                }

            catch (Invalid e)
            {
                Console.WriteLine("Error : "+e.Message);
            }
        }
    }
}
