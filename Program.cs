using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubStrings;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            jump:
            Console.WriteLine("\n\n     ******************************************************");
            Console.WriteLine("     * 5. Cap nhat thong tin theo MSSV                    *");
            Console.WriteLine("     * 4. Tiem kiem thong tin sinh vien theo MSSV         *");
            Console.WriteLine("     * 3. Sap xep danh sach theo thu tu tang dan GPA      *");
            Console.WriteLine("     * 2. de nhap them sinh vien                          *");
            Console.WriteLine("     * 1. de xuat danh sach                               *");
            Console.WriteLine("     * 0. de thoat:                                       *");
            Console.WriteLine("     ******************************************************");

            Console.Write("Chon key: ");
            int key = int.Parse(Console.ReadLine());

            switch(key)
            {
                case 5:
                    Console.WriteLine("\n\nCap nhat thong tin sinh vien theo MSSV");
                    Console.Write("Nhap MSSV can cap nhen: ");
                    int mssv = int.Parse(Console.ReadLine());
                    QuanLyThongTin.UpdateThongTin(mssv);
                    goto jump;
                case 4:
                    Console.WriteLine("\n\nTiem kiem thong tin sinh vien theo MSSV");
                    Console.Write("Nhap MSSV can tiem: ");
                    int k = int.Parse(Console.ReadLine());
                    QuanLyThongTin.TimKiem(k);
                    goto jump;
                case 3:
                    Console.WriteLine("\n\nSap xep danh sach theo GPA tang dan: ");
                    QuanLyThongTin.SapXep();
                    QuanLyThongTin.XuatDuLieu();
                    goto jump;
                case 2:
                    Console.WriteLine("\n\nThem sinh vien: ");
                    QuanLyThongTin.NhapDuLieu();
                    goto jump;
                case 1:
                    Console.WriteLine("\n\nXuat danh sach: ");
                    QuanLyThongTin.XuatDuLieu();
                    goto jump;
                case 0:
                    Console.WriteLine("\n\n-------Da Thoat Thanh Cong!-------");
                    break;
            }

            Console.ReadKey();
        }
    }
}
