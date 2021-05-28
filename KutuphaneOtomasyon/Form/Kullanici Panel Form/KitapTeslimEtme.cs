using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqKit;

namespace KutuphaneOtomasyon
{
    public partial class KitapTeslimEtme : System.Windows.Forms.Form
    {
        public KitapTeslimEtme()
        {
            InitializeComponent();
        }

        public static int _userID;

        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        private Users user = new Users();
        public static string usname;
        private void KitapTeslimEtme_Load(object sender, EventArgs e)
        {
            GetData();
            
            //MessageBox.Show("OK");
        }
        void GetData(String search = ""  )
        {
            if (_userID > 0 )
            {
                user = db.Users.Find(_userID);

                //dataGridViewDataEn.DataSource = db.Confirm.Where((x) => x.UserId == _userID).ToList();

                var sorgu = (from c in db.Confirm
                    where c.UserName.Contains(user.Name)
                    select new
                    {
                        c.Books,
                        c.BookId,
                        c.UserId,
                        c.UserName,


                    }).ToList();
                dataGridViewDataEn.DataSource = sorgu;

                //dataGridViewDataEn.DataSource = db.Confirm.ToList();


                ////dataGridViewDataConfirm.Columns[3].Visible = false;
                //dataGridViewDataEn.Columns[5].Visible = false;
                //dataGridViewDataEn.Columns[6].Visible = false;

                dataGridViewDataEn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDataEn.RowTemplate.Height = 150;


                //dataGridViewDataConfirm.Columns[0].HeaderText = "İşlem Numarası";
                //dataGridViewDataConfirm.Columns[1].HeaderText = "Kitap ID";
                //dataGridViewDataConfirm.Columns[2].HeaderText = "Kitap Alım Onayı ";
                //dataGridViewDataConfirm.Columns[4].HeaderText = "Kullanıcı ID";

                DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
                dataGridViewDataEn.DefaultCellStyle = dataGridViewCellStyle;
            }
            else
            {
                MessageBox.Show("Hatalı iŞlem");
            }
            

        }

        private void dataGridViewDataEn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewDataEn.Rows[dataGridViewDataEn.CurrentCell.RowIndex].Cells[1].Value);
            
            var book = db.Books.Find(id);

            labelBookId.Text =book.BookId.ToString();
            labelBookName.Text = book.Name;
            labelWriter.Text = book.Writer;
            labelPublisher.Text = book.Publisher;
            labelPageNo.Text = book.PageNo.ToString();
            labelCategory.Text = book.Category;
            //pictureBox1.Image = book.Image;
            
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Confirm confirm = new Confirm();
            confirm.UserId = _userID;
            confirm.UserName =usname;
            confirm.BookId = Convert.ToInt32(labelBookId.Text);
            db.Confirm.Add(confirm);
            db.SaveChanges();

        }
    }
}
