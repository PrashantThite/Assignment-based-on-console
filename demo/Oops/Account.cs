using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Basic opps
    class Account
    {
        int AccountNo,balance,Amount;
        string Name, BranchName, type;
        public void insert(string Name,string BranchName,string type,int AccountNo,int balance)
        {
            this.Name = Name;
            this.BranchName=BranchName;           
            this.type = type;
            this.AccountNo = AccountNo;
            this.balance = balance;
        }
        public void display()
        {
            Console.WriteLine("Name="+Name);
            Console.WriteLine("Branch Name"+BranchName);
            Console.WriteLine("Type="+type);
            Console.WriteLine("Account number="+AccountNo);
            Console.WriteLine("Balance="+balance);
        }
        public void deposite(int deposite)
        {
            balance = balance+deposite;
        }
        public void displaydiposite()
        {
            Console.WriteLine("balance after deposite= "+balance);
        }
        public void Withdraw(int withdraw)
        {
            balance = balance - withdraw;
        }
        public void displayWithdraw()
        {
            Console.WriteLine("balance after withdraw"+balance);
        }
        
               
        
        public void displayBalance()
        {
            Console.WriteLine("Balance is Rs"+balance);
        }

    }
    
    class Results
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.insert("Prashant", "Pune", "Hdfc",  1020212,200000);
            a.display();
            Console.WriteLine();
            a.deposite(10000);
            a.displaydiposite();
            Console.WriteLine();
            a.Withdraw(20000);
            a.displayWithdraw();
            Console.WriteLine();
            a.displayBalance();
            

        }
    }
    class x
    {
        public static int a;
        static x()
        {
            Console.WriteLine("In static");
        }
            static void Main(string[] args)
            {

            }          
    }
    class Y
    {
        static void Main(string[] args)
        {
            x.a = 10;   
        }
    }
}
