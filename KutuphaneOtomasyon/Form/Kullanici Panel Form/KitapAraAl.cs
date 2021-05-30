using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace KutuphaneOtomasyon.Form.Kullanici_Panel_Form
{
    public partial class KitapAraAl : System.Windows.Forms.Form
    {

        public KitapAraAl()
        {
            InitializeComponent();
        }

        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        private ImageConvert image = new ImageConvert();

        private void KitapAraAl_Load(object sender, EventArgs e)
        {
           GetData();
            dataGridViewData.Columns[9].Visible = false;
            
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewData.Rows[dataGridViewData.CurrentCell.RowIndex].Cells[0].Value);
            Books book = new Books();
            book = db.Books.Find(id);

            KitapAlma.id = book.BookId;
            KitapAlma.bookName = book.Name;
            KitapAlma.bookWriter = book.Writer;
            KitapAlma.bookPublisher = book.Publisher;
            KitapAlma.bookPageNo = book.PageNo; 
            KitapAlma.bookCategory = book.Category;
            KitapAlma.bookSaloon = book.SaloonShelf;
            KitapAlma.bookStatus = book.Status;
            KitapAlma.bookImage = image.byteArrayToImage(book.Image);
            KitapAlma kitapAlma = new KitapAlma();
            kitapAlma.ShowDialog();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonBook.Checked)
            {
                Filtre(textBoxSearch.Text);
            }

            if (radioButtonCategory.Checked)
            {
                FiltreCategory(textBoxSearch.Text);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FiltreCategory(comboBoxCategory.Text);
        }
        void GetData(String search = "")
        {
            var list = from item in db.Books
                where item.Name.Contains(search) || item.Category.Contains(search)
                select new { item.BookId, item.Name, item.Category, item.PageNo, item.Writer, item.Publisher, item.SaloonShelf, item.Status };

            dataGridViewData.DataSource = list.ToList();

            dataGridViewData.DataSource = db.Books.ToList();

            dataGridViewData.Columns[0].HeaderText = "Kitap Numarası";
            dataGridViewData.Columns[1].HeaderText = "Kitap İsmi";
            dataGridViewData.Columns[2].HeaderText = "Kategori ";
            dataGridViewData.Columns[3].HeaderText = "Yayın Evi";
            dataGridViewData.Columns[4].HeaderText = "Yazar";
            dataGridViewData.Columns[5].HeaderText = "Sayfa Sayısı";
            dataGridViewData.Columns[6].HeaderText = "Salon / Raf";
            dataGridViewData.Columns[7].HeaderText = "Durumu";
            dataGridViewData.Columns[8].HeaderText = "Resim";


            dataGridViewData.RowTemplate.Height = 200;


        }
        void FiltreCategory(string bName)
        {

            var filtreCategory = from dbCategory in db.Books
                where dbCategory.Category.Contains(bName)
                select dbCategory;
            dataGridViewData.DataSource = filtreCategory.ToList();

        }
        void Filtre(string bName)
        {
            
            var filtreBook = from dbBook in db.Books
                where dbBook.Name.Contains(bName)
                select dbBook;
            dataGridViewData.DataSource = filtreBook.ToList();

        
        }
    }
}
