namespace SecConvClient
{
    partial class Conv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conv));
            this.LInfo = new System.Windows.Forms.Label();
            this.BDisconnect = new System.Windows.Forms.Button();
            this.LAddress = new System.Windows.Forms.Label();
            this.LUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LInfo
            // 
            this.LInfo.BackColor = System.Drawing.Color.Transparent;
            this.LInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LInfo.Location = new System.Drawing.Point(12, 10);
            this.LInfo.Name = "LInfo";
            this.LInfo.Size = new System.Drawing.Size(260, 18);
            this.LInfo.TabIndex = 15;
            this.LInfo.Text = "Rozmowa z";
            this.LInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BDisconnect
            // 
            this.BDisconnect.BackgroundImage = global::SecConvClient.Properties.Resources.nocall;
            this.BDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BDisconnect.Location = new System.Drawing.Point(126, 94);
            this.BDisconnect.Name = "BDisconnect";
            this.BDisconnect.Size = new System.Drawing.Size(36, 36);
            this.BDisconnect.TabIndex = 12;
            this.BDisconnect.UseVisualStyleBackColor = true;
            this.BDisconnect.Click += new System.EventHandler(this.BDisconnect_Click);
            // 
            // LAddress
            // 
            this.LAddress.BackColor = System.Drawing.Color.Transparent;
            this.LAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAddress.Location = new System.Drawing.Point(12, 48);
            this.LAddress.Name = "LAddress";
            this.LAddress.Size = new System.Drawing.Size(260, 18);
            this.LAddress.TabIndex = 14;
            this.LAddress.Text = "(adres IP)";
            this.LAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LUser
            // 
            this.LUser.BackColor = System.Drawing.Color.Transparent;
            this.LUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUser.Location = new System.Drawing.Point(12, 29);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(260, 18);
            this.LUser.TabIndex = 13;
            this.LUser.Text = "Użytkownik";
            this.LUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Czas trwania";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecConvClient.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LInfo);
            this.Controls.Add(this.BDisconnect);
            this.Controls.Add(this.LAddress);
            this.Controls.Add(this.LUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conv";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LInfo;
        private System.Windows.Forms.Button BDisconnect;
        private System.Windows.Forms.Label LAddress;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label label1;
    }
}