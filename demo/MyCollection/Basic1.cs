using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Assignment.MyCollection
{
    class Basic1
    {
        // Arraylist in collection
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("abc");
            a.Add('c');
            a.Add(50);
            a.Add("###");
            a.Add(80);
            Console.WriteLine(a.Count);
            Console.WriteLine(a.Capacity);
            Console.WriteLine(a.IndexOf(50));
            a.Insert(3, 'j');
            a.Remove("abc");
            a.RemoveAt(2);
            foreach(var p in a)
            {
                Console.WriteLine(p);
            }

        }
    }
    class Basic2
    {
        // hashtable non genric basics
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "prashant");
            ht.Add(2, "Deepak");
            ht.Add(3, "Thite");
            ht.Add(4, "Haffkine");
            ht.Add("pune", 5);
            ht.Add(6, 'A');
            ht.Add(7, "abc");
            Console.WriteLine(ht.ContainsValue("Deepak"));
            Console.WriteLine(ht.ContainsKey(2));
            foreach(var x in ht.Keys)
            {
                Console.WriteLine($"key= {x} , value= {ht[x]}");
            }
            
           /* foreach(DictionaryEntry x in ht)
            {
                Console.WriteLine($"key = {x.Key}, value = {x.Value}");
            }
           */

        }
    }
  public  class Emp5
    {
        int id;
        string name;

        public Emp5(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is Emp5 emp &&
                   id == emp.id &&
                   name == emp.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name);
        }
    }
    class Basic3
    {
        // hashtable non generic using objects
        static void Main(string[] args)
        {
            Emp5 emp1 = new Emp5(1, "prashant");
            Emp5 emp2 = new Emp5(2, "Deepak");
            Emp5 emp3 = new Emp5(3, "thite");
            Emp5 emp4 = new Emp5(4, "***");
            Emp5 emp5 = new Emp5(5, "haffkine");
            Emp5 emp6 = new Emp5(1, "prashant");


            Hashtable ht = new Hashtable();
            ht.Add(emp1, "Back office");
            ht.Add(emp2, "manager");
            ht.Add(emp6, "manager");
            Console.WriteLine(ht.ContainsKey(emp1));
            
        }
    }
}
