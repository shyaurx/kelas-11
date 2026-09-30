using Contoh_Soal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part1
{
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            InitializeComponent();
        }

        private void ShowDashboard(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void ShowBandara(object sender, EventArgs e)
        {
            Form4Bandara bandaraForm = new Form4Bandara();
            bandaraForm.Show();
            this.Close();
        }

        private void ShowMaskapai(object sender, EventArgs e)
        {
            Form5Maskapai maskapaiForm = new Form5Maskapai();
            maskapaiForm.Show();
            this.Close();
        }
        private void ShowJadwal(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwalservice = new Form6JadwalPenerbangan();
            jadwalservice.Show();
            this.Close();
        }

        private void ShowKode(object sender, EventArgs e)
        {
            Form7KodePromo Vouchermember = new Form7KodePromo();
            Vouchermember.Show();
            this.Close();
        }

        private void ShowStatus(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan riwayat = new Form8UbahStatusPenerbangan();
            riwayat.Show();
            this.Close();
        }

        private void BackToLogin(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
