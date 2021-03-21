
namespace Wolfteam_Launcher
{
    partial class Rakion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rakion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.game_wolfteam = new System.Windows.Forms.Panel();
            this.Game_Rakion = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.game_wolfteam);
            this.panel1.Controls.Add(this.Game_Rakion);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 600);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wolfteam_Launcher.Properties.Resources.selectgame_rakionimgc;
            this.pictureBox1.Location = new System.Drawing.Point(835, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // game_wolfteam
            // 
            this.game_wolfteam.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.selectgame_wolfteamm;
            this.game_wolfteam.Location = new System.Drawing.Point(223, 80);
            this.game_wolfteam.Name = "game_wolfteam";
            this.game_wolfteam.Size = new System.Drawing.Size(184, 100);
            this.game_wolfteam.TabIndex = 7;
            // 
            // Game_Rakion
            // 
            this.Game_Rakion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Game_Rakion.BackgroundImage")));
            this.Game_Rakion.Location = new System.Drawing.Point(30, 80);
            this.Game_Rakion.Name = "Game_Rakion";
            this.Game_Rakion.Size = new System.Drawing.Size(184, 100);
            this.Game_Rakion.TabIndex = 6;
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources._123sys0;
            this.minimize.Location = new System.Drawing.Point(745, 5);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(19, 19);
            this.minimize.TabIndex = 4;
            this.minimize.TabStop = false;
            // 
            // close
            // 
            this.close.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.s1ys01;
            this.close.Location = new System.Drawing.Point(765, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(19, 19);
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(33, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 319);
            this.panel3.TabIndex = 2;
            // 
            // log
            // 
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(35, 515);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(101, 49);
            this.log.TabIndex = 1;
            this.log.Text = "Başlatılıyor... Yakında";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(34, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 319);
            this.panel2.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Wolfteam_Launcher.Properties.Resources.selectgame_comingsoon;
            this.pictureBox2.Location = new System.Drawing.Point(140, 516);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(449, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Rakion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Rakion";
            this.Text = "Rakion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel game_wolfteam;
        private System.Windows.Forms.Panel Game_Rakion;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}