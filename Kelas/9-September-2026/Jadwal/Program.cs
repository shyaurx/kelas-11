using System;
namespace Jadwal
{

    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("JADWAL PELAJARAN");
            Console.WriteLine();

            Senin day1 = new Senin();
            Selasa day2 = new Selasa();
            Rabu day3 = new Rabu();

            day1.sesi1();
            day1.sesi2();
            day1.sesi3();

            day2.sesi1();
            day2.sesi2();
            day2.sesi3();

            day3.sesi1();
            day3.sesi2();
            day3.sesi3();

            Kamis.sesi1();
            Kamis.sesi2();
            Kamis.sesi3();

            Jumat.sesi1();
            Jumat.sesi2();
            Jumat.sesi3();
        }
    }

    class Senin
    {
        public void sesi1()
        {
            Console.WriteLine("=========Senin==========");
            Console.WriteLine("Sesi 1 (jam ke 0-4)");
            Console.WriteLine("jam ke-0. Upacara");
            Console.WriteLine("jam ke-1. Bahasa Jepang");
            Console.WriteLine("jam ke-2. Bahasa Jepang");
            Console.WriteLine("jam ke-3. Bahasa Inggris");
            Console.WriteLine("jam ke-4. Bahasa Inggris");
            Console.WriteLine("Waktunya Istirahat 1");
            Console.WriteLine();
        }
        public void sesi2()
        {
            Console.WriteLine("Sesi 2 (jam ke 5-7)");
            Console.WriteLine("jam ke-5. Matematika");
            Console.WriteLine("jam ke-6. Matematika");
            Console.WriteLine("jam ke-7. Matematika");
            Console.WriteLine("Waktunya Istirahat 2");
            Console.WriteLine();
        }
        public void sesi3()
        {
            Console.WriteLine("Sesi 3 (jam ke 8-11)");
            Console.WriteLine("jam ke-8. PPLG");
            Console.WriteLine("jam ke-9. PPLG");
            Console.WriteLine("jam ke-10. PPLG");
            Console.WriteLine("jam ke-11. PPLG");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }

    class Selasa
    {
        public void sesi1()
        {
            Console.WriteLine("=========Selasa==========");
            Console.WriteLine("Sesi 1 (jam ke 1-4)");
            Console.WriteLine("jam ke-1. PKWU/KIK");
            Console.WriteLine("jam ke-2. PKWU/KIK");
            Console.WriteLine("jam ke-3. PJOK");
            Console.WriteLine("jam ke-4. PJOK");
            Console.WriteLine("Waktunya Istirahat 1");
            Console.WriteLine();
        }
        public void sesi2()
        {
            Console.WriteLine("Sesi 2 (jam ke 5-7)");
            Console.WriteLine("jam ke-5. Bahasa Indonesia");
            Console.WriteLine("jam ke-6. Bahasa Indonesia");
            Console.WriteLine("jam ke-7. Bahasa Indonesia");
            Console.WriteLine("jam ke-8. PPLG");
            Console.WriteLine("Waktunya Istirahat 2");
            Console.WriteLine();
        }
        public void sesi3()
        {
            Console.WriteLine("Sesi 3 (jam ke 9-11)");
            Console.WriteLine("jam ke-9. PPLG");
            Console.WriteLine("jam ke-10. PPLG");
            Console.WriteLine("jam ke-11. PPLG");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }

    class Rabu
    {
        public void sesi1()
        {
            Console.WriteLine("==========Rabu==========");
            Console.WriteLine("Sesi 1 (jam ke 1-4)");
            Console.WriteLine("jam ke-1. PPLG");
            Console.WriteLine("jam ke-2. PPLG");
            Console.WriteLine("jam ke-3. Koding");
            Console.WriteLine("jam ke-4. Koding");
            Console.WriteLine("Waktunya Istirahat 1");
            Console.WriteLine();
        }
        public void sesi2()
        {
            Console.WriteLine("Sesi 2 (jam ke 5-7)");
            Console.WriteLine("jam ke-5. Koding");
            Console.WriteLine("jam ke-6. Koding");
            Console.WriteLine("jam ke-7. Koding");
            Console.WriteLine("jam ke-8. Koding");
            Console.WriteLine("Waktunya Istirahat 2");
            Console.WriteLine();
        }
        public void sesi3()
        {
            Console.WriteLine("Sesi 3 (jam ke 9-11)");
            Console.WriteLine("jam ke-9. Koding");
            Console.WriteLine("jam ke-10. Koding");
            Console.WriteLine("jam ke-11. BK");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }
    class Kamis
    {
        public static void sesi1()
        {
            Console.WriteLine("=========Kamis==========");
            Console.WriteLine("Sesi 1 (jam ke 1-4)");
            Console.WriteLine("jam ke-1. Bahasa Jerman");
            Console.WriteLine("jam ke-2. Bahasa Jerman");
            Console.WriteLine("jam ke-3. Bahasa Jawa");
            Console.WriteLine("jam ke-4. Bahasa Jawa");
            Console.WriteLine("Waktunya Istirahat 1");
            Console.WriteLine();
        }
        public static void sesi2()
        {
            Console.WriteLine("Sesi 2 (jam ke 5-8)");
            Console.WriteLine("jam ke-5. PKWU/KIK");
            Console.WriteLine("jam ke-6. PKWU/KIK");
            Console.WriteLine("jam ke-7. PKWU/KIK");
            Console.WriteLine("jam ke-8. PAI");
            Console.WriteLine("Waktunya Istirahat 2");
            Console.WriteLine();
        }
        public static void sesi3()
        {
            Console.WriteLine("Sesi 3 (jam ke 9-11)");
            Console.WriteLine("jam ke-9. PAI");
            Console.WriteLine("jam ke-10. PAI");
            Console.WriteLine("jam ke-11. PAI");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }
    class Jumat
    {
        public static void sesi1()
        {
            Console.WriteLine("=========Jum'at==========");
            Console.WriteLine("Sesi 1 (jam ke 0-3)");
            Console.WriteLine("jam ke-0. Istigosah/Senam/Jumat Bersih");
            Console.WriteLine("jam ke-1. Bahasa Inggris");
            Console.WriteLine("jam ke-2. Bahasa Inggris");
            Console.WriteLine("jam ke-3. Sejarah");
            Console.WriteLine("Waktunya Istirahat 1");
            Console.WriteLine();
        }
        public static void sesi2()
        {
            Console.WriteLine("Sesi 2 (jam ke 4-6)");
            Console.WriteLine("jam ke-4. Sejarah");
            Console.WriteLine("jam ke-5. Pendidikan Pancasila");
            Console.WriteLine("jam ke-6. Pendidikan Pancasila");
            Console.WriteLine();
        }
        public static void sesi3()
        {
            Console.WriteLine("Sesi 3 (jam ke 7)");
            Console.WriteLine("jam ke-7. Pramuka/Keputrian");
            Console.WriteLine("Waktunya Pulang");
            Console.WriteLine();
        }
    }
}
