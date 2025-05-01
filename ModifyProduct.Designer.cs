namespace Inventory_ManagementC968
{
    partial class ModifyProduct
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
            searchPartsProd = new TextBox();
            btnAddAssocParts = new Button();
            btnSaveModProd = new Button();
            btnDeleteModProd = new Button();
            btnCancelModPart = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idTextBoxModProd = new TextBox();
            nameTextBoxModProd = new TextBox();
            label5 = new Label();
            inventoryTextBoxModProd = new TextBox();
            label6 = new Label();
            priceTextBoxModProd = new TextBox();
            label7 = new Label();
            label8 = new Label();
            maxTextBoxModProd = new TextBox();
            minTextBoxModProd = new TextBox();
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
            label1.Size = new Size(240, 45);
            label1.TabIndex = 0;
            label1.Text = "Modify Product";
            // 
            // allPartsDGV
            // 
            allPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allPartsDGV.Location = new Point(644, 125);
            allPartsDGV.Name = "allPartsDGV";
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
            // searchPartsProd
            // 
            searchPartsProd.Location = new Point(1040, 53);
            searchPartsProd.Multiline = true;
            searchPartsProd.Name = "searchPartsProd";
            searchPartsProd.Size = new Size(382, 46);
            searchPartsProd.TabIndex = 4;
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
            // btnSaveModProd
            // 
            btnSaveModProd.Location = new Point(1123, 727);
            btnSaveModProd.Name = "btnSaveModProd";
            btnSaveModProd.Size = new Size(78, 46);
            btnSaveModProd.TabIndex = 6;
            btnSaveModProd.Text = "Save";
            btnSaveModProd.UseVisualStyleBackColor = true;
            btnSaveModProd.Click += btnSaveModProd_Click;
            // 
            // btnDeleteModProd
            // 
            btnDeleteModProd.Location = new Point(1228, 727);
            btnDeleteModProd.Name = "btnDeleteModProd";
            btnDeleteModProd.Size = new Size(78, 46);
            btnDeleteModProd.TabIndex = 7;
            btnDeleteModProd.Text = "Delete";
            btnDeleteModProd.UseVisualStyleBackColor = true;
            btnDeleteModProd.Click += btnDeleteModProd_Click;
            // 
            // btnCancelModPart
            // 
            btnCancelModPart.Location = new Point(1325, 727);
            btnCancelModPart.Name = "btnCancelModPart";
            btnCancelModPart.Size = new Size(78, 46);
            btnCancelModPart.TabIndex = 8;
            btnCancelModPart.Text = "Cancel";
            btnCancelModPart.UseVisualStyleBackColor = true;
            btnCancelModPart.Click += btnCancelModPart_Click;
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
            // idTextBoxModProd
            // 
            idTextBoxModProd.Location = new Point(158, 260);
            idTextBoxModProd.Multiline = true;
            idTextBoxModProd.Name = "idTextBoxModProd";
            idTextBoxModProd.Size = new Size(244, 46);
            idTextBoxModProd.TabIndex = 12;
            // 
            // nameTextBoxModProd
            // 
            nameTextBoxModProd.Location = new Point(158, 355);
            nameTextBoxModProd.Multiline = true;
            nameTextBoxModProd.Name = "nameTextBoxModProd";
            nameTextBoxModProd.Size = new Size(244, 46);
            nameTextBoxModProd.TabIndex = 14;
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
            // inventoryTextBoxModProd
            // 
            inventoryTextBoxModProd.Location = new Point(158, 433);
            inventoryTextBoxModProd.Multiline = true;
            inventoryTextBoxModProd.Name = "inventoryTextBoxModProd";
            inventoryTextBoxModProd.Size = new Size(244, 46);
            inventoryTextBoxModProd.TabIndex = 16;
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
            // priceTextBoxModProd
            // 
            priceTextBoxModProd.Location = new Point(158, 517);
            priceTextBoxModProd.Multiline = true;
            priceTextBoxModProd.Name = "priceTextBoxModProd";
            priceTextBoxModProd.Size = new Size(244, 46);
            priceTextBoxModProd.TabIndex = 18;
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
            // maxTextBoxModProd
            // 
            maxTextBoxModProd.Location = new Point(139, 607);
            maxTextBoxModProd.Multiline = true;
            maxTextBoxModProd.Name = "maxTextBoxModProd";
            maxTextBoxModProd.Size = new Size(133, 46);
            maxTextBoxModProd.TabIndex = 20;
            // 
            // minTextBoxModProd
            // 
            minTextBoxModProd.Location = new Point(358, 607);
            minTextBoxModProd.Multiline = true;
            minTextBoxModProd.Name = "minTextBoxModProd";
            minTextBoxModProd.Size = new Size(133, 46);
            minTextBoxModProd.TabIndex = 22;
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
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 848);
            Controls.Add(minTextBoxModProd);
            Controls.Add(label9);
            Controls.Add(maxTextBoxModProd);
            Controls.Add(label8);
            Controls.Add(priceTextBoxModProd);
            Controls.Add(label7);
            Controls.Add(inventoryTextBoxModProd);
            Controls.Add(label6);
            Controls.Add(nameTextBoxModProd);
            Controls.Add(label5);
            Controls.Add(idTextBoxModProd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelModPart);
            Controls.Add(btnDeleteModProd);
            Controls.Add(btnSaveModProd);
            Controls.Add(btnAddAssocParts);
            Controls.Add(searchPartsProd);
            Controls.Add(btnSearchAddProd);
            Controls.Add(associatedPartsDGV);
            Controls.Add(allPartsDGV);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "AddProduct";
            Load += ModifyProduct_Load;
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
        private TextBox searchPartsProd;
        private Button btnAddAssocParts;
        private Button btnSaveModProd;
        private Button btnDeleteModProd;
        private Button btnCancelModPart;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idTextBoxModProd;
        private TextBox nameTextBoxModProd;
        private Label label5;
        private TextBox inventoryTextBoxModProd;
        private Label label6;
        private TextBox priceTextBoxModProd;
        private Label label7;
        private Label label8;
        private TextBox maxTextBoxModProd;
        private TextBox minTextBoxModProd;
        private Label label9;
    }
}