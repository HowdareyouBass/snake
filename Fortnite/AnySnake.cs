using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite
{
    struct Coordinate
    {
        public int x;
        public int y;
        public Bitmap b;
    }
    class AnySnake
    {
        static int width = 20, height = 20;
        public List<Coordinate> li = new List<Coordinate>();
        public char path = 'L';
        public char Wantedpath = 'N';
        public string Skin = "Standart";
        public Bitmap SnakeHeadU, SnakeHeadD, SnakeHeadL, SnakeHeadR, SnakeBodyUD,SnakeBodyRL, UtoLorRtoD,UtoRorLtoD,LtoUorDtoR,RtoUorDtoL,SnakeTailL,SnakeTailR,SnakeTailU,SnakeTailD;
        public AnySnake()
        {
            SnakeHeadU = new Bitmap("img/" + Skin + "/SnakeHeadU.png");
            SnakeHeadD = new Bitmap("img/" + Skin + "/SnakeHeadD.png");
            SnakeHeadL = new Bitmap("img/" + Skin + "/SnakeHeadL.png");
            SnakeHeadR = new Bitmap("img/" + Skin + "/SnakeHeadR.png");
            SnakeBodyRL = new Bitmap("img/" + Skin + "/SnakeBodyLR.png");
            SnakeBodyUD = new Bitmap("img/" + Skin + "/SnakeBodyUD.png");
            UtoLorRtoD = new Bitmap("img/" + Skin + "/UtoL or RtoD.png");
            UtoRorLtoD = new Bitmap("img/" + Skin + "/UtoR or LtoD.png");
            RtoUorDtoL = new Bitmap("img/" + Skin + "/RtoU or DtoL.png");
            LtoUorDtoR = new Bitmap("img/" + Skin + "/LtoU or DtoR.png");
            SnakeTailD = new Bitmap("img/" + Skin + "/SnakeTailD.png");
            SnakeTailU = new Bitmap("img/" + Skin + "/SnakeTailU.png");
            SnakeTailR = new Bitmap("img/" + Skin + "/SnakeTailR.png");
            SnakeTailL = new Bitmap("img/" + Skin + "/SnakeTailL.png");
            li.Add(new Coordinate() { x = width / 2, y = height / 2 , b = SnakeHeadL});
            li.Add(new Coordinate() { x = width / 2 + 1, y = height / 2, b =  SnakeTailL});
        }
        public void ChangeSkin(string Skiny)
        {
            SnakeHeadU = new Bitmap("img/" + Skiny + "/SnakeHeadU.png");
            SnakeHeadD = new Bitmap("img/" + Skiny + "/SnakeHeadD.png");
            SnakeHeadL = new Bitmap("img/" + Skiny + "/SnakeHeadL.png");
            SnakeHeadR = new Bitmap("img/" + Skiny + "/SnakeHeadR.png");
            SnakeBodyRL = new Bitmap("img/" + Skiny + "/SnakeBodyLR.png");
            SnakeBodyUD = new Bitmap("img/" + Skiny + "/SnakeBodyUD.png");
            UtoLorRtoD = new Bitmap("img/" + Skiny + "/UtoL or RtoD.png");
            UtoRorLtoD = new Bitmap("img/" + Skiny + "/UtoR or LtoD.png");
            RtoUorDtoL = new Bitmap("img/" + Skiny + "/RtoU or DtoL.png");
            LtoUorDtoR = new Bitmap("img/" + Skiny + "/LtoU or DtoR.png");
            SnakeTailD = new Bitmap("img/" + Skiny + "/SnakeTailD.png");
            SnakeTailU = new Bitmap("img/" + Skiny + "/SnakeTailU.png");
            SnakeTailR = new Bitmap("img/" + Skiny + "/SnakeTailR.png");
            SnakeTailL = new Bitmap("img/" + Skiny + "/SnakeTailL.png");
        }
        public void Move()
        {
            if(Wantedpath != 'N')
            {
                if (Wantedpath == 'L' && path != 'R') path = Wantedpath;
                if (Wantedpath == 'R' && path != 'L') path = Wantedpath;
                if (Wantedpath == 'U' && path != 'D') path = Wantedpath;
                if (Wantedpath == 'D' && path != 'U') path = Wantedpath;
            }
            switch (path)
            {
                case 'R':
                    {
                        var temp = li[0];
                        temp.x++;
                        li[0] = temp;
                        break;
                    }
                case 'L':
                    {
                        var temp = li[0];
                        temp.x--;
                        li[0] = temp;
                        break;
                    }
                case 'U':
                    {
                        var temp = li[0];
                        temp.y--;
                        li[0] = temp;
                        break;
                    }
                case 'D':
                    {
                        var temp = li[0];
                        temp.y++;
                        li[0] = temp;
                        break;
                    }
            }
        }
        public void GetSecondElement()
        {
            if(path == 'U')
            {
                var temp = li[0];
                temp.b = SnakeHeadU;
                li[0] = temp;
                if(Wantedpath == 'L')
                {
                    var temp1 = li[1];
                    temp1.b = UtoLorRtoD;
                    li[1] = temp1;
                }
                if(Wantedpath == 'U')
                {
                    var temp1 = li[1];
                    temp1.b = SnakeBodyUD;
                    li[1] = temp1;
                }
                if(Wantedpath == 'D')
                {
                    var temp1 = li[1];
                    temp1.b = SnakeBodyUD;
                    li[1] = temp1;
                }
                if(Wantedpath == 'R')
                {
                    var temp1 = li[1];
                    temp1.b = UtoRorLtoD;
                    li[1] = temp1;
                }
            }
            if(path == 'D')
            {
                var temp = li[0];
                temp.b = SnakeHeadD;
                li[0] = temp;
                if(Wantedpath == 'L')
                {
                    var temp1 = li[1];
                    temp1.b = RtoUorDtoL;
                    li[1] = temp1;
                }
                if(Wantedpath == 'R')
                {
                    var temp1 = li[1];
                    temp1.b = LtoUorDtoR;
                    li[1] = temp1;
                }
                if(Wantedpath == 'D')
                {
                    var temp1 = li[1];
                    temp1.b = SnakeBodyUD;
                    li[1] = temp1;
                }
                if(Wantedpath == 'U')
                {
                    var temp1 = li[1];
                    temp1.b = SnakeBodyUD;
                    li[1] = temp1;
                }
            }
            if(path == 'R')
            {
                var temp = li[0];
                temp.b = SnakeHeadR;
                li[0] = temp;
                if (Wantedpath == 'L')
                {
                    var temp1 = li[1];
                    temp1.b = SnakeBodyRL;
                    li[1] = temp1;
                }
                if (Wantedpath == 'R')
                {
                    var temp1 = li[1];
                    temp1.b = SnakeBodyRL;
                    li[1] = temp1;
                }
                if (Wantedpath == 'D')
                {
                    var temp1 = li[1];
                    temp1.b = UtoLorRtoD;
                    li[1] = temp1;
                }
                if (Wantedpath == 'U')
                {
                    var temp1 = li[1];
                    temp1.b = RtoUorDtoL;
                    li[1] = temp1;
                }
            }
            if (path == 'L')
            {
                var temp = li[0];
                temp.b = SnakeHeadL;
                li[0] = temp;
                if (Wantedpath == 'L')
                {
                    var temp1 = li[1];
                    temp1.b = SnakeBodyRL;
                    li[1] = temp1;
                }
                if (Wantedpath == 'R')
                {
                    var temp1 = li[1];
                    temp1.b = SnakeBodyRL;
                    li[1] = temp1;
                }
                if (Wantedpath == 'D')
                {
                    var temp1 = li[1];
                    temp1.b = UtoRorLtoD;
                    li[1] = temp1;
                }
                if (Wantedpath == 'U')
                {
                    var temp1 = li[1];
                    temp1.b = LtoUorDtoR;
                    li[1] = temp1;
                }
            }
        }
        public void GetTail()
        {
            var temp = li[li.Count() - 1];
            if(li[li.Count() - 2].b == UtoLorRtoD)
            {
                if (li[li.Count() - 3].y == li[li.Count() - 2].y + 1)
                {
                    temp.b = SnakeTailR;
                }
                if (li[li.Count() - 3].x == li[li.Count() - 2].x - 1)
                {
                    temp.b = SnakeTailU;
                }
            }
            if (li[li.Count() - 2].b == UtoRorLtoD)
            {
                if (li[li.Count() - 3].y == li[li.Count() - 2].y + 1)
                {
                    temp.b = SnakeTailL;
                }
                if (li[li.Count() - 3].x == li[li.Count() - 2].x + 1)
                {
                    temp.b = SnakeTailU;
                }
            }
            if (li[li.Count() - 2].b == RtoUorDtoL)
            {
                if (li[li.Count() - 3].y == li[li.Count() - 2].y - 1)
                {
                    temp.b = SnakeTailR;
                }
                if (li[li.Count() - 3].x == li[li.Count() - 2].x - 1)
                {
                    temp.b = SnakeTailD;
                }
            }
            if (li[li.Count() - 2].b == LtoUorDtoR)
            {
                if (li[li.Count() - 3].y == li[li.Count() - 2].y - 1)
                {
                    temp.b = SnakeTailL;
                }
                if (li[li.Count() - 3].x == li[li.Count() - 2].x + 1)
                {
                    temp.b = SnakeTailD;
                }
            }
            if (li[li.Count() - 2].b == SnakeBodyRL)
            {
                if (li[li.Count() - 3].x == li[li.Count() - 2].x + 1)
                {
                    temp.b = SnakeTailR;
                }
                if (li[li.Count() - 3].x == li[li.Count() - 2].x - 1)
                {
                    temp.b = SnakeTailL;
                }
            }
            if (li[li.Count() - 2].b == SnakeBodyUD)
            {
                if (li[li.Count() - 3].y == li[li.Count() - 2].y + 1)
                {
                    temp.b = SnakeTailD;
                }
                if (li[li.Count() - 3].y == li[li.Count() - 2].y - 1)
                {
                    temp.b = SnakeTailU;
                }
            }
            li[li.Count() - 1] = temp;
        }
    }
}
