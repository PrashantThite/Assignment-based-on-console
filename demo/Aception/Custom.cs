using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Aception
{
    class AgeException:Exception
    {
        public AgeException(string msg):base(msg)
        {

        }
    }
    class Custom
    {
        //custom exception
        // if Person age is below 18

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            
                string name = Console.ReadLine();
          
            Console.WriteLine("Enter age");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                    throw new AgeException("Age should be above 18");

            }
            catch (AgeException a)
            {
                Console.WriteLine("Error : "+a.Message);               
            }
            catch(Exception a)
            {
                Console.WriteLine("Error : " + a.Message);

            }
        }
    }
}
