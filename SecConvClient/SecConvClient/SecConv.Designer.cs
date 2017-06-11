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
            this.tSBLogOut = new System.Windows.Forms.ToolStripButton();
            this.tSBContact = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gBCallOut = new System.Windows.Forms.GroupBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.LUserCallOut = new System.Windows.Forms.Label();
            this.LInfoCallOut = new System.Windows.Forms.Label();
            this.gBCallIn = new System.Windows.Forms.GroupBox();
            this.LInfoCallIn = new System.Windows.Forms.Label();
            this.LUserCallIn = new System.Windows.Forms.Label();
            this.BDecline = new System.Windows.Forms.Button();
            this.BAccept = new System.Windows.Forms.Button();
            this.gbConv = new System.Windows.Forms.GroupBox();
            this.LTimeConv = new System.Windows.Forms.Label();
            this.LInfoConv = new System.Windows.Forms.Label();
            this.BDisconnect = new System.Windows.Forms.Button();
            this.LUserConv = new System.Windows.Forms.Label();
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
            this.gBDelAcc = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BDeleteAccount = new System.Windows.Forms.Button();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.gBChangePass = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TOldPass = new System.Windows.Forms.Label();
            this.BChangePassword = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TPassword2 = new System.Windows.Forms.TextBox();
            this.TPassword1 = new System.Windows.Forms.TextBox();
            this.TPasswordOld = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerIAM = new System.Windows.Forms.Timer(this.components);
            this.timerConv = new System.Windows.Forms.Timer(this.components);
            this.timerCallOut = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBCallOut.SuspendLayout();
            this.gBCallIn.SuspendLayout();
            this.gbConv.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gBDelAcc.SuspendLayout();
            this.gBChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBLogOut,
            this.tSBContact});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(319, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBLogOut
            // 
            this.tSBLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBLogOut.AutoToolTip = false;
            this.tSBLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBLogOut.ForeColor = System.Drawing.Color.Black;
            this.tSBLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tSBLogOut.Image")));
            this.tSBLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBLogOut.Name = "tSBLogOut";
            this.tSBLogOut.Size = new System.Drawing.Size(55, 22);
            this.tSBLogOut.Text = "Wyloguj";
            this.tSBLogOut.Click += new System.EventHandler(this.tSBLogOut_Click);
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
            this.tabPage1.Controls.Add(this.gBCallOut);
            this.tabPage1.Controls.Add(this.gBCallIn);
            this.tabPage1.Controls.Add(this.gbConv);
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
            // gBCallOut
            // 
            this.gBCallOut.BackColor = System.Drawing.Color.Brown;
            this.gBCallOut.Controls.Add(this.BCancel);
            this.gBCallOut.Controls.Add(this.LUserCallOut);
            this.gBCallOut.Controls.Add(this.LInfoCallOut);
            this.gBCallOut.Location = new System.Drawing.Point(6, 6);
            this.gBCallOut.Name = "gBCallOut";
            this.gBCallOut.Size = new System.Drawing.Size(298, 92);
            this.gBCallOut.TabIndex = 5;
            this.gBCallOut.TabStop = false;
            this.gBCallOut.Visible = false;
            // 
            // BCancel
            // 
            this.BCancel.BackgroundImage = global::SecConvClient.Properties.Resources.nocall;
            this.BCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BCancel.Location = new System.Drawing.Point(132, 46);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(36, 36);
            this.BCancel.TabIndex = 14;
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // LUserCallOut
            // 
            this.LUserCallOut.BackColor = System.Drawing.Color.Transparent;
            this.LUserCallOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LUserCallOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUserCallOut.Location = new System.Drawing.Point(6, 26);
            this.LUserCallOut.Name = "LUserCallOut";
            this.LUserCallOut.Size = new System.Drawing.Size(286, 18);
            this.LUserCallOut.TabIndex = 13;
            this.LUserCallOut.Text = "Użytkownik";
            this.LUserCallOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LInfoCallOut
            // 
            this.LInfoCallOut.BackColor = System.Drawing.Color.Transparent;
            this.LInfoCallOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LInfoCallOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LInfoCallOut.Location = new System.Drawing.Point(6, 8);
            this.LInfoCallOut.Name = "LInfoCallOut";
            this.LInfoCallOut.Size = new System.Drawing.Size(286, 18);
            this.LInfoCallOut.TabIndex = 12;
            this.LInfoCallOut.Text = "Łączę";
            this.LInfoCallOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBCallIn
            // 
            this.gBCallIn.BackColor = System.Drawing.Color.Brown;
            this.gBCallIn.Controls.Add(this.LInfoCallIn);
            this.gBCallIn.Controls.Add(this.LUserCallIn);
            this.gBCallIn.Controls.Add(this.BDecline);
            this.gBCallIn.Controls.Add(this.BAccept);
            this.gBCallIn.Location = new System.Drawing.Point(6, 6);
            this.gBCallIn.Name = "gBCallIn";
            this.gBCallIn.Size = new System.Drawing.Size(298, 92);
            this.gBCallIn.TabIndex = 6;
            this.gBCallIn.TabStop = false;
            this.gBCallIn.Visible = false;
            // 
            // LInfoCallIn
            // 
            this.LInfoCallIn.BackColor = System.Drawing.Color.Transparent;
            this.LInfoCallIn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LInfoCallIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LInfoCallIn.Location = new System.Drawing.Point(9, 25);
            this.LInfoCallIn.Name = "LInfoCallIn";
            this.LInfoCallIn.Size = new System.Drawing.Size(283, 18);
            this.LInfoCallIn.TabIndex = 11;
            this.LInfoCallIn.Text = "dzwoni!";
            this.LInfoCallIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LUserCallIn
            // 
            this.LUserCallIn.BackColor = System.Drawing.Color.Transparent;
            this.LUserCallIn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LUserCallIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUserCallIn.Location = new System.Drawing.Point(9, 8);
            this.LUserCallIn.Name = "LUserCallIn";
            this.LUserCallIn.Size = new System.Drawing.Size(283, 18);
            this.LUserCallIn.TabIndex = 10;
            this.LUserCallIn.Text = "Użytkownik";
            this.LUserCallIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BDecline
            // 
            this.BDecline.BackgroundImage = global::SecConvClient.Properties.Resources.nocall;
            this.BDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BDecline.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BDecline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BDecline.Location = new System.Drawing.Point(174, 48);
            this.BDecline.Name = "BDecline";
            this.BDecline.Size = new System.Drawing.Size(36, 36);
            this.BDecline.TabIndex = 9;
            this.BDecline.UseVisualStyleBackColor = true;
            this.BDecline.Click += new System.EventHandler(this.BDecline_Click);
            // 
            // BAccept
            // 
            this.BAccept.BackgroundImage = global::SecConvClient.Properties.Resources.call;
            this.BAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAccept.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BAccept.Location = new System.Drawing.Point(83, 48);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(36, 36);
            this.BAccept.TabIndex = 8;
            this.BAccept.UseVisualStyleBackColor = true;
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // gbConv
            // 
            this.gbConv.BackColor = System.Drawing.Color.Brown;
            this.gbConv.Controls.Add(this.LTimeConv);
            this.gbConv.Controls.Add(this.LInfoConv);
            this.gbConv.Controls.Add(this.BDisconnect);
            this.gbConv.Controls.Add(this.LUserConv);
            this.gbConv.Location = new System.Drawing.Point(6, 6);
            this.gbConv.Name = "gbConv";
            this.gbConv.Size = new System.Drawing.Size(298, 92);
            this.gbConv.TabIndex = 12;
            this.gbConv.TabStop = false;
            this.gbConv.Visible = false;
            // 
            // LTimeConv
            // 
            this.LTimeConv.BackColor = System.Drawing.Color.Transparent;
            this.LTimeConv.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.LTimeConv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LTimeConv.Location = new System.Drawing.Point(19, 73);
            this.LTimeConv.Name = "LTimeConv";
            this.LTimeConv.Size = new System.Drawing.Size(260, 18);
            this.LTimeConv.TabIndex = 20;
            this.LTimeConv.Text = "Czas trwania";
            this.LTimeConv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LInfoConv
            // 
            this.LInfoConv.BackColor = System.Drawing.Color.Transparent;
            this.LInfoConv.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LInfoConv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LInfoConv.Location = new System.Drawing.Point(19, 6);
            this.LInfoConv.Name = "LInfoConv";
            this.LInfoConv.Size = new System.Drawing.Size(260, 18);
            this.LInfoConv.TabIndex = 19;
            this.LInfoConv.Text = "Rozmowa";
            this.LInfoConv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BDisconnect
            // 
            this.BDisconnect.BackgroundImage = global::SecConvClient.Properties.Resources.nocall;
            this.BDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BDisconnect.Location = new System.Drawing.Point(132, 39);
            this.BDisconnect.Name = "BDisconnect";
            this.BDisconnect.Size = new System.Drawing.Size(36, 36);
            this.BDisconnect.TabIndex = 17;
            this.BDisconnect.UseVisualStyleBackColor = true;
            this.BDisconnect.Click += new System.EventHandler(this.BDisconnect_Click);
            // 
            // LUserConv
            // 
            this.LUserConv.BackColor = System.Drawing.Color.Transparent;
            this.LUserConv.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LUserConv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUserConv.Location = new System.Drawing.Point(19, 21);
            this.LUserConv.Name = "LUserConv";
            this.LUserConv.Size = new System.Drawing.Size(260, 18);
            this.LUserConv.TabIndex = 18;
            this.LUserConv.Text = "Użytkownik";
            this.LUserConv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.listView1.Location = new System.Drawing.Point(0, 104);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 309);
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
            this.listView2.AllowColumnReorder = true;
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
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(312, 412);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Znajomy";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kiedy";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Czas trwania";
            this.columnHeader4.Width = 83;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.gBDelAcc);
            this.tabPage3.Controls.Add(this.gBChangePass);
            this.tabPage3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(312, 422);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Ustawienia";
            // 
            // gBDelAcc
            // 
            this.gBDelAcc.Controls.Add(this.label3);
            this.gBDelAcc.Controls.Add(this.BDeleteAccount);
            this.gBDelAcc.Controls.Add(this.TPassword);
            this.gBDelAcc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBDelAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBDelAcc.Location = new System.Drawing.Point(7, 222);
            this.gBDelAcc.Name = "gBDelAcc";
            this.gBDelAcc.Size = new System.Drawing.Size(295, 178);
            this.gBDelAcc.TabIndex = 1;
            this.gBDelAcc.TabStop = false;
            this.gBDelAcc.Text = "Usuń konto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Obecne hasło";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BDeleteAccount
            // 
            this.BDeleteAccount.BackColor = System.Drawing.Color.Brown;
            this.BDeleteAccount.FlatAppearance.BorderSize = 0;
            this.BDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDeleteAccount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BDeleteAccount.Location = new System.Drawing.Point(100, 97);
            this.BDeleteAccount.Name = "BDeleteAccount";
            this.BDeleteAccount.Size = new System.Drawing.Size(179, 26);
            this.BDeleteAccount.TabIndex = 12;
            this.BDeleteAccount.Text = "Usuń konto";
            this.toolTip1.SetToolTip(this.BDeleteAccount, "Usunięcia konta nie można cofnąć!");
            this.BDeleteAccount.UseVisualStyleBackColor = false;
            this.BDeleteAccount.Click += new System.EventHandler(this.BDeleteAccount_Click);
            // 
            // TPassword
            // 
            this.TPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword.Location = new System.Drawing.Point(100, 65);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(179, 26);
            this.TPassword.TabIndex = 11;
            this.TPassword.UseSystemPasswordChar = true;
            // 
            // gBChangePass
            // 
            this.gBChangePass.Controls.Add(this.label2);
            this.gBChangePass.Controls.Add(this.label1);
            this.gBChangePass.Controls.Add(this.TOldPass);
            this.gBChangePass.Controls.Add(this.BChangePassword);
            this.gBChangePass.Controls.Add(this.button3);
            this.gBChangePass.Controls.Add(this.TPassword2);
            this.gBChangePass.Controls.Add(this.TPassword1);
            this.gBChangePass.Controls.Add(this.TPasswordOld);
            this.gBChangePass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBChangePass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBChangePass.Location = new System.Drawing.Point(7, 17);
            this.gBChangePass.Name = "gBChangePass";
            this.gBChangePass.Size = new System.Drawing.Size(295, 178);
            this.gBChangePass.TabIndex = 0;
            this.gBChangePass.TabStop = false;
            this.gBChangePass.Text = "Zmień hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nowe hasło";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nowe hasło";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TOldPass
            // 
            this.TOldPass.AutoSize = true;
            this.TOldPass.Location = new System.Drawing.Point(14, 36);
            this.TOldPass.Name = "TOldPass";
            this.TOldPass.Size = new System.Drawing.Size(80, 15);
            this.TOldPass.TabIndex = 16;
            this.TOldPass.Text = "Obecne hasło";
            this.TOldPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BChangePassword
            // 
            this.BChangePassword.BackColor = System.Drawing.Color.Brown;
            this.BChangePassword.FlatAppearance.BorderSize = 0;
            this.BChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BChangePassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BChangePassword.Location = new System.Drawing.Point(100, 128);
            this.BChangePassword.Name = "BChangePassword";
            this.BChangePassword.Size = new System.Drawing.Size(179, 26);
            this.BChangePassword.TabIndex = 10;
            this.BChangePassword.Text = "Zmień hasło";
            this.BChangePassword.UseVisualStyleBackColor = false;
            this.BChangePassword.Click += new System.EventHandler(this.BChangePassword_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(251, 63);
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
            // TPassword2
            // 
            this.TPassword2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword2.Location = new System.Drawing.Point(100, 96);
            this.TPassword2.Name = "TPassword2";
            this.TPassword2.Size = new System.Drawing.Size(179, 26);
            this.TPassword2.TabIndex = 9;
            this.TPassword2.UseSystemPasswordChar = true;
            // 
            // TPassword1
            // 
            this.TPassword1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword1.Location = new System.Drawing.Point(100, 63);
            this.TPassword1.Name = "TPassword1";
            this.TPassword1.Size = new System.Drawing.Size(145, 26);
            this.TPassword1.TabIndex = 8;
            this.TPassword1.UseSystemPasswordChar = true;
            // 
            // TPasswordOld
            // 
            this.TPasswordOld.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPasswordOld.Location = new System.Drawing.Point(100, 31);
            this.TPasswordOld.Name = "TPasswordOld";
            this.TPasswordOld.Size = new System.Drawing.Size(179, 26);
            this.TPasswordOld.TabIndex = 7;
            this.TPasswordOld.UseSystemPasswordChar = true;
            // 
            // timerIAM
            // 
            this.timerIAM.Interval = 60000;
            this.timerIAM.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerConv
            // 
            this.timerConv.Interval = 200;
            this.timerConv.Tick += new System.EventHandler(this.timerConv_Tick);
            // 
            // timerCallOut
            // 
            this.timerCallOut.Interval = 30000;
            this.timerCallOut.Tick += new System.EventHandler(this.timerCallOut_Tick);
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
            this.gBCallOut.ResumeLayout(false);
            this.gBCallIn.ResumeLayout(false);
            this.gbConv.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gBDelAcc.ResumeLayout(false);
            this.gBDelAcc.PerformLayout();
            this.gBChangePass.ResumeLayout(false);
            this.gBChangePass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBContact;
        private System.Windows.Forms.ToolStripButton tSBLogOut;
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
        public System.Windows.Forms.GroupBox gBChangePass;
        public System.Windows.Forms.GroupBox gBDelAcc;
        private System.Windows.Forms.TextBox TPassword2;
        private System.Windows.Forms.TextBox TPassword1;
        private System.Windows.Forms.TextBox TPasswordOld;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BDeleteAccount;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Button BChangePassword;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.Timer timerIAM;
        public System.Windows.Forms.GroupBox gBCallOut;
        private System.Windows.Forms.Label LInfoCallOut;
        public System.Windows.Forms.Label LUserCallOut;
        private System.Windows.Forms.Button BCancel;
        public System.Windows.Forms.GroupBox gBCallIn;
        private System.Windows.Forms.Label LInfoCallIn;
        public System.Windows.Forms.Label LUserCallIn;
        private System.Windows.Forms.Button BDecline;
        private System.Windows.Forms.Button BAccept;
        public System.Windows.Forms.GroupBox gbConv;
        private System.Windows.Forms.Label LTimeConv;
        private System.Windows.Forms.Label LInfoConv;
        private System.Windows.Forms.Button BDisconnect;
        public System.Windows.Forms.Label LUserConv;
        public System.Windows.Forms.Timer timerConv;
        public System.Windows.Forms.Timer timerCallOut;
        private System.Windows.Forms.Label TOldPass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}