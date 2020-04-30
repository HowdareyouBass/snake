namespace Fortnite
{
    partial class Shop
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
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StandartBox = new System.Windows.Forms.PictureBox();
            this.RedBox = new System.Windows.Forms.PictureBox();
            this.Moneyt = new System.Windows.Forms.Label();
            this.StandartSkin = new System.Windows.Forms.RadioButton();
            this.RedSkin = new System.Windows.Forms.RadioButton();
            this.GreenBerryBox = new System.Windows.Forms.PictureBox();
            this.PurpleBerryBox = new System.Windows.Forms.PictureBox();
            this.GreenBerryC = new System.Windows.Forms.RadioButton();
            this.PurpleBerryC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuyRedSnake = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuyPurpleBerry = new System.Windows.Forms.Button();
            this.PurchaseResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StandartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBerryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurpleBerryBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Green;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.Back.FlatAppearance.BorderSize = 2;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back.Location = new System.Drawing.Point(12, 378);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(125, 60);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StandartBox
            // 
            this.StandartBox.Location = new System.Drawing.Point(54, 112);
            this.StandartBox.Name = "StandartBox";
            this.StandartBox.Size = new System.Drawing.Size(150, 50);
            this.StandartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StandartBox.TabIndex = 2;
            this.StandartBox.TabStop = false;
            // 
            // RedBox
            // 
            this.RedBox.Location = new System.Drawing.Point(54, 168);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(150, 50);
            this.RedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedBox.TabIndex = 3;
            this.RedBox.TabStop = false;
            // 
            // Moneyt
            // 
            this.Moneyt.AutoSize = true;
            this.Moneyt.Font = new System.Drawing.Font("MKMEGADRIVE", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Moneyt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Moneyt.Location = new System.Drawing.Point(611, 36);
            this.Moneyt.Name = "Moneyt";
            this.Moneyt.Size = new System.Drawing.Size(108, 18);
            this.Moneyt.TabIndex = 4;
            this.Moneyt.Text = "Монеты:0";
            // 
            // StandartSkin
            // 
            this.StandartSkin.AutoSize = true;
            this.StandartSkin.Font = new System.Drawing.Font("MKMEGADRIVE", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StandartSkin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StandartSkin.Location = new System.Drawing.Point(5, 18);
            this.StandartSkin.Name = "StandartSkin";
            this.StandartSkin.Size = new System.Drawing.Size(153, 19);
            this.StandartSkin.TabIndex = 5;
            this.StandartSkin.TabStop = true;
            this.StandartSkin.Text = "Обычная змея";
            this.StandartSkin.UseVisualStyleBackColor = true;
            // 
            // RedSkin
            // 
            this.RedSkin.AutoSize = true;
            this.RedSkin.Font = new System.Drawing.Font("MKMEGADRIVE", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedSkin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RedSkin.Location = new System.Drawing.Point(6, 75);
            this.RedSkin.Name = "RedSkin";
            this.RedSkin.Size = new System.Drawing.Size(152, 19);
            this.RedSkin.TabIndex = 6;
            this.RedSkin.TabStop = true;
            this.RedSkin.Text = "Красная змея";
            this.RedSkin.UseVisualStyleBackColor = true;
            // 
            // GreenBerryBox
            // 
            this.GreenBerryBox.Location = new System.Drawing.Point(629, 112);
            this.GreenBerryBox.Name = "GreenBerryBox";
            this.GreenBerryBox.Size = new System.Drawing.Size(50, 50);
            this.GreenBerryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenBerryBox.TabIndex = 7;
            this.GreenBerryBox.TabStop = false;
            // 
            // PurpleBerryBox
            // 
            this.PurpleBerryBox.Location = new System.Drawing.Point(629, 168);
            this.PurpleBerryBox.Name = "PurpleBerryBox";
            this.PurpleBerryBox.Size = new System.Drawing.Size(50, 50);
            this.PurpleBerryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PurpleBerryBox.TabIndex = 8;
            this.PurpleBerryBox.TabStop = false;
            // 
            // GreenBerryC
            // 
            this.GreenBerryC.AutoSize = true;
            this.GreenBerryC.Font = new System.Drawing.Font("MKMEGADRIVE", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenBerryC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GreenBerryC.Location = new System.Drawing.Point(41, 18);
            this.GreenBerryC.Name = "GreenBerryC";
            this.GreenBerryC.Size = new System.Drawing.Size(164, 19);
            this.GreenBerryC.TabIndex = 9;
            this.GreenBerryC.TabStop = true;
            this.GreenBerryC.Text = "Зелёная Вишня";
            this.GreenBerryC.UseVisualStyleBackColor = true;
            // 
            // PurpleBerryC
            // 
            this.PurpleBerryC.AutoSize = true;
            this.PurpleBerryC.Font = new System.Drawing.Font("MKMEGADRIVE", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PurpleBerryC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PurpleBerryC.Location = new System.Drawing.Point(6, 74);
            this.PurpleBerryC.Name = "PurpleBerryC";
            this.PurpleBerryC.Size = new System.Drawing.Size(199, 19);
            this.PurpleBerryC.TabIndex = 10;
            this.PurpleBerryC.TabStop = true;
            this.PurpleBerryC.Text = "Фиолетовая вишня";
            this.PurpleBerryC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StandartSkin);
            this.groupBox1.Controls.Add(this.RedSkin);
            this.groupBox1.Location = new System.Drawing.Point(218, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  ";
            // 
            // BuyRedSnake
            // 
            this.BuyRedSnake.BackColor = System.Drawing.Color.Green;
            this.BuyRedSnake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyRedSnake.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.BuyRedSnake.FlatAppearance.BorderSize = 2;
            this.BuyRedSnake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyRedSnake.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyRedSnake.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuyRedSnake.Location = new System.Drawing.Point(230, 161);
            this.BuyRedSnake.Name = "BuyRedSnake";
            this.BuyRedSnake.Size = new System.Drawing.Size(125, 60);
            this.BuyRedSnake.TabIndex = 13;
            this.BuyRedSnake.Text = "10000";
            this.BuyRedSnake.UseVisualStyleBackColor = false;
            this.BuyRedSnake.Click += new System.EventHandler(this.BuyRedSnake_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GreenBerryC);
            this.groupBox2.Controls.Add(this.PurpleBerryC);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(413, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   ";
            // 
            // BuyPurpleBerry
            // 
            this.BuyPurpleBerry.BackColor = System.Drawing.Color.Green;
            this.BuyPurpleBerry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyPurpleBerry.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.BuyPurpleBerry.FlatAppearance.BorderSize = 2;
            this.BuyPurpleBerry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyPurpleBerry.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyPurpleBerry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuyPurpleBerry.Location = new System.Drawing.Point(477, 160);
            this.BuyPurpleBerry.Name = "BuyPurpleBerry";
            this.BuyPurpleBerry.Size = new System.Drawing.Size(125, 60);
            this.BuyPurpleBerry.TabIndex = 14;
            this.BuyPurpleBerry.Text = "50000";
            this.BuyPurpleBerry.UseVisualStyleBackColor = false;
            this.BuyPurpleBerry.Click += new System.EventHandler(this.BuyPurpleBerry_Click);
            // 
            // PurchaseResult
            // 
            this.PurchaseResult.AutoSize = true;
            this.PurchaseResult.Location = new System.Drawing.Point(203, 355);
            this.PurchaseResult.Name = "PurchaseResult";
            this.PurchaseResult.Size = new System.Drawing.Size(0, 13);
            this.PurchaseResult.TabIndex = 15;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PurchaseResult);
            this.Controls.Add(this.BuyPurpleBerry);
            this.Controls.Add(this.BuyRedSnake);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PurpleBerryBox);
            this.Controls.Add(this.GreenBerryBox);
            this.Controls.Add(this.Moneyt);
            this.Controls.Add(this.RedBox);
            this.Controls.Add(this.StandartBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StandartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBerryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurpleBerryBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox StandartBox;
        private System.Windows.Forms.PictureBox RedBox;
        private System.Windows.Forms.Label Moneyt;
        private System.Windows.Forms.RadioButton StandartSkin;
        private System.Windows.Forms.RadioButton RedSkin;
        private System.Windows.Forms.PictureBox GreenBerryBox;
        private System.Windows.Forms.PictureBox PurpleBerryBox;
        private System.Windows.Forms.RadioButton GreenBerryC;
        private System.Windows.Forms.RadioButton PurpleBerryC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuyRedSnake;
        private System.Windows.Forms.Button BuyPurpleBerry;
        private System.Windows.Forms.Label PurchaseResult;
    }
}