using System;

namespace Baitap1_3
{
    class SanPham
    {
        private int ma;
        private string ten;
        private double gia;

        // Constructor khong tham so
        public SanPham()
        {
            ma = 0;
            ten = "";
            gia = 0;
        }

        // Constructor co 3 tham so
        public SanPham(int ma, string ten, double gia)
        {
            this.ma = ma;
            this.ten = ten;
            this.gia = gia;
        }

        // Tinh thue VAT
        public double TinhVAT()
        {
            return gia * 0.1;
        }

        // Nhap san pham
        public void Nhap()
        {
            Console.Write("Nhap ma san pham: ");
            ma = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten san pham: ");
            ten = Console.ReadLine();

            Console.Write("Nhap gia san pham: ");
            gia = double.Parse(Console.ReadLine());
        }

        // Xuat san pham
        public void Xuat()
        {
            Console.WriteLine("Ma: " + ma);
            Console.WriteLine("Ten: " + ten);
            Console.WriteLine("Gia: " + gia);
            Console.WriteLine("Thue VAT: " + TinhVAT());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SanPham sp1 = new SanPham();
            SanPham sp2 = new SanPham();

            Console.WriteLine("===== NHAP SAN PHAM 1 =====");
            sp1.Nhap();

            Console.WriteLine();

            Console.WriteLine("===== NHAP SAN PHAM 2 =====");
            sp2.Nhap();

            Console.WriteLine();

            Console.WriteLine("===== SAN PHAM 1 =====");
            sp1.Xuat();

            Console.WriteLine();

            Console.WriteLine("===== SAN PHAM 2 =====");
            sp2.Xuat();

            Console.ReadKey();
        }
    }
}