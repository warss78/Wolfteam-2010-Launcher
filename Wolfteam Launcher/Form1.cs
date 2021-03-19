using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolfteam_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            close.MouseEnter += OnMouseEnterButton1;
            close.MouseLeave += OnMouseLeaveButton1;
            minimize.MouseEnter += OnMouseEnterButton1;
            minimize.MouseLeave += OnMouseLeaveButton1;

        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            close.Image = global::Wolfteam_Launcher.Properties.Resources.close_hover;
            minimize.Image = global::Wolfteam_Launcher.Properties.Resources.minimize1;
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            close.Image = global::Wolfteam_Launcher.Properties.Resources.s1ys0;
            minimize.Image = global::Wolfteam_Launcher.Properties.Resources._123sys0;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.log.AutoSize = false;
            //this.log.Size = new System.Drawing.Size(101, 49);
            //this.id.Size = new System.Drawing.Size(109, 16);
           // this.pw.Size = new System.Drawing.Size(109, 16);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 30;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {  
           close.Image = global::Wolfteam_Launcher.Properties.Resources.close_hover;
           Application.Exit();


        }

        private void minimize_Click(object sender, EventArgs e)
        {

        }
    }
}
