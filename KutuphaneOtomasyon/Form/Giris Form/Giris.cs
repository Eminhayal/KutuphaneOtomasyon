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

        KutuphaneOtoEntities3 context = new KutuphaneOtoEntities3();
        
        public static string mail;
        public static int _userID;
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
            
            if (girisdoğrula(Convert.ToInt32(txtLogMail.Text) ,txtLogPass.Text) )
            {
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();


                Users user = new Users();
                int loginId = Convert.ToInt32(txtLogMail.Text);
                user = context.Users.Find(loginId);
                _userID = user.UserId;
                FormProfil.id = user.UserId;
                FormProfil.userName = user.Name;
                FormProfil.userSurname = user.Surname;
                FormProfil.userBirthDate = user.BirthDate;
                FormProfil.userRegisterDate = user.RegisterDate;
                FormProfil.userMail = user.Mail;
                FormProfil.tckn = user.Tckn;
                FormProfil.userPhone = user.Telephone;
                KitapAlma._userID = _userID;
                KitapAlma.userName = user.Name;
                // FormProfil.status = user.Status;



            }

            else if(girisdoğrulaiki(Convert.ToInt32(txtLogMail.Text) , txtLogPass.Text))
            {
                AnasayfaYonetici anayon = new AnasayfaYonetici();
                anayon.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("E posta yada şifre hatalı");
            }

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

        private bool girisdoğrula(int kId, string kSifre  )
        {
          
            var sorgu = from p in context.Users
                        where p.UserId == kId
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
         private bool girisdoğrulaiki(int yId, string ySifre)
        {
            KutuphaneOtoEntities3 context = new KutuphaneOtoEntities3();
            var sorgus = from p in context.Admins
                         where p.AdminId == yId
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
