using System;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap so luong phan tu n: ");
                string inputN = Console.ReadLine();

                int n;

                if (!int.TryParse(inputN, out n) || n <= 0)
                {
                    Console.WriteLine("So luong phan tu khong hop le!");
                    return;
                }

                int[] a = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nhap a[" + i + "]: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out a[i]))
                    {
                        Console.WriteLine("Gia tri khong hop le!");
                        return;
                    }
                }

                int tong = 0;
                int lonNhat = a[0];
                int nhoNhat = a[0];

                for (int i = 0; i < n; i++)
                {
                    tong += a[i];

                    if (a[i] > lonNhat)
                    {
                        lonNhat = a[i];
                    }

                    if (a[i] < nhoNhat)
                    {
                        nhoNhat = a[i];
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Tong cua mang = " + tong);
                Console.WriteLine("So nguyen lon nhat = " + lonNhat);
                Console.WriteLine("So nguyen nho nhat = " + nhoNhat);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Da xay ra loi: " + ex.Message);
            }
        }
    }
}
