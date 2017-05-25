namespace SecConvClient
{
    partial class SecConv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecConv));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tSBContact = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BDeleteFriend = new System.Windows.Forms.Button();
            this.BAddFriend = new System.Windows.Forms.Button();
            this.BCall = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.BDeleteAccount = new System.Windows.Forms.Button();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BChangePassword = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTipPass1 = new System.Windows.Forms.Button();
            this.TPassword2 = new System.Windows.Forms.TextBox();
            this.TPassword1 = new System.Windows.Forms.TextBox();
            this.TPasswordOld = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tSBContact});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(319, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton1.Text = "Wyloguj";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tSBContact
            // 
            this.tSBContact.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBContact.AutoToolTip = false;
            this.tSBContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBContact.ForeColor = System.Drawing.Color.Black;
            this.tSBContact.Image = ((System.Drawing.Image)(resources.GetObject("tSBContact.Image")));
            this.tSBContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBContact.Name = "tSBContact";
            this.tSBContact.Size = new System.Drawing.Size(52, 22);
            this.tSBContact.Text = "Kontakt";
            this.tSBContact.Click += new System.EventHandler(this.tSBContact_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.BDeleteFriend);
            this.tabPage1.Controls.Add(this.BAddFriend);
            this.tabPage1.Controls.Add(this.BCall);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 422);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Kontakty";
            // 
            // BDeleteFriend
            // 
            this.BDeleteFriend.BackgroundImage = global::SecConvClient.Properties.Resources.sub;
            this.BDeleteFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BDeleteFriend.Location = new System.Drawing.Point(214, 16);
            this.BDeleteFriend.Name = "BDeleteFriend";
            this.BDeleteFriend.Size = new System.Drawing.Size(61, 61);
            this.BDeleteFriend.TabIndex = 4;
            this.BDeleteFriend.UseVisualStyleBackColor = true;
            this.BDeleteFriend.Click += new System.EventHandler(this.BDeleteFriend_Click);
            // 
            // BAddFriend
            // 
            this.BAddFriend.BackgroundImage = global::SecConvClient.Properties.Resources.add;
            this.BAddFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAddFriend.Location = new System.Drawing.Point(127, 16);
            this.BAddFriend.Name = "BAddFriend";
            this.BAddFriend.Size = new System.Drawing.Size(61, 61);
            this.BAddFriend.TabIndex = 3;
            this.BAddFriend.UseVisualStyleBackColor = true;
            this.BAddFriend.Click += new System.EventHandler(this.BAddFriend_Click);
            // 
            // BCall
            // 
            this.BCall.BackgroundImage = global::SecConvClient.Properties.Resources.call;
            this.BCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCall.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BCall.Location = new System.Drawing.Point(38, 16);
            this.BCall.Name = "BCall";
            this.BCall.Size = new System.Drawing.Size(61, 61);
            this.BCall.TabIndex = 2;
            this.BCall.UseVisualStyleBackColor = true;
            this.BCall.Click += new System.EventHandler(this.BCall_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login,
            this.IP});
            this.listView1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(0, 93);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 320);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Login
            // 
            this.Login.Text = "Znajomy";
            this.Login.Width = 310;
            // 
            // IP
            // 
            this.IP.Width = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "unavailable.png");
            this.imageList1.Images.SetKeyName(1, "available.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 448);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 422);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Historia";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listView2.FullRowSelect = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.Location = new System.Drawing.Point(-1, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(312, 412);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Znajomy";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kiedy";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Czas trwania";
            this.columnHeader4.Width = 85;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(312, 422);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Ustawienia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.BDeleteAccount);
            this.groupBox2.Controls.Add(this.TPassword);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(7, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuń konto";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.IndianRed;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(205, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 26);
            this.button6.TabIndex = 16;
            this.button6.TabStop = false;
            this.button6.Text = "?";
            this.toolTip1.SetToolTip(this.button6, "Podaj obecne hasło");
            this.button6.UseVisualStyleBackColor = false;
            // 
            // BDeleteAccount
            // 
            this.BDeleteAccount.BackColor = System.Drawing.Color.Brown;
            this.BDeleteAccount.FlatAppearance.BorderSize = 0;
            this.BDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDeleteAccount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BDeleteAccount.Location = new System.Drawing.Point(54, 97);
            this.BDeleteAccount.Name = "BDeleteAccount";
            this.BDeleteAccount.Size = new System.Drawing.Size(145, 26);
            this.BDeleteAccount.TabIndex = 17;
            this.BDeleteAccount.Text = "Usuń konto";
            this.toolTip1.SetToolTip(this.BDeleteAccount, "Usunięcia konta nie można cofnąć!");
            this.BDeleteAccount.UseVisualStyleBackColor = false;
            this.BDeleteAccount.Click += new System.EventHandler(this.BDeleteAccount_Click);
            // 
            // TPassword
            // 
            this.TPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword.Location = new System.Drawing.Point(54, 65);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(145, 26);
            this.TPassword.TabIndex = 16;
            this.TPassword.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BChangePassword);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.BTipPass1);
            this.groupBox1.Controls.Add(this.TPassword2);
            this.groupBox1.Controls.Add(this.TPassword1);
            this.groupBox1.Controls.Add(this.TPasswordOld);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(7, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zmień hasło";
            // 
            // BChangePassword
            // 
            this.BChangePassword.BackColor = System.Drawing.Color.Brown;
            this.BChangePassword.FlatAppearance.BorderSize = 0;
            this.BChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BChangePassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BChangePassword.Location = new System.Drawing.Point(54, 128);
            this.BChangePassword.Name = "BChangePassword";
            this.BChangePassword.Size = new System.Drawing.Size(145, 26);
            this.BChangePassword.TabIndex = 15;
            this.BChangePassword.Text = "Zmień hasło";
            this.BChangePassword.UseVisualStyleBackColor = false;
            this.BChangePassword.Click += new System.EventHandler(this.BChangePassword_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(205, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 26);
            this.button4.TabIndex = 14;
            this.button4.TabStop = false;
            this.button4.Text = "?";
            this.toolTip1.SetToolTip(this.button4, "Wpisz nowe hasło powtórnie");
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(205, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 26);
            this.button3.TabIndex = 13;
            this.button3.TabStop = false;
            this.button3.Text = "?";
            this.toolTip1.SetToolTip(this.button3, "Wpisz nowe hasło.\r\nHasło musi być co najmniej 8 znakowe\r\ni spełniać poniższe wyma" +
        "gania:\r\n- minimum 1 cyfra,\r\n- minimum 1 wielka litera,\r\n- minimum 1 mała litera." +
        "");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // BTipPass1
            // 
            this.BTipPass1.BackColor = System.Drawing.Color.IndianRed;
            this.BTipPass1.FlatAppearance.BorderSize = 0;
            this.BTipPass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTipPass1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BTipPass1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTipPass1.Location = new System.Drawing.Point(205, 32);
            this.BTipPass1.Name = "BTipPass1";
            this.BTipPass1.Size = new System.Drawing.Size(28, 26);
            this.BTipPass1.TabIndex = 12;
            this.BTipPass1.TabStop = false;
            this.BTipPass1.Text = "?";
            this.toolTip1.SetToolTip(this.BTipPass1, "Podaj obecne hasło");
            this.BTipPass1.UseVisualStyleBackColor = false;
            // 
            // TPassword2
            // 
            this.TPassword2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword2.Location = new System.Drawing.Point(54, 96);
            this.TPassword2.Name = "TPassword2";
            this.TPassword2.Size = new System.Drawing.Size(145, 26);
            this.TPassword2.TabIndex = 9;
            this.TPassword2.UseSystemPasswordChar = true;
            // 
            // TPassword1
            // 
            this.TPassword1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword1.Location = new System.Drawing.Point(54, 64);
            this.TPassword1.Name = "TPassword1";
            this.TPassword1.Size = new System.Drawing.Size(145, 26);
            this.TPassword1.TabIndex = 8;
            this.TPassword1.UseSystemPasswordChar = true;
            // 
            // TPasswordOld
            // 
            this.TPasswordOld.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPasswordOld.Location = new System.Drawing.Point(54, 32);
            this.TPasswordOld.Name = "TPasswordOld";
            this.TPasswordOld.Size = new System.Drawing.Size(145, 26);
            this.TPasswordOld.TabIndex = 7;
            this.TPasswordOld.UseSystemPasswordChar = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SecConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(319, 476);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SecConv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecConv_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBContact;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.Button BCall;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BDeleteFriend;
        private System.Windows.Forms.Button BAddFriend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TPassword2;
        private System.Windows.Forms.TextBox TPassword1;
        private System.Windows.Forms.TextBox TPasswordOld;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BTipPass1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BDeleteAccount;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Button BChangePassword;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.Timer timer1;
    }
}