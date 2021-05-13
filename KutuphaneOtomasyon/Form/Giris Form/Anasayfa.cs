using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyon.Form.Kullanici_Panel_Form;

namespace KutuphaneOtomasyon
{
    public partial class Anasayfa : System.Windows.Forms.Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();

        }
        private void profilButton_Click(object sender, EventArgs e)
        {
            panelKullanici.Controls.Clear();
            FormProfil formProfil = new FormProfil();
            formProfil.Dock = DockStyle.Fill;
            formProfil.TopLevel = false;
            formProfil.FormBorderStyle = FormBorderStyle.None;
            panelKullanici.Controls.Add(formProfil);
            formProfil.Show();
        }
        private void kitapAraAlButton_Click_1(object sender, EventArgs e)
        {
            panelKullanici.Controls.Clear();
            KitapAraAl kitapAraAl = new KitapAraAl();
            kitapAraAl.Dock = DockStyle.Fill;
            kitapAraAl.TopLevel = false;
            kitapAraAl.FormBorderStyle = FormBorderStyle.None;
            panelKullanici.Controls.Add(kitapAraAl);
            kitapAraAl.Show();
        }

        private void kitapTeslimButton_Click(object sender, EventArgs e)
        {
            panelKullanici.Controls.Clear();
            KitapTeslimEtme kitapTeslimEtme = new KitapTeslimEtme();
            kitapTeslimEtme.Dock = DockStyle.Fill;
            kitapTeslimEtme.TopLevel = false;
            kitapTeslimEtme.FormBorderStyle = FormBorderStyle.None;
            panelKullanici.Controls.Add(kitapTeslimEtme);
            kitapTeslimEtme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
