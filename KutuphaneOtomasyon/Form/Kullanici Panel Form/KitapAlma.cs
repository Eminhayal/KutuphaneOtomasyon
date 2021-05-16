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
        public static string name ;
        public static string writer;
        public static string publisher;
        public static int pageNo;
        public static string category;
        public static string saloon;
        public static bool status;
        public static Image image;
        public static int userId;


        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        private void KitapAlma_Load(object sender, EventArgs e)
        {
            labelBookId.Text = id.ToString();
            labelBookName.Text = name;
            labelWriter.Text = writer;
            labelPublisher.Text = publisher;
            labelPageNo.Text = pageNo.ToString();
            labelCategory.Text = category;
            labelSaloon.Text = saloon;
            labelStatus.Text = status.ToString();
            pictureBox1.Image = image;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Confirm confirm = new Confirm();
            Books book = new Books();
            Users user = new Users();
            book = db.Books.Find(id);
            book.Confirm.BookId = Convert.ToInt32(labelBookId.Text);
            book.Confirm.DeliveryConfirm = true;
            book.Confirm.EntrustConfirm = false;
            

        }
    }
}
