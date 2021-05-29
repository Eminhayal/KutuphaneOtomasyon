using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyon.Form;

namespace KutuphaneOtomasyon
{
    public partial class EmanetBilgileri : System.Windows.Forms.Form
    {
        public EmanetBilgileri()
        {
            InitializeComponent();
        }

        private KutuphaneOtoEntities4 db = new KutuphaneOtoEntities4();
        private Books book = new Books();
        private EntrustedBooks entrustedBooks = new EntrustedBooks();
        private ImageConvert image = new ImageConvert();
        
        public static int _userID;
        

        private void EmanetBilgileri_Load(object sender, EventArgs e)
        {
         
        }

        private void textBoxTakeId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (textBoxTakeId.Enabled = true) 
            {
                textBoxTakeId.Enabled = true;
                buttonClear.Enabled = true;
                textBoxTakeId.Text = "";
                labelBookId.Text = "";
                labelBookName.Text = "";
                labelEntUserSurname.Text = "";
                labelEntUserPhone.Text = "";
                labelEntUserDeadLine.Text = "";
                labelEntUserId.Text = "";
                labelEntUserName.Text = "";
                pictureBox1.Image = default;

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           

                var textboxId = Convert.ToInt32(textBoxTakeId.Text);
                var kayit = db.EntrustedBooks.Find(textboxId);
                if (kayit == null)
                {
                     MessageBox.Show("asdsade saq");
                }
                else
                {
                    if (textBoxTakeId.Enabled == true && kayit.BookId == Convert.ToInt32(textBoxTakeId.Text) && textBoxTakeId.Text != null)
                    {
                        textBoxTakeId.Enabled = false;
                        

                        var x = kayit.UserId;
                        var xFind = db.Users.Find(x);
                        labelBookId.Text = kayit.BookId.ToString();
                        labelBookName.Text = kayit.UserName;
                        labelEntUserId.Text = kayit.UserId.ToString();
                        labelEntUserName.Text = kayit.UserName;
                        labelEntUserDeadLine.Text = kayit.DeadLine.ToString();



                        labelEntUserSurname.Text = xFind.Surname;
                        labelEntUserPhone.Text = xFind.Telephone.ToString();
                        pictureBox1.Image = image.byteArrayToImage(xFind.Image);


                    }
                    else
                    {
                        MessageBox.Show("asdsade saq");
                    }
                }
        }
    }
}
