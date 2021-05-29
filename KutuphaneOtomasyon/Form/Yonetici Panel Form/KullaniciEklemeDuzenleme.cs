using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private KutuphaneOtoEntities4 db = new KutuphaneOtoEntities4();

        private ImageConvert image = new ImageConvert();


        private void btnUsersAdd_click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void UserForm_load(object sender, EventArgs e)
        {
            txtUserNumber.Text = "5XXXXXXXXX";
            txtUserNumber.ForeColor = Color.Gray;
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

        private void btnUsersEdit_Click(object sender, EventArgs e)
        {
            ChanceInfo();
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

        private void btnUsersSearch_Click(object sender, EventArgs e)
        {
            if (txtUserID.Enabled == true)
            {
                txtUserID.Enabled = false;
                buttonUserEdit.Enabled = true;
                try
                {
                    int id = Convert.ToInt32(txtUserID.Text);
                    var kayit = db.Users.Find(id);
                    txtUserName.Text = kayit.Name.ToString();
                    txtUserSurname.Text = kayit.Surname.ToString();
                    txtUserPassword.Text = kayit.Password.ToString();
                    dateTimePickerUserBirthdate.Text = kayit.BirthDate.ToLongDateString();
                    txtUserTckn.Text = kayit.Tckn.ToString();
                    txtUserMail.Text = kayit.Mail.ToString();
                    txtUserNumber.Text = kayit.Telephone.ToString();
                    cmbUserStatus.Text = kayit.Status.ToString();
                    pictureBox1.Image = image.byteArrayToImage(kayit.Image);

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
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtUserMail.Text = "";
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtUserName.Text = "";
            txtUserNumber.Text = "";
            txtUserPassword.Text = "";
            cmbUserStatus.Text = "";
            txtUserSurname.Text = "";
            txtUserID.Enabled = true;
            buttonSearch.Visible = true;

        }

        public void ChanceInfo()
        {
            int id = Convert.ToInt32(txtUserID.Text);
            var kayit = db.Users.Find(id);
            kayit.Name = txtUserName.Text;
            kayit.Surname = txtUserSurname.Text;
            kayit.Password = txtUserPassword.Text;
            kayit.BirthDate = Convert.ToDateTime(dateTimePickerUserBirthdate.Text);
            kayit.Tckn = Convert.ToInt64(txtUserTckn.Text);
            kayit.Mail = txtUserMail.Text;
            kayit.Telephone = Convert.ToInt64(txtUserNumber.Text);
            kayit.Status = cmbUserStatus.Text;
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
            user.Tckn = Convert.ToInt64(txtUserTckn.Text);
            user.RegisterDate = DateTime.Now;
            user.Mail = txtUserMail.Text;
            user.Telephone = Convert.ToInt64(txtUserNumber.Text);
            user.Status = cmbUserStatus.Text;

            ImageAdd(user);
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Eklendi");

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

        private void txtUserTckn_Leave(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txtUserTckn.Text, @"^\d{11}$"))
            {
                MessageBox.Show("TC Kimlik Numarası 11 Haneli Rakamlardan Oluşmaldır!..");
            }
        }

        private void txtUserNumber_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtUserNumber.Text, @"^(5(\d{9}))$"))
            {
                MessageBox.Show("Telefon Numarası başında 0 olmadan ,9 haneli olacak şekilde girilmelidir");
            }
        }


        private void txtUserNumber_Click(object sender, EventArgs e)
        {
            txtUserNumber.Text = null;
            txtUserNumber.ForeColor = Color.Black;
        }
    }
}


