using System;

namespace tugas_1
{
    public class BangunRuang
    {
        public void Jalankan()
        {
            Console.Clear();
            Console.WriteLine("=== MENU BANGUN RUANG (Luas Permukaan & Volume) ===");
            Console.WriteLine("1. Kubus");
            Console.WriteLine("2. Balok");
            Console.WriteLine("3. Tabung");
            Console.Write("Pilih bangun ruang (1-3): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Write("Masukkan sisi: ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    double luasK = 6 * (s * s);
                    double volK = Math.Pow(s, 3);
                    Console.WriteLine($"Luas Permukaan Kubus = {luasK}");
                    Console.WriteLine($"Volume Kubus = {volK}");
                    break;
                case 2:
                    Console.Write("Masukkan panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi: ");
                    double t = Convert.ToDouble(Console.ReadLine());

                    double luasB = 2 * ((p * l) + (p * t) + (l * t));
                    double volB = p * l * t;
                    Console.WriteLine($"Luas Permukaan Balok = {luasB}");
                    Console.WriteLine($"Volume Balok = {volB}");
                    break;
                case 3:
                    Console.Write("Masukkan jari-jari alas: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi tabung: ");
                    double tinggiT = Convert.ToDouble(Console.ReadLine());
                    double luasT = 2 * Math.PI * r * (r + tinggiT);
                    double volT = Math.PI * Math.Pow(r, 2) * tinggiT;
                    Console.WriteLine($"Luas Permukaan Tabung = {luasT:F2}");
                    Console.WriteLine($"Volume Tabung = {volT:F2}");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}