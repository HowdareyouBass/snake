using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite
{
    public partial class MainMenu : Form
    {
        Fort f;
        SettingsMenu s;
        Shop sp;
        public Image background;
        public int hardness;
        public string Skin;
        public string SkinBerry;
        public string Money;
        public bool Red;
        public bool Purple;
        string[] save;
        public MainMenu(int hardnes,string ski,string skinbery)
        {
            InitializeComponent();
            save = new string[] { "", "", "" };
            background = new Bitmap("img/Background.jpg");
            pictureBox1.Image = background;
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Start();
            Skin = ski;
            SkinBerry = skinbery;
            hardness = hardnes;
            using (StreamReader Save = new StreamReader("Saves/Save.txt"))
            {
                for(int i = 0; !Save.EndOfStream; i++)
                {
                    save[i] = Save.ReadLine();
                }
            }
            Money = save[0];
            if(save[1] == "RedSnakeBought = True")
            {
                Red = true;
            }
            if(save[1] == "RedSnakeBought = False")
            {
                Red = false;
            }
            if(save[2] == "PurpleBerryBought = True")
            {
                Purple = true;
            }
            if(save[2] == "PurpleBerryBought = False")
            {
                Purple = false;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            Play.Location = new Point((this.Width - Play.Width) / 2,(this.Height - Play.Height - Settings.Height - Quit.Height - 20) / 2);
            Settings.Location = new Point((this.Width - Settings.Width) / 2,((this.Height - Play.Height - Settings.Height - Quit.Height - 20) / 2) + Play.Height + 10);
            Shop.Location = new Point((this.Width - Quit.Width) / 2, ((this.Height - Play.Height - Settings.Height - Quit.Height - 20) / 2) + 2 * (Play.Height + 10));
            Quit.Location = new Point((this.Width - Quit.Width) / 2, ((this.Height - Play.Height - Settings.Height - Quit.Height - 20) / 2) + 3 * (Play.Height + 10));
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            f = new Fort(hardness,Skin,SkinBerry);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            s = new SettingsMenu(hardness,Skin,SkinBerry);
            this.Hide();
            s.ShowDialog();
            this.Close();
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            sp = new Shop(hardness,Skin,SkinBerry,Money,Red,Purple);
            this.Hide();
            sp.ShowDialog();
            this.Close();
        }
    }
}
