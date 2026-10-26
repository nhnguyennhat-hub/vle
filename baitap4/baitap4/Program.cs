using System;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== BAI TAP 4 - CHUOI =====");

            Console.WriteLine();
            Console.WriteLine("Cau 1");

            Console.Write("Nhap ho: ");
            string ho = Console.ReadLine();

            Console.Write("Nhap ten lot: ");
            string tenLot = Console.ReadLine();

            Console.Write("Nhap ten: ");
            string ten = Console.ReadLine();

            Console.WriteLine("Ho ten day du: " + ho + " " + tenLot + " " + ten);

            Console.WriteLine();
            Console.WriteLine("Cau 2");

            Console.Write("Nhap ho ten day du: ");
            string hoTen = Console.ReadLine();

            string[] mang = hoTen.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            Console.WriteLine("Ho: " + mang[0]);

            if (mang.Length == 2)
            {
                Console.WriteLine("Ten lot: Khong co");
                Console.WriteLine("Ten: " + mang[1]);
            }
            else
            {
                Console.Write("Ten lot: ");

                for (int i = 1; i < mang.Length - 1; i++)
                {
                    Console.Write(mang[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Ten: " + mang[mang.Length - 1]);
            }

            Console.WriteLine();
            Console.WriteLine("Cau 3");

            Console.Write("Nhap ho ten chua chuan hoa: ");
            string hoTenChuanHoa = Console.ReadLine();

            hoTenChuanHoa = hoTenChuanHoa.Trim().ToLower();

            string[] phan = hoTenChuanHoa.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            for (int i = 0; i < phan.Length; i++)
            {
                phan[i] = char.ToUpper(phan[i][0]) + phan[i].Substring(1);
            }

            string ketQua = string.Join(" ", phan);

            Console.WriteLine("Ho ten chuan: " + ketQua);
        }
    }
}