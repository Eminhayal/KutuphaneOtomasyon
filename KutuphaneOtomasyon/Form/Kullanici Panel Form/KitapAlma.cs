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
    public partial class KitapAlma : System.Windows.Forms.Form
    {
        public KitapAlma()
        {
            InitializeComponent();
        }

        public static int id;
        public static string bookName;
        public static string bookWriter;
        public static string bookPublisher;
        public static int bookPageNo;
        public static string bookCategory;
        public static string bookSaloon;
        public static string bookStatus;
        public static Image bookImage;
        public static int _userID;
        public static string userName;


        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        private void KitapAlma_Load(object sender, EventArgs e)
        {
            labelBookId.Text = id.ToString();
            labelBookName.Text = bookName;
            labelWriter.Text = bookWriter;
            labelPublisher.Text = bookPublisher;
            labelPageNo.Text = bookPageNo.ToString();
            labelCategory.Text = bookCategory;
            labelSaloon.Text = bookSaloon;
            labelStatus.Text = bookStatus.ToString();
            pictureBox1.Image = bookImage;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Confirm confirm = new Confirm();
            confirm.UserId = _userID;
            confirm.UserName = userName;
            confirm.BookId = id; 
            db.Confirm.Add(confirm);
            db.SaveChanges();

           




        }
    }
}
