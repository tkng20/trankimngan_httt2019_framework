using System;

namespace nguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            soNTT(number);
            soCP(number);
        }


        static void soNTT(int number){
            bool flag = true; 
            if (number < 2)
            {
                flag = false;
            }
            int n = (int) Math.Sqrt(number);
            for (int i = 2; i <= n ; i++){
                if (number % i == 0)
                {
                    flag = false;
                    break;
                }
            }

            if (flag == true)
            {
                Console.WriteLine(number + " la so nguyen to");
            }
            else{
                Console.WriteLine(number +" khong la so nguyen to");
            }
        }

        static void soCP(int number){
            int sqrt = (int) Math.Sqrt(number);
            if(sqrt * sqrt == number){
            Console.WriteLine(number + " la so chinh phuong");
            }
            else Console.WriteLine(number + " khong la so chinh phuong");
        }
    }
}
