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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conv));
            this.LInfo = new System.Windows.Forms.Label();
            this.BDisconnect = new System.Windows.Forms.Button();
            this.LUser = new System.Windows.Forms.Label();
            this.LTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LInfo
            // 
            this.LInfo.BackColor = System.Drawing.Color.Transparent;
            this.LInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LInfo.Location = new System.Drawing.Point(12, 20);
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
            // LUser
            // 
            this.LUser.BackColor = System.Drawing.Color.Transparent;
            this.LUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUser.Location = new System.Drawing.Point(12, 39);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(260, 18);
            this.LUser.TabIndex = 13;
            this.LUser.Text = "Użytkownik";
            this.LUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LTime
            // 
            this.LTime.BackColor = System.Drawing.Color.Transparent;
            this.LTime.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LTime.Location = new System.Drawing.Point(12, 59);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(260, 18);
            this.LTime.TabIndex = 16;
            this.LTime.Text = "Czas trwania";
            this.LTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Conv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecConvClient.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.LInfo);
            this.Controls.Add(this.BDisconnect);
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
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LTime;
        private System.Windows.Forms.Timer timer1;
    }
}