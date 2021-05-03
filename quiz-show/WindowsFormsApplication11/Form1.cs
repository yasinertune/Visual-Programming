using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string ad_soyad="";
        private void button1_Click(object sender, EventArgs e)
        {
            ad_soyad = textBox1.Text + "  " + textBox2.Text;
            Form2 ac = new Form2();
            ac.Show();
            this.Hide();
        }
    }
}
