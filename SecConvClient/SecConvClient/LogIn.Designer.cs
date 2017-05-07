namespace SecConvClient
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.TLogin = new System.Windows.Forms.TextBox();
            this.BLogIn = new System.Windows.Forms.Button();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BTipServerIP = new System.Windows.Forms.Button();
            this.BTipPass = new System.Windows.Forms.Button();
            this.BTipLogin = new System.Windows.Forms.Button();
            this.BRegister = new System.Windows.Forms.Button();
            this.TServerIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(320, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton2.Text = "Pomoc";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.AutoToolTip = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "Kontakt";
            // 
            // TLogin
            // 
            this.TLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TLogin.Location = new System.Drawing.Point(9, 19);
            this.TLogin.Name = "TLogin";
            this.TLogin.Size = new System.Drawing.Size(145, 26);
            this.TLogin.TabIndex = 2;
            // 
            // BLogIn
            // 
            this.BLogIn.BackColor = System.Drawing.Color.Brown;
            this.BLogIn.FlatAppearance.BorderSize = 0;
            this.BLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogIn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BLogIn.Location = new System.Drawing.Point(74, 332);
            this.BLogIn.Name = "BLogIn";
            this.BLogIn.Size = new System.Drawing.Size(179, 26);
            this.BLogIn.TabIndex = 4;
            this.BLogIn.Text = "Zaloguj";
            this.BLogIn.UseVisualStyleBackColor = false;
            this.BLogIn.Click += new System.EventHandler(this.BLogIn_Click);
            // 
            // TPassword
            // 
            this.TPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword.Location = new System.Drawing.Point(9, 51);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(145, 26);
            this.TPassword.TabIndex = 3;
            this.TPassword.UseSystemPasswordChar = true;
            // 
            // BTipServerIP
            // 
            this.BTipServerIP.BackColor = System.Drawing.Color.IndianRed;
            this.BTipServerIP.FlatAppearance.BorderSize = 0;
            this.BTipServerIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTipServerIP.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BTipServerIP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTipServerIP.Location = new System.Drawing.Point(221, 195);
            this.BTipServerIP.Name = "BTipServerIP";
            this.BTipServerIP.Size = new System.Drawing.Size(28, 26);
            this.BTipServerIP.TabIndex = 17;
            this.BTipServerIP.TabStop = false;
            this.BTipServerIP.Text = "?";
            this.toolTip1.SetToolTip(this.BTipServerIP, "Wpisz adres serwera");
            this.BTipServerIP.UseVisualStyleBackColor = false;
            // 
            // BTipPass
            // 
            this.BTipPass.BackColor = System.Drawing.Color.IndianRed;
            this.BTipPass.FlatAppearance.BorderSize = 0;
            this.BTipPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTipPass.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BTipPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTipPass.Location = new System.Drawing.Point(160, 51);
            this.BTipPass.Name = "BTipPass";
            this.BTipPass.Size = new System.Drawing.Size(28, 26);
            this.BTipPass.TabIndex = 16;
            this.BTipPass.TabStop = false;
            this.BTipPass.Text = "?";
            this.toolTip1.SetToolTip(this.BTipPass, "Wpisz hasło");
            this.BTipPass.UseVisualStyleBackColor = false;
            // 
            // BTipLogin
            // 
            this.BTipLogin.BackColor = System.Drawing.Color.IndianRed;
            this.BTipLogin.FlatAppearance.BorderSize = 0;
            this.BTipLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTipLogin.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BTipLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTipLogin.Location = new System.Drawing.Point(160, 19);
            this.BTipLogin.Name = "BTipLogin";
            this.BTipLogin.Size = new System.Drawing.Size(28, 26);
            this.BTipLogin.TabIndex = 15;
            this.BTipLogin.TabStop = false;
            this.BTipLogin.Text = "?";
            this.toolTip1.SetToolTip(this.BTipLogin, "Wpisz login");
            this.BTipLogin.UseVisualStyleBackColor = false;
            // 
            // BRegister
            // 
            this.BRegister.BackColor = System.Drawing.Color.Brown;
            this.BRegister.FlatAppearance.BorderSize = 0;
            this.BRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegister.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BRegister.Location = new System.Drawing.Point(74, 395);
            this.BRegister.Name = "BRegister";
            this.BRegister.Size = new System.Drawing.Size(179, 26);
            this.BRegister.TabIndex = 5;
            this.BRegister.Text = "Załóż konto";
            this.BRegister.UseVisualStyleBackColor = false;
            this.BRegister.Click += new System.EventHandler(this.BRegister_Click);
            // 
            // TServerIP
            // 
            this.TServerIP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TServerIP.Location = new System.Drawing.Point(70, 195);
            this.TServerIP.Name = "TServerIP";
            this.TServerIP.Size = new System.Drawing.Size(145, 26);
            this.TServerIP.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TLogin);
            this.groupBox1.Controls.Add(this.TPassword);
            this.groupBox1.Controls.Add(this.BTipPass);
            this.groupBox1.Controls.Add(this.BTipLogin);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(63, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 84);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANE LOGOWANIA";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecConvClient.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(320, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTipServerIP);
            this.Controls.Add(this.TServerIP);
            this.Controls.Add(this.BRegister);
            this.Controls.Add(this.BLogIn);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox TLogin;
        private System.Windows.Forms.Button BLogIn;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BRegister;
        private System.Windows.Forms.TextBox TServerIP;
        private System.Windows.Forms.Button BTipServerIP;
        private System.Windows.Forms.Button BTipPass;
        private System.Windows.Forms.Button BTipLogin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

