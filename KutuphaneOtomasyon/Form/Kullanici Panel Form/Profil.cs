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
        public static bool userStatus;
        

        private void FormProfil_Load(object sender, EventArgs e)
        {
            labelUserId.Text = id.ToString();
            labelUserName.Text = userName;
            labelUserSurname.Text = userSurname;
            labelUserBirthDate.Text = userBirthDate.ToShortDateString();
            labelUserRegisterDate.Text = userRegisterDate.ToLongDateString();
            labelUserMail.Text = userMail;
            labelUserPhone.Text = userPhone.ToString();
            labelUserTckn.Text = tckn.ToString();
            labelUserStatus.Text = userStatus.ToString();
            labelUserMail.Text = Giris.mail;


        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

       
    }
}
