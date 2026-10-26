using System;

namespace DuongTron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // =========================================
            // 1. Kiem tra constructor khong tham so
            // =========================================

            Console.WriteLine("===== DUONG TRON 1 =====");

            DuongTron dt1 = new DuongTron();

            dt1.Xuat();

            Console.WriteLine("Dien tich: " + dt1.DienTich());
            Console.WriteLine("Chu vi: " + dt1.ChuVi());

            // =========================================
            // 2. Kiem tra constructor co tham so
            // =========================================

            Console.WriteLine();
            Console.WriteLine("===== DUONG TRON 2 =====");

            Diem point = new Diem(1, 3);

            DuongTron dt2 = new DuongTron(point, 10);

            dt2.Xuat();

            Console.WriteLine("Dien tich: " + dt2.DienTich());
            Console.WriteLine("Chu vi: " + dt2.ChuVi());

            // =========================================
            // 3. Kiem tra constructor sao chep
            // =========================================

            Console.WriteLine();
            Console.WriteLine("===== DUONG TRON 3 - SAO CHEP =====");

            DuongTron dt3 = new DuongTron(dt2);

            dt3.Xuat();

            // =========================================
            // 4. Nhap duong tron
            // =========================================

            Console.WriteLine();
            Console.WriteLine("===== NHAP DUONG TRON =====");

            DuongTron dt4 = new DuongTron();

            dt4.Nhap();

            Console.WriteLine();
            Console.WriteLine("Duong tron vua nhap:");

            dt4.Xuat();

            Console.WriteLine("Dien tich: " + dt4.DienTich());
            Console.WriteLine("Chu vi: " + dt4.ChuVi());

            // =========================================
            // 5. Kiem tra diem voi duong tron
            // =========================================

            Console.WriteLine();
            Console.WriteLine("===== KIEM TRA DIEM =====");

            Diem p = new Diem(5, 3);

            Console.WriteLine("Diem P = " + p);
            Console.WriteLine("Duong tron: ");

            dt2.Xuat();

            Console.WriteLine(dt2.ViTriDiem(p));

            // =========================================
            // 6. Kiem tra hai duong tron
            // =========================================

            Console.WriteLine();
            Console.WriteLine("===== KIEM TRA HAI DUONG TRON =====");

            DuongTron dt5 = new DuongTron(
                new Diem(15, 3),
                5
            );

            Console.WriteLine("Duong tron 1:");
            dt2.Xuat();

            Console.WriteLine("Duong tron 2:");
            dt5.Xuat();

            Console.WriteLine();
            Console.WriteLine(dt2.ViTriHaiDuongTron(dt5));

            Console.WriteLine();
            Console.WriteLine("Nhan phim bat ky de ket thuc...");
            Console.ReadKey();
        }
    }
}