using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console1
{
    public class QuanLyThongTin
    {
        private static List<Student> ListSinhVien = new List<Student>();
        public static void NhapDuLieu()
        {
            Student sv = new Student();
            //throw new System.NotImplementedException();
            Console.Write("Enter the student's name: ");
            sv.Name = Console.ReadLine();
            Console.Write("Enter the student ID: ");
            sv.Mssv = int.Parse(Console.ReadLine());
            Console.Write("1st semester grades: ");
            sv.Diem.TCC = double.Parse(Console.ReadLine());
            Console.Write("2nd semester grades: ");
            sv.Diem.LDC = double.Parse(Console.ReadLine());
            Console.Write("3rd semester grades: ");
            sv.Diem.HDC = double.Parse(Console.ReadLine());
            ListSinhVien.Add(sv);
        }

        public static void XuatDuLieu()
        {
            Console.WriteLine("==========================================================================================================================================================================");
            Console.WriteLine("{0,10} {4,30} {1,30} {2,30} {3,30} {5,31}", "Ho ten", "1st", "2nd", "3rd","MSSV", "GPA");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var sv in ListSinhVien)
            {
                Console.WriteLine($"{sv.Name,16} {sv.Mssv,24} {sv.Diem.TCC,30} {sv.Diem.LDC,30} {sv.Diem.HDC,30} {sv.Gpa,31:F2}");
            }
            Console.WriteLine("==========================================================================================================================================================================");
        }

        public static void SapXep()
        {
            bool flag = true;
            int j = 0;

            while (flag)
            {
                flag = false;
                j++;
                for (int i = 0; i < ListSinhVien.Count-j; i++)
                {
                    if (ListSinhVien[i].Gpa < ListSinhVien[i+1].Gpa)
                    {
                        Student temp = ListSinhVien[i];
                        ListSinhVien[i] = ListSinhVien[i + 1];
                        ListSinhVien[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
        public static void TimKiem(int mssv)
        {
            Student temp = new Student();
            for (int i=0; i < ListSinhVien.Count; i++)
            {
                if (ListSinhVien[i].Mssv == mssv)
                {
                    temp = ListSinhVien[i];
                    break;
                }
            }
            Console.WriteLine("==========================================================================================================================================================================");
            Console.WriteLine("{0,10} {4,30} {1,30} {2,30} {3,30} {5,31}", "Ho ten", "1st", "2nd", "3rd", "MSSV", "GPA");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{temp.Name,16} {temp.Mssv,24} {temp.Diem.TCC,30} {temp.Diem.LDC,30} {temp.Diem.HDC,30} {temp.Gpa,31:F2}");
            Console.WriteLine("==========================================================================================================================================================================");
        }
        public static void UpdateThongTin(int mssv)
        {
            // Check co ton tai sinh vien hay khong 
            bool check = false;
            int index = 0;
            for (int i=0; i<ListSinhVien.Count; i++)
            {
                if (mssv == ListSinhVien[i].Mssv)
                {
                    check = true;
                    index = i;
                    break;
                }
            }
            // Cap nhat
            if (check)
            {
                Console.Write("Cap nhat ten sinh vien: ");
                string sName = Console.ReadLine();
                if (sName != null && sName.Length>0)
                {
                    ListSinhVien[index].Name = sName;
                }
                Console.Write("Cap nhat diem Toan Cao Cap: ");
                string sToanCC = Console.ReadLine();
                if (sToanCC != null && sToanCC.Length > 0)
                {
                    ListSinhVien[index].Diem.TCC = int.Parse(sToanCC);
                }
                Console.Write("Cap nhat diem Ly Dai Cuong: ");
                string sLyDC = Console.ReadLine();
                if (sLyDC != null && sLyDC.Length > 0)
                {
                    ListSinhVien[index].Diem.LDC = int.Parse(sLyDC);
                }
                Console.Write("Cap nhat diem Hoa Dai Cuong: ");
                string sHoaDC = Console.ReadLine();
                if (sHoaDC != null && sHoaDC.Length > 0)
                {
                    ListSinhVien[index].Diem.HDC = int.Parse(sHoaDC);
                }
                Console.WriteLine("\nUpdated successfully!");
            }
            else
            {
                Console.WriteLine($"This student is not exist: {mssv}");
            }
        }
    }
}