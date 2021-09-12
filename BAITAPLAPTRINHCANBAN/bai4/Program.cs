using System;
using System.Linq;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang");
            int soPTT = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[soPTT];
            for(int i=0;i<soPTT;i++){
               Console.WriteLine("Nhap phan tu thu "+ i +" : ");
               array[i] = Convert.ToInt32(Console.ReadLine());
            }

        Console.WriteLine("Mang vua nhap: ");    
        foreach (int i in array) 
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("Phan tu lon nhat trong mang la: "+array.Max());
        Console.WriteLine("Phan tu nho nhat trong mang la: "+array.Min());
        Console.WriteLine("Trung binh cong cua mang la : "+ array.Sum()/soPTT);
        }
    }
}
