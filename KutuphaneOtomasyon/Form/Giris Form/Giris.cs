using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                FormProfil._userID = user.UserId;

                KitapAlma._userID = _userID;
                KitapAlma.userName = user.Name;

                
                KitapTeslimEtme._userID = user.UserId;


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
            txtLogMail.Text = "ID Giriniz...";
            txtLogMail.ForeColor = Color.Gray;
            txtLogPass.Text = "Şifre Giriniz...";
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

        private void txtLogMail_Leave(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txtLogMail.Text, @"^\d{4,10}$"))
            {
                MessageBox.Show("Giriş yapmak istediğiniz ID en az 4 haneli rakamlardan oluşmalıdır!..");
               
            }
        }
    }
}
