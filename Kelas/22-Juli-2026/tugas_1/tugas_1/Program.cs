using System;

namespace tugas_1
{
    class Menu
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();
            BangunDatar bangunDatar = new BangunDatar();
            BangunRuang bangunRuang = new BangunRuang();
            Zodiak zodiak = new Zodiak();

            bool ulangi = true;
            while (ulangi)
            {
                Console.Clear();
                Console.WriteLine("==================");
                Console.WriteLine("   MENU UTAMA     ");
                Console.WriteLine("==================");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Bangun Datar");
                Console.WriteLine("3. Bangun Ruang");
                Console.WriteLine("4. Zodiak");
                Console.WriteLine("5. Keluar Program");
                Console.Write("Pilih menu utama (1-5): ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        kalkulator.Jalankan();
                        break;
                    case "2":
                        bangunDatar.Jalankan();
                        break;
                    case "3":
                        bangunRuang.Jalankan();
                        break;
                    case "4":
                        zodiak.Jalankan();
                        break;
                    case "5":
                        ulangi = false;
                        Console.WriteLine("Terima kasih telah menggunakan program ini.");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid! Silakan tekan Enter untuk mengulang.");
                        break;
                }

                if (ulangi)
                {
                    Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu utama...");
                    Console.ReadKey();
                }
            }
        }
    }
}