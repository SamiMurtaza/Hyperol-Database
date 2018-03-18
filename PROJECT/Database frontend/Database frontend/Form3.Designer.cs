namespace Database_frontend
{
    partial class Form3
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
            this.Checkin = new System.Windows.Forms.Button();
            this.Inquiry = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Checkin
            // 
            this.Checkin.Location = new System.Drawing.Point(51, 23);
            this.Checkin.Name = "Checkin";
            this.Checkin.Size = new System.Drawing.Size(157, 29);
            this.Checkin.TabIndex = 0;
            this.Checkin.Text = "Check-in";
            this.Checkin.UseVisualStyleBackColor = true;
            this.Checkin.Click += new System.EventHandler(this.Checkin_Click);
            // 
            // Inquiry
            // 
            this.Inquiry.Location = new System.Drawing.Point(51, 60);
            this.Inquiry.Name = "Inquiry";
            this.Inquiry.Size = new System.Drawing.Size(157, 29);
            this.Inquiry.TabIndex = 1;
            this.Inquiry.Text = "Inquiry";
            this.Inquiry.UseVisualStyleBackColor = true;
            this.Inquiry.Click += new System.EventHandler(this.Inquiry_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(166, 107);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 142);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Inquiry);
            this.Controls.Add(this.Checkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Checkin;
        private System.Windows.Forms.Button Inquiry;
        private System.Windows.Forms.Button Back;
    }
}