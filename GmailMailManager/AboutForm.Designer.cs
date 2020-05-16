namespace GmailMailManager
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.close2 = new System.Windows.Forms.Button();
            this.Sourcecode = new System.Windows.Forms.Button();
            this.ProgramDes = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TopPanel.Controls.Add(this.TopPanelLabel);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(335, 25);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint_1);
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
            // 
            // Close
            // 
            this.Close.BackgroundImage = global::GmailMailManager.Properties.Resources.Close2;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Close.Location = new System.Drawing.Point(300, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 25);
            this.Close.TabIndex = 2;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // close2
            // 
            this.close2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.close2.Location = new System.Drawing.Point(234, 219);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(89, 23);
            this.close2.TabIndex = 21;
            this.close2.Text = "Close";
            this.close2.UseVisualStyleBackColor = true;
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // Sourcecode
            // 
            this.Sourcecode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sourcecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sourcecode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Sourcecode.Location = new System.Drawing.Point(6, 219);
            this.Sourcecode.Name = "Sourcecode";
            this.Sourcecode.Size = new System.Drawing.Size(102, 23);
            this.Sourcecode.TabIndex = 22;
            this.Sourcecode.Text = "Sourcecode";
            this.Sourcecode.UseVisualStyleBackColor = true;
            this.Sourcecode.Click += new System.EventHandler(this.Sourcecode_Click);
            // 
            // ProgramDes
            // 
            this.ProgramDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ProgramDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ProgramDes.Location = new System.Drawing.Point(6, 31);
            this.ProgramDes.Multiline = true;
            this.ProgramDes.Name = "ProgramDes";
            this.ProgramDes.ReadOnly = true;
            this.ProgramDes.Size = new System.Drawing.Size(329, 182);
            this.ProgramDes.TabIndex = 23;
            this.ProgramDes.Text = "Gmail Mail Manager is a tiny program allows you using your Gmail address and Gmai" +
    "l API service to move all your mails to trash after that you can empty your tras" +
    "h by one click.";
            this.ProgramDes.TextChanged += new System.EventHandler(this.ProgramDes_TextChanged);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(335, 254);
            this.Controls.Add(this.ProgramDes);
            this.Controls.Add(this.Sourcecode);
            this.Controls.Add(this.close2);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TopPanelLabel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button close2;
        private System.Windows.Forms.Button Sourcecode;
        private System.Windows.Forms.TextBox ProgramDes;
    }
}