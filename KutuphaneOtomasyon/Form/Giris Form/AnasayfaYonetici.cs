using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class AnasayfaYonetici : System.Windows.Forms.Form
    {
        public AnasayfaYonetici()
        {
            InitializeComponent();
        }

        private void AnasayfaYonetici_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void kitapAlimOnayButton_Click(object sender, EventArgs e)
        {
            panelYonetici.Controls.Clear();
            KitapAlimOnayi kitapAlimOnayi = new KitapAlimOnayi();
            kitapAlimOnayi.Dock = DockStyle.Fill;
            kitapAlimOnayi.TopLevel = false;
            kitapAlimOnayi.FormBorderStyle = FormBorderStyle.None;
            panelYonetici.Controls.Add(kitapAlimOnayi);
            kitapAlimOnayi.Show();
        }

        private void kitapTeslimOnayButton_Click(object sender, EventArgs e)
        {
            panelYonetici.Controls.Clear();
            KitapTeslimOnay kitapTeslimOnay = new KitapTeslimOnay();
            kitapTeslimOnay.Dock = DockStyle.Fill;
            kitapTeslimOnay.TopLevel = false;
            kitapTeslimOnay.FormBorderStyle = FormBorderStyle.None;
            panelYonetici.Controls.Add(kitapTeslimOnay);
            kitapTeslimOnay.Show();
        }




        void panelYonetim()
        {
            panelYonetici.Controls.Clear();
            KitapTeslimOnay kitapTeslimOnay = new KitapTeslimOnay();
            kitapTeslimOnay.Dock = DockStyle.Fill;
            kitapTeslimOnay.TopLevel = false;
            kitapTeslimOnay.FormBorderStyle = FormBorderStyle.None;
            panelYonetici.Controls.Add(kitapTeslimOnay);
            kitapTeslimOnay.Show();
        }

        private void kitapEklemeDuzenlemeButton_Click(object sender, EventArgs e)
        {
            panelYonetici.Controls.Clear();
            KitapEklemeDuzenleme kitapEklemeDuzenleme = new KitapEklemeDuzenleme();
            kitapEklemeDuzenleme.Dock = DockStyle.Fill;
            kitapEklemeDuzenleme.TopLevel = false;
            kitapEklemeDuzenleme.FormBorderStyle = FormBorderStyle.None;
            panelYonetici.Controls.Add(kitapEklemeDuzenleme);
            kitapEklemeDuzenleme.Show();
        }

        private void kullaniciEklemeButton_Click(object sender, EventArgs e)
        {
            panelYonetici.Controls.Clear();
            KullaniciEklemeDuzenleme kullaniciEklemeDuzenleme = new KullaniciEklemeDuzenleme();
            kullaniciEklemeDuzenleme.Dock = DockStyle.Fill;
            kullaniciEklemeDuzenleme.TopLevel = false;
            kullaniciEklemeDuzenleme.FormBorderStyle = FormBorderStyle.None;
            panelYonetici.Controls.Add(kullaniciEklemeDuzenleme);
            kullaniciEklemeDuzenleme.Show();
        }

        private void emanetBilgileriButton_Click(object sender, EventArgs e)
        {
            panelYonetici.Controls.Clear();
            EmanetBilgileri emanetBilgileri = new EmanetBilgileri();
            emanetBilgileri.Dock = DockStyle.Fill;
            emanetBilgileri.TopLevel = false;
            emanetBilgileri.FormBorderStyle = FormBorderStyle.None;
            panelYonetici.Controls.Add(emanetBilgileri);
            emanetBilgileri.Show();
        }
    }
}
