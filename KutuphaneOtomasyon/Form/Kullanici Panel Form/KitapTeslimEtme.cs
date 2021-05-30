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
using LinqKit;

namespace KutuphaneOtomasyon
{
    public partial class KitapTeslimEtme : System.Windows.Forms.Form
    {
        public KitapTeslimEtme()
        {
            InitializeComponent();
        }

        
        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        private Users user = new Users();

        ImageConvert image = new ImageConvert();

        public static string usname;
        public static int _userID;
        public static int _bookId;
        


        private void KitapTeslimEtme_Load(object sender, EventArgs e)
        {
            GetData();
            //dataGridViewDataEn.Columns[0].Visible = false;
            //dataGridViewDataEn.Columns[1].HeaderText = "Kitap ID";
            //dataGridViewDataEn.Columns[2].HeaderText = "Kullanıcı ID";
            //dataGridViewDataEn.Columns[3].HeaderText = "Kullanıcı Adı";

           
        }
        void GetData(String search = ""  )
        {
            if (_userID > 0 )
            {
                user = db.Users.Find(_userID);

                dataGridViewDataEn.DataSource = db.EntrustedBooks.Where((x) => x.UserId == _userID).ToList();

            //    var sorgu = (from c in db.EntrustedBooks
            //        where c.UserName.Contains(user.Name)
            //        select new
            //        {
            //            c.BookName,
            //            c.BookId,
            //            c.UserId,
            //            c.UserName,
            //            c.DeadLine,

            //        }).ToList();
            //    dataGridViewDataEn.DataSource = sorgu;

               


            //    dataGridViewDataEn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //    dataGridViewDataEn.RowTemplate.Height = 150;

            //    DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            //    dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            //    dataGridViewDataEn.DefaultCellStyle = dataGridViewCellStyle;
            //}
            //else
            //{
            //    MessageBox.Show("Hatalı iŞlem");
            }
            

        }

        private void dataGridViewDataEn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewDataEn.Rows[dataGridViewDataEn.CurrentCell.RowIndex].Cells[0].Value);
            _bookId = id;
            
            
            var book = db.Books.Find(id);
            

            labelBookId.Text =book.BookId.ToString();
            labelBookName.Text = book.Name;
            labelWriter.Text = book.Writer;
            labelPublisher.Text = book.Publisher;
            labelPageNo.Text = book.PageNo.ToString();
            labelCategory.Text = book.Category;
            pictureBox1.Image =image.byteArrayToImage(book.Image);
            
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            var book = db.Books.Find(_bookId);
            DeliveredBooks delivered = new DeliveredBooks();
            {
                delivered.UserId = _userID;
                delivered.UserName = usname;
                delivered.BookId = Convert.ToInt32(labelBookId.Text);
                delivered.DeliveryDate = DateTime.Now;
                delivered.BookName = book.Name;
            }
            db.DeliveredBooks.Add(delivered);
            db.SaveChanges();


            var sorgu = (from p in db.EntrustedBooks where p.BookId.ToString() == labelBookId.Text select p).First();
            db.EntrustedBooks.Remove(sorgu);
            db.SaveChanges();



        }
    }
}
