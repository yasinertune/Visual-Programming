//Yasin Ertune - String Fonksiyonları
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence = textBox1.Text;

            listBox1.Items.Add("Substring(4): "+sentence.Substring(4));
            listBox1.Items.Add("Substring(8,5): "+sentence.Substring(8,5));
            listBox1.Items.Add("İndexOf(Ü): "+sentence.IndexOf('Ü'));
            listBox1.Items.Add("İndexOf(Üniversitesi): "+sentence.IndexOf("Üniversitesi"));
            listBox1.Items.Add("ToLower(): "+sentence.ToLower());
            listBox1.Items.Add("ToUpper(): "+sentence.ToUpper());
            listBox1.Items.Add("Remove(5): "+sentence.Remove(5));
            listBox1.Items.Add("Remove(5,4): "+sentence.Remove(5,4));
            listBox1.Items.Add("Replace('a','z'): "+sentence.Replace('a','z'));
            listBox1.Items.Add("Insert(10,'Yasin'): "+sentence.Insert(9,"Yasin"));
            listBox1.Items.Add("Lenght: "+sentence.Length);

            //Substring(x): Belirtilen x indeksinden sonrasını gösterir
            //Substring(x,y): Belirtilen x indeksinden y indeksine kadar olan yeri alır
            //İndexOf(x): Belirtilen x indeksinin numarasını dönerir
            //ToLower(): Cümlenin hepsini küçük yapıyor.
            //ToUpper(): Cümlenin hepsini büyük yapıyor.
            //Remove(x): Belirtilen x indeksinden sonrasını siler.
            //Remove(x,y): Belirtilen x ve y aralığındaki harfleri siler.
            //Replace('x','y'): Belirtilen x harflerini y harflerine dönüştürür.
            //Insert(x,"y"): Belirtilen x indeksinden sonra y harfini ekler.
            //Lenght: Cümlenin uzunluğunu dönderir.     
        }
    }
}
