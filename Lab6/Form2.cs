using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string okunanmetin = "";
            string dosyaadresi = @"C:\DENEME\deneme.txt";

            if (File.Exists(dosyaadresi))
            {
                okunanmetin = File.ReadAllText(dosyaadresi);
                textBox1.Text = okunanmetin;
            }
            else
            {
                MessageBox.Show(dosyaadresi + " adlı dosya bulunamadı.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string okunanmetin = "";
            string dosyaadresi = @"C:\DENEME\deneme.txt";

            StreamReader sr = new StreamReader(dosyaadresi);

            if (File.Exists(dosyaadresi))
            {
                okunanmetin = sr.ReadToEnd();
                textBox1.Text = okunanmetin;
            }
            else
            {
                MessageBox.Show(dosyaadresi + " adlı dosya bulunamadı.");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dosyaadresi = @"C:\DENEME\deneme.txt";

            if (File.Exists(dosyaadresi))
            {
                int i = 0;
                foreach (string satirmetni in File.ReadLines(dosyaadresi))
                {
                    i++;
                    textBox1.Text += textBox1.Text + i.ToString() + ") " + satirmetni + "\r\n";
                }
            }
            else
            {
                MessageBox.Show(dosyaadresi + " adlı dosya bulunamadı.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string okunanmetin = "";
            string dosyaadresi = @"C:\DENEME\deneme.txt";

            StreamReader stroku = new StreamReader(dosyaadresi);

            if (File.Exists(dosyaadresi))
            {
                int i = 0;
                while (true)
                {
                    i++;
                    okunanmetin = stroku.ReadLine();
                    if(okunanmetin == null) break;
                    textBox1.Text += i.ToString() + " - " + okunanmetin + "\r\n";
                }
            }
            else
            {
                MessageBox.Show(dosyaadresi + " adlı dosya bulunamadı.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dosyaadresi = @"C:\DENEME\deneme.txt";
            if (File.Exists(dosyaadresi))
            {
                File.WriteAllText(dosyaadresi, textBox1.Text);
            }
            else
            {
                MessageBox.Show(dosyaadresi + " adlı dosya bulunamadı.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dosyaadresi = @"C:\DENEME\deneme.txt";

            if (File.Exists(dosyaadresi))
            {
                StreamWriter stryaz = new StreamWriter(dosyaadresi);
                stryaz.Write(textBox1.Text);
                stryaz.Close();
            }
            else
            {
                MessageBox.Show(dosyaadresi + " adlı dosya bulunamadı.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string okunanmetin = "";
            string dosyaadresi = @"C:\DENEME\deneme.txt";

            StreamReader stroku = new StreamReader(dosyaadresi);
            List<string> liste = new List<string>();

            if (File.Exists(dosyaadresi))
            {
                while (true)
                {
                    okunanmetin = stroku.ReadLine();
                    if (okunanmetin == null) break;
                    liste.Add(okunanmetin);
                }
            }
            else
            {
                MessageBox.Show(dosyaadresi + " adlı dosya bulunamadı.");
            }

            stroku.Close();

            liste.Insert(1, "Yeni Eklenen Satır");

            StreamWriter stryaz = new StreamWriter(dosyaadresi);

            foreach(string satirlar in liste)
            {
                stryaz.WriteLine(satirlar);
            }
            stryaz.Close();

        }
    }
}
