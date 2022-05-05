using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.MyCollection
{
    class GenericClassEX<T>
    {
        T data;
        public void Add(T data)
        {
            this.data = data;
        }
        public T Get()
        {
            return data;
        }


    }
    class Customer
    {
        public string CName { get; set; }
       public GenericClassEX<Account> account = new GenericClassEX<Account>();

    }
    class Account
    {
        public string Atype { get; set; }
        public int  Ano { get; set; }
       public GenericClassEX<Loan> loan = new GenericClassEX<Loan>();
    }
    class Loan
    {
        public string Lname { get; set; }
        public int Lperiod{ get; set; }
    }
    class Test12
    {
        static void Main(string[] args)
        {
            GenericClassEX<Customer> customer = new GenericClassEX<Customer>();
           
        }
    }
}
