using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random rnd = new Random();
            //string tek_cift="";
            int remainder = 0;
            //string step = "";
            int start = 0;
            int finish = 0;

            int number = 0;
            int[] numbers = new int[5];
            if (radio_tek.Checked == true)
                remainder = 1;

            if (radio_cift.Checked == true)
                remainder = 0;
           
            if (radio_1.Checked == true)
            {
                start = 0;
                finish = 10;
            }
            if (radio_2.Checked == true)
            {
                start = 10;
                finish = 100;
            }
            if (radio_3.Checked == true)
            {
                start = 100;
                finish = 1000;
            }

            int sayac = 0;
            for (int i = 0; i < 5; i++)
            {
                number=rnd.Next(start, finish);
                if (number % 2 == remainder)
                {
                    if (check_farkli.Checked==true)
                    {
                        for (int a = 0; a < i; a++)
                        {
                            if (numbers[a] == number)
                                sayac++;
                        }
                        if (sayac == 0)
                            numbers[i] = number;
                        else
                        {
                            i--;
                            sayac = 0;
                        }     
                    }
                    else
                        numbers[i] = number;
                }
                else
                    i--;
            }
            if (check_sirali.Checked==true)
            {
                int temp = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int a = 0; a < 5; a++)
                    {
                        if (numbers[i] > numbers[a])
                        {
                            temp = numbers[i];
                            numbers[i] = numbers[a];
                            numbers[a] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < 5; i++)
                textBox1.Text = textBox1.Text + " "+numbers[i];
        }
    }
}
