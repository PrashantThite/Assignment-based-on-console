using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyDelegat
{
    public delegate void dele2();
 class Bank
    {
        public event dele2 creeditEvent;
        public event dele2 InsufficientBal;
        public event dele2 ZeroBal;
        public event dele2 DebitEvent;

        public int Balance { get; set; }
        public void Credit(int x)
        {
            Balance += x;
            creeditEvent();
            Console.WriteLine("Balance is Rs= "+Balance);

        }
        public void Debit(int x)
        {
            int a = Balance - x;
            if (a < 0)
            {
                InsufficientBal();
            }
            else if (a == 0)
            {
                ZeroBal();
                Balance -= x;

            }
            else
            {
                Balance -= x;
                DebitEvent();
            }
            Console.WriteLine("Your account balance is Rs"+Balance);
        }
    }
    class Test11
    {
        
        static void CreditMsg()
        {
            Console.WriteLine("Credited succesfull.");
        }
        static void DebitMsg()
        {
            Console.WriteLine("Debit succesfull.");
        }
        static void ZeroMsg()
        {
            Console.WriteLine("Debit succesfully. Your balance is Rs 0.");
        }
        static void InsuffBal()
        {
            Console.WriteLine("Balance is insufficient to withdraw.");
        }

        static void Main(string[] args)
        {
            Bank sbi = new Bank();
            sbi.creeditEvent += new dele2(CreditMsg);
            sbi.DebitEvent += new dele2(DebitMsg);
            sbi.ZeroBal += new dele2(ZeroMsg);
            sbi.InsufficientBal += new dele2(InsuffBal);

            sbi.Balance = 10000;
            sbi.Credit(5000);
            sbi.Debit(10000);
            



        }
    }
 
    
}
