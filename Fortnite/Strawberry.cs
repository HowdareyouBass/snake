using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite
{
    class Strawberry
    {
        static int width = 20, height = 20;
        public int x, y;
        public string Skin;
        public Bitmap texture;
        public Strawberry()
        {
            Skin = "Green";
            texture = new Bitmap("img/Berries/" + Skin + "Berry.png");
            ChangeThere();
        }
        public void ChangeThere()
        {
            Thread.Sleep(1);
            Random r = new Random(DateTime.Now.Millisecond);
            this.x = r.Next(2, width - 2);
            this.y = r.Next(2, height - 2);
        }
    }
}
