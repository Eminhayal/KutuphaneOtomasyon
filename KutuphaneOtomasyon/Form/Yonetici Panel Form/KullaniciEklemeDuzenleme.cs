using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyon.Form;

namespace KutuphaneOtomasyon
{
    public partial class UserForm : System.Windows.Forms.Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();

        private ImageConvert image = new ImageConvert();


        private void btnUsersAdd_click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Name = txtUserName.Text;
            users.Surname = txtUserSurname.Text;
            users.Password = txtUserPassword.Text;
            users.BirthDate = Convert.ToDateTime(dateTimePickerUserBirthdate.Text);
            users.Tckn = Convert.ToInt64(txtUserTckn.Text);
            users.RegisterDate = DateTime.Now;
            users.Mail = txtUserMail.Text;
            users.Telephone = Convert.ToInt64(txtUserNumber.Text);
            users.Status = txtUserStatus.Text;

            db.Users.Add(users);
            db.SaveChanges();
        }
        private void UserForm_load(object sender, EventArgs e)
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
                    dateTimePickerUserBirthdate.Text= kayit.BirthDate.ToLongDateString(); 
                    txtUserTckn.Text=kayit.Tckn.ToString();
                    txtUserMail.Text=kayit.Mail.ToString();
                    txtUserNumber.Text=kayit.Telephone.ToString();
                    txtUserStatus.Text = kayit.Status.ToString();

                    txtUserID.Enabled = false;
                    buttonSearch.Visible = false;
                    buttonUserEdit.Visible = true;



                }
                catch
                {
                    MessageBox.Show("Kullanıcı ID Hatalı!");
                }

            }
        }
        private void btnUsersEdit_Click(object sender, EventArgs e)
        {
            buttonUserEdit.Enabled = true;
            txtUserID.Enabled = true;


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

        public void ChanceInfo()
        {
            int id = Convert.ToInt32(txtUserID.Text);
            var kayit = db.Users.Find(id);
            kayit.Name = txtUserName.Text;
            kayit.Surname = txtUserSurname.Text;
            kayit.Password = txtUserPassword.Text;
            kayit.BirthDate = Convert.ToDateTime(dateTimePickerUserBirthdate.Text);
            kayit.Tckn = Convert.ToInt32(txtUserTckn.Text);
            kayit.Mail = txtUserMail.Text;
            kayit.Telephone = Convert.ToInt32(txtUserNumber.Text);
            kayit.Status = txtUserStatus.Text;
            kayit.Image = image.imageToByteArray(pictureBox1.Image);
            db.SaveChanges();
        }
        public void AddUser()
        {

            Users user = new Users();
            user.Name = txtUserName.Text;
            user.Surname = txtUserSurname.Text;
            user.Password = txtUserPassword.Text;
            user.BirthDate = Convert.ToDateTime(dateTimePickerUserBirthdate.Text);
            user.Tckn = Convert.ToInt32(txtUserTckn.Text);
            user.Mail = txtUserMail.Text;
            user.Telephone = Convert.ToInt32(txtUserNumber.Text);
            user.Status = txtUserStatus.Text;

            ImageAdd(user);
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("ekle");
        }
        public void ImageAdd(Users user)
        {
            if (pictureBox1 != null)
            {
                MemoryStream ms1 = new MemoryStream();
                pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                user.Image = ms1.ToArray();

            }

        }
    }
}

