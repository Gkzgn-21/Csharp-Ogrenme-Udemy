using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "OOP'nin açılımı nedir? ";
                BtnA.Text = "Object Oriented Programming";
                BtnB.Text = "Operator Overload Process";
                BtnC.Text = "Optimal Output Protocol";
                BtnD.Text = "Open Operating Program";
                label4.Text = "Object Oriented Programming";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Güneydoğu Bölgesinde yer almaz ";
                BtnA.Text = "Diyarbakır";
                BtnB.Text = "Mardin";
                BtnC.Text = "Muğla";
                BtnD.Text = "Şırnak";
                label4.Text = "Muğla";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "En hafif metal hangisidir? ";
                BtnA.Text = "Altın";
                BtnB.Text = "Lityum";
                BtnC.Text = "Demir";
                BtnD.Text = "Alüminyum";
                label4.Text = "Lityum";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = " 'Araba Sevdası' adlı eser kime aittir?";
                BtnA.Text = "Ahmet Mithat Efendi";
                BtnB.Text = "Namık Kemal";
                BtnC.Text = "Halit Ziya Uşaklıgil";
                BtnD.Text = "Recaizade Mahmut Ekrem";
                label4.Text = "Recaizade Mahmut Ekrem";
                BtnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 5)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }
    }
}
