using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Patterns
{
    class Traingular
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=7;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class P1
    {
        /*
         11111
         2222
         333
         44
         5               
         
         */
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class P2
    {
        /*
         EEEEE
         DDDD
         CCC
         BB
         A
         */
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class P3
    {
        /*
        AAAAA
        BBBB
        CCC
        DD
        E
         */
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class P4
    {
        /*
         54321
         4321
         321
         21
         1
       */
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class P5
    {
        /*
         EDCBA
         EDCB
         EDC
         ED
         E
         */
        static void Main(string[] args)
        {
                for(char i='A';i<='E';i++)
            {
                for(char j='E';j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class P6
    /*
     5
     54
     543
     5432
     54321
     */
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class P7
    {
        /*
        5
        45
        345
        2345
        12345
         */
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=i;j<=5;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class P8
    {
        /*
        1
        21
        321
        4321
        54321
         */
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class P9
    {
        /*
        E
        ED
        EDC
        EDCB
        EDCBA
         */
        static void Main(string[] args)
        {
            for(char i='E';i>='A';i--)
            {
                for(char j='E';j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class P10
    {/*
      A
      BA
      CBA
      DCBA
      EDCBA

      */
        static void Main(string[] args)
        {
            for(char i='A';i<='E';i++)
            {
                for(char j=i;j>='A';j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
               
        }
    }
    class P11
    {
        /*
        1
        22
        333
        4444
        55555
         */
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class P12
    {/*
      5
      44
      333
      2222
      11111
      */
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            
        }
    }
    class P13
    {/*
     55555
     4444
     333
     22
     1     
      
      */      
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j <=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class P14
    {/*
    A
    BB
    CCC
    DDDD
    EEEEE
      */
        static void Main(string[] args)
        {
            for(char i='A';i<='E';i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();
            }
        }
    }
    class P15
    {/*
    E
    DD
    CCC
    BBBB
    AAAAA   
    
      */
        static void Main(string[] args)
        {
            for(char i='E';i>='A';i--)
            {
                for(char j='E';j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}

