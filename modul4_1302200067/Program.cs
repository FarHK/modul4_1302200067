﻿namespace modul4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(13, 02, 20));

        }
    }
    class penjumlahan
    {
        public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic a = input1;
            dynamic b = input2;
            dynamic c = input3;

            return a + b + c;
        }
    }
}