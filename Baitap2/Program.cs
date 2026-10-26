using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap he so a: ");
                string inputA = Console.ReadLine();

                Console.Write("Nhap he so b: ");
                string inputB = Console.ReadLine();

                double a, b;

                if (!double.TryParse(inputA, out a) || !double.TryParse(inputB, out b))
                {
                    Console.WriteLine("He so a hoac b khong hop le!");
                    return;
                }

                if (a != 0)
                {
                    double x = -b / a;
                    Console.WriteLine("Phuong trinh co nghiem x = " + x);
                }
                else
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Da xay ra loi: " + ex.Message);
            }
        }
    }
}
