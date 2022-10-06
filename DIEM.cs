using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Console1
{
    public class GRADE
    {
        private double ToanCC;
        private double LyDC;
        private double HoaDC;

        public GRADE() {}
        public GRADE(ref double d)
        {
            if (d > 10 || d < 0)
            {
                MessageBox.Show("Diem khong hop le, tra ve -1", "Canh Bao!");
                d = -1;
            }
        }

        public double TCC
        {
            get => ToanCC;
            set
            {
                GRADE temp = new GRADE(ref value);
                ToanCC = value;
            }
        }

        public double LDC
        {
            get => LyDC;
            set
            {
                GRADE temp = new GRADE(ref value);
                LyDC = value;
            }
        }
        public double HDC
        {
            get => HoaDC;
            set
            {
                GRADE temp = new GRADE(ref value);
                HoaDC = value;
            }
        }
        public double TinhDTB()
        {
            double dtb = (HoaDC + LyDC + ToanCC) / 3;
            return dtb;
        }
    }
}