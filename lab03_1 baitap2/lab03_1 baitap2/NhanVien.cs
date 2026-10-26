using System;

namespace BaiTap2
{
    class NhanVien : Nguoi
    {
        private string mMaNhanVien;
        private string mEmail;
        private string mDienThoai;
        private DateTime mNgayLamViec;
        private string mMaCongTy;

        public NhanVien() : base()
        {
            mMaNhanVien = "";
            mEmail = "";
            mDienThoai = "";
            mNgayLamViec = DateTime.Now;
            mMaCongTy = "";
        }

        public NhanVien(
            string hoTen,
            DateTime ngaySinh,
            string diaChi,
            string maNhanVien,
            string email,
            string dienThoai,
            DateTime ngayLamViec,
            string maCongTy) : base(hoTen, ngaySinh, diaChi)
        {
            mMaNhanVien = maNhanVien;
            mEmail = email;
            mDienThoai = dienThoai;
            mNgayLamViec = ngayLamViec;
            mMaCongTy = maCongTy;
        }

        public string MaNhanVien
        {
            get
            {
                return mMaNhanVien;
            }
            set
            {
                if (value != "")
                {
                    mMaNhanVien = value;
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

        public DateTime NgayLamViec
        {
            get
            {
                return mNgayLamViec;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    mNgayLamViec = value;
                }
            }
        }

        public string MaCongTy
        {
            get
            {
                return mMaCongTy;
            }
            set
            {
                if (value != "")
                {
                    mMaCongTy = value;
                }
            }
        }

        public override void XemThongTin()
        {
            base.XemThongTin();
            Console.WriteLine("Ma nhan vien: " + mMaNhanVien);
            Console.WriteLine("Email: " + mEmail);
            Console.WriteLine("Dien thoai: " + mDienThoai);
            Console.WriteLine("Ngay lam viec: " + mNgayLamViec.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ma cong ty: " + mMaCongTy);
        }
    }
}