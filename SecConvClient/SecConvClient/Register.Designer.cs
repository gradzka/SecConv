namespace SecConvClient
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.TPassword1 = new System.Windows.Forms.TextBox();
            this.BRegister = new System.Windows.Forms.Button();
            this.TLogin = new System.Windows.Forms.TextBox();
            this.TPassword2 = new System.Windows.Forms.TextBox();
            this.BTipPass1 = new System.Windows.Forms.Button();
            this.BTipPass2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BBack = new System.Windows.Forms.Button();
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
            this.toolStrip1.TabIndex = 1;
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
            // TPassword1
            // 
            this.TPassword1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword1.ForeColor = System.Drawing.Color.Gray;
            this.TPassword1.Location = new System.Drawing.Point(8, 51);
            this.TPassword1.Name = "TPassword1";
            this.TPassword1.Size = new System.Drawing.Size(145, 26);
            this.TPassword1.TabIndex = 6;
            this.TPassword1.Text = "Hasło";
            this.TPassword1.UseSystemPasswordChar = true;
            this.TPassword1.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TPassword1.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // BRegister
            // 
            this.BRegister.BackColor = System.Drawing.Color.Brown;
            this.BRegister.FlatAppearance.BorderSize = 0;
            this.BRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegister.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BRegister.Location = new System.Drawing.Point(70, 366);
            this.BRegister.Name = "BRegister";
            this.BRegister.Size = new System.Drawing.Size(179, 26);
            this.BRegister.TabIndex = 8;
            this.BRegister.Text = "Zarejestruj";
            this.BRegister.UseVisualStyleBackColor = false;
            this.BRegister.Click += new System.EventHandler(this.BRegister_Click);
            // 
            // TLogin
            // 
            this.TLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TLogin.ForeColor = System.Drawing.Color.Gray;
            this.TLogin.Location = new System.Drawing.Point(8, 19);
            this.TLogin.Name = "TLogin";
            this.TLogin.Size = new System.Drawing.Size(179, 26);
            this.TLogin.TabIndex = 5;
            this.TLogin.Text = "Login";
            this.TLogin.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TLogin.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // TPassword2
            // 
            this.TPassword2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TPassword2.ForeColor = System.Drawing.Color.Gray;
            this.TPassword2.Location = new System.Drawing.Point(8, 83);
            this.TPassword2.Name = "TPassword2";
            this.TPassword2.Size = new System.Drawing.Size(145, 26);
            this.TPassword2.TabIndex = 7;
            this.TPassword2.Text = "Hasło";
            this.TPassword2.UseSystemPasswordChar = true;
            this.TPassword2.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TPassword2.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // BTipPass1
            // 
            this.BTipPass1.BackColor = System.Drawing.Color.IndianRed;
            this.BTipPass1.FlatAppearance.BorderSize = 0;
            this.BTipPass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTipPass1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BTipPass1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTipPass1.Location = new System.Drawing.Point(159, 51);
            this.BTipPass1.Name = "BTipPass1";
            this.BTipPass1.Size = new System.Drawing.Size(28, 26);
            this.BTipPass1.TabIndex = 11;
            this.BTipPass1.TabStop = false;
            this.BTipPass1.Text = "?";
            this.toolTip1.SetToolTip(this.BTipPass1, "Wpisz hasło.\r\nHasło musi być co najmniej 8 znakowe\r\ni spełniać poniższe wymagania" +
        ":\r\n- minimum 1 cyfra,\r\n- minimum 1 wielka litera,\r\n- minimum 1 mała litera.");
            this.BTipPass1.UseVisualStyleBackColor = false;
            // 
            // BTipPass2
            // 
            this.BTipPass2.BackColor = System.Drawing.Color.IndianRed;
            this.BTipPass2.FlatAppearance.BorderSize = 0;
            this.BTipPass2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTipPass2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BTipPass2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTipPass2.Location = new System.Drawing.Point(159, 83);
            this.BTipPass2.Name = "BTipPass2";
            this.BTipPass2.Size = new System.Drawing.Size(28, 26);
            this.BTipPass2.TabIndex = 12;
            this.BTipPass2.TabStop = false;
            this.BTipPass2.Text = "?";
            this.toolTip1.SetToolTip(this.BTipPass2, "Wpisz hasło powtórnie");
            this.BTipPass2.UseVisualStyleBackColor = false;
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.Color.IndianRed;
            this.BBack.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.BBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBack.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BBack.Location = new System.Drawing.Point(12, 434);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 29);
            this.BBack.TabIndex = 9;
            this.BBack.Text = "Wstecz";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // TServerIP
            // 
            this.TServerIP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TServerIP.ForeColor = System.Drawing.Color.Gray;
            this.TServerIP.Location = new System.Drawing.Point(70, 195);
            this.TServerIP.Name = "TServerIP";
            this.TServerIP.Size = new System.Drawing.Size(180, 26);
            this.TServerIP.TabIndex = 13;
            this.TServerIP.Text = "Adres IP serwera";
            this.TServerIP.Enter += new System.EventHandler(this.Textbox_Enter);
            this.TServerIP.Leave += new System.EventHandler(this.Textbox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TLogin);
            this.groupBox1.Controls.Add(this.TPassword1);
            this.groupBox1.Controls.Add(this.TPassword2);
            this.groupBox1.Controls.Add(this.BTipPass2);
            this.groupBox1.Controls.Add(this.BTipPass1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(63, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 117);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANE REJESTRACJI";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecConvClient.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(320, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BRegister);
            this.Controls.Add(this.TServerIP);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
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
        private System.Windows.Forms.TextBox TPassword1;
        private System.Windows.Forms.Button BRegister;
        private System.Windows.Forms.TextBox TLogin;
        private System.Windows.Forms.TextBox TPassword2;
        private System.Windows.Forms.Button BTipPass1;
        private System.Windows.Forms.Button BTipPass2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.TextBox TServerIP;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}