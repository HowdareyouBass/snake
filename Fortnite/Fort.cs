using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite
{
    public partial class Fort : Form
    {
        static int width = 25, height = 25;
        Pen black = new Pen(Color.Black, 2);
        Bitmap bi;
        private string BackMoney;
        public bool hardmode;
        public bool gamestarted;
        public string SkinBerry;
        AnySnake snake;
        MainMenu m;
        Bitmap SnakeTail;
        public Image background;
        public int hardness;
        public string Skin;
        private string redpur = "", purplepur = "";
        public bool gameover;
        public int count;
        SolidBrush green = new SolidBrush(Color.Green);
        SolidBrush red = new SolidBrush(Color.Red);
        Strawberry Berry;
        public Fort(int hardnes,string ski,string skinbery)
        {
            InitializeComponent();
            youLose.Parent = Monitor;
            youLose.BackColor = Color.FromArgb(50, 0, 0, 0);
            youLose.Hide();
            youLose.Width = this.Width;
            youLose.Height = this.Height;
            Skin = ski;
            SkinBerry = skinbery;
            youLoseText.Parent = youLose;
            youLoseText.BackColor = Color.Transparent;
            youLoseText.Hide();
            ScoreWas.Parent = youLose;
            ScoreWas.BackColor = Color.Transparent;
            ScoreWas.Hide();
            Back.Hide();
            button1.Hide();
            Score.Parent = Monitor;
            Score.BackColor = Color.Transparent;
            hardness = hardnes;
            snake = new AnySnake();
            Berry = new Strawberry();
            Berry.texture = new Bitmap("img/Berries/" + SkinBerry + "Berry.png");
            snake.ChangeSkin(Skin);
            bi = new Bitmap(Monitor.Width, Monitor.Height);
            KeyPreview = true;
            background = new Bitmap("img/Background.jpg");
            SnakeTail = new Bitmap("img/" + snake.Skin + "/SnakeTailL.png");
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Interval = 100;
            timer2.Interval = 1;
            timer2.Start();
            gamestarted = true;
            if(hardness == 1)
            {
                timer1.Interval = 100;
                hardmode = false;
            }
            if(hardness == 2)
            {
                timer1.Interval = 50;
                hardmode = false;
            }
            if(hardness == 3)
            {
                timer1.Interval = 50;
                hardmode = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer2.Start();
            snake = new AnySnake();
            Berry = new Strawberry();
            Berry.texture = new Bitmap("img/Berries/" + SkinBerry + "Berry.png");
            snake.ChangeSkin(Skin);
            youLose.Hide();
            youLoseText.Hide();
            button1.Hide();
            ScoreWas.Hide();
            Back.Hide();
            count = 0;
            Score.Text = count.ToString();
            gamestarted = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hardness == 1)
            {
                timer1.Interval = 100;
                hardmode = false;
            }
            if (hardness == 2)
            {
                timer1.Interval = 50;
                hardmode = false;
            }
            if (hardness == 3)
            {
                timer1.Interval = 50;
                hardmode = true;
            }
            for (int i = snake.li.Count() - 1;i >= 0; i--)
            {
                if (i == 0)
                {
                    snake.GetSecondElement();
                    snake.GetTail();
                    snake.Move();
                    if (snake.path == 'U')
                    {
                        var temp1 = snake.li[0];
                        temp1.b = snake.SnakeHeadU;
                        snake.li[0] = temp1;
                        if(snake.li.Count() == 2)
                        {
                            var temp9 = snake.li[1];
                            temp9.b = snake.SnakeTailU;
                            snake.li[1] = temp9;
                        }
                    }
                    if (snake.path == 'D')
                    {
                        var temp1 = snake.li[0];
                        temp1.b = snake.SnakeHeadD;
                        snake.li[0] = temp1;
                        if (snake.li.Count() == 2)
                        {
                            var temp9 = snake.li[1];
                            temp9.b = snake.SnakeTailD;
                            snake.li[1] = temp9;
                        }
                    }
                    if (snake.path == 'L')
                    {
                        var temp1 = snake.li[0];
                        temp1.b = snake.SnakeHeadL;
                        snake.li[0] = temp1;
                        if (snake.li.Count() == 2)
                        {
                            var temp9 = snake.li[1];
                            temp9.b = snake.SnakeTailL;
                            snake.li[1] = temp9;
                        }
                    }
                    if (snake.path == 'R')
                    {
                        var temp1 = snake.li[0];
                        temp1.b = snake.SnakeHeadR;
                        snake.li[0] = temp1;
                        if (snake.li.Count() == 2)
                        {
                            var temp9 = snake.li[1];
                            temp9.b = snake.SnakeTailR;
                            snake.li[1] = temp9;
                        }
                    }
                }
                else
                {
                    var temp = snake.li[i];
                    temp.x = snake.li[i - 1].x;
                    temp.y = snake.li[i - 1].y;
                    if (i == 1)
                    {
                        if(snake.li.Count() != 2)
                        {
                            snake.GetSecondElement();
                        }
                    }
                    if (i == snake.li.Count() - 1 && snake.li.Count() != 2)
                    {
                        snake.GetTail();
                        temp = snake.li[i];
                        temp.x = snake.li[i - 1].x;
                        temp.y = snake.li[i - 1].y;
                    }
                    if (i != 0 && i != 1 && i != snake.li.Count() - 1 && snake.li.Count() != 2)
                    {
                        temp.b = snake.li[i - 1].b;
                    }
                    snake.li[i] = temp;
                }
            }
            if((snake.li[0].x == Berry.x) && (snake.li[0].y == Berry.y))
            {
                count += 100;
                Score.Text = "Счёт:" + count.ToString();
                Berry.ChangeThere();
                var temp1 = snake.li.Last();
                snake.li.Add(new Coordinate() { x = temp1.x, y = temp1.y, b = temp1.b});
            }
            snake.GetTail();

            Graphics g = Graphics.FromImage(bi);
            g.Clear(Color.LightBlue);

            

            for (int i = 0; i < snake.li.Count(); i++)
            {
                g.DrawImage(snake.li[i].b, snake.li[i].x * width, snake.li[i].y * height, width, height);
            }
            g.DrawImage(Berry.texture, Berry.x * width, Berry.y * height, 25, 25);

            for (int i = 1; i < snake.li.Count(); i++)
            {
                if ((snake.li[0].x == snake.li[i].x) && (snake.li[0].y == snake.li[i].y))
                {
                    gameover = true;
                    break;
                }
            }
            if (hardmode && (snake.li[0].x < 0 || snake.li[0].y < 0 || snake.li[0].x >= 20 || snake.li[0].y >= 20))
            {
                gameover = true;
            }
            if (hardmode == false)
            {
                if (snake.li[0].x < 0)
                {
                    var temp = snake.li[0];
                    temp.x = 19;
                    snake.li[0] = temp;
                }
                if (snake.li[0].x >= 20)
                {
                    var temp = snake.li[0];
                    temp.x = 0;
                    snake.li[0] = temp;
                }
                if (snake.li[0].y >= 20)
                {
                    var temp = snake.li[0];
                    temp.y = 0;
                    snake.li[0] = temp;
                }
                if (snake.li[0].y < 0)
                {
                    var temp = snake.li[0];
                    temp.y = 19;
                    snake.li[0] = temp;
                }
            }
            if (gameover)
            {
                gamestarted = false;
                timer1.Stop();
                timer2.Stop();
                youLose.Show();
                button1.Show();
                youLoseText.Show();
                Back.Show();
                ScoreWas.Text = "Счёт:" + count.ToString();
                ScoreWas.Show();
            }
            gameover = false;
            Monitor.Image = bi;
        }

        private void Fort_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "W":
                    {
                        if (gamestarted)
                        {
                            snake.Wantedpath = 'U';
                        }
                        break;
                    }
                case "S":
                    {
                        if (gamestarted)
                        {
                            snake.Wantedpath = 'D';
                        }
                        break;
                    }
                case "D":
                    {
                        if (gamestarted)
                        {
                            snake.Wantedpath = 'R';
                        }
                        break;
                    }
                case "A":
                    {
                        if (gamestarted)
                        {
                            snake.Wantedpath = 'L';
                        }
                        break;
                    }
                default:
                    {
                        if (gamestarted)
                        {
                            snake.Wantedpath = snake.path;
                        }
                        break;
                    }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            using (StreamReader Save = new StreamReader("Saves/Save.txt"))
            {
                for (int i = 0; !Save.EndOfStream; i++)
                {
                    if (i == 0)
                    {
                        BackMoney = Save.ReadLine();
                    }
                    if (i == 1)
                    {
                        redpur = Save.ReadLine();
                    }
                    if (i == 2)
                    {
                        purplepur = Save.ReadLine();
                    }
                }
            }
            using (StreamWriter Save = new StreamWriter("Saves/Save.txt"))
            {
                Save.Write((count + int.Parse(BackMoney)).ToString() + "\r\n" + redpur + "\r\n" + purplepur);
            }
            m = new MainMenu(hardness,Skin,SkinBerry);
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void Fort_Load(object sender, EventArgs e)
        {

        }
    }
}
