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
            //GetData();
 


        }
        private void verilerigoster()
        {
       

            Books book = new Books();
            while (textBoxSearch != null)
            {
            }
        }

        //void GetData(String search = "")
        //{
        //    var list = from item in db.Books
        //               where item.Name.Contains(search) || item.Category.Contains(search)
        //               select new { item.BookId, item.Name, item.Category, item.PageNo, item.Writer, item.Publisher, item.SaloonShelf, item.Status };

        //    dataGridViewData.DataSource = list.ToList();

        //    dataGridViewData.DataSource = db.Books.ToList();

        //    dataGridViewData.RowTemplate.Height = 200;


        //}


        

        private void button2_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            
            //dataGridViewData.DataSource = db.Books.Where(book => book.Name.Contains(textBoxSearch.Text));

            //if (textBoxSearch.Text.Length > 2 || textBoxSearch.Text.Length == 0)
            //{
            //    dataGridViewData.DataSource = db.Books.Where(book => book.Name == textBoxSearch.Text).ToList();
            //    //GetData(textBoxSearch.Text);
            //}


            if (textBoxSearch.Text.Length > 2 || textBoxSearch.Text.Length == 0)
            {
                categorysearch();
            }
        }
          private void categorysearch( string tarama="")
        {

            var cat_list = from item in db.Books
                           where item.Category.Contains(tarama) || item.Name.Contains(tarama)
                           select new { item.BookId,item.Name,item.Writer,item.Publisher,item.PageNo,item.Category,item.SaloonShelf,item.Status,item.Image};

            dataGridViewData.DataSource = cat_list.ToList();
        }
    }
}
