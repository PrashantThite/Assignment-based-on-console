using System;
namespace A
{
    class class2
    {
        static void Main(string[] a)
        {

            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter height");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter gender");
            char gender = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Name=" + name);
            Console.WriteLine("Age=" + age);
            Console.WriteLine("Height=" + height);
            Console.WriteLine("Gender(M/f)=" + gender);


        }
    }
}
