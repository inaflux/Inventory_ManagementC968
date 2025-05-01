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
    public partial class ModifyProduct : Form
    {

        BindingList<Part> associatedParts = new BindingList<Part>();
        public MainScreen mainScreenObject;
        public int selectedProdID;
        public ModifyProduct()
        {
            InitializeComponent();

            var candidateTable = new BindingSource();
            candidateTable.DataSource = Inventory.AllParts;
            allPartsDGV.DataSource = candidateTable;


            var associatedTable = new BindingSource();
            associatedTable.DataSource = associatedParts;
            associatedPartsDGV.DataSource = associatedTable;

        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            var selectedProd = Inventory.LookUpProduct(selectedProdID);

            idTextBoxModProd.ReadOnly = true;
            idTextBoxModProd.Text = selectedProd.ProductID.ToString();
            nameTextBoxModProd.Text = selectedProd.Name;
            priceTextBoxModProd.Text = selectedProd.Price.ToString();
            inventoryTextBoxModProd.Text = selectedProd.Inventory.ToString();
            minTextBoxModProd.Text = selectedProd.Min.ToString();
            maxTextBoxModProd.Text = selectedProd.Max.ToString();

            foreach (Part p in selectedProd.AssociatedParts)
            {
                associatedParts.Add(p);
            }



        }

        private void btnSearchAddProd_Click(object sender, EventArgs e)
        {
            int searchObject;
            try
            {
                searchObject = int.Parse(searchPartsProd.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("You can only search for the ID number. Please enter a valid input.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (searchObject < 1) return;

            Part matchPart = Inventory.LookUpPart(searchObject);
            if (matchPart == null)
            {
                MessageBox.Show("That Part does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            foreach (DataGridViewRow row in allPartsDGV.Rows)
            {
                Part part = (Part)row.DataBoundItem;


                if (part.PartID == matchPart.PartID)
                {
                    row.Selected = true;
                    break;
                }

                else
                {
                    row.Selected = false;
                }
            }
        }

        private void btnAddAssocParts_Click(object sender, EventArgs e)
        {
            Part addPart = (Part)allPartsDGV.CurrentRow.DataBoundItem;
            associatedParts.Add(addPart);
        }

        private void btnDeleteModProd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to permanently delete this part?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in associatedPartsDGV.SelectedRows)
                {
                    associatedPartsDGV.Rows.RemoveAt(row.Index);
                }

            }
            return;
        }

        private void btnCancelModPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveModProd_Click(object sender, EventArgs e)
        {
            int inventorySave;
            decimal priceSave;
            int minSave;
            int maxSave;
            try
            {
                inventorySave = Int32.Parse(inventoryTextBoxModProd.Text);
                priceSave = Decimal.Parse(priceTextBoxModProd.Text);
                minSave = Int32.Parse(minTextBoxModProd.Text);
                maxSave = Int32.Parse(maxTextBoxModProd.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Please enter a valid input. Inventory, Price, Min, and Max take numeric inputs only.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int prodIDSave = Int32.Parse(idTextBoxModProd.Text);
            string nameSave = nameTextBoxModProd.Text;
            priceSave = Decimal.Parse(priceTextBoxModProd.Text);
            inventorySave = Int32.Parse(inventoryTextBoxModProd.Text);
            minSave = Int32.Parse(minTextBoxModProd.Text);
            maxSave = Int32.Parse(maxTextBoxModProd.Text);

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


            
            
            Product prod = new Product(prodIDSave, nameSave, priceSave, inventorySave, minSave, maxSave);



            foreach (Part p in associatedParts)
            {
                prod.AddAssociatedPart(p);
               
            }


            //refreshes and updates the Product DGV  on the main screen form
            Inventory.UpdateProduct(selectedProdID, prod);

            mainScreenObject.RemoveSelectedRow();
            
            mainScreenObject.AddProdToDGV(prod);

            Close();
        }
    }
}
