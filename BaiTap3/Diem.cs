using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class Diem
    {
        double x, y;
        public Diem()
        {
            x = 0; y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void nhap(string s)
        {
            try
            {
                Console.Write("Nhap toa do {0}.x : ",s);
                x = double.Parse(Console.ReadLine());
                Console.Write("Nhap toa do {0}.y : ", s);
                y = double.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void xuat(string s)
        {
            Console.Write("\nToa do diem {0}({1},{2})",s,x.ToString(),y.ToString());
        }

        public double khoangCach(Diem B)
        {
            return Math.Sqrt((x-B.x)*(x-B.x)+(y-B.y)*(y-B.y));
        }
    }
}
