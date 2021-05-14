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

        //public static int id;
        //public static string name;
        //public static string surname;
        //public static DateTime birthDate;
        //public static DateTime registerDate;
        //public static string mail;
        //public static Int64 phone;
        //public static Int64 tckn;  
        //public static bool status;

        private void FormProfil_Load(object sender, EventArgs e)
        {
            //labelUserId.Text = id.ToString();
            //labelUserName.Text = name;
            //labelUserSurname.Text = surname;
            //labelUserBirthDate.Text = birthDate.ToShortDateString();
            //labelUserRegisterDate.Text = registerDate.ToLongDateString();
            //labelUserMail.Text = mail;
            //labelUserPhone.Text = phone.ToString();
            //labelUserTckn.Text = tckn.ToString();
            //labelUserStatus.Text = status.ToString();
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
