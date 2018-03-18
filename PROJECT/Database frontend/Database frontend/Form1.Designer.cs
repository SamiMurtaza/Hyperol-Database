namespace Database_frontend
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Products_gb = new System.Windows.Forms.GroupBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Products_lb = new System.Windows.Forms.ListBox();
            this.Return_Replace = new System.Windows.Forms.ComboBox();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Products_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // OrderID
            // 
            this.OrderID.Location = new System.Drawing.Point(68, 6);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(158, 20);
            this.OrderID.TabIndex = 1;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(275, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Products_gb
            // 
            this.Products_gb.Controls.Add(this.Quantity);
            this.Products_gb.Controls.Add(this.label2);
            this.Products_gb.Controls.Add(this.Description);
            this.Products_gb.Controls.Add(this.Clear);
            this.Products_gb.Controls.Add(this.Remove);
            this.Products_gb.Controls.Add(this.Add);
            this.Products_gb.Controls.Add(this.Products_lb);
            this.Products_gb.Controls.Add(this.Return_Replace);
            this.Products_gb.Controls.Add(this.Product);
            this.Products_gb.Location = new System.Drawing.Point(12, 32);
            this.Products_gb.Name = "Products_gb";
            this.Products_gb.Size = new System.Drawing.Size(338, 288);
            this.Products_gb.TabIndex = 3;
            this.Products_gb.TabStop = false;
            this.Products_gb.Text = "Products";
            this.Products_gb.Enter += new System.EventHandler(this.Products_gb_Enter);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(160, 19);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(64, 20);
            this.Quantity.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Discription";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(6, 220);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(326, 60);
            this.Description.TabIndex = 4;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(249, 104);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(249, 75);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 9;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add.Location = new System.Drawing.Point(249, 46);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Products_lb
            // 
            this.Products_lb.FormattingEnabled = true;
            this.Products_lb.Location = new System.Drawing.Point(6, 46);
            this.Products_lb.Name = "Products_lb";
            this.Products_lb.Size = new System.Drawing.Size(234, 147);
            this.Products_lb.TabIndex = 7;
            // 
            // Return_Replace
            // 
            this.Return_Replace.FormattingEnabled = true;
            this.Return_Replace.Items.AddRange(new object[] {
            "Return",
            "Replace"});
            this.Return_Replace.Location = new System.Drawing.Point(230, 19);
            this.Return_Replace.Name = "Return_Replace";
            this.Return_Replace.Size = new System.Drawing.Size(102, 21);
            this.Return_Replace.TabIndex = 6;
            // 
            // Product
            // 
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(6, 19);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(148, 21);
            this.Product.TabIndex = 4;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(275, 328);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(194, 328);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 363);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Products_gb);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.OrderID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return/Replace";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Products_gb.ResumeLayout(false);
            this.Products_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderID;
        private new System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.GroupBox Products_gb;
        private System.Windows.Forms.ListBox Products_lb;
        private System.Windows.Forms.ComboBox Return_Replace;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Quantity;
    }
}

