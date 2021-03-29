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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int nowWidth = 1920;
            int nowHeight = 1080;
            Rectangle ClientCozunurluk = new Rectangle();

            ClientCozunurluk = System.Windows.Forms.Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float) ClientCozunurluk.Width / (float) nowWidth);
            float OranHeight = ((float)ClientCozunurluk.Height / (float)nowHeight);

            this.Scale(OranWidth, OranHeight);
        } 
   
    }
}
