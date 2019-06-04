using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Hedef_Vurma
{
    public partial class oyunEkrani : Form
    {
        public oyunEkrani()
        {
            InitializeComponent();
        }

        bool okYaydaMi = true;
        bool okHedefeCarptimi = false;
        public int skor = 0;
        public int hak = 3;
        int xOk, yOk, xHedef, yHedef;
        

        private void oyunEkrani_Load(object sender, EventArgs e)
        {            
            basla(); 
            tmOk.Enabled = false;
        }

        private void skorAyarla()
        {
           
            skor += 5;
            lbSkor.Text = skor.ToString();           
            if(skor>=15)      //Oyunun kendi içinde ki skor ve level ayarları
            {
                timerAssagi.Interval = 125;
                timerYukari.Interval = 125;
            }
            if (skor >= 30) 
            {
                timerAssagi.Interval = 100;
                timerYukari.Interval = 100;
            }
            if (skor >= 45)
            {
                timerAssagi.Interval = 90;
                timerYukari.Interval = 90;
            }
            if (skor >= 60)
            {
                timerAssagi.Interval = 75;
                timerYukari.Interval = 75;
            }
            if (skor == 80) 
            {
                MessageBox.Show("Tebrikler ! Oyunu kazandınız..."+ skor);
                dur();
                sonEkran son = new sonEkran();               
                son.Show();
                this.Hide();
            }
        }

        private void oyunEkrani_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Y < 270)   /* Adam ve oku 0-270 Y koordinatı üzerinde hareket ettirmek için */
            {
                pbAdam.Top = e.Y;

                Point adamX = this.PointToClient(Cursor.Position); //Adamın koordinatlarını verir
     
                labelx.Text = adamX.ToString();
                

            }
            else
            {
                
            }
            

            if(okYaydaMi) //okun dışarı çıkmama kontrolü
            {
                if(e.Y < 270)
                {
                    pbOk.Top = e.Y;
                }
                
            }
            

            
        }
        private void hakDuzenle()  //hak 0 olunca diğer forma geçişi sağlıyoruz
        {
            hak--;
            
            if (hak == 0)
            {
                lbHak.Text = 0.ToString();
                lbSkor.Text = skor.ToString();
                MessageBox.Show("Oyun bitti , kaybettin :( Skorun :" + skor);             
                dur();
                sonEkran son = new sonEkran();
                son.Show();
                this.Hide();
                
            }
            lbHak.Text = hak.ToString();

        }


        private void oyunEkrani_MouseClick(object sender, MouseEventArgs e)
        {
            okYaydaMi = false;
            tmOk.Enabled = true;
            SoundPlayer ses = new SoundPlayer();
            string yol = Application.StartupPath + "\\ok.wav";
            ses.SoundLocation = yol;
            ses.Play();
            
        }


        private void timerAssagi_Tick(object sender, EventArgs e)
        {
            //hedefin asagi hareketi
            pbHedef.Top += 20;
            if (pbHedef.Top >= 270)
            {
                timerYukari.Enabled = true;
                timerAssagi.Enabled = false;
            }
        }

        private void timerYukari_Tick(object sender, EventArgs e)
        { //hedefin yukari hareketi
            pbHedef.Top -= 20;
            if (pbHedef.Top <= 10) 
            {
                timerAssagi.Enabled = true;
                timerYukari.Enabled = false;
            }
        }

        private void tmOk_Tick(object sender, EventArgs e)
        {
            //Okun ve hedefin fonksiyonları
            xOk = pbOk.Location.X;
            yOk = pbOk.Location.Y;
            xHedef = pbHedef.Location.X;
            yHedef = pbHedef.Location.Y;
            labely.Text = yOk.ToString();

            if (Math.Abs(xOk - xHedef) < 70 && Math.Abs(yOk - yHedef) < 73)
            {
                if (!okHedefeCarptimi)
                {
                    
                    skorAyarla();
                    okHedefeCarptimi = true;
                }
                

            }
                
                pbOk.Left += 12;

            if (pbOk.Location.X > this.Width)
            {
                hakDuzenle();
                okYaydaMi = true;
                okHedefeCarptimi = false;
                Point adam = new Point(pbAdam.Location.X, pbAdam.Location.Y + 10);

                pbOk.Location = adam;

                tmOk.Enabled = false;

                
            }
            else if(Math.Abs(xOk - xHedef) < 70 && Math.Abs(yOk - yHedef) < 73)
            {
                
                okYaydaMi = true;
                okHedefeCarptimi = false;

                Point adam = new Point(pbAdam.Location.X, pbAdam.Location.Y + 10);

                pbOk.Location = adam;

                tmOk.Enabled = false;
            }
        }

        private void pbAdam_Click(object sender, EventArgs e)
        {
           
        }


        void dur()
        {
            timerAssagi.Enabled = false;
            timerYukari.Enabled = false;

        }

        private void labelx_Click(object sender, EventArgs e)
        {

        }

        void basla()
        {
            timerAssagi.Enabled = true;
            timerYukari.Enabled = true;

        }

        private void tmPuan_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void tmAdamAssagi_Tick(object sender, EventArgs e)
        {
           
        }

        private void tmAdamYukari_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
