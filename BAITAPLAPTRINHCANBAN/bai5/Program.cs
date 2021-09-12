using System;
using System.Linq;
using System.Text;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhap keo/bua/bao: ");
            Console.WriteLine("1.Kéo");
            Console.WriteLine("2.Búa");
            Console.WriteLine("3.Bao");
            Console.WriteLine("4.Thoát");
            int player;
            do {
            Console.Write("Bạn chọn: ");
            player = Convert.ToInt32(Console.ReadLine());
                Random r = new Random();
                int may = r.Next(1, 4);
                switch(player){
                    case 1:
                        if(may == player){
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Hoa");
                            break;
                        }
                        else if (may==2){
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Thua");
                            break;
                        }
                        else {
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Thắng");
                            break;
                        }
                    case 2:
                        if(may == player){
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Hoà");
                            break;
                        }
                        else if (may==1){
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Thắng");
                            break;
                        }
                        else {
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Thua");
                            break;
                        }
                     case 3:
                        if(may == player){
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Hoà");
                            break;
                        }
                        else if (may==2){
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Thắng");
                            break;
                        }
                        else {
                            Console.WriteLine("Máy chọn: " +may);
                            Console.WriteLine("Thua");
                            break;
                        }
                    case 4:
                        Console.WriteLine("Kết thúc trò chơi");
                        break;
                    default:
                        Console.WriteLine("Lỗi lựa chọn");
                        break;
                }
            }while(player != 4);
        }
    }
}
