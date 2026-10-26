```csharp
using System;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo đa thức P bậc 3
            DaThuc P = new DaThuc(3);

            P[0] = 2;
            P[1] = 3;
            P[2] = 4;
            P[3] = 5;

            Console.WriteLine("Da thuc P:");
            Console.WriteLine("P = " + P);

            Console.WriteLine("Bac cua P: " + P.Bac);

            // Tạo đa thức Q bậc 2
            DaThuc Q = new DaThuc(2);

            Q[0] = 1;
            Q[1] = 2;
            Q[2] = 3;

            Console.WriteLine();
            Console.WriteLine("Da thuc Q:");
            Console.WriteLine("Q = " + Q);

            Console.WriteLine("Bac cua Q: " + Q.Bac);

            // Cộng hai đa thức
            DaThuc Tong = P + Q;

            Console.WriteLine();
            Console.WriteLine("P + Q = " + Tong);

            // Trừ hai đa thức
            DaThuc Hieu = P - Q;

            Console.WriteLine("P - Q = " + Hieu);

            // Tính giá trị tại x = 2
            double x = 2;

            Console.WriteLine();
            Console.WriteLine("P(" + x + ") = " + P.TinhGiaTri(x));
            Console.WriteLine("Q(" + x + ") = " + Q.TinhGiaTri(x));
            Console.WriteLine("(P + Q)(" + x + ") = " + Tong.TinhGiaTri(x));
            Console.WriteLine("(P - Q)(" + x + ") = " + Hieu.TinhGiaTri(x));

            Console.WriteLine();
            Console.WriteLine("Nhan phim bat ky de ket thuc...");
            Console.ReadKey();
        }
    }
}
```