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

        private void verilerigoster()
        {
            int id = Convert.ToInt32(textBoxSearch.Text);
            var kayit = db.Books.Find(id);

            Book book = new Book();
            while (textBoxSearch != null)
            {
            }
        }

        void GetData(String search = "")
        {
            var list = from item in db.Books
                where item.Name.Contains(search) || item.Category.Contains(search)
                select new { item.BookId, item.Name, item.Category, item.PageNo, item.Writer, item.Publisher, item.SaloonShelf, item.Status};

            dataGridViewData.DataSource = list.ToList();
        }


        private void KitapAraAl_Load(object sender, EventArgs e)
        {

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
    }
}
