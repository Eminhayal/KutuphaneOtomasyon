using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyon.Form;

namespace KutuphaneOtomasyon
{
    public partial class KitapEklemeDuzenleme : System.Windows.Forms.Form
    {
        public KitapEklemeDuzenleme()
        {
            InitializeComponent();
        }

        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();

        private ImageConvert image = new ImageConvert();
        private void buttonBookEdit_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonBookEditUpdate_Click(object sender, EventArgs e)
        {
            ChanceInfo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            file.Title = "ayemkutuphane ";
            file.ShowDialog();
            string filePath = file.FileName;
            pictureBox1.ImageLocation = filePath;
        }
        private void button_Clear(object sender, EventArgs e)
        {
            textBoxBookId.Enabled = true;
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
                textBoxBookId.Enabled = false;
                buttonBookEditUpdate.Enabled = true;
                
                    int id = Convert.ToInt32(textBoxBookId.Text);
                    var kayit = db.Books.Find(id);
 
                        textBoxBookName.Text = kayit.Name.ToString();
                        comboBoxCategory.Text = kayit.Category.ToString();
                        textBoxPublisher.Text = kayit.Publisher.ToString();
                        textBoxSaloonShelf.Text = kayit.SaloonShelf.ToString();
                        textBoxWriter.Text = kayit.Writer.ToString();
                        numericUpDownPageNo.Text = kayit.PageNo.ToString();
                        comboBoxStatus.Text = kayit.Status.ToString();
                        textBoxBookId.Enabled = false;
                        buttonAra.Visible = false;
                        buttonBookEditUpdate.Visible = true;
                        pictureBox1.Image = image.byteArrayToImage(kayit.Image);
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
            kayit.Category = comboBoxCategory.Text;
            kayit.SaloonShelf = textBoxSaloonShelf.Text;
            kayit.Status = comboBoxStatus.Text;

            kayit.Image = image.imageToByteArray(pictureBox1.Image);
            db.SaveChanges();
        }

        public void AddBook()
        {
           
            Books book = new Books();
            book.Name = textBoxBookName.Text;
            book.Writer = textBoxWriter.Text;
            book.Publisher = textBoxPublisher.Text;
            book.PageNo = Convert.ToInt16(numericUpDownPageNo.Text);
            book.Category = comboBoxCategory.Text;
            book.SaloonShelf = textBoxSaloonShelf.Text;
            book.Status = comboBoxStatus.Text;

            ImageAdd(book);

            db.Books.Add(book);
            db.SaveChanges();
            MessageBox.Show("ekle");
        }
        public void ImageAdd(Books book)
        {
            if (pictureBox1 != null)
            {
                MemoryStream ms1 = new MemoryStream();
                pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                book.Image = ms1.ToArray();

            }

        }
        private void numericUpDownPageNo_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownPageNo.Maximum = 2500;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            textBoxBookId.Text = "";
            textBoxBookName.Text = "";
            comboBoxCategory.Text = "";
            textBoxPublisher.Text = "";
            textBoxSaloonShelf.Text = "";
            textBoxWriter.Text = "";
            numericUpDownPageNo.Text = "";
            comboBoxStatus.Text = "";
            textBoxBookId.Enabled = true;
            buttonAra.Visible = true;
            
            pictureBox1.Image = Properties.Resources.Xbüyük;
            buttonBookEditUpdate.Enabled = false;

        }
    }
}
