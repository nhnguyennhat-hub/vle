
using System;

namespace DuongTron
{
    class DuongTron
    {
        private Diem tam;
        private int banKinh;

        public Diem Tam
        {
            get
            {
                return tam;
            }
            set
            {
                tam = value;
            }
        }

        public int BanKinh
        {
            get
            {
                return banKinh;
            }
            set
            {
                if (value >= 0)
                {
                    banKinh = value;
                }
            }
        }

        // Constructor khong tham so
        public DuongTron()
        {
            tam = new Diem();
            banKinh = 0;
        }

        // Constructor co tham so
        public DuongTron(Diem t, int r)
        {
            tam = new Diem(t);
            BanKinh = r;
        }

        // Constructor sao chep
        public DuongTron(DuongTron dt)
        {
            tam = new Diem(dt.Tam);
            banKinh = dt.BanKinh;
        }

        // Nhap duong tron
        public void Nhap()
        {
            Console.WriteLine("Nhap tam duong tron:");
            tam.Nhap();

            Console.Write("Nhap ban kinh: ");
            banKinh = int.Parse(Console.ReadLine());

            while (banKinh < 0)
            {
                Console.Write("Ban kinh phai >= 0. Nhap lai: ");
                banKinh = int.Parse(Console.ReadLine());
            }
        }

        // Xuat duong tron
        public void Xuat()
        {
            Console.WriteLine(
                "Duong tron: Tam = " + tam +
                ", Ban kinh = " + banKinh);
        }

        // Tinh dien tich
        public double DienTich()
        {
            return Math.PI * banKinh * banKinh;
        }

        // Tinh chu vi
        public double ChuVi()
        {
            return 2 * Math.PI * banKinh;
        }

        // Vi tri tuong doi giua diem va duong tron
        public string ViTriDiem(Diem p)
        {
            double d = tam.KhoangCach(p);

            if (d < banKinh)
            {
                return "Diem nam trong duong tron.";
            }
            else if (d == banKinh)
            {
                return "Diem nam tren duong tron.";
            }
            else
            {
                return "Diem nam ngoai duong tron.";
            }
        }

        // Vi tri tuong doi giua hai duong tron
        public string ViTriHaiDuongTron(DuongTron dt)
        {
            double d = tam.KhoangCach(dt.Tam);

            double tongBanKinh = banKinh + dt.BanKinh;
            double hieuBanKinh = Math.Abs(banKinh - dt.BanKinh);

            if (d == 0 && banKinh == dt.BanKinh)
            {
                return "Hai duong tron trung nhau.";
            }

            if (d > tongBanKinh)
            {
                return "Hai duong tron khong giao nhau.";
            }

            if (d == tongBanKinh)
            {
                return "Hai duong tron tiep xuc ngoai.";
            }

            if (d < tongBanKinh && d > hieuBanKinh)
            {
                return "Hai duong tron cat nhau tai hai diem.";
            }

            if (d == hieuBanKinh && d != 0)
            {
                return "Hai duong tron tiep xuc trong.";
            }

            if (d < hieuBanKinh)
            {
                return "Mot duong tron nam trong mot duong tron.";
            }

            return "Khong xac dinh.";
        }
    }
}