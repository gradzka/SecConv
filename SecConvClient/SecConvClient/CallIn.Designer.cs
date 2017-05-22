namespace SecConvClient
{
    partial class CallIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallIn));
            this.BDecline = new System.Windows.Forms.Button();
            this.BAccept = new System.Windows.Forms.Button();
            this.LUser = new System.Windows.Forms.Label();
            this.LInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BDecline
            // 
            this.BDecline.BackgroundImage = global::SecConvClient.Properties.Resources.nocall;
            this.BDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BDecline.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BDecline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BDecline.Location = new System.Drawing.Point(167, 71);
            this.BDecline.Name = "BDecline";
            this.BDecline.Size = new System.Drawing.Size(36, 36);
            this.BDecline.TabIndex = 4;
            this.BDecline.UseVisualStyleBackColor = true;
            this.BDecline.Click += new System.EventHandler(this.BDecline_Click);
            // 
            // BAccept
            // 
            this.BAccept.BackgroundImage = global::SecConvClient.Properties.Resources.call;
            this.BAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAccept.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BAccept.Location = new System.Drawing.Point(76, 71);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(36, 36);
            this.BAccept.TabIndex = 3;
            this.BAccept.UseVisualStyleBackColor = true;
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // LUser
            // 
            this.LUser.BackColor = System.Drawing.Color.Transparent;
            this.LUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUser.Location = new System.Drawing.Point(12, 14);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(260, 18);
            this.LUser.TabIndex = 5;
            this.LUser.Text = "Użytkownik";
            this.LUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LInfo
            // 
            this.LInfo.BackColor = System.Drawing.Color.Transparent;
            this.LInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LInfo.Location = new System.Drawing.Point(12, 34);
            this.LInfo.Name = "LInfo";
            this.LInfo.Size = new System.Drawing.Size(260, 18);
            this.LInfo.TabIndex = 7;
            this.LInfo.Text = "dzwoni!";
            this.LInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CallIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecConvClient.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.LInfo);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.BDecline);
            this.Controls.Add(this.BAccept);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CallIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallIn";
           // this.Shown += new System.EventHandler(this.CallIn_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAccept;
        private System.Windows.Forms.Button BDecline;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LInfo;
        private System.Windows.Forms.Timer timer1;
    }
}