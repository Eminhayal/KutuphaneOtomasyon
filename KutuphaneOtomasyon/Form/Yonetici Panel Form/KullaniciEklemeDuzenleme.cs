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
    public partial class KullaniciEklemeDuzenleme : System.Windows.Forms.Form
    {
        public KullaniciEklemeDuzenleme()
        {
            InitializeComponent();
        }

        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        

        private void btnUsersAdd_click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Name = txtUserName.Text;
            users.Surname = txtUserSurname.Text;
            users.Password = txtUserPassword.Text;
            users.BirthDate = Convert.ToDateTime(txtUserBirthdate.Text);
            users.Tckn = Convert.ToInt64(txtUserTckn.Text);
            users.RegisterDate = Convert.ToDateTime(txtUserRegDate.Text);
            users.Mail = txtUserMail.Text;
            users.Telephone = Convert.ToInt64(txtUserNumber.Text);
            users.Status = Convert.ToBoolean(Convert.ToInt32(txtUserStatus.Text));

            db.Users.Add(users);
            db.SaveChanges();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void KullaniciEklemeDuzenleme_Load(object sender, EventArgs e)
        {

        }

        private void btnUsersRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUserID.Text);
            var kayit = db.Users.Find(id);

            if (kayit == null)
            {
                MessageBox.Show("Bos");
                return;
            }

            if (MessageBox.Show(kayit.Name + "Kullanıcı silinecek onaylıyor musunuz ? ",
                " Kayıt silme onayı",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Users.Remove(kayit);
                db.SaveChanges();
            }
        }

        private void btnUsersSearch_Click(object sender, EventArgs e)
        {
            if(txtUserID.Enabled==true)
            {
                try
                {
                    int id = Convert.ToInt32(txtUserID.Text);
                    var kayit = db.Users.Find(id);
                    txtUserName.Text = kayit.Name.ToString();
                    txtUserSurname.Text = kayit.Surname.ToString();
                    txtUserPassword.Text = kayit.Password.Tostring();
                    txtUserBirthdate.Text=kayit.BirthDate.ToDateTime();
                    txtUserTckn.Text=kayit.Tckn.ToInt64();
                    txtUserRegDate.Text=kayit.RegisterDate.ToDateTime();
                    txtUserMail.Text=kayit.Mail.Tostring();
                    txtUserNumber.Text=kayit.Telephone.ToInt64();
                    txtUserStatus.Text=kayit.Status.ToBoolean();
                }
                catch
                {
                    MessageBox.Show("Kullanıcı ID Hatalı!");
                }

            }
        }

        private void btnUsersEdit_Click(object sender, EventArgs e)
        {
            btnUsersEdit.Enabled = true;
            btnUsersSearch.Visible = true;


        }

        private void btnEditt_Click(object sender, EventArgs e)
        {
            btnUsersEdit.Visible = false;
            btnEditt.Visible = true;

            int id = Convert.ToInt32(txtUserID.Text);
            var kayit = db.Users.Find(id);
            kayit.Name = txtUserName.Text;
            kayit.Surname = txtUserSurname.Text;
            kayit.Password = txtUserPassword.Text;
            txtUserBirthdate.Text = kayit.BirthDate;
            txtUserTckn.Text = kayit.Tckn;
            txtUserRegDate.Text = kayit.RegisterDate;
            txtUserMail.Text = kayit.Mail;
            txtUserNumber.Text = kayit.Telephone;
            txtUserStatus.Text = kayit.Status;
            db.SaveChanges();
        }
    }
}

