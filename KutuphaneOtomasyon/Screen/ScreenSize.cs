using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Screen
{
    public class ScreenSize
    {
        int SimdikiWidth = 1280;

        int SimdikiHeight = 800;

        


            Rectangle Cozunurluk = new Rectangle();

            Cozunurluk = Screen.GetBounds(ClientCozunurluk);

            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);


            this.Scale(OranWidth, OranHeight);



    }
}
