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
    public partial class KitapAraAl : Form
    {
        public KitapAraAl()
        {
            InitializeComponent();
        }

        private KutuphaneOtoEntities dbEntities = new KutuphaneOtoEntities();
        private void KitapAraAl_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void GridSettings()
        {
            dataGridCategory.ReadOnly = true;
            dataGridCategory.AllowUserToDeleteRows = false;

        }

        private void GetData()
        {
         
            dataGridCategory.DataSource = dbEntities.Books.ToList();
        }














        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
            pictureBox1.Visible = false;
            
        }

        private void KitapAraAl_MouseClick(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
