using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string marka = comboBox1.Text;
            string ürün = comboBox2.Text;
            string kampanyacesidi = comboBox3.Text;
            comboBox1.Items.Add("SIEMENS");
            comboBox1.Items.Add("ARÇELİK");
            comboBox1.Items.Add("LG");
            comboBox1.Items.Add("SAMSUNG");
            comboBox1.Items.Add("BOSCH");
            comboBox2.Items.Add("TELEVİZYON");
            comboBox2.Items.Add("BULAŞIK M.");
            comboBox2.Items.Add("ÇAMAŞIR M.");
            comboBox2.Items.Add("KLİMA");
            comboBox3.Items.Add("%25 İNDİRİMLİ");
            comboBox3.Items.Add("%50 İNDİRİMLİ");
            comboBox3.Items.Add("%75 İNDİRİMLİ");
            comboBox4.Items.Add("STOKTA VAR");
            comboBox4.Items.Add("STOKTA YOK");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string marka = comboBox1.Text;
            string ürün = comboBox2.Text;
            string kampanyacesidi = comboBox3.Text;
            string stok = comboBox4.Text;
            dataGridView1.Rows.Add(ad, ürün, marka, kampanyacesidi, stok );


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }  
    }
}
