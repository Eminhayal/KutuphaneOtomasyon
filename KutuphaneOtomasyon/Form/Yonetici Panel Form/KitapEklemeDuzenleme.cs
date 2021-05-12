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
    public partial class KitapEklemeDuzenleme : System.Windows.Forms.Form
    {
        public KitapEklemeDuzenleme()
        {
            InitializeComponent();
        }

        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void KitapEklemeDuzenleme_Load(object sender, EventArgs e)
        {

        }

        private void buttonBookAdd_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Name = textBoxBookName.Text;
            book.Writer = textBoxWriter.Text;
            book.Publisher = textBoxPublisher.Text;
            book.PageNo = Convert.ToInt16(textBoxPageNo.Text);
            book.Category = textBoxCategory.Text;
            book.SaloonShelf = textBoxSaloonShelf.Text;


        }
    }
}
