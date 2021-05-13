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
    }
}
