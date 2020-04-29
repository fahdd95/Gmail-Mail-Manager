using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailMailManager
{
    public partial class MainForm : Form
    {
        // That's our custom TextWriter class
        TextWriter _writer = null;

        //Detect Screen Size
        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        //Storge Drag Status
        bool drag = false;
        //Storage Cursor Start Point         
        Point start_point = new Point(0, 0);       
        Size StockSize = new Size(640,500);
        public MainForm()
        {
            InitializeComponent();

            //Allow Resize Feature
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Size = StockSize  ;
        
        }
        //Allow Resize Feature
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);

        }  // Resize Feature
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Instantiate the writer
            _writer = new TextBoxStreamWriter(txtConsole);
            // Redirect the out Console stream
            Console.SetOut(_writer);

            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseDown
            // Storing Cursor Start Point and Allow Drag feature 
            drag = true;
            start_point = new Point(e.X, e.Y);

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

        private void TopPanelLabel_Click(object sender, EventArgs e)
        {

        }

        private void TopPanelLabel_DoubleClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void GmailAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProgramDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProgramDes_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GmailAddressTextBox_Enter(object sender, EventArgs e)
        {
             if (GmailAddressTextBox.Text == "example@gmail.com")
            {
                GmailAddressTextBox.Text = "";
                GmailAddressTextBox.ForeColor = Color.FromArgb(220, 220, 170);
            }
        }

        private void GmailAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (GmailAddressTextBox.Text == "" )
            {
                GmailAddressTextBox.Text = "example@gmail.com";
                GmailAddressTextBox.ForeColor = Color.Gray;
            }

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved_1(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://console.developers.google.com/apis/credentials/consent");
        }

        private void Enableapi_Click(object sender, EventArgs e)
        {

        }

        private void fromproject_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Appnametextbox_Enter(object sender, EventArgs e)
        {
           if (Appnametextbox.Text == "from created project")
           {
                Appnametextbox.Text = "";
                Appnametextbox.ForeColor = Color.FromArgb(220,220, 170);
           }
        }

        private void Appnametextbox_Leave(object sender, EventArgs e)
        {
            if (Appnametextbox.Text == "")
            {
                Appnametextbox.Text = "from created project";
                Appnametextbox.ForeColor = Color.Gray;
            }
        }

        private void DownloadCredentials_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://console.developers.google.com/apis/credentials");
        }

        private void credentialslabel_Click(object sender, EventArgs e)
        {

        }

        private void GmailAddressLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void close2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void StartTrash_Click(object sender, EventArgs e)
        {
            if (Appnametextbox.Text != "" && Appnametextbox.Text != "from created project")
            {
                if (GmailAddressTextBox.Text != "" && GmailAddressTextBox.Text != "example@gmail.com")
                {
       
                    Program.MoveAllMessagesToTrash(Appnametextbox.Text, GmailAddressTextBox.Text);
                }
                else
                {
                   Console.WriteLine("Application Name or Gmail Address is empty");
                }
            }else {
                   Console.WriteLine("Application Name or Gmail Address is empty"); 
                  }

           
        }

        private void ConsoleOutPut_TextChanged(object sender, EventArgs e)
        {

        }

        private void untrash_Click(object sender, EventArgs e)
        {
            if (Appnametextbox.Text != "" && Appnametextbox.Text != "from created project")
            {
                if (GmailAddressTextBox.Text != "" && GmailAddressTextBox.Text != "example@gmail.com")
                {
                    Program.UntrashAndUnspamAllMessages(Appnametextbox.Text, GmailAddressTextBox.Text);
                }
                else
                {
                    Console.WriteLine("Application Name or Gmail Address is empty");
                }
            }
            else
            {
                Console.WriteLine("Application Name or Gmail Address is empty");
            }
        }

        private void locatecredentials_Click(object sender, EventArgs e)
        {         
            DialogResult result = locate.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = locate.FileName;
                string directoryPath = Path.GetDirectoryName(file);
                Console.WriteLine(file); // <-- Shows file size in debugging mode.
            }
     
        }
    }
}
