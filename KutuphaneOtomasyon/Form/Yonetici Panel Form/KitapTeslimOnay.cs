using KutuphaneOtomasyon.Form;
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
    public partial class KitapTeslimOnay : System.Windows.Forms.Form
    {
        public KitapTeslimOnay()
        {
            InitializeComponent();
        }
        private KutuphaneOtoEntities4 db = new KutuphaneOtoEntities4();

        Books book = new Books();
        Users user = new Users();

        ImageConvert imageConvert = new ImageConvert();

        void GetData(String search = "")
        {


            dataGridViewDataDel.DataSource = db.DeliveredBooks.ToList();
            dataGridViewDataDel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridViewDataDel.RowTemplate.Height = 100;
            //DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            //dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            //dataGridViewDataDel.DefaultCellStyle = dataGridViewCellStyle;


        }

        private void KitapTeslimOnay_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridViewDataDel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookId = Convert.ToInt32(dataGridViewDataDel.Rows[dataGridViewDataDel.CurrentCell.RowIndex].Cells[0].Value);
            book = db.Books.Find(bookId);




            labelBookId.Text = book.BookId.ToString();
            labelBookName.Text = book.Name;
            labelWriter.Text = book.Writer;
            labelPublisher.Text = book.Publisher;
            labelPageNo.Text = book.PageNo.ToString();
            labelCategory.Text = book.Category;
            labelSaloon.Text = book.SaloonShelf;

            
            pictureBox1.Image = imageConvert.byteArrayToImage(book.Image);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_Id = Convert.ToInt32(dataGridViewDataDel.Rows[dataGridViewDataDel.CurrentCell.RowIndex].Cells[2].Value);
            user = db.Users.Find(user_Id);

            DeliveredBooks deliveredBooks = new DeliveredBooks();
            deliveredBooks.BookId = Convert.ToInt32(labelBookId.Text);
            deliveredBooks.BookName = labelBookName.Text;
            deliveredBooks.UserId = Convert.ToInt32(user_Id);
            deliveredBooks.UserName = user.Name;
            deliveredBooks.DeliveryDate = DateTime.Now;


            var sorgus = (from p in db.DeliveredBooks where p.BookId.ToString() == labelBookId.Text select p).First();//teslim silme
            db.DeliveredBooks.Remove(sorgus);
            db.SaveChanges();



        }

    }
}
