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
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.TLogin = new System.Windows.Forms.TextBox();
            this.BLogIn = new System.Windows.Forms.Button();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(320, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStripButton3.Click += new System.EventHandler(this.tSBContact_Click);
            // 
            // TLogin
            // 
            this.TLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TLogin.ForeColor = System.Drawing.Color.Gray;
            this.TLogin.Location = new System.Drawing.Point(9, 19);
            this.TLogin.Name = "TLogin";
            this.TLogin.Size = new System.Drawing.Size(181, 26);
            this.TLogin.TabIndex = 2;
            this.TLogin.Text = "Login";
            this.TLogin.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.TLogin.Leave += new System.EventHandler(this.Textbox_Leave);
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
            this.TPassword.ForeColor = System.Drawing.Color.Gray;
            this.TPassword.Location = new System.Drawing.Point(9, 51);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(181, 26);
            this.TPassword.TabIndex = 3;
            this.TPassword.Text = "Hasło";
            this.TPassword.UseSystemPasswordChar = true;
            this.TPassword.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.TPassword.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // BRegister
            // 
            this.BRegister.BackColor = System.Drawing.Color.Brown;
            this.BRegister.FlatAppearance.BorderSize = 0;
            this.BRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegister.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BRegister.Location = new System.Drawing.Point(74, 390);
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
            this.TServerIP.ForeColor = System.Drawing.Color.Gray;
            this.TServerIP.Location = new System.Drawing.Point(72, 195);
            this.TServerIP.Name = "TServerIP";
            this.TServerIP.Size = new System.Drawing.Size(181, 26);
            this.TServerIP.TabIndex = 6;
            this.TServerIP.Text = "Adres IP serwera";
            this.TServerIP.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TServerIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            this.TServerIP.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TLogin);
            this.groupBox1.Controls.Add(this.TPassword);
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
            this.Controls.Add(this.TServerIP);
            this.Controls.Add(this.BRegister);
            this.Controls.Add(this.BLogIn);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox TLogin;
        private System.Windows.Forms.Button BLogIn;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BRegister;
        private System.Windows.Forms.TextBox TServerIP;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

