namespace GmailMailManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelLabel = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ProgramDes = new System.Windows.Forms.TextBox();
            this.GmailAddressLabel = new System.Windows.Forms.Label();
            this.GmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.close2 = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.untrash = new System.Windows.Forms.Button();
            this.StartTrash = new System.Windows.Forms.Button();
            this.locatecredentials = new System.Windows.Forms.Button();
            this.credentialslabel = new System.Windows.Forms.Label();
            this.DownloadCredentials = new System.Windows.Forms.Button();
            this.Appnametextbox = new System.Windows.Forms.TextBox();
            this.Applicationnamelabel = new System.Windows.Forms.Label();
            this.fromproject = new System.Windows.Forms.Label();
            this.How = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.locate = new System.Windows.Forms.OpenFileDialog();
            this.TopPanel.SuspendLayout();
            this.MainPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TopPanel.Controls.Add(this.TopPanelLabel);
            this.TopPanel.Controls.Add(this.Minimize);
            this.TopPanel.Controls.Add(this.Maximize);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(640, 25);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            this.TopPanel.DoubleClick += new System.EventHandler(this.TopPanel_DoubleClick_1);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // TopPanelLabel
            // 
            this.TopPanelLabel.AutoSize = true;
            this.TopPanelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TopPanelLabel.Location = new System.Drawing.Point(3, 6);
            this.TopPanelLabel.Name = "TopPanelLabel";
            this.TopPanelLabel.Size = new System.Drawing.Size(94, 13);
            this.TopPanelLabel.TabIndex = 4;
            this.TopPanelLabel.Text = "GmailMailManager";
            this.TopPanelLabel.Click += new System.EventHandler(this.TopPanelLabel_Click);
            this.TopPanelLabel.DoubleClick += new System.EventHandler(this.TopPanelLabel_DoubleClick);
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = global::GmailMailManager.Properties.Resources.minus;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Minimize.Location = new System.Drawing.Point(535, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(35, 25);
            this.Minimize.TabIndex = 3;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.BackgroundImage = global::GmailMailManager.Properties.Resources.maximize;
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Maximize.Location = new System.Drawing.Point(570, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(35, 25);
            this.Maximize.TabIndex = 1;
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Close
            // 
            this.Close.BackgroundImage = global::GmailMailManager.Properties.Resources.Close2;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Close.Location = new System.Drawing.Point(605, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 25);
            this.Close.TabIndex = 2;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ProgramDes
            // 
            this.ProgramDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ProgramDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ProgramDes.Location = new System.Drawing.Point(6, 6);
            this.ProgramDes.Multiline = true;
            this.ProgramDes.Name = "ProgramDes";
            this.ProgramDes.ReadOnly = true;
            this.ProgramDes.Size = new System.Drawing.Size(522, 43);
            this.ProgramDes.TabIndex = 5;
            this.ProgramDes.Text = "Gmail Mail Manager is a tiny program allows you using your Gmail address and Gmai" +
    "l API service to move all your mails to trash after that you can empty your tras" +
    "h by one click.";
            this.ProgramDes.TextChanged += new System.EventHandler(this.ProgramDes_TextChanged_1);
            // 
            // GmailAddressLabel
            // 
            this.GmailAddressLabel.AutoSize = true;
            this.GmailAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.GmailAddressLabel.Location = new System.Drawing.Point(3, 197);
            this.GmailAddressLabel.Name = "GmailAddressLabel";
            this.GmailAddressLabel.Size = new System.Drawing.Size(89, 13);
            this.GmailAddressLabel.TabIndex = 6;
            this.GmailAddressLabel.Text = "4 - Gmail Address";
            this.GmailAddressLabel.Click += new System.EventHandler(this.GmailAddressLabel_Click_1);
            // 
            // GmailAddressTextBox
            // 
            this.GmailAddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.GmailAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GmailAddressTextBox.ForeColor = System.Drawing.Color.Gray;
            this.GmailAddressTextBox.Location = new System.Drawing.Point(110, 195);
            this.GmailAddressTextBox.Name = "GmailAddressTextBox";
            this.GmailAddressTextBox.Size = new System.Drawing.Size(254, 20);
            this.GmailAddressTextBox.TabIndex = 7;
            this.GmailAddressTextBox.Text = "example@gmail.com";
            this.GmailAddressTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.GmailAddressTextBox.Enter += new System.EventHandler(this.GmailAddressTextBox_Enter);
            this.GmailAddressTextBox.Leave += new System.EventHandler(this.GmailAddressTextBox_Leave);
            // 
            // MainPanel1
            // 
            this.MainPanel1.Controls.Add(this.CancelBtn);
            this.MainPanel1.Controls.Add(this.txtConsole);
            this.MainPanel1.Controls.Add(this.close2);
            this.MainPanel1.Controls.Add(this.About);
            this.MainPanel1.Controls.Add(this.untrash);
            this.MainPanel1.Controls.Add(this.StartTrash);
            this.MainPanel1.Controls.Add(this.locatecredentials);
            this.MainPanel1.Controls.Add(this.credentialslabel);
            this.MainPanel1.Controls.Add(this.DownloadCredentials);
            this.MainPanel1.Controls.Add(this.Appnametextbox);
            this.MainPanel1.Controls.Add(this.Applicationnamelabel);
            this.MainPanel1.Controls.Add(this.fromproject);
            this.MainPanel1.Controls.Add(this.How);
            this.MainPanel1.Controls.Add(this.button1);
            this.MainPanel1.Controls.Add(this.GmailAddressTextBox);
            this.MainPanel1.Controls.Add(this.GmailAddressLabel);
            this.MainPanel1.Controls.Add(this.ProgramDes);
            this.MainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel1.Location = new System.Drawing.Point(0, 25);
            this.MainPanel1.Name = "MainPanel1";
            this.MainPanel1.Size = new System.Drawing.Size(640, 475);
            this.MainPanel1.TabIndex = 5;
            this.MainPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CancelBtn.Location = new System.Drawing.Point(518, 290);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(102, 23);
            this.CancelBtn.TabIndex = 22;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsole.ForeColor = System.Drawing.Color.Gray;
            this.txtConsole.Location = new System.Drawing.Point(6, 335);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(441, 132);
            this.txtConsole.TabIndex = 21;
            this.txtConsole.TextChanged += new System.EventHandler(this.ConsoleOutPut_TextChanged);
            // 
            // close2
            // 
            this.close2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.close2.Location = new System.Drawing.Point(548, 442);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(89, 23);
            this.close2.TabIndex = 20;
            this.close2.Text = "Close";
            this.close2.UseVisualStyleBackColor = true;
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // About
            // 
            this.About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.About.Location = new System.Drawing.Point(453, 441);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(89, 23);
            this.About.TabIndex = 19;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // untrash
            // 
            this.untrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.untrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.untrash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.untrash.Location = new System.Drawing.Point(261, 290);
            this.untrash.Name = "untrash";
            this.untrash.Size = new System.Drawing.Size(231, 23);
            this.untrash.TabIndex = 18;
            this.untrash.Text = "Move all mails from trash";
            this.untrash.UseVisualStyleBackColor = true;
            this.untrash.Click += new System.EventHandler(this.untrash_Click);
            // 
            // StartTrash
            // 
            this.StartTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTrash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.StartTrash.Location = new System.Drawing.Point(16, 290);
            this.StartTrash.Name = "StartTrash";
            this.StartTrash.Size = new System.Drawing.Size(231, 23);
            this.StartTrash.TabIndex = 17;
            this.StartTrash.Text = "Move all mails to trash";
            this.StartTrash.UseVisualStyleBackColor = true;
            this.StartTrash.Click += new System.EventHandler(this.StartTrash_Click);
            // 
            // locatecredentials
            // 
            this.locatecredentials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.locatecredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locatecredentials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.locatecredentials.Location = new System.Drawing.Point(110, 150);
            this.locatecredentials.Name = "locatecredentials";
            this.locatecredentials.Size = new System.Drawing.Size(231, 23);
            this.locatecredentials.TabIndex = 16;
            this.locatecredentials.Text = "3 - Locate Credentials";
            this.locatecredentials.UseVisualStyleBackColor = true;
            this.locatecredentials.Click += new System.EventHandler(this.locatecredentials_Click);
            // 
            // credentialslabel
            // 
            this.credentialslabel.AutoSize = true;
            this.credentialslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.credentialslabel.Location = new System.Drawing.Point(3, 140);
            this.credentialslabel.Name = "credentialslabel";
            this.credentialslabel.Size = new System.Drawing.Size(59, 13);
            this.credentialslabel.TabIndex = 15;
            this.credentialslabel.Text = "Credentials";
            this.credentialslabel.Click += new System.EventHandler(this.credentialslabel_Click);
            // 
            // DownloadCredentials
            // 
            this.DownloadCredentials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DownloadCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadCredentials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.DownloadCredentials.Location = new System.Drawing.Point(110, 121);
            this.DownloadCredentials.Name = "DownloadCredentials";
            this.DownloadCredentials.Size = new System.Drawing.Size(231, 23);
            this.DownloadCredentials.TabIndex = 14;
            this.DownloadCredentials.Text = "2 - Create and Download Credentials";
            this.DownloadCredentials.UseVisualStyleBackColor = true;
            this.DownloadCredentials.Click += new System.EventHandler(this.DownloadCredentials_Click);
            // 
            // Appnametextbox
            // 
            this.Appnametextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Appnametextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Appnametextbox.ForeColor = System.Drawing.Color.Gray;
            this.Appnametextbox.Location = new System.Drawing.Point(110, 222);
            this.Appnametextbox.Name = "Appnametextbox";
            this.Appnametextbox.Size = new System.Drawing.Size(254, 20);
            this.Appnametextbox.TabIndex = 13;
            this.Appnametextbox.Text = "from created project";
            this.Appnametextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            this.Appnametextbox.Enter += new System.EventHandler(this.Appnametextbox_Enter);
            this.Appnametextbox.Leave += new System.EventHandler(this.Appnametextbox_Leave);
            // 
            // Applicationnamelabel
            // 
            this.Applicationnamelabel.AutoSize = true;
            this.Applicationnamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Applicationnamelabel.Location = new System.Drawing.Point(3, 223);
            this.Applicationnamelabel.Name = "Applicationnamelabel";
            this.Applicationnamelabel.Size = new System.Drawing.Size(105, 13);
            this.Applicationnamelabel.TabIndex = 12;
            this.Applicationnamelabel.Text = "5 - Application Name";
            // 
            // fromproject
            // 
            this.fromproject.AutoSize = true;
            this.fromproject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.fromproject.Location = new System.Drawing.Point(3, 99);
            this.fromproject.Name = "fromproject";
            this.fromproject.Size = new System.Drawing.Size(296, 13);
            this.fromproject.TabIndex = 11;
            this.fromproject.Text = "From your project put the application name and credential file.\r\n";
            this.fromproject.Click += new System.EventHandler(this.fromproject_Click);
            // 
            // How
            // 
            this.How.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.How.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.How.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.How.Location = new System.Drawing.Point(6, 42);
            this.How.Multiline = true;
            this.How.Name = "How";
            this.How.ReadOnly = true;
            this.How.Size = new System.Drawing.Size(337, 31);
            this.How.TabIndex = 10;
            this.How.Text = "The application works using OAuth.\r\nSo create your project at Google Api by click" +
    "ing on create project.";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(347, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "1 - Create Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // locate
            // 
            this.locate.DefaultExt = "json";
            this.locate.FileName = "Credentials";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(640, 500);
            this.Controls.Add(this.MainPanel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainPanel1.ResumeLayout(false);
            this.MainPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label TopPanelLabel;
        private System.Windows.Forms.TextBox ProgramDes;
        private System.Windows.Forms.Label GmailAddressLabel;
        private System.Windows.Forms.TextBox GmailAddressTextBox;
        private System.Windows.Forms.Panel MainPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox How;
        private System.Windows.Forms.Label fromproject;
        private System.Windows.Forms.Label Applicationnamelabel;
        private System.Windows.Forms.TextBox Appnametextbox;
        private System.Windows.Forms.Button locatecredentials;
        private System.Windows.Forms.Label credentialslabel;
        private System.Windows.Forms.Button DownloadCredentials;
        private System.Windows.Forms.Button untrash;
        private System.Windows.Forms.Button StartTrash;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button close2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.OpenFileDialog locate;
        private System.Windows.Forms.Button CancelBtn;
    }
}