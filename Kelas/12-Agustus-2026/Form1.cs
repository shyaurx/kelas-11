using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konversi_panjang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          comboBox1.Items.Clear();
            comboBox1.Items.Add("Meter ke Centimeter (m -> cm)");
            comboBox1.Items.Add("Kilometer ke Meter (km -> m)");
            comboBox1.Items.Add("Meter ke Kilometer (m -> km)");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.SelectedIndex = 0;

            label4.Text = "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Silahkan masukkan nilai angka terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (!double.TryParse(textBox1.Text, out double inputNilai))
            {
                MessageBox.Show("Input harus berupa angka!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }

            double hasil = 0;
            string satuanAkhir = "";

            switch (comboBox1.SelectedIndex)
            {
                case 0: //m ke cm
                    hasil = inputNilai * 100;
                    satuanAkhir = "cm";
                    break;

                case 1: //km ke m
                    hasil = inputNilai * 1000;
                    satuanAkhir = "m";
                    break;

                case 2: //m ke km
                    hasil = inputNilai / 1000;
                    satuanAkhir = "km";
                    break;

                default:
                    return;
            }

            label4.Text = $"{hasil} {satuanAkhir}";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "0";
            comboBox1. SelectedIndex = 0;
            textBox1.Focus();
            textBox1.SelectAll(); 
        }
    }
}
