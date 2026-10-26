using System;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("===== KIEM TRA LOP NGUOI =====");

            Nguoi nguoi1 = new Nguoi();

            nguoi1.HoTen = "Nguyen Van A";
            nguoi1.NgaySinh = new DateTime(2000, 5, 10);
            nguoi1.DiaChi = "TP Ho Chi Minh";

            nguoi1.XemThongTin();

            Console.WriteLine();

            Nguoi nguoi2 = new Nguoi(
                "Tran Thi B",
                new DateTime(2002, 8, 20),
                "Binh Duong"
            );

            nguoi2.XemThongTin();

            Console.WriteLine();
            Console.WriteLine("===== KIEM TRA LOP SINH VIEN =====");

            SinhVien sv1 = new SinhVien();

            sv1.HoTen = "Pham Van C";
            sv1.NgaySinh = new DateTime(2004, 3, 15);
            sv1.DiaChi = "TP Ho Chi Minh";
            sv1.MaSV = "SV001";
            sv1.MaLop = "K49CNTT";
            sv1.Email = "sv001@gmail.com";
            sv1.DienThoai = "0901234567";

            sv1.XemThongTin();

            Console.WriteLine();

            SinhVien sv2 = new SinhVien(
                "Le Thi D",
                new DateTime(2003, 11, 25),
                "Dong Nai",
                "SV002",
                "K49CNTT",
                "sv002@gmail.com",
                "0912345678"
            );

            sv2.XemThongTin();

            Console.WriteLine();
            Console.WriteLine("===== KIEM TRA LOP NHAN VIEN =====");

            NhanVien nv1 = new NhanVien();

            nv1.HoTen = "Nguyen Van E";
            nv1.NgaySinh = new DateTime(1995, 6, 12);
            nv1.DiaChi = "TP Ho Chi Minh";
            nv1.MaNhanVien = "NV001";
            nv1.Email = "nv001@congty.com";
            nv1.DienThoai = "0987654321";
            nv1.NgayLamViec = new DateTime(2020, 1, 10);
            nv1.MaCongTy = "CT001";

            nv1.XemThongTin();

            Console.WriteLine();

            NhanVien nv2 = new NhanVien(
                "Tran Van F",
                new DateTime(1990, 9, 5),
                "Long An",
                "NV002",
                "nv002@congty.com",
                "0977777777",
                new DateTime(2018, 5, 20),
                "CT002"
            );

            nv2.XemThongTin();

            Console.WriteLine();
            Console.WriteLine("Nhan phim bat ky de ket thuc...");
            Console.ReadKey();
        }
    }
}