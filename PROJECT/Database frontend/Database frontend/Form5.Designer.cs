namespace Database_frontend
{
    partial class Form5
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
            this.Employee = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(144, 144);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(112, 23);
            this.Employee.TabIndex = 5;
            this.Employee.Text = "Employee Login";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(58, 83);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(143, 32);
            this.Return.TabIndex = 4;
            this.Return.Text = "Return/Replace";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(58, 45);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(143, 32);
            this.Checkout.TabIndex = 3;
            this.Checkout.Text = "Check-out";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Checkout);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Checkout;
    }
}