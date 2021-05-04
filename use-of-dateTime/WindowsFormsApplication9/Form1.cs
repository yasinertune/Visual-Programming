//Yasin Ertune - DateTime Uygulaması
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //Listbox temizle
            int year = Convert.ToInt32(textBox1.Text);
            int year2 = Convert.ToInt32(textBox2.Text);
            DateTime dt1 = new DateTime();
            for (int i = year; i <= year2; i++)
            {
                dt1 = new DateTime(i, 1, 1);
                if (dt1.DayOfWeek.ToString()=="Monday") //pazartesi olanları listbox'a ekle
		                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int year = Convert.ToInt32(textBox3.Text);
            int year2 = Convert.ToInt32(textBox4.Text);
            int random_year = 0;
            int random_month = 0;
            int random_day = 0;
            DateTime date_time = new DateTime();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                random_year = rnd.Next(year, year2);
                random_month = rnd.Next(1, 12);
                random_day = rnd.Next(1, 30);
                date_time = new DateTime(random_year, random_month, random_day);
                listBox2.Items.Add(date_time);
                listBox3.Items.Add(date_time.DayOfWeek.ToString());
            }
        }   
    }
}
