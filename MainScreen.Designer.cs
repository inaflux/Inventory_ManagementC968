namespace Inventory_ManagementC968
{
    partial class MainScreen
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
            label1 = new Label();
            partsDGV = new DataGridView();
            productsDGV = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnPartSearch = new Button();
            txtBoxPartsSearch = new RichTextBox();
            btnProductSearch = new Button();
            txtBoxProdSearch = new RichTextBox();
            btnAddPart = new Button();
            btnModPart = new Button();
            btnDeletePart = new Button();
            btnDeleteProd = new Button();
            btnModProd = new Button();
            btnAddProd = new Button();
            btnExitMainScreen = new Button();
            ((System.ComponentModel.ISupportInitialize)partsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(461, 45);
            label1.TabIndex = 0;
            label1.Text = "Inventroy Management System";
            // 
            // partsDGV
            // 
            partsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsDGV.Location = new Point(44, 201);
            partsDGV.Name = "partsDGV";
            partsDGV.RowHeadersWidth = 62;
            partsDGV.Size = new Size(814, 424);
            partsDGV.TabIndex = 1;
            // 
            // productsDGV
            // 
            productsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDGV.Location = new Point(935, 201);
            productsDGV.Name = "productsDGV";
            productsDGV.RowHeadersWidth = 62;
            productsDGV.Size = new Size(814, 424);
            productsDGV.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 142);
            label2.Name = "label2";
            label2.Size = new Size(77, 38);
            label2.TabIndex = 3;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(935, 142);
            label3.Name = "label3";
            label3.Size = new Size(125, 38);
            label3.TabIndex = 4;
            label3.Text = "Products";
            // 
            // btnPartSearch
            // 
            btnPartSearch.Location = new Point(414, 134);
            btnPartSearch.Name = "btnPartSearch";
            btnPartSearch.Size = new Size(113, 39);
            btnPartSearch.TabIndex = 5;
            btnPartSearch.Text = "Search";
            btnPartSearch.UseVisualStyleBackColor = true;
            btnPartSearch.Click += btnPartSearch_Click;
            // 
            // txtBoxPartsSearch
            // 
            txtBoxPartsSearch.Location = new Point(550, 135);
            txtBoxPartsSearch.Name = "txtBoxPartsSearch";
            txtBoxPartsSearch.Size = new Size(308, 38);
            txtBoxPartsSearch.TabIndex = 6;
            txtBoxPartsSearch.Text = "";
            // 
            // btnProductSearch
            // 
            btnProductSearch.Location = new Point(1303, 134);
            btnProductSearch.Name = "btnProductSearch";
            btnProductSearch.Size = new Size(113, 39);
            btnProductSearch.TabIndex = 7;
            btnProductSearch.Text = "Search";
            btnProductSearch.UseVisualStyleBackColor = true;
            btnProductSearch.Click += btnProductSearch_Click;
            // 
            // txtBoxProdSearch
            // 
            txtBoxProdSearch.Location = new Point(1441, 134);
            txtBoxProdSearch.Name = "txtBoxProdSearch";
            txtBoxProdSearch.Size = new Size(308, 38);
            txtBoxProdSearch.TabIndex = 8;
            txtBoxProdSearch.Text = "";
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(498, 642);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(103, 65);
            btnAddPart.TabIndex = 9;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnModPart
            // 
            btnModPart.Location = new Point(627, 642);
            btnModPart.Name = "btnModPart";
            btnModPart.Size = new Size(103, 65);
            btnModPart.TabIndex = 10;
            btnModPart.Text = "Modify";
            btnModPart.UseVisualStyleBackColor = true;
            btnModPart.Click += btnModPart_Click;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(755, 642);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(103, 65);
            btnDeletePart.TabIndex = 11;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.Location = new Point(1646, 642);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new Size(103, 65);
            btnDeleteProd.TabIndex = 14;
            btnDeleteProd.Text = "Delete";
            btnDeleteProd.UseVisualStyleBackColor = true;
            btnDeleteProd.Click += btnDeleteProd_Click;
            // 
            // btnModProd
            // 
            btnModProd.Location = new Point(1518, 642);
            btnModProd.Name = "btnModProd";
            btnModProd.Size = new Size(103, 65);
            btnModProd.TabIndex = 13;
            btnModProd.Text = "Modify";
            btnModProd.UseVisualStyleBackColor = true;
            btnModProd.Click += btnModProd_Click;
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(1389, 642);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(103, 65);
            btnAddProd.TabIndex = 12;
            btnAddProd.Text = "Add";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // btnExitMainScreen
            // 
            btnExitMainScreen.Location = new Point(1632, 779);
            btnExitMainScreen.Name = "btnExitMainScreen";
            btnExitMainScreen.Size = new Size(117, 57);
            btnExitMainScreen.TabIndex = 16;
            btnExitMainScreen.Text = "Exit";
            btnExitMainScreen.UseVisualStyleBackColor = true;
            btnExitMainScreen.Click += btnExitMainScreen_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1799, 848);
            Controls.Add(btnExitMainScreen);
            Controls.Add(btnDeleteProd);
            Controls.Add(btnModProd);
            Controls.Add(btnAddProd);
            Controls.Add(btnDeletePart);
            Controls.Add(btnModPart);
            Controls.Add(btnAddPart);
            Controls.Add(txtBoxProdSearch);
            Controls.Add(btnProductSearch);
            Controls.Add(txtBoxPartsSearch);
            Controls.Add(btnPartSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(productsDGV);
            Controls.Add(partsDGV);
            Controls.Add(label1);
            Name = "MainScreen";
            Text = "Main Screen";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)partsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView partsDGV;
        private DataGridView productsDGV;
        private Label label2;
        private Label label3;
        private Button btnPartSearch;
        private RichTextBox txtBoxPartsSearch;
        private Button btnProductSearch;
        private RichTextBox txtBoxProdSearch;
        private Button btnAddPart;
        private Button btnModPart;
        private Button btnDeletePart;
        private Button btnDeleteProd;
        private Button btnModProd;
        private Button btnAddProd;
        private Button btnExitMainScreen;
    }
}
