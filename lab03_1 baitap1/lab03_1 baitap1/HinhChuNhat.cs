using System;

namespace Baitap1
{
    class HinhChuNhat : HinhHoc
    {
        private double mChieuDai;
        private double mChieuRong;

        public HinhChuNhat()
        {
            mChieuDai = 0;
            mChieuRong = 0;
        }

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            mChieuDai = chieuDai;
            mChieuRong = chieuRong;
        }

        public double ChieuDai
        {
            get
            {
                return mChieuDai;
            }
            set
            {
                mChieuDai = value;
            }
        }

        public double ChieuRong
        {
            get
            {
                return mChieuRong;
            }
            set
            {
                mChieuRong = value;
            }
        }

        public override void tinhDienTichChuVi()
        {
            DienTich = mChieuDai * mChieuRong;
            ChuVi = (mChieuDai + mChieuRong) * 2;
        }

        public override string ToString()
        {
            return "Hinh chu nhat - " +
                   "Chieu dai: " + mChieuDai +
                   ", Chieu rong: " + mChieuRong +
                   ", Dien tich: " + DienTich +
                   ", Chu vi: " + ChuVi;
        }
    }
}