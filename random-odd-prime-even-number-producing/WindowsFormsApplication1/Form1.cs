//Yasin Ertune - 1 ile 100 arasindaki tek,cift,asal sayilar uretme
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = 0;
            int counter = 0;
            listBox1.Items.Clear();
            if (comboBox1.Text == "Çift")
            {
                for (int i = 0; i < 10; i++)
                {
                    number = rnd.Next(1, 100);
                    if (number % 2 == 0)
                        listBox1.Items.Add(number);
                    else
                        i--;
                }
            }
            else if (comboBox1.Text == "Tek")
            {
                for (int i = 0; i < 10; i++)
                {
                    number = rnd.Next(1, 100);
                    if (number % 2 == 1)
                        listBox1.Items.Add(number);
                    else
                        i--;
                }
            }
            else if (comboBox1.Text == "Asal")
            {
                for (int i = 0; i < 10; i++)
                {
                    number = rnd.Next(1, 100);
                    for (int a = 2; a < number; a++)
                        if (number % a == 0)
                            counter++;

                    if (counter == 0)
                        listBox1.Items.Add(number);
                    else
                    {
                        i--;
                        counter = 0;
                    }
                }
            }
        }
    }
}
