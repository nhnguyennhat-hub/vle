using System;
using System.Collections.Generic;

namespace Baitap1
{
    class Program
    {
        static void XuatMang(List<string> mang)
        {
            string chuoi = string.Join(", ", mang);
            Console.WriteLine(chuoi);
        }

        static bool TimHangHoa(List<string> mang, string ten)
        {
            return mang.Contains(ten);
        }

        static void Main(string[] args)
        {
            List<string> mang = new List<string>();

            string tmp;

            Console.WriteLine("===== QUAN LY HANG HOA =====");

            Console.WriteLine();
            Console.WriteLine("Nhap ten hang hoa");
            Console.WriteLine("Nhap STOP de dung.");

            while (true)
            {
                Console.Write("Chuoi nhap: ");
                tmp = Console.ReadLine().Trim();

                if (tmp.ToUpper() == "STOP")
                {
                    break;
                }

                if (tmp != "")
                {
                    mang.Add(tmp);

                    Console.WriteLine(
                        "Count = {0}, Capacity = {1}",
                        mang.Count,
                        mang.Capacity
                    );
                }
            }

            Console.WriteLine();
            Console.WriteLine("Danh sach hang hoa:");
            XuatMang(mang);

            Console.WriteLine();
            Console.Write("Nhap ten hang hoa can tim: ");
            tmp = Console.ReadLine().Trim();

            if (TimHangHoa(mang, tmp))
            {
                int viTri = mang.IndexOf(tmp);

                Console.WriteLine(
                    "Tim thay {0} tai vi tri {1}",
                    tmp,
                    viTri
                );
            }
            else
            {
                Console.WriteLine("Khong tim thay " + tmp);
            }

            Console.WriteLine();
            Console.Write("Nhap ten hang hoa can xoa: ");
            tmp = Console.ReadLine().Trim();

            if (mang.Contains(tmp))
            {
                mang.Remove(tmp);

                Console.WriteLine("Da xoa hang hoa: " + tmp);

                Console.WriteLine("Danh sach sau khi xoa:");
                XuatMang(mang);
            }
            else
            {
                Console.WriteLine("Khong tim thay hang hoa de xoa.");
            }

            Console.WriteLine();
            Console.Write("Nhap hang hoa muon them: ");
            string hangHoaMoi = Console.ReadLine().Trim();

            Console.Write("Nhap vi tri index muon them: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index <= mang.Count)
            {
                mang.Insert(index, hangHoaMoi);

                Console.WriteLine("Danh sach sau khi them:");
                XuatMang(mang);
            }
            else
            {
                Console.WriteLine("Index khong hop le!");
            }
        }
    }
}