using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Aception
{
    class OutOfRange
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter numbers");
            int divide = 35;
            int c = 0;
            try
            {
                for (int i = 0; i <= a.Length; i++)
                {
                    
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    if (divide / a[i] == 0)
                        c++;
                }
               
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
