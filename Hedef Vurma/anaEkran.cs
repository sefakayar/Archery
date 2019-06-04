using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hedef_Vurma
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void btOyna_Click(object sender, EventArgs e)
        {
            oyunEkrani oyun = new oyunEkrani();
            oyun.Show();
            this.Hide();
        }

        private void btYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyunumuzun amacı hareket eden hedefi vurmaktır.Sadece mouse move ve click olayı ile çalışır." +
                "Mouse move ile karakterimizi hareket ettiriyoruz. " +
                "Mouse click ile okumuzu atıyoruz her 3 isabetli atışta hedefimiz daha da hızlanacaktır,skor 80 olunca oyun biter."); 
        }

        private void btCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
