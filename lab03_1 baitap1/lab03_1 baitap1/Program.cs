using System;
using System.Collections.Generic;
using System.IO;

namespace Baitap1
{
    class Program
    {
        static void DocFile(string tenFile, List<HinhHoc> ds)
        {
            string[] lines = File.ReadAllLines(tenFile);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split('|');

                if (data[0] == "HCN")
                {
                    double dai = double.Parse(data[1]);
                    double rong = double.Parse(data[2]);

                    HinhChuNhat hcn = new HinhChuNhat(dai, rong);

                    hcn.tinhDienTichChuVi();

                    ds.Add(hcn);
                }
                else if (data[0] == "HT")
                {
                    double banKinh = double.Parse(data[1]);

                    HinhTron ht = new HinhTron(banKinh);

                    ht.tinhDienTichChuVi();

                    ds.Add(ht);
                }
            }
        }

        static void XuatDanhSach(List<HinhHoc> ds)
        {
            Console.WriteLine("===== DANH SACH HINH =====");

            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }
        }

        static double TongDienTich(List<HinhHoc> ds)
        {
            double tong = 0;

            for (int i = 0; i < ds.Count; i++)
            {
                tong += ds[i].DienTich;
            }

            return tong;
        }

        static double TongChuVi(List<HinhHoc> ds)
        {
            double tong = 0;

            for (int i = 0; i < ds.Count; i++)
            {
                tong += ds[i].ChuVi;
            }

            return tong;
        }

        static HinhChuNhat HinhChuNhatDienTichLonNhat(List<HinhHoc> ds)
        {
            HinhChuNhat ketQua = null;

            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] is HinhChuNhat)
                {
                    HinhChuNhat hcn = (HinhChuNhat)ds[i];

                    if (ketQua == null || hcn.DienTich > ketQua.DienTich)
                    {
                        ketQua = hcn;
                    }
                }
            }

            return ketQua;
        }

        static HinhTron HinhTronChuViNhoNhat(List<HinhHoc> ds)
        {
            HinhTron ketQua = null;

            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] is HinhTron)
                {
                    HinhTron ht = (HinhTron)ds[i];

                    if (ketQua == null || ht.ChuVi < ketQua.ChuVi)
                    {
                        ketQua = ht;
                    }
                }
            }

            return ketQua;
        }

        static void GhiFile(string tenFile, List<HinhHoc> ds)
        {
            using (StreamWriter sw = new StreamWriter(tenFile))
            {
                sw.WriteLine("===== KET QUA =====");

                sw.WriteLine("Tong dien tich: " + TongDienTich(ds));
                sw.WriteLine("Tong chu vi: " + TongChuVi(ds));

                HinhChuNhat hcn = HinhChuNhatDienTichLonNhat(ds);

                if (hcn != null)
                {
                    sw.WriteLine();
                    sw.WriteLine("===== HINH CHU NHAT CO DIEN TICH LON NHAT =====");
                    sw.WriteLine(hcn);
                }

                HinhTron ht = HinhTronChuViNhoNhat(ds);

                if (ht != null)
                {
                    sw.WriteLine();
                    sw.WriteLine("===== HINH TRON CO CHU VI NHO NHAT =====");
                    sw.WriteLine(ht);
                }
            }
        }

        static void Main(string[] args)
        {
            List<HinhHoc> ds = new List<HinhHoc>();

            string fileInput = "input.txt";
            string fileOutput = "output.txt";

            try
            {
                DocFile(fileInput, ds);

                Console.WriteLine("Doc file thanh cong!");
                Console.WriteLine();

                XuatDanhSach(ds);

                Console.WriteLine();
                Console.WriteLine("Tong dien tich: " + TongDienTich(ds));
                Console.WriteLine("Tong chu vi: " + TongChuVi(ds));

                HinhChuNhat hcn = HinhChuNhatDienTichLonNhat(ds);

                if (hcn != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hinh chu nhat co dien tich lon nhat:");
                    Console.WriteLine(hcn);
                }

                HinhTron ht = HinhTronChuViNhoNhat(ds);

                if (ht != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hinh tron co chu vi nho nhat:");
                    Console.WriteLine(ht);
                }

                GhiFile(fileOutput, ds);

                Console.WriteLine();
                Console.WriteLine("Da ghi ket qua vao file output.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}