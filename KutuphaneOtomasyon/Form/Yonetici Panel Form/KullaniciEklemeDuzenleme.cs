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
            users.RegisterDate = DateTime.Now;
            users.Mail = txtUserMail.Text;
            users.Telephone = Convert.ToInt64(txtUserNumber.Text);
            users.Status = txtUserStatus.Text;

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
                    txtUserPassword.Text = kayit.Password.ToString();
                    txtUserBirthdate.Text= kayit.BirthDate.ToLongDateString(); 
                    txtUserTckn.Text=kayit.Tckn.ToString();
                    txtUserMail.Text=kayit.Mail.ToString();
                    txtUserNumber.Text=kayit.Telephone.ToString();
                    txtUserStatus.Text = kayit.Status.ToString();

                    txtUserID.Enabled = false;
                    btnUsersSearch.Visible = false;
                    btnUsersEdit.Visible = false;
                    btnEditt.Visible = true;



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
            txtUserID.Enabled = true;


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
            kayit.BirthDate = Convert.ToDateTime(txtUserBirthdate.Text);
            kayit.Tckn =Convert.ToInt64(txtUserTckn.Text) ;
            kayit.Mail = txtUserMail.Text;
            kayit.Telephone = Convert.ToInt64(txtUserNumber.Text); 
            kayit.Status = txtUserStatus.Text; 
            db.SaveChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            file.Title = "ayemkutuphane ";
            file.ShowDialog();
            string filePath = file.FileName;
            pictureBox1.ImageLocation = filePath;
        }
    }
}

