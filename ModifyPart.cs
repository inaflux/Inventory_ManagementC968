using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_ManagementC968
{
    public partial class ModifyPart : Form
    {
        public MainScreen mainScreenObject;
        public int selectedPartID;
        public ModifyPart()
        {
            InitializeComponent();
        }

        public void radioBtnChange()
        {
            if (radioBtnInHouse.Checked == true)
            {
                machCompLabel.Text = "Machine ID";
            }
            else
            {
                machCompLabel.Text = "Company Name";

            }
        }



        private void ModifyPart_Load(object sender, EventArgs e)
        {

            var selectedPart = Inventory.LookUpPart(selectedPartID);

            idTextBoxModPart.ReadOnly= true;
            idTextBoxModPart.Text = selectedPart.PartID.ToString();
            nameTextBoxModPart.Text = selectedPart.Name;
            priceTextBoxModPart.Text = selectedPart.Price.ToString();
            inventoryTextBoxModPart.Text = selectedPart.Inventory.ToString();
            minTextBoxModPart.Text = selectedPart.Min.ToString();
            maxTextBoxModPart.Text = selectedPart.Max.ToString();




            if (selectedPart is InHouse)
            {

                machCompLabel.Text = "Machine ID";
                radioBtnInHouse.Checked = true;
                machOrCompTextBoxModPart.Text = ((InHouse)(selectedPart)).MachineID.ToString();
                radioBtnOutsourced.Checked = false;
            }

            else
            {
                machCompLabel.Text = "Company Name";
                radioBtnOutsourced.Checked = true;
                machOrCompTextBoxModPart.Text = ((Outsourced)(selectedPart)).CompanyName;
                radioBtnInHouse.Checked = false;
            }
        }

        private void btnModSavePart_Click(object sender, EventArgs e)


        {

            int inventorySave;
            decimal priceSave;
            int minSave;
            int maxSave;
            try
            {
                inventorySave = Int32.Parse(inventoryTextBoxModPart.Text);
                priceSave = Decimal.Parse(priceTextBoxModPart.Text);
                minSave = Int32.Parse(minTextBoxModPart.Text);
                maxSave = Int32.Parse(maxTextBoxModPart.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Please enter a valid input. Inventory, Price, Min, and Max take numeric inputs only.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int partIDSave = Int32.Parse(idTextBoxModPart.Text);
            string nameSave = nameTextBoxModPart.Text;
            priceSave = Decimal.Parse(priceTextBoxModPart.Text);
            inventorySave = Int32.Parse(inventoryTextBoxModPart.Text);
            minSave = Int32.Parse(minTextBoxModPart.Text);
            maxSave = Int32.Parse(maxTextBoxModPart.Text);

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
                    Int32.Parse(machOrCompTextBoxModPart.Text);
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
                    Int32.Parse(machOrCompTextBoxModPart.Text)
                    );

                Inventory.UpdatePart(selectedPartID, newPart);
                
                //mainScreenObject.RemoveSelectedRow();


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
                    machOrCompTextBoxModPart.Text);
                Inventory.UpdatePart(selectedPartID, newPart);
                //mainScreenObject.AddPartToDGV(newPart);
                //mainScreenObject.RemoveSelectedRow();
            }

            mainScreenObject.AddPartToDGV();
            Close();

        }



        private void btnModCancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtnInHouse_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnChange();
        }

        private void radioBtnOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnChange();
        }
    }
}
