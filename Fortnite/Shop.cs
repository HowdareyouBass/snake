using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite
{
    public partial class Shop : Form
    {
        MainMenu m;
        Graphics g;

        Bitmap RedMonitor;
        Bitmap StandartMonitor;
        Bitmap GreenBerryMonitor;
        Bitmap PurpleBerryMonitor;

        Bitmap RedHead;
        Bitmap RedBody;
        Bitmap RedTail;

        Bitmap StandartHead;
        Bitmap StandartBody;
        Bitmap StandartTail;

        Bitmap PurpleBerry;
        Bitmap GreenBerry;

        Color t;

        public int hardness;
        public string Skin;
        public string SkinBerry;
        public int Money;
        public Shop(int hardnes,string ski,string skinbery,string mony,bool red,bool purple)
        {
            InitializeComponent();
            Moneyt.Text = "Монеты:" + mony.ToString();
            Skin = ski;
            Money = int.Parse(mony);
            hardness = hardnes;
            t = Color.Transparent;
            SkinBerry = skinbery;
            if (SkinBerry == "Green")
            {
                GreenBerryC.Checked = true;
                PurpleBerryC.Checked = false;
            }
            if (SkinBerry == "Purple")
            {
                GreenBerryC.Checked = false;
                PurpleBerryC.Checked = true;
            }
            if(Skin == "Red")
            {
                RedSkin.Checked = true;
                StandartSkin.Checked = false;
            }
            if(Skin == "Standart")
            {
                RedSkin.Checked = false;
                StandartSkin.Checked = true;
            }
            if (red)
            {
                BuyRedSnake.Visible = false;
                RedSkin.Visible = true;
            }
            else
            {
                BuyRedSnake.Visible = true;
                RedSkin.Visible = false;
            }
            if (purple)
            {
                BuyPurpleBerry.Visible = false;
                PurpleBerryC.Visible = true;
            }
            else
            {
                BuyPurpleBerry.Visible = true;
                PurpleBerryC.Visible = false;
            }
            StandartBox.Parent = pictureBox1;
            StandartBox.BackColor = t;
            RedBox.Parent = pictureBox1;
            RedBox.BackColor = t;
            PurchaseResult.Parent = pictureBox1;
            PurchaseResult.BackColor = t;
            GreenBerryBox.Parent = pictureBox1;
            GreenBerryBox.BackColor = t;
            PurpleBerryBox.Parent = pictureBox1;
            PurpleBerryBox.BackColor = t;

            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = t;
            groupBox2.Parent = pictureBox1;
            groupBox2.BackColor = t;
            //StandartSkin.Parent = pictureBox1;
            //StandartSkin.BackColor = Color.Transparent;
            //RedSkin.Parent = pictureBox1;
            //RedSkin.BackColor = Color.Transparent;
            //GreenBerryC.Parent = pictureBox1;
            //GreenBerryC.BackColor = Color.Transparent;
            //PurpleBerryC.Parent = pictureBox1;
            //PurpleBerryC.BackColor = Color.Transparent;
            Moneyt.Parent = pictureBox1;
            Moneyt.BackColor = t;
            
            StandartMonitor = new Bitmap(75, 25);
            RedMonitor = new Bitmap(75, 25);
            PurpleBerryMonitor = new Bitmap(25, 25);
            GreenBerryMonitor = new Bitmap(25, 25);

            RedHead = new Bitmap(GetStringSkin("Red")[0]);
            RedBody = new Bitmap(GetStringSkin("Red")[1]);
            RedTail = new Bitmap(GetStringSkin("Red")[2]);

            StandartHead = new Bitmap(GetStringSkin("Standart")[0]);
            StandartBody = new Bitmap(GetStringSkin("Standart")[1]);
            StandartTail = new Bitmap(GetStringSkin("Standart")[2]);

            GreenBerry = new Bitmap("img/Berries/GreenBerry.png");
            PurpleBerry = new Bitmap("img/Berries/PurpleBerry.png");

            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
            
            pictureBox1.Image = new Bitmap("img/ShopBackground.jpg");

            g = Graphics.FromImage(StandartMonitor);
            g.DrawImage(StandartHead, 50, 0);
            g.DrawImage(StandartBody, 25, 0);
            g.DrawImage(StandartTail, 0, 0);
            StandartBox.Image = StandartMonitor;

            g = Graphics.FromImage(RedMonitor);
            g.DrawImage(RedHead, 50, 0);
            g.DrawImage(RedBody, 25, 0);
            g.DrawImage(RedTail, 0, 0);
            RedBox.Image = RedMonitor;

            g = Graphics.FromImage(GreenBerryMonitor);
            g.DrawImage(GreenBerry, 0, 0);
            GreenBerryBox.Image = GreenBerryMonitor;

            g = Graphics.FromImage(PurpleBerryMonitor);
            g.DrawImage(PurpleBerry, 0, 0);
            PurpleBerryBox.Image = PurpleBerryMonitor;
        }
        
        private void Back_Click(object sender, EventArgs e)
        {
            m = new MainMenu(hardness,Skin,SkinBerry);
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            Back.Location = new Point(15, this.Height - 115);
            if (StandartSkin.Checked)
            {
                Skin = "Standart";
            }
            if (RedSkin.Checked)
            {
                Skin = "Red";
            }
            if (GreenBerryC.Checked)
            {
                SkinBerry = "Green";
            }
            if (PurpleBerryC.Checked)
            {
                SkinBerry = "Purple";
            }
        }
        public string[] GetStringSkin(string skin)
        {
            string[] temp = { "img/" + skin + "/SnakeHeadR.png", "img/" + skin + "/SnakeBodyLR.png", "img/" + skin + "/SnakeTailR.png"};
            return temp;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BuyRedSnake_Click(object sender, EventArgs e)
        {
            if (Money < 10000)
            {
                PurchaseResult.ForeColor = Color.Red;
                PurchaseResult.Text = "Не достаточно денег";
            }
            else
            {
                Money -= 10000;
                Moneyt.Text = "Монеты:" + Money.ToString();
                string purplebought = "";
                using(StreamReader Save = new StreamReader("Saves/Save.txt"))
                {
                    for(int i = 0; !Save.EndOfStream; i++)
                    {
                        if(i == 2)
                        {
                            purplebought = Save.ReadLine();
                        }
                        else
                        {
                            string temp = Save.ReadLine();
                        }
                    }
                }
                using(StreamWriter Save = new StreamWriter("Saves/Save.txt"))
                {
                    Save.Write(Money.ToString() + "\r\n" + "RedSnakeBought = True" + "\r\n" + purplebought);
                }
                BuyRedSnake.Visible = false;
                RedSkin.Visible = true;
                PurchaseResult.ForeColor = Color.Green;
                PurchaseResult.Text = "Покукпа совершена";
            }
        }

        private void BuyPurpleBerry_Click(object sender, EventArgs e)
        {
            if(Money < 50000)
            {
                PurchaseResult.ForeColor = Color.Red;
                PurchaseResult.Text = "Не хватает денег";
            }
            else
            {
                Money -= 50000;
                Moneyt.Text = "Монеты:" + Money.ToString();
                string redbought = "";
                using(StreamReader Save = new StreamReader("Saves/Save.txt"))
                {
                    for(int i = 0; !Save.EndOfStream; i++)
                    {
                        if(i == 1)
                        {
                            redbought = Save.ReadLine();
                        }
                        else
                        {
                            string temp1 = Save.ReadLine();
                        }
                    }
                }
                using(StreamWriter Save = new StreamWriter("Saves/Save.txt"))
                {
                    Save.Write(Money.ToString() + "\r\n" + redbought + "\r\n" + "PurpleBerryBought = True");
                }
                BuyPurpleBerry.Visible = false;
                PurpleBerryC.Visible = true;
                PurchaseResult.ForeColor = Color.Green;
                PurchaseResult.Text = "Покукпа совершена";
            }
        }
    }
}
