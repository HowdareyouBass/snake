namespace Fortnite
{
    partial class SettingsMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Middle = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Reset = new System.Windows.Forms.Button();
            this.ResetText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MKMEGADRIVE", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(160, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сложность:";
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
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hard);
            this.panel1.Controls.Add(this.Middle);
            this.panel1.Controls.Add(this.Easy);
            this.panel1.Location = new System.Drawing.Point(318, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 80);
            this.panel1.TabIndex = 4;
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Font = new System.Drawing.Font("MKMEGADRIVE", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hard.Location = new System.Drawing.Point(4, 51);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(78, 15);
            this.Hard.TabIndex = 2;
            this.Hard.TabStop = true;
            this.Hard.Text = "Сложно";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Middle
            // 
            this.Middle.AutoSize = true;
            this.Middle.Font = new System.Drawing.Font("MKMEGADRIVE", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Middle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Middle.Location = new System.Drawing.Point(4, 27);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(77, 15);
            this.Middle.TabIndex = 1;
            this.Middle.TabStop = true;
            this.Middle.Text = "Средне";
            this.Middle.UseVisualStyleBackColor = true;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Font = new System.Drawing.Font("MKMEGADRIVE", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Easy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Easy.Location = new System.Drawing.Point(4, 4);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(67, 15);
            this.Easy.TabIndex = 0;
            this.Easy.TabStop = true;
            this.Easy.Text = "Легко";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Green;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.Reset.FlatAppearance.BorderSize = 2;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset.Location = new System.Drawing.Point(663, 378);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(125, 60);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Сбросить прогресс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ResetText
            // 
            this.ResetText.AutoSize = true;
            this.ResetText.Font = new System.Drawing.Font("MKMEGADRIVE", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResetText.Location = new System.Drawing.Point(208, 392);
            this.ResetText.Name = "ResetText";
            this.ResetText.Size = new System.Drawing.Size(0, 24);
            this.ResetText.TabIndex = 6;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetText);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Middle;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label ResetText;
    }
}