using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SosGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox[,] tbLer;
        int siradakiOyuncu=1;
        int satirlar = 15, sütünlar = 20;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            tbLer = new TextBox[satirlar, sütünlar];
            //10x10 alana TextBox kontrolleri ekleyerek oyun alanı oluşturma
            for (int i = 0; i < satirlar; i++)
            {
                for (int j = 0; j < sütünlar; j++)
                {
                    TextBox tb = new TextBox();
                    tb.Location = new System.Drawing.Point(50 + j * 25, i * 25);
                    tb.Name = i + "*" + j;
                    tb.Size = new System.Drawing.Size(20, 20);
                    tb.MaxLength = 1;
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.KeyUp += new KeyEventHandler(tb_KeyUp);
                    this.Controls.Add(tb);
                    tbLer[i, j]=tb;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1oyuncu.Text = "0";
            lbl2oyuncu.Text = "0";
            lbltplmsos.Text = "0";
            lblsiraoyuncu.Text = "1";
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    (item as TextBox).Text = "";
                }
            }

        }

        private void tb_KeyUp(object sender,KeyEventArgs e)
        {
            //Giriş yapılan kontrolü tanımlama
            TextBox tb = sender as TextBox;
            tb.Text = tb.Text.ToUpper();
            if (tb.Text.Length == 1) 
                tb.Enabled = false;
            if(siradakiOyuncu==1)
            {
                siradakiOyuncu = 2;
            }
            else
            {
                siradakiOyuncu = 1;
            }
            lblsiraoyuncu.Text = siradakiOyuncu.ToString();
            //S ve O karakterleri dışında HARF GİRİLEMEZ!
            if(tb.Text !="S" && tb.Text !="O")
            {
                tb.Text = "";
            }
            int toplamSOSsayisi = 0;
            //SOS KONTROLÜ
            for (int i = 0; i < satirlar; i++)
            {
                for (int j = 0; j < sütünlar; j++)
                {
                    //Soldan sağa
                    try
                    {
                        if(tbLer[i,j].Text=="S" && tbLer[i,j+1].Text=="O" && tbLer[i,j+2].Text=="S")
                        {
                            toplamSOSsayisi++;
                        }
                        
                    }
                    catch
                    {
                    }
                    try
                    {
                        if (tbLer[i, j].Text == "S" && tbLer[i+1, j ].Text == "O" && tbLer[i+2, j].Text == "S")
                        {
                            toplamSOSsayisi++;
                        }
                    }
                    catch
                    {
                    }
                    try
                    {
                        if (tbLer[i, j].Text == "S" && tbLer[i+1 , j-1].Text == "O" && tbLer[i +2, j-2].Text == "S")
                        {
                            toplamSOSsayisi++;
                        }
                    }
                    catch 
                    {
                    }
                    try
                    {
                        if (tbLer[i, j].Text == "S" && tbLer[i - 1, j - 1].Text == "O" && tbLer[i - 2, j - 2].Text == "S")
                        {
                            toplamSOSsayisi++;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            int OlusanSOSSayisi = toplamSOSsayisi - Convert.ToInt32(lbltplmsos.Text);
            lbltplmsos.Text = toplamSOSsayisi.ToString();
            if (siradakiOyuncu==1)
            {
                int puan = Convert.ToInt32(lbl1oyuncu.Text) + OlusanSOSSayisi;
                lbl1oyuncu.Text = puan.ToString();
            }
            else
            {
                int puan = Convert.ToInt32(lbl2oyuncu.Text) + OlusanSOSSayisi;
                lbl2oyuncu.Text = puan.ToString();
            }
        }
    }
}
