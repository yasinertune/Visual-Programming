//Yasin Ertune - Richtextbox kullanımı ve kelime arama 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = 0;
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                richTextBox1.Find(textBox1.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                richTextBox1.SelectionBackColor = Color.Green;  //seçilenin arka planını yeşil renk olsun
                richTextBox1.SelectionColor = Color.White;  //seçilenin  yazı rengini beyaz renk olsun
                index = richTextBox1.Text.IndexOf(textBox1.Text, index) + 1;
            }
        }
    }
}
