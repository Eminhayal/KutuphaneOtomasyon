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

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=KitapAra;Integrated Security=True");
        private void verilerigoster()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=KitapAra;Integrated Security=True");

         
            
            SqlCommand komut = new SqlCommand("SELECT * FROM Kitap", baglanti);
            komut.Connection = baglanti;
            
            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kitap ID"].ToString();
                ekle.SubItems.Add(oku["Kitap Adı"].ToString());
                ekle.SubItems.Add(oku["Yazar"].ToString());
                ekle.SubItems.Add(oku["Yayın Evi"].ToString());
                ekle.SubItems.Add(oku["Sayfa Sayısı"].ToString());
                ekle.SubItems.Add(oku["Kategori"].ToString());
                ekle.SubItems.Add(oku["Raf / Salon"].ToString());
                ekle.SubItems.Add(oku["Durum"].ToString());

                listView1.Items.Add(ekle);



            }
            baglanti.Close();



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
    }
}
