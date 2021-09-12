using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ten ban");
            string myName = Console.ReadLine();
            Console.WriteLine("Nhap MSSV");
            string maSV = Console.ReadLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine(myName+" "+maSV);
        }
    }
}