namespace Inventory_ManagementC968
{
    partial class AddProduct
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
            label1 = new Label();
            allPartsDGV = new DataGridView();
            associatedPartsDGV = new DataGridView();
            btnSearchAddProd = new Button();
            searchPartsAddProd = new TextBox();
            btnAddAssocParts = new Button();
            btnSaveAddProd = new Button();
            btnDeleteAddProd = new Button();
            btnCancelAddPart = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idTextBoxAddProd = new TextBox();
            nameTextBoxAddProd = new TextBox();
            label5 = new Label();
            inventoryTextBoxAddProd = new TextBox();
            label6 = new Label();
            priceTextBoxAddProd = new TextBox();
            label7 = new Label();
            label8 = new Label();
            maxTextBoxAddProd = new TextBox();
            minTextBoxAddProd = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)allPartsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(199, 45);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // allPartsDGV
            // 
            allPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allPartsDGV.Location = new Point(644, 125);
            allPartsDGV.Name = "allPartsDGV";
            allPartsDGV.RightToLeft = RightToLeft.Yes;
            allPartsDGV.RowHeadersWidth = 62;
            allPartsDGV.Size = new Size(778, 213);
            allPartsDGV.TabIndex = 1;
            // 
            // associatedPartsDGV
            // 
            associatedPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedPartsDGV.Location = new Point(644, 485);
            associatedPartsDGV.Name = "associatedPartsDGV";
            associatedPartsDGV.RowHeadersWidth = 62;
            associatedPartsDGV.Size = new Size(778, 227);
            associatedPartsDGV.TabIndex = 2;
            // 
            // btnSearchAddProd
            // 
            btnSearchAddProd.Location = new Point(929, 53);
            btnSearchAddProd.Name = "btnSearchAddProd";
            btnSearchAddProd.Size = new Size(78, 46);
            btnSearchAddProd.TabIndex = 3;
            btnSearchAddProd.Text = "Search";
            btnSearchAddProd.UseVisualStyleBackColor = true;
            btnSearchAddProd.Click += btnSearchAddProd_Click;
            // 
            // searchPartsAddProd
            // 
            searchPartsAddProd.Location = new Point(1040, 53);
            searchPartsAddProd.Multiline = true;
            searchPartsAddProd.Name = "searchPartsAddProd";
            searchPartsAddProd.Size = new Size(382, 46);
            searchPartsAddProd.TabIndex = 4;
            // 
            // btnAddAssocParts
            // 
            btnAddAssocParts.Location = new Point(1325, 355);
            btnAddAssocParts.Name = "btnAddAssocParts";
            btnAddAssocParts.Size = new Size(78, 46);
            btnAddAssocParts.TabIndex = 5;
            btnAddAssocParts.Text = "Add";
            btnAddAssocParts.UseVisualStyleBackColor = true;
            btnAddAssocParts.Click += btnAddAssocParts_Click;
            // 
            // btnSaveAddProd
            // 
            btnSaveAddProd.Location = new Point(1123, 727);
            btnSaveAddProd.Name = "btnSaveAddProd";
            btnSaveAddProd.Size = new Size(78, 46);
            btnSaveAddProd.TabIndex = 6;
            btnSaveAddProd.Text = "Save";
            btnSaveAddProd.UseVisualStyleBackColor = true;
            btnSaveAddProd.Click += btnSaveAddProd_Click;
            // 
            // btnDeleteAddProd
            // 
            btnDeleteAddProd.Location = new Point(1228, 727);
            btnDeleteAddProd.Name = "btnDeleteAddProd";
            btnDeleteAddProd.Size = new Size(78, 46);
            btnDeleteAddProd.TabIndex = 7;
            btnDeleteAddProd.Text = "Delete";
            btnDeleteAddProd.UseVisualStyleBackColor = true;
            btnDeleteAddProd.Click += btnDeleteAddProd_Click;
            // 
            // btnCancelAddPart
            // 
            btnCancelAddPart.Location = new Point(1325, 727);
            btnCancelAddPart.Name = "btnCancelAddPart";
            btnCancelAddPart.Size = new Size(78, 46);
            btnCancelAddPart.TabIndex = 8;
            btnCancelAddPart.Text = "Cancel";
            btnCancelAddPart.UseVisualStyleBackColor = true;
            btnCancelAddPart.Click += btnCancelAddPart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 83);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 9;
            label2.Text = "All Candidate Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(644, 436);
            label3.Name = "label3";
            label3.Size = new Size(313, 25);
            label3.TabIndex = 10;
            label3.Text = "Parts that associated with this product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 260);
            label4.Name = "label4";
            label4.Size = new Size(31, 28);
            label4.TabIndex = 11;
            label4.Text = "ID";
            // 
            // idTextBoxAddProd
            // 
            idTextBoxAddProd.Location = new Point(158, 260);
            idTextBoxAddProd.Multiline = true;
            idTextBoxAddProd.Name = "idTextBoxAddProd";
            idTextBoxAddProd.Size = new Size(244, 46);
            idTextBoxAddProd.TabIndex = 12;
            // 
            // nameTextBoxAddProd
            // 
            nameTextBoxAddProd.Location = new Point(158, 355);
            nameTextBoxAddProd.Multiline = true;
            nameTextBoxAddProd.Name = "nameTextBoxAddProd";
            nameTextBoxAddProd.Size = new Size(244, 46);
            nameTextBoxAddProd.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 355);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 13;
            label5.Text = "Name";
            // 
            // inventoryTextBoxAddProd
            // 
            inventoryTextBoxAddProd.Location = new Point(158, 433);
            inventoryTextBoxAddProd.Multiline = true;
            inventoryTextBoxAddProd.Name = "inventoryTextBoxAddProd";
            inventoryTextBoxAddProd.Size = new Size(244, 46);
            inventoryTextBoxAddProd.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 433);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 15;
            label6.Text = "Inventory";
            // 
            // priceTextBoxAddProd
            // 
            priceTextBoxAddProd.Location = new Point(158, 517);
            priceTextBoxAddProd.Multiline = true;
            priceTextBoxAddProd.Name = "priceTextBoxAddProd";
            priceTextBoxAddProd.Size = new Size(244, 46);
            priceTextBoxAddProd.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(70, 517);
            label7.Name = "label7";
            label7.Size = new Size(54, 28);
            label7.TabIndex = 17;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(70, 607);
            label8.Name = "label8";
            label8.Size = new Size(49, 28);
            label8.TabIndex = 19;
            label8.Text = "Max";
            // 
            // maxTextBoxAddProd
            // 
            maxTextBoxAddProd.Location = new Point(139, 607);
            maxTextBoxAddProd.Multiline = true;
            maxTextBoxAddProd.Name = "maxTextBoxAddProd";
            maxTextBoxAddProd.Size = new Size(133, 46);
            maxTextBoxAddProd.TabIndex = 20;
            // 
            // minTextBoxAddProd
            // 
            minTextBoxAddProd.Location = new Point(358, 607);
            minTextBoxAddProd.Multiline = true;
            minTextBoxAddProd.Name = "minTextBoxAddProd";
            minTextBoxAddProd.Size = new Size(133, 46);
            minTextBoxAddProd.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(289, 607);
            label9.Name = "label9";
            label9.Size = new Size(46, 28);
            label9.TabIndex = 21;
            label9.Text = "Min";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 848);
            Controls.Add(minTextBoxAddProd);
            Controls.Add(label9);
            Controls.Add(maxTextBoxAddProd);
            Controls.Add(label8);
            Controls.Add(priceTextBoxAddProd);
            Controls.Add(label7);
            Controls.Add(inventoryTextBoxAddProd);
            Controls.Add(label6);
            Controls.Add(nameTextBoxAddProd);
            Controls.Add(label5);
            Controls.Add(idTextBoxAddProd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelAddPart);
            Controls.Add(btnDeleteAddProd);
            Controls.Add(btnSaveAddProd);
            Controls.Add(btnAddAssocParts);
            Controls.Add(searchPartsAddProd);
            Controls.Add(btnSearchAddProd);
            Controls.Add(associatedPartsDGV);
            Controls.Add(allPartsDGV);
            Controls.Add(label1);
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)allPartsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView allPartsDGV;
        private DataGridView associatedPartsDGV;
        private Button btnSearchAddProd;
        private TextBox searchPartsAddProd;
        private Button btnAddAssocParts;
        private Button btnSaveAddProd;
        private Button btnDeleteAddProd;
        private Button btnCancelAddPart;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idTextBoxAddProd;
        private TextBox nameTextBoxAddProd;
        private Label label5;
        private TextBox inventoryTextBoxAddProd;
        private Label label6;
        private TextBox priceTextBoxAddProd;
        private Label label7;
        private Label label8;
        private TextBox maxTextBoxAddProd;
        private TextBox minTextBoxAddProd;
        private Label label9;
    }
}