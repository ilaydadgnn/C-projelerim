using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_X_OYUNU
{
    public partial class Form1 : Form
    {
        bool X_sıra;
        bool O_sıra;
        int islem_sayisi;
        public Form1()
        {
            InitializeComponent();
        }
        public void X_belirle()
        {
            // yatay başlangıç
            if(button1.Text=="X" && button2.Text=="X"  && button3.Text == "X")
            {
                temizle();
                MessageBox.Show("X kazandı");

            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                temizle();
                MessageBox.Show("X kazandı");

            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                temizle();
                MessageBox.Show("X kazandı");

            }

            // yatay bitiş 


            // dikey başlangıç

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                temizle();
                MessageBox.Show("X kazandı");

            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                temizle();
                MessageBox.Show("X kazandı");

            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                temizle();
                MessageBox.Show("X kazandı");

            }

            // dikey bitiş 

            // çapraz başlangıç
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                temizle();
                MessageBox.Show("X kazandı");

            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                temizle();
                MessageBox.Show("X kazandı");

            }
            // çapraz bitiş 

        

        }
        public void O_belirle()
        {
            // yatay başlangıç
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                temizle();
                MessageBox.Show("O kazandı");

            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                temizle();
                MessageBox.Show("O kazandı");

            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                temizle();
                MessageBox.Show("O kazandı");

            }

            // yatay bitiş 


            // dikey başlangıç

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                temizle();
                MessageBox.Show("O kazandı");

            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                temizle();
                MessageBox.Show("O kazandı");

            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                temizle();
                MessageBox.Show("O kazandı");

            }

            // dikey bitiş 

            // çapraz başlangıç
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                temizle();
                MessageBox.Show("O kazandı");

            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                temizle();
                MessageBox.Show("O kazandı");

            }
            // çapraz bitiş 







        }
        public void temizle()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            islem_sayisi = 0;



        }
        public void beraberlik()
        {
            if (islem_sayisi == 9)
            {
                temizle();
                MessageBox.Show("Beraberlik...");
            }

        }


        private void Toplı_Tik(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            islem_sayisi = islem_sayisi + 1;

            if (X_sıra)
            {
                X_sıra = false;
                O_sıra = true;
                b.Text = "X";
                b.Enabled = false;
                X_belirle();
                beraberlik();
            }
            else if (O_sıra)
           
            {
                O_sıra = false;
                X_sıra = true;
                b.Text = "O";

                b.Enabled = false;
                O_belirle();
                beraberlik();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X_sıra = true;

        }
    }
}
