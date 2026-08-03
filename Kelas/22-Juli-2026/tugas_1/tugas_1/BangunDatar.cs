using System;

namespace tugas_1
{
    public class BangunDatar
    {
        public void Jalankan()
        {
            Console.Clear();
            Console.WriteLine("=== MENU BANGUN DATAR (Luas & Keliling) ===");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Lingkaran");
            Console.Write("Pilih bangun datar (1-3): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Write("Masukkan sisi: ");
                    double sisi = Convert.ToDouble(Console.ReadLine());
                    double luasP = sisi * sisi;
                    double kelP = 4 * sisi;
                    Console.WriteLine($"Luas Persegi = {luasP}");
                    Console.WriteLine($"Keliling Persegi = {kelP}");
                    break;
                case 2:
                    Console.Write("Masukkan panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    double luasPP = p * l;
                    double kelPP = 2 * (p + l);
                    Console.WriteLine($"Luas Persegi Panjang = {luasPP}");
                    Console.WriteLine($"Keliling Persegi Panjang = {kelPP}");
                    break;
                case 3:
                    Console.Write("Masukkan jari-jari: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    double luasL = Math.PI * r * r;
                    double kelL = 2 * Math.PI * r;
                    Console.WriteLine($"Luas Lingkaran = {luasL:F2}");
                    Console.WriteLine($"Keliling Lingkaran = {kelL:F2}");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}