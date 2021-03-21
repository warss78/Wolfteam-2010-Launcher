using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace Wolfteam_Launcher
{
    
    public partial class Form1 : Form
    {

        bool drag = false;
        Point start_point = new Point(0, 0);
       

        public Form1()
        {
            InitializeComponent();


        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //get picboxPB dimension
            pbWIDTH = picboxPB.Width;
            pbHEIGHT = picboxPB.Height;

            pbUnit = pbWIDTH / 100.0;

            //pbComplete - This is equal to work completed in % [min = 0 max = 100]
            pbComplete = 0;

            //create bitmap
            bmp = new Bitmap(pbWIDTH, pbHEIGHT);

            //timer
            t.Interval = 50;    //in millisecond
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            timer2.Start();
            //this.MinimumSize = new System.Drawing.Size(this.Width, Screen.PrimaryScreen.Bounds.Height);
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
            Application.Exit();



        }

        private void minimize_Click(object sender, EventArgs e)
        {

        }

        private void game_wolfteam_Paint(object sender, PaintEventArgs e)
        {
            timer4.Start();
        }

        private void game_wolfteam_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void game_wolfteam_Click(object sender, EventArgs e)
        {
            game_wolfteam.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.selectgame_wolfteam;
            test.Start();

        }

        private void Game_Rakion_Click(object sender, EventArgs e)
        {
            Game_Rakion.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.selectgame_rakionimgc;
            timer3.Start();




        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.closehover;

        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackgroundImage = global::Wolfteam_Launcher.Properties.Resources.s1ys0;
        }



        private void Game_Rakion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
            frm.Show();
            //Bu mevcut formu kapatıyorum.
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
            frm.Show();
            //Bu mevcut formu kapatıyorum.
            this.Hide();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            game_wolfteam.Visible = false;
            Game_Rakion.Visible = false;
            log.Text = "Başlatılıyor Launcher Yaması";

            progressBar1.Increment(1);
            progressBar2.Increment(1);



            if (progressBar1.Value == 100)
            {
                //timer1.Stop();//timerı durduruyoruz.
                progressBar2.Increment(1);
                if (progressBar2.Value == 100)
                {
                    log.Text = "Yama Bitti Lütfen Oyun Seçiniz";

                }
                //Messagebox ile uyarı veriyoruz.
            }




            log.Text = "Başlatılıyor Launcher Yaması";

            progressBar1.Increment(1);



            if (progressBar2.Value == 100)
            {

                log.Text = "Yama Bitti ";

                game_wolfteam.Visible = true;
                Game_Rakion.Visible = true;
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                //Messagebox ile uyarı veriyoruz.
                //panel4.Visible = false;
                test.Start();
                timer2.Stop();


            }



        }

        private void timer3_Tick(object sender, EventArgs e)
        {


            Image pbimage1 = Properties.Resources.selectgame_wolfteamm;//seçili olmayan wolfteam
            Image pbimage2 = Properties.Resources.selectgame_rakionimgc;//seçili olan rakion
            Image pbimage3 = Properties.Resources.sselectgame_rakionimgc; // seçili olmayan rakion
            Image pbimage4 = Properties.Resources.selectgame_wolfteam; // seçili olan wolftü


            if (Game_Rakion.BackgroundImage == pbimage2)
            {
                MessageBox.Show("salam");
            }
            else
                game_wolfteam.BackgroundImage = pbimage1;
            Game_Rakion.BackgroundImage = pbimage2;





        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Login login = new Login();
            Image pbimage1 = Properties.Resources.selectgame_wolfteamm;//seçili olmayan wolfteam
            Image pbimage2 = Properties.Resources.selectgame_rakionimgc;//seçili olan rakion
            Image pbimage3 = Properties.Resources.sselectgame_rakionimgc; // seçili olmayan rakion
            Image pbimage4 = Properties.Resources.selectgame_wolfteam; // seçili olan wolftü


            if (Game_Rakion.BackgroundImage == pbimage2)
            {
                MessageBox.Show("salam");
            }
            else
                game_wolfteam.BackgroundImage = pbimage4;
            Game_Rakion.BackgroundImage = pbimage3;


            login.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz
            test.Stop();



        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }


        Timer t = new Timer();

        //pb = ProgressBar
        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete;

        Bitmap bmp;

        private void picboxPB_Click(object sender, EventArgs e)
        {

        }
        private Point MouseDownLocation;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //drag is your variable flag.
            start_point = new Point(e.X, e.Y);
        }

        Graphics g;
        private bool mouseDown;
        private Point lastLocation;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //drag is your variable flag.
            start_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }
        private Point _mouseLoc;

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        

        

        private void t_Tick(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(0, 255 ,255) ; 


            SolidBrush myBrush = new SolidBrush(myColor);

            //graphics
            g = Graphics.FromImage(bmp);

            //clear graphics
            g.Clear(System.Drawing.ColorTranslator.FromHtml("#bfb5eb"));


            Color color = Color.FromArgb(126 ,114 ,176);
            Brush brush = new SolidBrush(color);

            //draw progressbar
            g.FillRectangle(brush, new Rectangle(0, 0, (int)(pbComplete * pbUnit), pbHEIGHT));

            //draw % complete
            g.DrawString(pbComplete + "%", new Font("Arial", pbHEIGHT / 2), Brushes.Black, new PointF(pbWIDTH / 2 - pbHEIGHT, pbHEIGHT / 10));

            //load bitmap in picturebox picboxPB
            picboxPB.Image = bmp;
            picboxPB2.Image = bmp;

            //update pbComplete
            //Note!
            //To keep things simple I am adding +1 to pbComplete every 50ms
            //You can change this as per your requirement :)
            pbComplete++;
            if (pbComplete > 100)
                
            {
                log.Text = "Yama Bitti";
                //dispose
                picboxPB.Visible = false;
                picboxPB2.Visible = false;
                g.Dispose();
                t.Stop();
            }



        }
    }
}
