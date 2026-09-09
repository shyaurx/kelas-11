using System;
namespace IdentitasDiri
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATA DIRI");
            Console.WriteLine();

            Identitas data = new Identitas();
            Mapel pljrn = new Mapel();
            Absensi absen = new Absensi();
            Nilai rapot = new Nilai();

            data.DataDiri();
            data.DataWali();
            data.DataSklh();

            pljrn.Produktif();
            pljrn.NonProduktif();

            absen.SemuaBulan();

            rapot.SemuaNilai();
        }
    }

    class Identitas
    {
        public void DataDiri()
        {
            Console.WriteLine("===== IDENTITAS DIRI =====");
            Console.WriteLine("NISN          : 0098765432");
            Console.WriteLine("Nama          : Shifa Aura Nuradiansyah");
            Console.WriteLine("Kelas         : XI - Rekayasa Perangkat Lunak");
            Console.WriteLine("Jenis Kelamin : Perempuan");
            Console.WriteLine("Alamat        : Jati Utara 3 Rt06/Rw02");
            Console.WriteLine();
        }

        public void DataWali()
        {
            Console.WriteLine("===== IDENTITAS WALI =====");
            Console.WriteLine("Nama      : Nurliani");
            Console.WriteLine("Pekerjaan : PRT");
            Console.WriteLine("Alamat    : Jati Utara 3 Rt06/Rw02");
            Console.WriteLine();
        }

        public void DataSklh()
        {
            Console.WriteLine("===== RIWAYAT SEKOLAH =====");
            Console.WriteLine("TK  : TK Dharma Wanita");
            Console.WriteLine("SD  : SD Negeri Jati");
            Console.WriteLine("SMP : SMP PGRI 9 Sidoarjo");
            Console.WriteLine("SMK : SMK Negeri 2 Buduran");
            Console.WriteLine();
        }
    }

    class Mapel
    {
        public void Produktif()
        {
            Console.WriteLine("=== MATA PELAJARAN PRODUKTIF ===");
            Console.WriteLine("1. PPLG");
            Console.WriteLine("2. Basis Data");
            Console.WriteLine("3. Pemrograman");
            Console.WriteLine("4. Pemrograman Web");
            Console.WriteLine();
        }

        public void NonProduktif()
        {
            Console.WriteLine("=== MATA PELAJARAN NON PRODUKTIF ===");
            Console.WriteLine("1. Matematika");
            Console.WriteLine("2. Bahasa Inggris");
            Console.WriteLine("3. Bahasa Indonesia");
            Console.WriteLine("4. Pendidikan Agama");
            Console.WriteLine("5. Pendidikan Pancasila");
            Console.WriteLine();
        }
    }

    class Absensi
    {
        public void SemuaBulan()
        {
            Console.WriteLine("===== DATA ABSENSI =====");
            Console.WriteLine("Januari   : Sakit = 1, Izin = 0, Alpa = 0");
            Console.WriteLine("Februari  : Sakit = 0, Izin = 1, Alpa = 0");
            Console.WriteLine("Maret     : Sakit = 1, Izin = 0, Alpa = 1");
            Console.WriteLine("April     : Sakit = 0, Izin = 0, Alpa = 0");
            Console.WriteLine("Mei       : Sakit = 1, Izin = 0, Alpa = 0");
            Console.WriteLine("Juni      : Sakit = 0, Izin = 1, Alpa = 0");
            Console.WriteLine("Juli      : Sakit = 0, Izin = 0, Alpa = 0");
            Console.WriteLine("Agustus   : Sakit = 1, Izin = 0, Alpa = 0");
            Console.WriteLine("September : Sakit = 0, Izin = 0, Alpa = 1");
            Console.WriteLine("Oktober   : Sakit = 0, Izin = 1, Alpa = 0");
            Console.WriteLine("November  : Sakit = 0, Izin = 0, Alpa = 0");
            Console.WriteLine("Desember  : Sakit = 1, Izin = 0, Alpa = 0");
            Console.WriteLine();
        }
    }

    class Nilai
    {
        public void SemuaNilai()
        {
            Console.WriteLine("===== DATA NILAI =====");
            Console.WriteLine("Matematika       : 88");
            Console.WriteLine("Bahasa Inggris   : 90");
            Console.WriteLine("Bahasa Indonesia : 87");
            Console.WriteLine("PPLG             : 92");
            Console.WriteLine("Bahasa Jepang    : 89");
            Console.WriteLine("Pemrograman      : 90");
            Console.WriteLine();
        }
    }
}