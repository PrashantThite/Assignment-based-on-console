using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyCollection
{
   public class Departmentt
    {
        public string Name { get; set; }
        public List<Emp6> emp = new List<Emp6>();


    }
    public class Emp6
    {
        public string Ename { get; set; }
        public int Eid { get; set; }

    }
    class MyClass
    {
        static void Main(string[] args)
        {


            List<Departmentt> d = new List<Departmentt>()
        {
            new Departmentt{Name="HRO",emp={new Emp6{ Ename="aniket",Eid=111},
            new Emp6{ Ename="aniket",Eid=111},
            new Emp6{ Ename="yasmin",Eid=123},
            new Emp6{ Ename="disha",Eid=215},
            new Emp6{ Ename="nadir",Eid=326},
            new Emp6{ Ename="manas",Eid=812} } },


            new Departmentt{Name="pyroll",emp={new Emp6{ Ename="kunal",Eid=108},
            new Emp6{ Ename="darshan",Eid=121},
            new Emp6{ Ename="sonal",Eid=255},
            new Emp6{ Ename="sbehal",Eid=102},
            new Emp6{ Ename="rashi",Eid=454},
            new Emp6{ Ename="deepak",Eid=212} } },

            new Departmentt{Name="BGV",emp={new Emp6{ Ename="Hari",Eid=201},
            new Emp6{ Ename="Sumit",Eid=202},
            new Emp6{ Ename="Mainsh",Eid=203},
            new Emp6{ Ename="Srini",Eid=203},
            new Emp6{ Ename="Unmesh",Eid=204},
            new Emp6{ Ename="Rakesh",Eid=205} } }

        };
            foreach (Departmentt item in d)
            {
                Console.WriteLine();
                Console.WriteLine("---------------");
                Console.WriteLine(item.Name);
                foreach (Emp6 e  in item.emp)
                {
                    Console.WriteLine($"Name= {e.Ename}, Id= {e.Eid}");
                }
            }


        }   
    }
}
