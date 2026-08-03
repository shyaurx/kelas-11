using System;

namespace tugas_1
{
    public class Kalkulator
    {
        public void Jalankan()
        {
            Console.Clear();
            Console.WriteLine("=== MENU KALKULATOR ===");
            Console.WriteLine("1. Penjumlahan (+)");
            Console.WriteLine("2. Pengurangan (-)");
            Console.WriteLine("3. Perkalian (*)");
            Console.WriteLine("4. Pembagian (/)");
            Console.Write("Pilih operasi (1-4): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double hasil = 0;

            switch (pilihan)
            {
                case 1:
                    hasil = a + b;
                    Console.WriteLine($"Hasil: {a} + {b} = {hasil}");
                    break;
                case 2:
                    hasil = a - b;
                    Console.WriteLine($"Hasil: {a} - {b} = {hasil}");
                    break;
                case 3:
                    hasil = a * b;
                    Console.WriteLine($"Hasil: {a} * {b} = {hasil}");
                    break;
                case 4:
                    if (b != 0)
                    {
                        hasil = a / b;
                        Console.WriteLine($"Hasil: {a} / {b} = {hasil}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Pembagian dengan nol tidak diperbolehkan!");
                    }
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}