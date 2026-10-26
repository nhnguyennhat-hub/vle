```csharp
using System;

namespace BaiTap3
{
    class DaThuc
    {
        private double[] a;

        // Constructor nhận vào bậc của đa thức
        public DaThuc(int bac)
        {
            a = new double[bac + 1];

            for (int i = 0; i <= bac; i++)
            {
                a[i] = 0;
            }
        }

        // Property cho biết bậc của đa thức
        public int Bac
        {
            get
            {
                return a.Length - 1;
            }
        }

        // Indexer: a[k]
        public double this[int k]
        {
            get
            {
                if (k >= 0 && k <= Bac)
                {
                    return a[k];
                }

                return 0;
            }

            set
            {
                if (k >= 0 && k <= Bac)
                {
                    a[k] = value;
                }
            }
        }

        // Phép cộng hai đa thức
        public static DaThuc operator +(DaThuc p, DaThuc q)
        {
            int bacLonNhat;

            if (p.Bac > q.Bac)
            {
                bacLonNhat = p.Bac;
            }
            else
            {
                bacLonNhat = q.Bac;
            }

            DaThuc ketQua = new DaThuc(bacLonNhat);

            for (int i = 0; i <= bacLonNhat; i++)
            {
                ketQua[i] = p[i] + q[i];
            }

            return ketQua;
        }

        // Phép trừ hai đa thức
        public static DaThuc operator -(DaThuc p, DaThuc q)
        {
            int bacLonNhat;

            if (p.Bac > q.Bac)
            {
                bacLonNhat = p.Bac;
            }
            else
            {
                bacLonNhat = q.Bac;
            }

            DaThuc ketQua = new DaThuc(bacLonNhat);

            for (int i = 0; i <= bacLonNhat; i++)
            {
                ketQua[i] = p[i] - q[i];
            }

            return ketQua;
        }

        // Tính giá trị đa thức tại x = b
        public double TinhGiaTri(double b)
        {
            double ketQua = 0;

            for (int i = 0; i <= Bac; i++)
            {
                ketQua += a[i] * Math.Pow(b, i);
            }

            return ketQua;
        }

        // Xuất đa thức
        public override string ToString()
        {
            string ketQua = "";

            for (int i = Bac; i >= 0; i--)
            {
                if (a[i] != 0)
                {
                    if (ketQua != "")
                    {
                        if (a[i] > 0)
                        {
                            ketQua += " + ";
                        }
                        else
                        {
                            ketQua += " - ";
                        }
                    }
                    else if (a[i] < 0)
                    {
                        ketQua += "-";
                    }

                    double giaTri = Math.Abs(a[i]);

                    if (i == 0)
                    {
                        ketQua += giaTri;
                    }
                    else if (i == 1)
                    {
                        ketQua += giaTri + "x";
                    }
                    else
                    {
                        ketQua += giaTri + "x^" + i;
                    }
                }
            }

            if (ketQua == "")
            {
                ketQua = "0";
            }

            return ketQua;
        }
    }
}
```