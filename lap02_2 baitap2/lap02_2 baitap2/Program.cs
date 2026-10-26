using System;
using System.Collections.Generic;

namespace Baitap2
{
    struct MatHang
    {
        public int MaMH;
        public string TenMH;
        public int SoLuong;
        public double DonGia;

        public MatHang(int maMH, string tenMH, int soLuong, double donGia)
        {
            MaMH = maMH;
            TenMH = tenMH;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public double ThanhTien()
        {
            return SoLuong * DonGia;
        }
    }

    class Program
    {
        // Hàm thêm mặt hàng
        static void ThemMatHang(List<MatHang> ds, MatHang mh)
        {
            ds.Add(mh);
        }

        // Hàm tìm mặt hàng theo mã
        static bool TimMatHang(List<MatHang> ds, int maMH)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaMH == maMH)
                {
                    return true;
                }
            }

            return false;
        }

        // Hàm xuất danh sách
        static void XuatDanhSach(List<MatHang> ds)
        {
            Console.WriteLine();
            Console.WriteLine("===== DANH SACH MAT HANG =====");

            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine("Ma MH: " + ds[i].MaMH);
                Console.WriteLine("Ten MH: " + ds[i].TenMH);
                Console.WriteLine("So luong: " + ds[i].SoLuong);
                Console.WriteLine("Don gia: " + ds[i].DonGia);
                Console.WriteLine("Thanh tien: " + ds[i].ThanhTien());
                Console.WriteLine("-----------------------------");
            }
        }

        // Hàm xóa mặt hàng theo mã
        static void XoaMatHang(List<MatHang> ds, int maMH)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaMH == maMH)
                {
                    ds.RemoveAt(i);
                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            List<MatHang> ds = new List<MatHang>();

            string tiepTuc;

            // Nhập danh sách
            do
            {
                try
                {
                    Console.Write("Nhap ma mat hang: ");
                    int maMH = int.Parse(Console.ReadLine());

                    Console.Write("Nhap ten mat hang: ");
                    string tenMH = Console.ReadLine();

                    Console.Write("Nhap so luong: ");
                    int soLuong = int.Parse(Console.ReadLine());

                    Console.Write("Nhap don gia: ");
                    double donGia = double.Parse(Console.ReadLine());

                    MatHang mh = new MatHang(
                        maMH,
                        tenMH,
                        soLuong,
                        donGia
                    );

                    ThemMatHang(ds, mh);

                    Console.Write("Ban co muon tiep tuc nhap? (y/n): ");
                    tiepTuc = Console.ReadLine().ToLower();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du lieu nhap vao khong hop le!");
                    tiepTuc = "y";
                }

            } while (tiepTuc == "y");

            // Xuất danh sách
            XuatDanhSach(ds);

            // Tìm và xóa
            Console.WriteLine();
            Console.Write("Nhap ma mat hang can tim: ");
            int maCanTim = int.Parse(Console.ReadLine());

            if (TimMatHang(ds, maCanTim))
            {
                Console.WriteLine("Tim thay mat hang.");

                XoaMatHang(ds, maCanTim);

                Console.WriteLine("Da xoa mat hang.");

                // Xuất lại danh sách sau khi xóa
                XuatDanhSach(ds);
            }
            else
            {
                Console.WriteLine("Khong tim thay mat hang co ma " + maCanTim);
            }
        }
    }
}