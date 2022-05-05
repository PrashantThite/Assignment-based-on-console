
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    // Containment example
    class Order
    {
        int orderid;
        string orderdate;
        Customer c=new Customer();
        Item itemm=new Item();

        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        internal Customer C { get => c; set => c = value; }
        internal Item Itemm { get => itemm; set => itemm = value; }
    }
    class Customer
    {
        Address addr=new Address();
        int cid;
        string cname;

        public int Cid { get => cid; set => cid = value; }
        public string Cname { get => cname; set => cname = value; }
        internal Address Addr { get => addr; set => addr = value; }
    }
    class Address
    {
        string city;
        int pincode;

        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    class Item
    {
        int itemid;
        string iname;

        public int Itemid { get => itemid; set => itemid = value; }
        public string Iname { get => iname; set => iname = value; }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Order a = new Order();
            Console.WriteLine("Enter following in Sequence:-order id,order date,addr city,addr pincode, customer id,customer name, item name, item id");
            a.Orderid = Convert.ToInt32(Console.ReadLine());
            a.Orderdate = Console.ReadLine();
            a.C.Addr.City = Console.ReadLine();
            a.C.Addr.Pincode= Convert.ToInt32(Console.ReadLine());
            a.C.Cid= Convert.ToInt32(Console.ReadLine());
            a.C.Cname = Console.ReadLine();
            a.Itemm.Iname = Console.ReadLine();
            a.Itemm.Itemid= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Order Id={a.Orderid},  Order date={a.Orderdate}");
            Console.WriteLine($"City addr={a.C.Addr.City},  Pincode addr={a.C.Addr.Pincode}");
            Console.WriteLine($"Customer Id={a.C.Cid},  customer name={a.C.Cname}");
            Console.WriteLine(($"Item name={a.Itemm.Iname}, Item Id={a.Itemm.Itemid}"));
        }

    }
}
