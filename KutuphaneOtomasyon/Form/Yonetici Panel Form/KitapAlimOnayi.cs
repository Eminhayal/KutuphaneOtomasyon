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
    public partial class KitapAlimOnayi : System.Windows.Forms.Form
    {
        public KitapAlimOnayi()
        {
            InitializeComponent();
        }
        private KutuphaneOtoEntities3 db = new KutuphaneOtoEntities3();
        Confirm confirm = new Confirm();
      
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxSearchId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxSearchId != null)
                {
                    var id = Convert.ToInt32(textBoxSearchId.Text);

                    var confirm = db.Confirms.Find(id);

                    labelBookId.Text = confirm.BookId.ToString();
                    labelBookName.Text = confirm.Book.Name;
                    labelUserName.Text = confirm.User.Name;
                    labelUserId.Text = confirm.UserId.ToString();



                    //var book1 = db.Books.Find(id);
                    //var user1 = db.Users.Find(book1.BookId);

                    // labelBookId.Text = book1.BookId.ToString();
                    //labelBookName.Text = book1.Name;
                    //labelUserId.Text = user1.UserId.ToString();
                    //labelUserName.Text = user1.Name;
                }
            }
        }
    }
}
