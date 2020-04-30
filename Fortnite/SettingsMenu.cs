using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortnite
{
    public partial class SettingsMenu : Form
    {
        Image background;
        MainMenu m;
        public string Skin;
        public int hardness;
        public string SkinBerry;
        public SettingsMenu(int hardnes,string ski,string skinbery)
        {
            InitializeComponent();
            background = new Bitmap("img/BackgroundSettings.jpg");
            pictureBox1.Image = background;
            timer1.Interval = 1;
            timer1.Enabled = true;
            timer1.Start();
            Skin = ski;
            SkinBerry = skinbery;
            label1.Parent = pictureBox1;
            panel1.Parent = pictureBox1;
            ResetText.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
            ResetText.BackColor = Color.Transparent;
            hardness = hardnes;
            if(hardness == 1)
            {
                Easy.Checked = true;
                Middle.Checked = false;
                Hard.Checked = false;
            }
            if(hardness == 2)
            {
                Easy.Checked = false;
                Middle.Checked = true;
                Hard.Checked = false;
            }
            if(hardness == 3)
            {
                Easy.Checked = false;
                Middle.Checked = false;
                Hard.Checked = true;
            }
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            if (Easy.Checked)
            {
                hardness = 1;
            }
            if (Middle.Checked)
            {
                hardness = 2;
            }
            if (Hard.Checked)
            {
                hardness = 3;
            }
        }
        
        GraphicsPath GetGpath(RectangleF rect,int radius) 
        {
            GraphicsPath gpath = new GraphicsPath();
            float r2 = radius / 3f;

            gpath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            gpath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            gpath.AddLine(rect.X + r2, rect.Y, rect.Width - r2, rect.Y);
            gpath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            gpath.AddLine(rect.Width, rect.Y + r2, rect.Width, rect.Height - r2);
            gpath.AddArc(rect.X + rect.Width - radius,rect.Y + rect.Height - radius, radius, radius, 0, 90);
            gpath.AddLine(rect.Width - r2, rect.Height, rect.X + r2, rect.Height);
            gpath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            gpath.AddLine(rect.X, rect.Height - r2, rect.X, rect.Y + r2);

            gpath.CloseFigure();
            return gpath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //RectangleF Rect = new RectangleF(0,0,200,100);
            //GraphicsPath gp = GetGpath(Rect, 50);
            //using(Pen pen = new Pen(Color.Black, 1.75f))
            //{
            //    pen.Alignment = PenAlignment.Inset;
            //    e.Graphics.DrawPath(pen, gp);
            //}
            base.OnPaint(e);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            m = new MainMenu(hardness, Skin, SkinBerry);
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetText.Text = "Прогресс Успешно Сброшен";
            using(StreamWriter Save = new StreamWriter("Saves/Save.txt"))
            {
                Save.Write("0" + "\r\n" + "RedSnakeBought = False" + "\r\n" + "PurpleBerryBought = False");
            }
        }
    }
}
