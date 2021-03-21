using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Wolfteam_Launcher
{
    public partial class Login : Form
    {
        public Point MouseDownLocation { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackgroundImage = Properties.Resources.start_hover;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackgroundImage = Properties.Resources.start_normal;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel5.BackgroundImage = Properties.Resources.start_click;
            ProcessStartInfo wolfteam = new ProcessStartInfo
            {
                FileName = "Server2.exe",
                CreateNoWindow = true,
                Arguments = id.Text + " 7761727373313233 15"


            };
            Process.Start(wolfteam);
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackgroundImage = Properties.Resources.selecgame_option_hover;

        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackgroundImage = Properties.Resources.selectgame_option;

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel6.BackgroundImage = Properties.Resources.selecgame_option_click;

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown;
        private Point lastLocation;
        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //drag is your variable flag.
            start_point = new Point(e.X, e.Y);
        }

        bool drag = false;
        Point start_point = new Point(0, 0);
        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
