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
    public partial class FormProfil : System.Windows.Forms.Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }

        public static int id;
        public static string userName;
        public static string userSurname;
        public static DateTime userBirthDate;
        public static DateTime userRegisterDate;
        public static string userMail;
        public static Int64 userPhone;
        public static Int64 tckn;
        public static string userStatus;

        private KutuphaneOtoEntities4 db = new KutuphaneOtoEntities4();
        private ImageConvert image = new ImageConvert();
        public static int _userIdConfirmTake;

        public static int _userID;

        private void FormProfil_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(_userID);
            var kayit = db.Users.Find(userId);

            labelUserId.Text = id.ToString();
            labelUserName.Text = userName;
            labelUserSurname.Text = userSurname;
            labelUserBirthDate.Text = userBirthDate.ToShortDateString();
            labelUserRegisterDate.Text = userRegisterDate.ToLongDateString();
            labelUserMail.Text = userMail;
            labelUserPhone.Text = userPhone.ToString();
            labelUserTckn.Text = tckn.ToString();
            labelUserStatus.Text = userStatus;
            labelUserMail.Text = kayit.Mail;
            labelUserStatus.Text = kayit.Status;
            pictureBoxImage.Image = image.byteArrayToImage(kayit.Image);
            _userIdConfirmTake = id;



        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
