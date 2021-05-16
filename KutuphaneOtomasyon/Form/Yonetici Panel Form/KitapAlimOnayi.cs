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
    public partial class KitapAlimOnayi : System.Windows.Forms.Form
    {
        public KitapAlimOnayi()
        {
            InitializeComponent();
        }
        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        Confirm confirm = new Confirm();
        Books book = new Books();
       
        
      
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void textBoxSearchId_KeyDown(object sender, KeyEventArgs e)
        {
           

        }
        private void dataGridViewDataConfirm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var id = Convert.ToInt32(textBoxSearchId.Text);
            //var confirm = db.Confirm.Find(id);
            int bookId = Convert.ToInt32(dataGridViewDataConfirm.Rows[dataGridViewDataConfirm.CurrentCell.RowIndex].Cells[1].Value);
            book = db.Books.Find(bookId);

            labelBookId.Text = book.BookId.ToString();
            labelBookName.Text = book.Name;
            labelWriter.Text = book.Writer;
            labelPublisher.Text = book.Publisher;
            labelPageNo.Text = book.PageNo.ToString();
            labelCategory.Text = book.Category;
            labelSaloon.Text = book.SaloonShelf;

            ImageConvert imageConvert = new ImageConvert();
            pictureBoxConfirm.Image = imageConvert.byteArrayToImage(book.Image);

        }
        void GetData(String search = "")
        {

            dataGridViewDataConfirm.DataSource = db.Confirm.ToList();
            dataGridViewDataConfirm.Columns[3].Visible = false;
            dataGridViewDataConfirm.Columns[5].Visible = false;
            dataGridViewDataConfirm.Columns[4].Visible = false;
            dataGridViewDataConfirm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDataConfirm.RowTemplate.Height = 100;


            dataGridViewDataConfirm.Columns[0].HeaderText = "İşlem Numarası";
            dataGridViewDataConfirm.Columns[1].HeaderText = "Kitap ID";
            dataGridViewDataConfirm.Columns[2].HeaderText = "Kitap Alım Onayı ";
            dataGridViewDataConfirm.Columns[4].HeaderText = "Kullanıcı ID";

            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            dataGridViewDataConfirm.DefaultCellStyle = dataGridViewCellStyle;




        }

        private void KitapAlimOnayi_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}

