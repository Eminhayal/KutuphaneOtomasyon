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
        private void KitapAraAl_Load(object sender, EventArgs e)
        {
            GetData();
            


        }
        private void verilerigoster()
        {
       

            Books book = new Books();
            while (textBoxSearch != null)
            {
            }
        }

        void GetData(String search = "")
        {
            //var list = from item in db.Books
            //    where item.Name.Contains(search) || item.Category.Contains(search)
            //    select new { item.BookId, item.Name, item.Category, item.PageNo, item.Writer, item.Publisher, item.SaloonShelf, item.Status};

            //dataGridViewData.DataSource = list.ToList();

            dataGridViewData.DataSource = db.Books.ToList();
            dataGridViewData.Columns[9].Visible = false;
            dataGridViewData.Columns[10].Visible = false;
            dataGridViewData.Columns[11].Visible = false;
            dataGridViewData.Columns[12].Visible = false;
            dataGridViewData.Columns[13].Visible = false;
            dataGridViewData.Columns[14].Visible = false;
            dataGridViewData.RowTemplate.Height = 200;


        }


        

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
            KitapAlma.name = book.Name;
            KitapAlma.writer = book.Writer;
            KitapAlma.publisher = book.Publisher;
            KitapAlma.pageNo = book.PageNo; 
            KitapAlma.category = book.Category;
            KitapAlma.saloon = book.SaloonShelf;
            KitapAlma.status = book.Status;
            KitapAlma kitapAlma = new KitapAlma();
            kitapAlma.ShowDialog();
            //kitapAlma.Show();







        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            //dataGridViewData.DataSource = db.Books.Where(book => book.Name.Contains(textBoxSearch.Text));

            if (textBoxSearch.Text.Length > 2 || textBoxSearch.Text.Length == 0)
            {
                dataGridViewData.DataSource = db.Books.Where(book => book.Name == textBoxSearch.Text).ToList();
                //GetData(textBoxSearch.Text);
            }
        }
    }
}
