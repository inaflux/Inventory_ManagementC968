namespace Inventory_ManagementC968
{
    partial class ModifyPart
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
            radioBtnInHouse = new RadioButton();
            radioBtnOutsourced = new RadioButton();
            btnModSavePart = new Button();
            label2 = new Label();
            idTextBoxModPart = new TextBox();
            nameTextBoxModPart = new TextBox();
            label3 = new Label();
            inventoryTextBoxModPart = new TextBox();
            label4 = new Label();
            priceTextBoxModPart = new TextBox();
            label5 = new Label();
            machOrCompTextBoxModPart = new TextBox();
            machCompLabel = new Label();
            label7 = new Label();
            maxTextBoxModPart = new TextBox();
            minTextBoxModPart = new TextBox();
            label8 = new Label();
            btnModCancelPart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 0;
            label1.Text = "Modify Part";
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
            // btnModSavePart
            // 
            btnModSavePart.Location = new Point(526, 683);
            btnModSavePart.Name = "btnModSavePart";
            btnModSavePart.Size = new Size(112, 62);
            btnModSavePart.TabIndex = 3;
            btnModSavePart.Text = "Save";
            btnModSavePart.UseVisualStyleBackColor = true;
            btnModSavePart.Click += btnModSavePart_Click;
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
            // idTextBoxModPart
            // 
            idTextBoxModPart.Location = new Point(294, 149);
            idTextBoxModPart.Multiline = true;
            idTextBoxModPart.Name = "idTextBoxModPart";
            idTextBoxModPart.Size = new Size(291, 56);
            idTextBoxModPart.TabIndex = 5;
            // 
            // nameTextBoxModPart
            // 
            nameTextBoxModPart.Location = new Point(294, 244);
            nameTextBoxModPart.Multiline = true;
            nameTextBoxModPart.Name = "nameTextBoxModPart";
            nameTextBoxModPart.Size = new Size(291, 56);
            nameTextBoxModPart.TabIndex = 7;
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
            // inventoryTextBoxModPart
            // 
            inventoryTextBoxModPart.Location = new Point(294, 339);
            inventoryTextBoxModPart.Multiline = true;
            inventoryTextBoxModPart.Name = "inventoryTextBoxModPart";
            inventoryTextBoxModPart.Size = new Size(291, 56);
            inventoryTextBoxModPart.TabIndex = 9;
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
            // priceTextBoxModPart
            // 
            priceTextBoxModPart.Location = new Point(294, 441);
            priceTextBoxModPart.Multiline = true;
            priceTextBoxModPart.Name = "priceTextBoxModPart";
            priceTextBoxModPart.Size = new Size(291, 56);
            priceTextBoxModPart.TabIndex = 11;
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
            // machOrCompTextBoxModPart
            // 
            machOrCompTextBoxModPart.Location = new Point(294, 606);
            machOrCompTextBoxModPart.Multiline = true;
            machOrCompTextBoxModPart.Name = "machOrCompTextBoxModPart";
            machOrCompTextBoxModPart.Size = new Size(291, 56);
            machOrCompTextBoxModPart.TabIndex = 13;
            // 
            // machCompLabel
            // 
            machCompLabel.AutoSize = true;
            machCompLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machCompLabel.Location = new Point(56, 624);
            machCompLabel.Name = "machCompLabel";
            machCompLabel.Size = new Size(158, 38);
            machCompLabel.TabIndex = 12;
            machCompLabel.Text = "Machine ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(477, 536);
            label7.Name = "label7";
            label7.Size = new Size(69, 38);
            label7.TabIndex = 14;
            label7.Text = "Max";
            // 
            // maxTextBoxModPart
            // 
            maxTextBoxModPart.Location = new Point(573, 536);
            maxTextBoxModPart.Multiline = true;
            maxTextBoxModPart.Name = "maxTextBoxModPart";
            maxTextBoxModPart.Size = new Size(137, 46);
            maxTextBoxModPart.TabIndex = 15;
            // 
            // minTextBoxModPart
            // 
            minTextBoxModPart.Location = new Point(294, 536);
            minTextBoxModPart.Multiline = true;
            minTextBoxModPart.Name = "minTextBoxModPart";
            minTextBoxModPart.Size = new Size(137, 46);
            minTextBoxModPart.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(196, 536);
            label8.Name = "label8";
            label8.Size = new Size(65, 38);
            label8.TabIndex = 16;
            label8.Text = "Min";
            // 
            // btnModCancelPart
            // 
            btnModCancelPart.Location = new Point(666, 683);
            btnModCancelPart.Name = "btnModCancelPart";
            btnModCancelPart.Size = new Size(112, 62);
            btnModCancelPart.TabIndex = 18;
            btnModCancelPart.Text = "Cancel";
            btnModCancelPart.UseVisualStyleBackColor = true;
            btnModCancelPart.Click += btnModCancelPart_Click;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 780);
            Controls.Add(btnModCancelPart);
            Controls.Add(minTextBoxModPart);
            Controls.Add(label8);
            Controls.Add(maxTextBoxModPart);
            Controls.Add(label7);
            Controls.Add(machOrCompTextBoxModPart);
            Controls.Add(machCompLabel);
            Controls.Add(priceTextBoxModPart);
            Controls.Add(label5);
            Controls.Add(inventoryTextBoxModPart);
            Controls.Add(label4);
            Controls.Add(nameTextBoxModPart);
            Controls.Add(label3);
            Controls.Add(idTextBoxModPart);
            Controls.Add(label2);
            Controls.Add(btnModSavePart);
            Controls.Add(radioBtnOutsourced);
            Controls.Add(radioBtnInHouse);
            Controls.Add(label1);
            Name = "ModifyPart";
            Text = "Modify Part";
            Load += ModifyPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioBtnInHouse;
        private RadioButton radioBtnOutsourced;
        private Button btnModSavePart;
        private Label label2;
        private TextBox idTextBoxModPart;
        private TextBox nameTextBoxModPart;
        private Label label3;
        private TextBox inventoryTextBoxModPart;
        private Label label4;
        private TextBox priceTextBoxModPart;
        private Label label5;
        private TextBox machOrCompTextBoxModPart;
        private Label machCompLabel;
        private Label label7;
        private TextBox maxTextBoxModPart;
        private TextBox minTextBoxModPart;
        private Label label8;
        private Button btnModCancelPart;
    }
}