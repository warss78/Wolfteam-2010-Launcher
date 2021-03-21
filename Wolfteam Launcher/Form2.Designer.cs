
namespace Wolfteam_Launcher
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pw = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 600);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.pw);
            this.panel4.Controls.Add(this.id);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel4.Location = new System.Drawing.Point(410, 519);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 43);
            this.panel4.TabIndex = 8;
            // 
            // pw
            // 
            this.pw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw.Font = new System.Drawing.Font("Calibri", 12F);
            this.pw.Location = new System.Drawing.Point(66, 26);
            this.pw.Margin = new System.Windows.Forms.Padding(300000000);
            this.pw.Multiline = true;
            this.pw.Name = "pw";
            this.pw.PasswordChar = '*';
            this.pw.Size = new System.Drawing.Size(109, 16);
            this.pw.TabIndex = 8;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.Location = new System.Drawing.Point(67, 1);
            this.id.Margin = new System.Windows.Forms.Padding(2000000);
            this.id.MaxLength = 12;
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(109, 13);
            this.id.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.progressBar2.Location = new System.Drawing.Point(181, 544);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(390, 10);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(100)))), ((int)(((byte)(166)))));
            this.progressBar1.Location = new System.Drawing.Point(181, 526);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(34, 186);
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
            // minimize
            // 
            this.minimize.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources._123sys0;
            this.minimize.Location = new System.Drawing.Point(748, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(19, 19);
            this.minimize.TabIndex = 6;
            this.minimize.TabStop = false;
            // 
            // close
            // 
            this.close.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.s1ys01;
            this.close.Location = new System.Drawing.Point(770, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(19, 19);
            this.close.TabIndex = 5;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
    }
}