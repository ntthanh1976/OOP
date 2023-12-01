using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace Chapter01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1;
            int x2, y2;
            double kc = 0;
            //b1.Nhap gia tri dau vao
            Console.Write("Nhap diem thu A.\n");
            Console.Write("Toa do xa:");
            x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Toa do ya:");
            y1 = Int32.Parse(Console.ReadLine());
            //b1.nhap diem thu 2
            Console.Write("Nhap diem thu B.\n");
            Console.Write("Toa do xb:");
            x2 = Int32.Parse(Console.ReadLine());
            Console.Write("Toa do yb:");
            y2 = Int32.Parse(Console.ReadLine());

            //tinh khoang cach
            kc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            String data = String.Format("Khoang cach A({0},{1}) - B({2},{3}) = {4:0.00}",x1,y1,x2,y2,kc);
            Console.Write(data);           
            Console.ReadLine();
            //fsdfdsfdsf
        }
    }
}
