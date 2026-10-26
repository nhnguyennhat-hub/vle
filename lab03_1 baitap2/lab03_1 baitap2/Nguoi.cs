using System;

namespace BaiTap2
{
    class Nguoi
    {
        protected string mHoTen;
        protected DateTime mNgaySinh;
        protected string mDiaChi;

        public Nguoi()
        {
            mHoTen = "";
            mNgaySinh = DateTime.Now;
            mDiaChi = "";
        }

        public Nguoi(string hoTen, DateTime ngaySinh, string diaChi)
        {
            mHoTen = hoTen;
            mNgaySinh = ngaySinh;
            mDiaChi = diaChi;
        }

        public string HoTen
        {
            get
            {
                return mHoTen;
            }
            set
            {
                if (value != "")
                {
                    mHoTen = value;
                }
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return mNgaySinh;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    mNgaySinh = value;
                }
            }
        }

        public string DiaChi
        {
            get
            {
                return mDiaChi;
            }
            set
            {
                if (value != "")
                {
                    mDiaChi = value;
                }
            }
        }

        public int LayTuoi
        {
            get
            {
                int tuoi = DateTime.Now.Year - mNgaySinh.Year;

                if (DateTime.Now < mNgaySinh.AddYears(tuoi))
                {
                    tuoi--;
                }

                return tuoi;
            }
        }

        public virtual void XemThongTin()
        {
            Console.WriteLine("Ho ten: " + mHoTen);
            Console.WriteLine("Ngay sinh: " + mNgaySinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Dia chi: " + mDiaChi);
            Console.WriteLine("Tuoi: " + LayTuoi);
        }
    }
}