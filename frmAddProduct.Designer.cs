namespace Inventory
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProduct = new Label();
            txtProductName = new TextBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            lblCategory = new Label();
            lblMfgDate = new Label();
            lblExpDate = new Label();
            lblQty = new Label();
            lblSellPrice = new Label();
            txtQuantity = new TextBox();
            label1 = new Label();
            lblAddProduct = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(10, 74);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(64, 21);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(95, 72);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(232, 23);
            txtProductName.TabIndex = 1;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(95, 159);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(232, 23);
            dtPickerMfgDate.TabIndex = 3;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(95, 207);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(232, 23);
            dtPickerExpDate.TabIndex = 4;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(95, 297);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(232, 23);
            txtSellPrice.TabIndex = 6;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(95, 118);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(232, 23);
            cbCategory.TabIndex = 7;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(465, 90);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(314, 185);
            richTxtDescription.TabIndex = 8;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.LightGray;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Location = new Point(665, 286);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(100, 32);
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(24, 359);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(755, 158);
            gridViewProductList.TabIndex = 10;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(10, 120);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 21);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category";
            // 
            // lblMfgDate
            // 
            lblMfgDate.AutoSize = true;
            lblMfgDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMfgDate.Location = new Point(10, 161);
            lblMfgDate.Name = "lblMfgDate";
            lblMfgDate.Size = new Size(77, 21);
            lblMfgDate.TabIndex = 12;
            lblMfgDate.Text = "Mfg. Date";
            // 
            // lblExpDate
            // 
            lblExpDate.AutoSize = true;
            lblExpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpDate.Location = new Point(10, 207);
            lblExpDate.Name = "lblExpDate";
            lblExpDate.Size = new Size(73, 21);
            lblExpDate.TabIndex = 13;
            lblExpDate.Text = "Exp. Date";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(10, 250);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(38, 21);
            lblQty.TabIndex = 14;
            lblQty.Text = "Qty.";
            // 
            // lblSellPrice
            // 
            lblSellPrice.AutoSize = true;
            lblSellPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSellPrice.Location = new Point(10, 295);
            lblSellPrice.Name = "lblSellPrice";
            lblSellPrice.Size = new Size(73, 21);
            lblSellPrice.TabIndex = 15;
            lblSellPrice.Text = "Sell Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(95, 252);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(232, 23);
            txtQuantity.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 40);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // lblAddProduct
            // 
            lblAddProduct.AutoSize = true;
            lblAddProduct.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddProduct.Location = new Point(10, 15);
            lblAddProduct.Name = "lblAddProduct";
            lblAddProduct.Size = new Size(119, 25);
            lblAddProduct.TabIndex = 18;
            lblAddProduct.Text = "Add Product";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(465, 63);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 21);
            lblDescription.TabIndex = 19;
            lblDescription.Text = "Description";
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 529);
            Controls.Add(lblDescription);
            Controls.Add(lblAddProduct);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(lblSellPrice);
            Controls.Add(lblQty);
            Controls.Add(lblExpDate);
            Controls.Add(lblMfgDate);
            Controls.Add(lblCategory);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(richTxtDescription);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(txtProductName);
            Controls.Add(lblProduct);
            MaximizeBox = false;
            Name = "frmAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += frmAddProduct_Load_1;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblProduct;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private TextBox textBox3;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private RichTextBox richTxtDescription;
        private Button btnAddProduct;
        private DataGridView gridViewProductList;
        private Label lblCategory;
        private Label lblMfgDate;
        private Label lblExpDate;
        private Label lblQty;
        private Label lblSellPrice;
        private TextBox txtQuantity;
        private Label label1;
        private Label lblAddProduct;
        private Label lblDescription;
    }
}
