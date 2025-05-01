using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_ManagementC968
{
    public partial class AddPart : Form
    {
        public MainScreen mainScreenObject;
        
        public AddPart()
        {
            InitializeComponent();


        }
        //Ex: the name textbox
        //The name textbox can only take a string
        //If thew user tries to enter a value other than string then the textbox turns red and a hover/tooltip appears that says, "name required"

        private void AddPart_Load(object sender, EventArgs e)
        {

            Inventory.GeneratePartID();
            int newPartID = Inventory.GeneratePartID();
            idTextBoxAddPart.ReadOnly = true;
            idTextBoxAddPart.Text = newPartID.ToString();

            nameTextBoxAddPart.BackColor = Color.Pink;
            priceTextBoxAddPart.BackColor = Color.Pink;
            inventoryTextBoxAddPart.BackColor = Color.Pink;
            minTextBoxAddPart.BackColor = Color.Pink;
            maxTextBoxAddPart.BackColor = Color.Pink;
            
        }




        public void radioBtnChange()
        {
            if (radioBtnInHouse.Checked == true)
            {
                machIDOrComNameLabel.Text = "Machine ID";
            }
            else
            {
                machIDOrComNameLabel.Text = "Company Name";

            }
        }

        private void radioBtnInHouse_CheckedChanged(object sender, EventArgs e)
        {

            radioBtnChange();
        }

        private void radioBtnOutsourced_CheckedChanged(object sender, EventArgs e)
        {

            radioBtnChange();
        }

        private void btnSavePart_Click(object sender, EventArgs e)
        {



            int inventorySave;
            decimal priceSave;
            int minSave;
            int maxSave;
            try
            {
                inventorySave = Int32.Parse(inventoryTextBoxAddPart.Text);
                priceSave = Decimal.Parse(priceTextBoxAddPart.Text);
                minSave = Int32.Parse(minTextBoxAddPart.Text);
                maxSave = Int32.Parse(maxTextBoxAddPart.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Please enter a valid input. Inventory, Price, Min, and Max, take numeric inputs only.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int partIDSave = Inventory.GeneratePartID();
            
            string nameSave = nameTextBoxAddPart.Text;
            priceSave = Decimal.Parse(priceTextBoxAddPart.Text);
            inventorySave = Int32.Parse(inventoryTextBoxAddPart.Text);
            minSave = Int32.Parse(minTextBoxAddPart.Text);
            maxSave = Int32.Parse(maxTextBoxAddPart.Text);


            if (minSave > maxSave)
            {
                MessageBox.Show("The min number of parts cannot be greater than the max number of parts. Please enter a valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inventorySave < minSave || inventorySave > maxSave)
            {
                MessageBox.Show("The number of parts in inventory cannot be outside of the min/max bounds. Please enter a valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioBtnInHouse.Checked)
            {

                try
                {
                    Int32.Parse(machOrCompTextBoxAddPart.Text);
                }

                catch (FormatException)
                {
                    MessageBox.Show("Machine ID must be a valid integer. Please enter a valid input", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                InHouse newPart = new InHouse(
                    partIDSave,
                    nameSave,
                    priceSave,
                    inventorySave,
                    minSave,
                    maxSave,
                    Int32.Parse(machOrCompTextBoxAddPart.Text)
                    );
                Inventory.AddPart(newPart);
                mainScreenObject.AddPartToDGV();


            }
            else
            {
                Outsourced newPart = new Outsourced(
                     partIDSave,
                    nameSave,
                    priceSave,
                    inventorySave,
                    minSave,
                    maxSave,
                    machOrCompTextBoxAddPart.Text);
                Inventory.AddPart(newPart);
                mainScreenObject.AddPartToDGV();
            }


            Close();

        }

        private void btnCancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventoryTextBoxAddPart_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(inventoryTextBoxAddPart.Text, out int value))
            {
                inventoryTextBoxAddPart.BackColor = Color.Pink;

                toolTipinventory.Show("Inventory Quantity Required", inventoryTextBoxAddPart, 0, -20, 3000);
                return;
            }

            else
            {
                inventoryTextBoxAddPart.BackColor = Color.White;
                toolTipinventory.Hide(inventoryTextBoxAddPart);
                return;
            }
        }

        private void nameTextBoxAddPart_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBoxAddPart.Text) || Int32.TryParse(nameTextBoxAddPart.Text, out int i))
            {
                nameTextBoxAddPart.BackColor = Color.Pink;
                toolTipName.Show("Name Number Required", nameTextBoxAddPart, 0, -20, 3000);
                return;
            }

            else
            {
                nameTextBoxAddPart.BackColor = Color.White;
                toolTipName.Hide(nameTextBoxAddPart);
                return;
            }
        }

        private void priceTextBoxAddPart_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(priceTextBoxAddPart.Text, out decimal value))
            {
                priceTextBoxAddPart.BackColor = Color.Pink;
                toolTipPrice.Show("Price Decimal Required", priceTextBoxAddPart, 0, -20, 3000);
                return;
            }

            else
            {
                priceTextBoxAddPart.BackColor = Color.White;
                toolTipPrice.Hide(priceTextBoxAddPart);
                return;
            }
        }

        private void minTextBoxAddPart_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(minTextBoxAddPart.Text, out int value))
            {
                minTextBoxAddPart.BackColor = Color.Pink;
                toolTipMin.Show("Min Number Required", minTextBoxAddPart, 0, -20, 3000);
                return;
            }

            else
            {
                minTextBoxAddPart.BackColor = Color.White;
                toolTipMin.Hide(minTextBoxAddPart);
                return;
            }
        }

        private void maxTextBoxAddPart_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(maxTextBoxAddPart.Text, out int value))
            {
                maxTextBoxAddPart.BackColor = Color.Pink;
                toolTipMax.Show("Max Number Required", maxTextBoxAddPart, 0, -20, 3000);
                return;
            }

            else
            {
                maxTextBoxAddPart.BackColor = Color.White;
                toolTipMax.Hide(maxTextBoxAddPart);
                return;
            }
        }

        private void machOrCompTextBoxAddPart_TextChanged(object sender, EventArgs e)
        {
            if (radioBtnInHouse.Checked == true)
            {

                if (!Int32.TryParse(machOrCompTextBoxAddPart.Text, out int value))
                {
                    

                    machOrCompTextBoxAddPart.BackColor = Color.Pink;
                    toolTipMach.Show("Machine ID Required", machOrCompTextBoxAddPart, 0, -20, 3000);


                    return;
                  
                }

                else 
                {
                    machOrCompTextBoxAddPart.BackColor = Color.White;
                    toolTipMach.Hide(machOrCompTextBoxAddPart);
                    return;
                }  
            }

           

        }


    }
}
