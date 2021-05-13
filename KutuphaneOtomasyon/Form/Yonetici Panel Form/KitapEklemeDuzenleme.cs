using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        Books book = new Books();
        
        private void buttonBookEdit_Click(object sender, EventArgs e)
        {
            textBoxBookId.Enabled = true;
            buttonAra.Visible = true;
        }
        private void buttonBookEditUpdate_Click(object sender, EventArgs e)
        {
            buttonBookEditUpdate.Visible = false;
            buttonBookEdit.Visible = true;

            ChanceInfo();
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
            AddBook();
        }

        private void buttonBookDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxBookId.Text);
            var kayit = db.Books.Find(id);

            if (kayit == null)
            {
                MessageBox.Show("Bos");
                return;
            }

            if (MessageBox.Show(kayit.Name + "kitap silinecek onaylıyor musunuz ? " ,
                " Kayıt silme onayı",
                MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                db.Books.Remove(kayit);
                db.SaveChanges();
            }

        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
            if (textBoxBookId.Enabled == true)
            {
                try
                {
                    int id = Convert.ToInt32(textBoxBookId.Text);
                    var kayit = db.Books.Find(id);
                    textBoxBookName.Text = kayit.Name.ToString();
                    textBoxCategory.Text = kayit.Category.ToString();
                    textBoxPublisher.Text = kayit.Publisher.ToString();
                    textBoxSaloonShelf.Text = kayit.SaloonShelf.ToString();
                    textBoxWriter.Text = kayit.Writer.ToString();
                    numericUpDownPageNo.Text = kayit.PageNo.ToString();
                    textBoxBookId.Enabled = false;
                    buttonAra.Visible = false;
                    buttonBookEdit.Visible = false;
                    buttonBookEditUpdate.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Hatali ");
                    
                }
                
            }
        }
        

        private void textBoxBookId_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void textBoxBookId_Enter(object sender, EventArgs e)
        {
           
          
        }
        public void ChanceInfo()
        {
            int id = Convert.ToInt32(textBoxBookId.Text);
            var kayit = db.Books.Find(id);
            kayit.Name = textBoxBookName.Text;
            kayit.Writer = textBoxWriter.Text;
            kayit.Publisher = textBoxPublisher.Text;
            kayit.PageNo = Convert.ToInt16(numericUpDownPageNo.Text);
            kayit.Category = textBoxCategory.Text;
            kayit.SaloonShelf = textBoxSaloonShelf.Text;
            db.SaveChanges();
        }

        public void AddBook()
        {
            Books book = new Books();
            book.Name = textBoxBookName.Text;
            book.Writer = textBoxWriter.Text;
            book.Publisher = textBoxPublisher.Text;
            book.PageNo = Convert.ToInt16(numericUpDownPageNo.Text);
            book.Category = textBoxCategory.Text;
            book.SaloonShelf = textBoxSaloonShelf.Text;
            db.Books.Add(book);
            db.SaveChanges();
            MessageBox.Show("ekle");
        }

    }
}
