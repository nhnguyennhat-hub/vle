using System;

namespace DuongTron
{
    class Diem
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        // Constructor khong tham so
        public Diem()
        {
            x = 0;
            y = 0;
        }

        // Constructor co tham so
        public Diem(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        // Constructor sao chep
        public Diem(Diem p)
        {
            x = p.X;
            y = p.Y;
        }

        // Nhap diem
        public void Nhap()
        {
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());
        }

        // Xuat diem
        public void Xuat()
        {
            Console.Write("(" + x + ", " + y + ")");
        }

        // Tinh khoang cach den diem b
        public double KhoangCach(Diem b)
        {
            double dx = x - b.X;
            double dy = y - b.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}