using System;

namespace Baitap1
{
    class NotNegativeException : Exception
    {
        public NotNegativeException()
            : base("Gia tri duoi dau can phai lon hon hoac bang 0.")
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Nhap y: ");
                double y = double.Parse(Console.ReadLine());

                double mau = 2 * x - y;

                if (mau == 0)
                {
                    throw new DivideByZeroException();
                }

                double bieuThuc = (3 * x + 2 * y) / mau;

                if (bieuThuc < 0)
                {
                    throw new NotNegativeException();
                }

                double H = Math.Sqrt(bieuThuc);

                Console.WriteLine("H = " + H);
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi: x va y phai la so.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Loi: Mau so bang 0, khong the chia cho 0.");
            }
            catch (NotNegativeException ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
        }
    }
}