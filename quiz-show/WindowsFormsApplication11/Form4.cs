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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (radioButton3.Checked)
            {
                Form2.puan += 5;
                Form2.toplam_sure = sure;
            }
            else
            {
                Form2.puan -= 2;
                Form2.toplam_sure = sure;
            }

            Form5 ac = new Form5();
            ac.Show();
            this.Hide();
        }

        int sure = Form2.toplam_sure;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = sure.ToString();
            sure--;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = sure.ToString();
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
