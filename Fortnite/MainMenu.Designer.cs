namespace Fortnite
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Shop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Green;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.Play.FlatAppearance.BorderSize = 2;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("MKMEGADRIVE", 16F, System.Drawing.FontStyle.Bold);
            this.Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Play.Location = new System.Drawing.Point(311, 168);
            this.Play.Margin = new System.Windows.Forms.Padding(0);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(125, 60);
            this.Play.TabIndex = 1;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Green;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.Settings.FlatAppearance.BorderSize = 2;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Settings.Location = new System.Drawing.Point(311, 238);
            this.Settings.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(125, 60);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Настройки";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Green;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.Quit.FlatAppearance.BorderSize = 2;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Quit.Location = new System.Drawing.Point(311, 374);
            this.Quit.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(125, 60);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Выход";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Shop
            // 
            this.Shop.BackColor = System.Drawing.Color.Green;
            this.Shop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Shop.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.Shop.FlatAppearance.BorderSize = 2;
            this.Shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shop.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Shop.Location = new System.Drawing.Point(311, 301);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(125, 60);
            this.Shop.TabIndex = 4;
            this.Shop.Text = "Магазин";
            this.Shop.UseVisualStyleBackColor = false;
            this.Shop.Click += new System.EventHandler(this.Shop_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.Shop);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Shop;
    }
}