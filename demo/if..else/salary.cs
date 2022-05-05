using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class salary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic salary");
            int basic = Convert.ToInt32(Console.ReadLine());
            float gross1= (float)((basic * 0.2f)+(basic*0.8f))+basic;
            float gross2 = (float)((basic * 0.25f) + (basic * 0.9f)) + basic;
            float gross3 = (float)((basic * 0.3f) + (basic * 0.95f)) + basic;
            if(basic<=10000)
            Console.WriteLine("Gross salary="+gross1);
            else if(basic<=20000)
                Console.WriteLine("Gross Salary="+gross2);
            else
                Console.WriteLine("Gross slary="+gross3);







        }
    }
}
