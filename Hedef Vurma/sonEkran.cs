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
    public partial class sonEkran : Form
    {
        public sonEkran()
        {
            InitializeComponent();
        }

        private void btYeniden_Click(object sender, EventArgs e)
        {
            oyunEkrani oyun = new oyunEkrani();
            oyun.Show();
            this.Hide();
        }

        private void btCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btiletisim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mail : ikayar18@posta.pau.edu.tr");
        }

        private void sonEkran_Load(object sender, EventArgs e)
        {
            
        }
    }
}
