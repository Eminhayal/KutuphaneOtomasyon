using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Giris : System.Windows.Forms.Form
    {
        public Giris()
        {
            InitializeComponent();
        }



        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // giris e posta ile olacak
            if (rdUsers.Checked)
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            if (rdAdmins.Checked)
            {
                AnasayfaYonetici anasayfaYonetici = new AnasayfaYonetici();
                anasayfaYonetici.Show();
                this.Hide();
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            txtLogMail.Text = "MAİL";
            txtLogPass.Text = "ŞİFRE";
        }

        private void txtLogMail_Click(object sender, EventArgs e)
        {
            txtLogMail.Text = null;
        }

        private void txtLogPass_Click(object sender, EventArgs e)
        {
            txtLogPass.Text = null;
        }
    }
}
