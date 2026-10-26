using System;
using System.Collections.Generic;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            List<int> ml = new List<int>();

            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                ml.Add(x);
            }

            Console.WriteLine("Day so ban dau:");

            for (int i = 0; i < ml.Count; i++)
            {
                Console.Write(ml[i] + " ");
            }

            ml.Sort();

            Console.WriteLine();
            Console.WriteLine("Day so sau khi sap xep tang dan:");

            for (int i = 0; i < ml.Count; i++)
            {
                Console.Write(ml[i] + " ");
            }
        }
    }
}