using System;

namespace Baitap1
{
    class HinhHoc
    {
        public double DienTich { get; set; }

        public double ChuVi { get; set; }

        public virtual void tinhDienTichChuVi()
        {
            DienTich = 0;
            ChuVi = 0;
        }

        public override string ToString()
        {
            return "Dien tich: " + DienTich +
                   ", Chu vi: " + ChuVi;
        }
    }
}