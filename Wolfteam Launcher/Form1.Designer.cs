
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Game_Rakion = new System.Windows.Forms.Panel();
            this.game_wolfteam = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.game_wolfteam);
            this.panel1.Controls.Add(this.Game_Rakion);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources._123sys0;
            this.minimize.Location = new System.Drawing.Point(745, 5);
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
            this.log.Text = "Başlatılıyor Oyun Yaması";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(34, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 319);
            this.panel2.TabIndex = 0;
            // 
            // Game_Rakion
            // 
            this.Game_Rakion.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources._1selectgame_rakionimgc1;
            this.Game_Rakion.Location = new System.Drawing.Point(30, 80);
            this.Game_Rakion.Name = "Game_Rakion";
            this.Game_Rakion.Size = new System.Drawing.Size(184, 100);
            this.Game_Rakion.TabIndex = 6;
            // 
            // game_wolfteam
            // 
            this.game_wolfteam.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.selectgame_wolfteamm;
            this.game_wolfteam.Location = new System.Drawing.Point(223, 80);
            this.game_wolfteam.Name = "game_wolfteam";
            this.game_wolfteam.Size = new System.Drawing.Size(184, 100);
            this.game_wolfteam.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
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
    }
}

