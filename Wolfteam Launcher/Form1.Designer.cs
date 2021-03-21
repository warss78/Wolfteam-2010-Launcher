
namespace Wolfteam_Launcher
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picboxPB2 = new System.Windows.Forms.PictureBox();
            this.picboxPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.game_wolfteam = new System.Windows.Forms.Panel();
            this.Game_Rakion = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.picboxPB2);
            this.panel1.Controls.Add(this.picboxPB);
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
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(14, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 43);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // picboxPB2
            // 
            this.picboxPB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.picboxPB2.Location = new System.Drawing.Point(161, 543);
            this.picboxPB2.Name = "picboxPB2";
            this.picboxPB2.Size = new System.Drawing.Size(390, 10);
            this.picboxPB2.TabIndex = 10;
            this.picboxPB2.TabStop = false;
            // 
            // picboxPB
            // 
            this.picboxPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(181)))), ((int)(((byte)(235)))));
            this.picboxPB.Location = new System.Drawing.Point(161, 527);
            this.picboxPB.Name = "picboxPB";
            this.picboxPB.Size = new System.Drawing.Size(390, 10);
            this.picboxPB.TabIndex = 9;
            this.picboxPB.TabStop = false;
            this.picboxPB.Click += new System.EventHandler(this.picboxPB_Click);
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
            this.game_wolfteam.Click += new System.EventHandler(this.game_wolfteam_Click);
            this.game_wolfteam.Paint += new System.Windows.Forms.PaintEventHandler(this.game_wolfteam_Paint);
            this.game_wolfteam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_wolfteam_MouseClick);
            // 
            // Game_Rakion
            // 
            this.Game_Rakion.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.sselectgame_rakionimgc;
            this.Game_Rakion.Location = new System.Drawing.Point(30, 80);
            this.Game_Rakion.Name = "Game_Rakion";
            this.Game_Rakion.Size = new System.Drawing.Size(184, 100);
            this.Game_Rakion.TabIndex = 6;
            this.Game_Rakion.Click += new System.EventHandler(this.Game_Rakion_Click);
            this.Game_Rakion.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Rakion_Paint);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources._123sys0;
            this.minimize.Location = new System.Drawing.Point(743, 5);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(19, 19);
            this.minimize.TabIndex = 4;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.s1ys01;
            this.close.Location = new System.Drawing.Point(765, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(19, 19);
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.pictureBox1_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.progressBar2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(33, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 319);
            this.panel3.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.White;
            this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.progressBar2.Location = new System.Drawing.Point(758, 246);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(390, 10);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(145)))), ((int)(((byte)(190)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.progressBar1.Location = new System.Drawing.Point(758, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.White;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.log.Location = new System.Drawing.Point(35, 516);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(101, 49);
            this.log.TabIndex = 1;
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
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // test
            // 
            this.test.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel game_wolfteam;
        private System.Windows.Forms.Panel Game_Rakion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer test;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picboxPB;
        private System.Windows.Forms.PictureBox picboxPB2;
        private System.Windows.Forms.Panel panel4;
    }
}

