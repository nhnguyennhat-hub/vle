using System;

namespace Baitap1
{
    class HinhTron : HinhHoc
    {
        private double mBanKinh;

        public HinhTron()
        {
            mBanKinh = 0;
        }

        public HinhTron(double banKinh)
        {
            mBanKinh = banKinh;
        }

        public double BanKinh
        {
            get
            {
                return mBanKinh;
            }
            set
            {
                mBanKinh = value;
            }
        }

        public override void tinhDienTichChuVi()
        {
            DienTich = Math.PI * mBanKinh * mBanKinh;
            ChuVi = 2 * Math.PI * mBanKinh;
        }

        public override string ToString()
        {
            return "Hinh tron - " +
                   "Ban kinh: " + mBanKinh +
                   ", Dien tich: " + DienTich +
                   ", Chu vi: " + ChuVi;
        }
    }
}