namespace Database_frontend
{
    partial class Form4
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
            this.Clear = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.ListBox();
            this.Products_gb = new System.Windows.Forms.GroupBox();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_supplier = new System.Windows.Forms.Button();
            this.Add_Product = new System.Windows.Forms.Button();
            this.Products_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(250, 104);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(82, 23);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(250, 75);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(82, 23);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add.Location = new System.Drawing.Point(250, 46);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(82, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(6, 46);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(238, 147);
            this.Products.TabIndex = 11;
            // 
            // Products_gb
            // 
            this.Products_gb.Controls.Add(this.Add_Product);
            this.Products_gb.Controls.Add(this.Quantity);
            this.Products_gb.Controls.Add(this.Clear);
            this.Products_gb.Controls.Add(this.Product);
            this.Products_gb.Controls.Add(this.Remove);
            this.Products_gb.Controls.Add(this.Add);
            this.Products_gb.Controls.Add(this.Products);
            this.Products_gb.Location = new System.Drawing.Point(13, 62);
            this.Products_gb.Name = "Products_gb";
            this.Products_gb.Size = new System.Drawing.Size(338, 202);
            this.Products_gb.TabIndex = 15;
            this.Products_gb.TabStop = false;
            this.Products_gb.Text = "Products";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(276, 270);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 16;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(195, 270);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(176, 19);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(68, 20);
            this.Quantity.TabIndex = 15;
            // 
            // Product
            // 
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(6, 19);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(164, 21);
            this.Product.TabIndex = 13;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(262, 10);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(87, 23);
            this.Refresh.TabIndex = 20;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // OrderID
            // 
            this.OrderID.Location = new System.Drawing.Point(78, 13);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(158, 20);
            this.OrderID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Supplier ID:";
            // 
            // Add_supplier
            // 
            this.Add_supplier.Location = new System.Drawing.Point(262, 39);
            this.Add_supplier.Name = "Add_supplier";
            this.Add_supplier.Size = new System.Drawing.Size(87, 23);
            this.Add_supplier.TabIndex = 21;
            this.Add_supplier.Text = "New Supplier";
            this.Add_supplier.UseVisualStyleBackColor = true;
            // 
            // Add_Product
            // 
            this.Add_Product.Location = new System.Drawing.Point(250, 16);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(82, 23);
            this.Add_Product.TabIndex = 22;
            this.Add_Product.Text = "New Product";
            this.Add_Product.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 301);
            this.Controls.Add(this.Add_supplier);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.OrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Products_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Products_gb.ResumeLayout(false);
            this.Products_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.GroupBox Products_gb;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_supplier;
    }
}