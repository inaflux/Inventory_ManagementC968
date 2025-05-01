namespace Inventory_ManagementC968
{
    partial class AddPart
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            radioBtnInHouse = new RadioButton();
            radioBtnOutsourced = new RadioButton();
            btnSavePart = new Button();
            label2 = new Label();
            idTextBoxAddPart = new TextBox();
            nameTextBoxAddPart = new TextBox();
            label3 = new Label();
            inventoryTextBoxAddPart = new TextBox();
            label4 = new Label();
            priceTextBoxAddPart = new TextBox();
            label5 = new Label();
            machOrCompTextBoxAddPart = new TextBox();
            machIDOrComNameLabel = new Label();
            label7 = new Label();
            maxTextBoxAddPart = new TextBox();
            minTextBoxAddPart = new TextBox();
            label8 = new Label();
            btnCancelPart = new Button();
            toolTipName = new ToolTip(components);
            toolTipinventory = new ToolTip(components);
            toolTipPrice = new ToolTip(components);
            toolTipMin = new ToolTip(components);
            toolTipMax = new ToolTip(components);
            toolTipMach = new ToolTip(components);
            toolTipComp = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(143, 45);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // radioBtnInHouse
            // 
            radioBtnInHouse.AutoSize = true;
            radioBtnInHouse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtnInHouse.Location = new Point(256, 56);
            radioBtnInHouse.Name = "radioBtnInHouse";
            radioBtnInHouse.Size = new Size(137, 36);
            radioBtnInHouse.TabIndex = 1;
            radioBtnInHouse.TabStop = true;
            radioBtnInHouse.Text = "In-House";
            radioBtnInHouse.UseVisualStyleBackColor = true;
            radioBtnInHouse.CheckedChanged += radioBtnInHouse_CheckedChanged;
            // 
            // radioBtnOutsourced
            // 
            radioBtnOutsourced.AutoSize = true;
            radioBtnOutsourced.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtnOutsourced.Location = new Point(422, 57);
            radioBtnOutsourced.Name = "radioBtnOutsourced";
            radioBtnOutsourced.Size = new Size(163, 36);
            radioBtnOutsourced.TabIndex = 2;
            radioBtnOutsourced.TabStop = true;
            radioBtnOutsourced.Text = "Outsourced";
            radioBtnOutsourced.UseVisualStyleBackColor = true;
            radioBtnOutsourced.CheckedChanged += radioBtnOutsourced_CheckedChanged;
            // 
            // btnSavePart
            // 
            btnSavePart.Location = new Point(526, 683);
            btnSavePart.Name = "btnSavePart";
            btnSavePart.Size = new Size(112, 62);
            btnSavePart.TabIndex = 3;
            btnSavePart.Text = "Save";
            btnSavePart.UseVisualStyleBackColor = true;
            btnSavePart.Click += btnSavePart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 149);
            label2.Name = "label2";
            label2.Size = new Size(44, 38);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // idTextBoxAddPart
            // 
            idTextBoxAddPart.Location = new Point(294, 149);
            idTextBoxAddPart.Multiline = true;
            idTextBoxAddPart.Name = "idTextBoxAddPart";
            idTextBoxAddPart.Size = new Size(291, 56);
            idTextBoxAddPart.TabIndex = 5;
            // 
            // nameTextBoxAddPart
            // 
            nameTextBoxAddPart.Location = new Point(294, 244);
            nameTextBoxAddPart.Multiline = true;
            nameTextBoxAddPart.Name = "nameTextBoxAddPart";
            nameTextBoxAddPart.Size = new Size(291, 56);
            nameTextBoxAddPart.TabIndex = 7;
            toolTipName.SetToolTip(nameTextBoxAddPart, "Name Required");
            nameTextBoxAddPart.TextChanged += nameTextBoxAddPart_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 244);
            label3.Name = "label3";
            label3.Size = new Size(91, 38);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // inventoryTextBoxAddPart
            // 
            inventoryTextBoxAddPart.Location = new Point(294, 339);
            inventoryTextBoxAddPart.Multiline = true;
            inventoryTextBoxAddPart.Name = "inventoryTextBoxAddPart";
            inventoryTextBoxAddPart.Size = new Size(291, 56);
            inventoryTextBoxAddPart.TabIndex = 9;
            toolTipinventory.SetToolTip(inventoryTextBoxAddPart, "Inventory Quantity Required");
            inventoryTextBoxAddPart.TextChanged += inventoryTextBoxAddPart_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 339);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 8;
            label4.Text = "Inventory";
            // 
            // priceTextBoxAddPart
            // 
            priceTextBoxAddPart.Location = new Point(294, 441);
            priceTextBoxAddPart.Multiline = true;
            priceTextBoxAddPart.Name = "priceTextBoxAddPart";
            priceTextBoxAddPart.Size = new Size(291, 56);
            priceTextBoxAddPart.TabIndex = 11;
            toolTipPrice.SetToolTip(priceTextBoxAddPart, "Price Required");
            priceTextBoxAddPart.TextChanged += priceTextBoxAddPart_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(189, 441);
            label5.Name = "label5";
            label5.Size = new Size(78, 38);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // machOrCompTextBoxAddPart
            // 
            machOrCompTextBoxAddPart.Location = new Point(294, 606);
            machOrCompTextBoxAddPart.Multiline = true;
            machOrCompTextBoxAddPart.Name = "machOrCompTextBoxAddPart";
            machOrCompTextBoxAddPart.Size = new Size(291, 56);
            machOrCompTextBoxAddPart.TabIndex = 13;
            toolTipMach.SetToolTip(machOrCompTextBoxAddPart, "Machine ID Required");
            // 
            // machIDOrComNameLabel
            // 
            machIDOrComNameLabel.AutoSize = true;
            machIDOrComNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machIDOrComNameLabel.Location = new Point(56, 624);
            machIDOrComNameLabel.Name = "machIDOrComNameLabel";
            machIDOrComNameLabel.Size = new Size(158, 38);
            machIDOrComNameLabel.TabIndex = 12;
            machIDOrComNameLabel.Text = "Machine ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(469, 538);
            label7.Name = "label7";
            label7.Size = new Size(69, 38);
            label7.TabIndex = 14;
            label7.Text = "Max";
            // 
            // maxTextBoxAddPart
            // 
            maxTextBoxAddPart.Location = new Point(565, 538);
            maxTextBoxAddPart.Multiline = true;
            maxTextBoxAddPart.Name = "maxTextBoxAddPart";
            maxTextBoxAddPart.Size = new Size(137, 46);
            maxTextBoxAddPart.TabIndex = 15;
            toolTipMax.SetToolTip(maxTextBoxAddPart, "Max Quantity Required");
            maxTextBoxAddPart.TextChanged += maxTextBoxAddPart_TextChanged;
            // 
            // minTextBoxAddPart
            // 
            minTextBoxAddPart.Location = new Point(294, 538);
            minTextBoxAddPart.Multiline = true;
            minTextBoxAddPart.Name = "minTextBoxAddPart";
            minTextBoxAddPart.Size = new Size(137, 46);
            minTextBoxAddPart.TabIndex = 17;
            toolTipMin.SetToolTip(minTextBoxAddPart, "Min Quantity Required");
            minTextBoxAddPart.TextChanged += minTextBoxAddPart_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(196, 538);
            label8.Name = "label8";
            label8.Size = new Size(65, 38);
            label8.TabIndex = 16;
            label8.Text = "Min";
            // 
            // btnCancelPart
            // 
            btnCancelPart.Location = new Point(666, 683);
            btnCancelPart.Name = "btnCancelPart";
            btnCancelPart.Size = new Size(112, 62);
            btnCancelPart.TabIndex = 18;
            btnCancelPart.Text = "Cancel";
            btnCancelPart.UseVisualStyleBackColor = true;
            btnCancelPart.Click += btnCancelPart_Click;
            // 
            // toolTipName
            // 
            toolTipName.Tag = "";
            toolTipName.ToolTipTitle = "Name Required";
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 780);
            Controls.Add(btnCancelPart);
            Controls.Add(minTextBoxAddPart);
            Controls.Add(label8);
            Controls.Add(maxTextBoxAddPart);
            Controls.Add(label7);
            Controls.Add(machOrCompTextBoxAddPart);
            Controls.Add(machIDOrComNameLabel);
            Controls.Add(priceTextBoxAddPart);
            Controls.Add(label5);
            Controls.Add(inventoryTextBoxAddPart);
            Controls.Add(label4);
            Controls.Add(nameTextBoxAddPart);
            Controls.Add(label3);
            Controls.Add(idTextBoxAddPart);
            Controls.Add(label2);
            Controls.Add(btnSavePart);
            Controls.Add(radioBtnOutsourced);
            Controls.Add(radioBtnInHouse);
            Controls.Add(label1);
            Name = "AddPart";
            Text = "Form1";
            Load += AddPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioBtnInHouse;
        private RadioButton radioBtnOutsourced;
        private Button btnSavePart;
        private Label label2;
        private TextBox idTextBoxAddPart;
        private TextBox nameTextBoxAddPart;
        private Label label3;
        private TextBox inventoryTextBoxAddPart;
        private Label label4;
        private TextBox priceTextBoxAddPart;
        private Label label5;
        private TextBox machOrCompTextBoxAddPart;
        private Label machIDOrComNameLabel;
        private Label label7;
        private TextBox maxTextBoxAddPart;
        private TextBox minTextBoxAddPart;
        private Label label8;
        private Button btnCancelPart;
        private ToolTip toolTipName;
        private ToolTip toolTipinventory;
        private ToolTip toolTipPrice;
        private ToolTip toolTipMin;
        private ToolTip toolTipMax;
        private ToolTip toolTipMach;
        private ToolTip toolTipComp;
    }
}