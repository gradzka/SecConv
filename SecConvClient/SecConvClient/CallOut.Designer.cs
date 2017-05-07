namespace SecConvClient
{
    partial class CallOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallOut));
            this.LInfo = new System.Windows.Forms.Label();
            this.LAddress = new System.Windows.Forms.Label();
            this.LUser = new System.Windows.Forms.Label();
            this.BDecline = new System.Windows.Forms.Button();
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
            this.LInfo.TabIndex = 11;
            this.LInfo.Text = "Łączę z";
            this.LInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAddress
            // 
            this.LAddress.BackColor = System.Drawing.Color.Transparent;
            this.LAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAddress.Location = new System.Drawing.Point(12, 48);
            this.LAddress.Name = "LAddress";
            this.LAddress.Size = new System.Drawing.Size(260, 18);
            this.LAddress.TabIndex = 10;
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
            this.LUser.TabIndex = 9;
            this.LUser.Text = "Użytkownik";
            this.LUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BDecline
            // 
            this.BDecline.BackgroundImage = global::SecConvClient.Properties.Resources.nocall;
            this.BDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BDecline.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BDecline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BDecline.Location = new System.Drawing.Point(126, 72);
            this.BDecline.Name = "BDecline";
            this.BDecline.Size = new System.Drawing.Size(36, 36);
            this.BDecline.TabIndex = 8;
            this.BDecline.UseVisualStyleBackColor = true;
            this.BDecline.Click += new System.EventHandler(this.BDecline_Click);
            // 
            // CallOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecConvClient.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.LInfo);
            this.Controls.Add(this.BDecline);
            this.Controls.Add(this.LAddress);
            this.Controls.Add(this.LUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CallOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LInfo;
        private System.Windows.Forms.Label LAddress;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Button BDecline;
    }
}