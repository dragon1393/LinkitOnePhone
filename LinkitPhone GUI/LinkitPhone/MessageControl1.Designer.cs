namespace LinkitPhone
{
    partial class MessageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.call_label = new System.Windows.Forms.Label();
            this.message_tbox = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.number_tBox = new System.Windows.Forms.TextBox();
            this.to_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // call_label
            // 
            this.call_label.AutoSize = true;
            this.call_label.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.call_label.Location = new System.Drawing.Point(11, 19);
            this.call_label.Name = "call_label";
            this.call_label.Size = new System.Drawing.Size(112, 24);
            this.call_label.TabIndex = 1;
            this.call_label.Text = "Message";
            // 
            // message_tbox
            // 
            this.message_tbox.Location = new System.Drawing.Point(15, 81);
            this.message_tbox.Multiline = true;
            this.message_tbox.Name = "message_tbox";
            this.message_tbox.Size = new System.Drawing.Size(276, 219);
            this.message_tbox.TabIndex = 2;
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.Green;
            this.send_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.send_btn.Image = global::LinkitPhone.Properties.Resources.Mail__Next_WF;
            this.send_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.send_btn.Location = new System.Drawing.Point(15, 306);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(276, 43);
            this.send_btn.TabIndex = 3;
            this.send_btn.Text = "Send SMS";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // number_tBox
            // 
            this.number_tBox.Location = new System.Drawing.Point(41, 55);
            this.number_tBox.Name = "number_tBox";
            this.number_tBox.Size = new System.Drawing.Size(250, 20);
            this.number_tBox.TabIndex = 4;
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_label.Location = new System.Drawing.Point(12, 58);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(24, 15);
            this.to_label.TabIndex = 5;
            this.to_label.Text = "To:";
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.to_label);
            this.Controls.Add(this.number_tBox);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.message_tbox);
            this.Controls.Add(this.call_label);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(306, 361);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label call_label;
        private System.Windows.Forms.TextBox message_tbox;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox number_tBox;
        private System.Windows.Forms.Label to_label;
    }
}
