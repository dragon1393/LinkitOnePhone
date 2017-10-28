namespace LinkitPhone
{
    partial class LinkitPhone
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
            this.copyright = new System.Windows.Forms.Label();
            this.comPort_cBox = new System.Windows.Forms.ComboBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.back_pBox = new System.Windows.Forms.PictureBox();
            this.phone_btn = new System.Windows.Forms.PictureBox();
            this.message_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(246, 285);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(69, 13);
            this.copyright.TabIndex = 2;
            this.copyright.Text = "© by Agneya";
            // 
            // comPort_cBox
            // 
            this.comPort_cBox.FormattingEnabled = true;
            this.comPort_cBox.Location = new System.Drawing.Point(23, 232);
            this.comPort_cBox.Name = "comPort_cBox";
            this.comPort_cBox.Size = new System.Drawing.Size(290, 21);
            this.comPort_cBox.TabIndex = 3;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(127, 259);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(75, 36);
            this.open_btn.TabIndex = 4;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(20, 60);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(295, 238);
            this.panel.TabIndex = 5;
            this.panel.Visible = false;
            // 
            // back_pBox
            // 
            this.back_pBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back_pBox.Image = global::LinkitPhone.Properties.Resources.Data_Previous;
            this.back_pBox.Location = new System.Drawing.Point(20, 19);
            this.back_pBox.Name = "back_pBox";
            this.back_pBox.Size = new System.Drawing.Size(31, 35);
            this.back_pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_pBox.TabIndex = 6;
            this.back_pBox.TabStop = false;
            this.back_pBox.Click += new System.EventHandler(this.back_pBox_Click);
            // 
            // phone_btn
            // 
            this.phone_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.phone_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_btn.Enabled = false;
            this.phone_btn.Image = global::LinkitPhone.Properties.Resources.call_connect;
            this.phone_btn.Location = new System.Drawing.Point(23, 85);
            this.phone_btn.Name = "phone_btn";
            this.phone_btn.Size = new System.Drawing.Size(130, 130);
            this.phone_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.phone_btn.TabIndex = 1;
            this.phone_btn.TabStop = false;
            this.phone_btn.Click += new System.EventHandler(this.phone_btn_Click);
            // 
            // message_btn
            // 
            this.message_btn.BackColor = System.Drawing.Color.Lime;
            this.message_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message_btn.Enabled = false;
            this.message_btn.Image = global::LinkitPhone.Properties.Resources.message;
            this.message_btn.Location = new System.Drawing.Point(185, 85);
            this.message_btn.Name = "message_btn";
            this.message_btn.Size = new System.Drawing.Size(130, 130);
            this.message_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.message_btn.TabIndex = 0;
            this.message_btn.TabStop = false;
            this.message_btn.Click += new System.EventHandler(this.message_btn_Click);
            // 
            // LinkitPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(335, 318);
            this.Controls.Add(this.back_pBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.comPort_cBox);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.phone_btn);
            this.Controls.Add(this.message_btn);
            this.Name = "LinkitPhone";
            this.Text = "           Desktop Mobile";
            ((System.ComponentModel.ISupportInitialize)(this.back_pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox message_btn;
        private System.Windows.Forms.PictureBox phone_btn;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.ComboBox comPort_cBox;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox back_pBox;
    }
}

