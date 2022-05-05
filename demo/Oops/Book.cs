using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Oops
{
    class Book
    {
        public string BookName, AuthorName;
        public int Mrp;
        public Book()
        {
            Console.WriteLine("Book info is below");

        }
    }

    class A
    {
        static void Main(string[] args)
        {

            Book s1 = new Book();
            s1.BookName = "English";
            s1.AuthorName = "Ramesh";
            s1.Mrp = 100;
            Console.WriteLine($"Book name={s1.BookName} Author name ={s1.AuthorName} MRP={s1.Mrp}");

            Book s2 = new Book();
            s2.BookName = "Hindi";
            s2.AuthorName = "Kabir";
            s2.Mrp = 90;
            Console.WriteLine($"Book name={s2.BookName} Author name ={s2.AuthorName} MRP={s2.Mrp}");

            Book s3 = new Book();
            s3.BookName = "Histroy";
            s3.AuthorName = "Hari";
            s3.Mrp = 110;
            Console.WriteLine($"Book name={s3.BookName} Author name ={s3.AuthorName} MRP={s3.Mrp}");


        }
    }
}
