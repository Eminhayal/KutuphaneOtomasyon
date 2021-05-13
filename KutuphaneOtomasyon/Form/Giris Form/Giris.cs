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
        IDbConnection con;
        IDbCommand com;
        IDataReader dr;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(girisdoğrula(txtLogMail.Text,txtLogPass.Text))
            {
                Anasayfa ana = new Anasayfa();
                ana.Show();
            }
            else
            {
                MessageBox.Show("E posta yada şifre hatalı");
            }

             if(girisdoğrulaiki(txtLogMail.Text,txtLogPass.Text))
            {
                AnasayfaYonetici anayon = new AnasayfaYonetici();
                anayon.Show();
            }

            /* giris e posta ile olacak
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
            }*/
        }

        private bool girisdoğrula(string kEposta, string kSifre)
        {
            KutuphaneOtoEntities3 context = new KutuphaneOtoEntities3();
            var sorgu = from p in context.Users
                        where p.Mail == kEposta
                        && p.Password == kSifre
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         private bool girisdoğrulaiki(string yEposta, string ySifre)
        {
            KutuphaneOtoEntities3 context = new KutuphaneOtoEntities3();
            var sorgus = from p in context.Admins
                         where p.Mail == yEposta
                         && p.Password == ySifre
                         select p;
            if(sorgus.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void Giris_Load(object sender, EventArgs e)
        {
            txtLogMail.Text = "e-posta";
            txtLogMail.ForeColor = Color.Gray;
            txtLogPass.Text = "şifre";
            txtLogPass.ForeColor = Color.Gray;
        }

        private void txtLogMail_Click(object sender, EventArgs e)
        {
            txtLogMail.Text = null;
            txtLogMail.ForeColor = Color.Black;
        }

        private void txtLogPass_Click(object sender, EventArgs e)
        {
            txtLogPass.Text = null;
            txtLogPass.ForeColor = Color.Black;
          
        }
    }
}
