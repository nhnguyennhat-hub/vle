using System;

namespace BaiTap2
{
    class SinhVien : Nguoi
    {
        private string mMaSV;
        private string mMaLop;
        private string mEmail;
        private string mDienThoai;

        public SinhVien() : base()
        {
            mMaSV = "";
            mMaLop = "";
            mEmail = "";
            mDienThoai = "";
        }

        public SinhVien(
            string hoTen,
            DateTime ngaySinh,
            string diaChi,
            string maSV,
            string maLop,
            string email,
            string dienThoai) : base(hoTen, ngaySinh, diaChi)
        {
            mMaSV = maSV;
            mMaLop = maLop;
            mEmail = email;
            mDienThoai = dienThoai;
        }

        public string MaSV
        {
            get
            {
                return mMaSV;
            }
            set
            {
                if (value != "")
                {
                    mMaSV = value;
                }
            }
        }

        public string MaLop
        {
            get
            {
                return mMaLop;
            }
            set
            {
                if (value != "")
                {
                    mMaLop = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                if (value.Contains("@"))
                {
                    mEmail = value;
                }
            }
        }

        public string DienThoai
        {
            get
            {
                return mDienThoai;
            }
            set
            {
                if (value != "")
                {
                    mDienThoai = value;
                }
            }
        }

        public override void XemThongTin()
        {
            base.XemThongTin();
            Console.WriteLine("Ma sinh vien: " + mMaSV);
            Console.WriteLine("Ma lop: " + mMaLop);
            Console.WriteLine("Email: " + mEmail);
            Console.WriteLine("Dien thoai: " + mDienThoai);
        }
    }
}