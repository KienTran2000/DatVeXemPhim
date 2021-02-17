using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatVeXemPhim
{
    public partial class Form1 : Form
    {
        infor inf;
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        List<string> listItem;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Iron man with Spiderman")
            {
                listItem = new List<string>()
                {
                    "15h30", "17h30", "19h30"
                };
                comboBox2.DataSource = listItem;
                listItem = new List<string>()
                {
                    "1", "2", "6"
                };
                comboBox3.DataSource = listItem;
            }
            else if (comboBox1.Text == "Anh thầy ngôi sao")
            {
                listItem = new List<string>()
                {
                    "16h00", "18h00"
                };
                comboBox2.DataSource = listItem;
                listItem = new List<string>()
                {
                    "3", "4",
                };
                comboBox3.DataSource = listItem;
            }
            else if (comboBox1.Text == "Gone with the wind")
            {
                listItem = new List<string>()
                {
                    "17h00", "19h00"
                };
                comboBox2.DataSource = listItem;
                listItem = new List<string>()
                {
                    "5"
                };
                comboBox3.DataSource = listItem;
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                inf.soGhe += cb.Tag + ", ";
                inf.thanhtien += 70000;
            }
            else
            {
                string s = cb.Tag + ", ";
                if (inf.soGhe.Contains(s))
                {
                    inf.soGhe = inf.soGhe.Replace(s, "");
                    inf.thanhtien -= 70000;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inf.tenPhim = comboBox1.Text;
            inf.thoiGian = comboBox2.Text;
            inf.phong = comboBox3.Text;
            inf.khachHang = textBox1.Text;
            inf.sdt = textBox2.Text;
            Form2 f2 = new Form2(inf);
            f2.ShowDialog();
        }
    }
}
