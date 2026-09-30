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
    public partial class Form2Register : Form
    {
        public Form2Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berhasil Daftar, Silahkan Login");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }
    }
}
