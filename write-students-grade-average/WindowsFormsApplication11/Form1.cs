//Yasin Ertune - Vize Final Ortalaması 
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double midterm=0,final=0,avg=0;
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                midterm=Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                final=Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                avg=(midterm*0.4) + (final*0.6);
                dataGridView1.Rows[i].Cells[4].Value = avg.ToString();
                if (avg < Convert.ToDouble(textBox5.Text))
                {   dataGridView1.Rows[i].Cells[5].Value = "KALDI";
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
                else
                {   dataGridView1.Rows[i].Cells[5].Value = "GEÇTİ";
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                }
            }
        }
    }
}
