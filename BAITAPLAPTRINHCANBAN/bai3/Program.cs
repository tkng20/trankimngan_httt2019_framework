using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UCLN(a,b) + " là UCLN cua "+ a + " va " + b);
            Console.WriteLine(BCNN(a,b) + " là BCLN cua "+ a + " va " + b);
        }

        static int UCLN(int a, int b){
            while ( a != b){
                 if (a > b)
                     a = a - b;
                 else
                     b = b - a;
            }
            return a; 
        }

        static int BCNN(int a, int b){
                int result = UCLN(a, b);
                return a * b / result;
        }
    }
}
