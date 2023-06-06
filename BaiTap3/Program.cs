using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Diem A = new Diem();
            Diem B = new Diem();

            A.nhap("A");
            B.nhap("B");

            A.xuat("A");
            B.xuat("B");

            Console.WriteLine("\nAB = " + A.khoangCach(B));   // khoang cach
        }
    }
}