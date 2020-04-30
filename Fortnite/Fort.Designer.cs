namespace Fortnite
{
    partial class Fort
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
            this.Score = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Monitor = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.youLoseText = new System.Windows.Forms.Label();
            this.youLose = new System.Windows.Forms.PictureBox();
            this.ScoreWas = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youLose)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(13, 13);
            this.Score.TabIndex = 0;
            this.Score.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(175, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Повторить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Monitor
            // 
            this.Monitor.BackColor = System.Drawing.SystemColors.Highlight;
            this.Monitor.Location = new System.Drawing.Point(0, 0);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(500, 500);
            this.Monitor.TabIndex = 3;
            this.Monitor.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // youLoseText
            // 
            this.youLoseText.AutoSize = true;
            this.youLoseText.Font = new System.Drawing.Font("MKMEGADRIVE", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.youLoseText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.youLoseText.Location = new System.Drawing.Point(67, 159);
            this.youLoseText.Name = "youLoseText";
            this.youLoseText.Size = new System.Drawing.Size(367, 47);
            this.youLoseText.TabIndex = 4;
            this.youLoseText.Text = "Ты Поиграл!";
            // 
            // youLose
            // 
            this.youLose.Location = new System.Drawing.Point(0, 0);
            this.youLose.Name = "youLose";
            this.youLose.Size = new System.Drawing.Size(100, 50);
            this.youLose.TabIndex = 5;
            this.youLose.TabStop = false;
            // 
            // ScoreWas
            // 
            this.ScoreWas.AutoSize = true;
            this.ScoreWas.Font = new System.Drawing.Font("MKMEGADRIVE", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreWas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreWas.Location = new System.Drawing.Point(175, 241);
            this.ScoreWas.Name = "ScoreWas";
            this.ScoreWas.Size = new System.Drawing.Size(26, 22);
            this.ScoreWas.TabIndex = 6;
            this.ScoreWas.Text = "0";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Green;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.Back.FlatAppearance.BorderSize = 2;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("MKMEGADRIVE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back.Location = new System.Drawing.Point(175, 345);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(125, 60);
            this.Back.TabIndex = 7;
            this.Back.Text = "Выход В Меню";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Fort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 497);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ScoreWas);
            this.Controls.Add(this.youLose);
            this.Controls.Add(this.youLoseText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Monitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fort";
            this.Text = "Fort";
            this.Load += new System.EventHandler(this.Fort_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fort_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youLose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Monitor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label youLoseText;
        private System.Windows.Forms.PictureBox youLose;
        private System.Windows.Forms.Label ScoreWas;
        private System.Windows.Forms.Button Back;
    }
}