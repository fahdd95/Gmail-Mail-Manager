using System;
using System.Drawing;
using System.Windows.Forms;

namespace GmailMailManager
{
    public partial class AboutForm : Form
    {


        //Detect Screen Size
        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        //Storge Drag Status
        bool drag = false;
        //Storage Cursor Start Point         
        Point start_point = new Point(0, 0);
        Size StockSize = new Size(335, 254);

        public AboutForm()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //MouseUp

            Size Half = StockSize;
            Point p = PointToScreen(e.Location);
            //Console.WriteLine(p);
            if (p.Y == 0)        //if cursor location on the top edge
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (p.X == 0)   //if cursor location on the left edge
            {

                int w = screen.Width / 2;
                int h = screen.Height;
                this.Size = new Size(w, h);
                this.Location = new Point(0, 0);

            }
            else if (p.X == screen.Width - 1)  //if cursor location on the right edge
            {
                int w = screen.Width / 2;
                int h = screen.Height;
                this.Size = new Size(w, h);
                this.Location = new Point(screen.Width / 2, 0);
            }
            else if (this.WindowState == FormWindowState.Maximized && start_point.Y == 0) //if cursor location on the top edge and the form Maximized
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
                this.Size = Half;
            }
            else if (this.WindowState == FormWindowState.Normal && start_point.Y <= 25)    //if cursor location on the top edge and the form Normal
            {
                this.Size = Half;
            }

            drag = false;
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //MouseMove
            if (drag)
            {
                //Calculate Current Cursor Location
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }
        }

        private void Toppanel_DoubleClick(object sender, EventArgs e)
        {

        }

        private void TopPanel_DoubleClick_1(object sender, EventArgs e)
        {
            // Double click to maximize or reset normal
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseDown
            // Storing Cursor Start Point and Allow Drag feature 
            drag = true;
            start_point = new Point(e.X, e.Y);

        }

        private void TopPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sourcecode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fahdd95/Gmail-Mail-Manager");
        }
    }
}
