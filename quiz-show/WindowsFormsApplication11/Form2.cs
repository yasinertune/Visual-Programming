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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        int sure = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = sure.ToString();
            sure--;
        }

        public static int toplam_sure = 0;
        public static int puan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (radioButton1.Checked)
            {
                puan += 5;
                toplam_sure = sure;
            }
            else
            {
                puan -= 2;
                toplam_sure = sure;
            }

            Form3 ac = new Form3();
            ac.Show();
            this.Hide();
        }
    }
}
