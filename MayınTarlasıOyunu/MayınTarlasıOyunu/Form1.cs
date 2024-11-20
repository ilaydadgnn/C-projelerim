using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlasıOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList mayinlar = new ArrayList();

       
        private void kolayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();

            int oMayın = 200;
            int oTarla = 900;
            label2.Text = "mayın :" + oMayın.ToString();
            label3.Text = "boyut:" + tableLayoutPanel1.ColumnCount + "x" + tableLayoutPanel1.ColumnCount;

            tableLayoutPanel1.ColumnCount = 30;
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayın; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }

            }


            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;

                }



                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += Button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
        }
        int gpuan = 0;

        private void Button_Click(object sender, EventArgs e)
        {

            Button tıklanan = (Button)sender;
            if (int.Parse(tıklanan.Tag.ToString()) == -1)
            {
                tıklanan.BackgroundImage = Image.FromFile("indir.png");
                tıklanan.BackColor = Color.Red;
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    tableLayoutPanel1.Controls[i].Enabled = false;
                    if ((int.Parse(tableLayoutPanel1.Controls[i].Tag.ToString()) == -1))

                    {
                        tableLayoutPanel1.Controls[i].BackgroundImage = Image.FromFile("indir.png");


                    }
                    else
                    {
                        tableLayoutPanel1.Controls[i].Text = tableLayoutPanel1.Controls[i].Tag.ToString();


                    }
                }
            }
            else
            {



                gpuan += int.Parse(tıklanan.Tag.ToString());
                tıklanan.Text = tıklanan.Tag.ToString();
                label1.Text = "puan: " + gpuan;
                tıklanan.Enabled = false;
            }
        }
}
}

