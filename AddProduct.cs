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

    public partial class AddProduct : Form
    {

        BindingList<Part> associatedParts = new BindingList<Part>();

        public MainScreen mainScreenObject;
        public AddProduct()
        {
            InitializeComponent();


            var candidateTable = new BindingSource();
            candidateTable.DataSource = Inventory.AllParts;
            allPartsDGV.DataSource = candidateTable;


            var associatedTable = new BindingSource();
            associatedTable.DataSource = associatedParts;
            associatedPartsDGV.DataSource = associatedTable;
        }



        private void btnDeleteAddProd_Click(object sender, EventArgs e)
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

        private void btnSearchAddProd_Click(object sender, EventArgs e)
        {

            int searchObject;
            try
            {
                searchObject = int.Parse(searchPartsAddProd.Text);
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

        private void btnCancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAddProd_Click(object sender, EventArgs e)
        {

            int inventorySave;
            decimal priceSave;
            int minSave;
            int maxSave;
            try
            {
                inventorySave = Int32.Parse(inventoryTextBoxAddProd.Text);
                priceSave = Decimal.Parse(priceTextBoxAddProd.Text);
                minSave = Int32.Parse(minTextBoxAddProd.Text);
                maxSave = Int32.Parse(maxTextBoxAddProd.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Please enter a valid input. Inventory, Price, Min, and Max take numeric inputs only.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int prodIDSave = Inventory.GenerateProdID();
            string nameSave = nameTextBoxAddProd.Text;
            priceSave = Decimal.Parse(priceTextBoxAddProd.Text);
            inventorySave = Int32.Parse(inventoryTextBoxAddProd.Text);
            minSave = Int32.Parse(minTextBoxAddProd.Text);
            maxSave = Int32.Parse(maxTextBoxAddProd.Text);

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


            else
            {
                Product prod = new Product(prodIDSave, nameSave, priceSave, inventorySave, minSave, maxSave);
                Inventory.AddProduct(prod);

                foreach (Part p in associatedParts)
                {
                    prod.AddAssociatedPart(p);
                    break;
                }
            }
            Close();

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            int newProdID = Inventory.GenerateProdID();
            idTextBoxAddProd.ReadOnly= true;
            idTextBoxAddProd.Text = newProdID.ToString();
            

        }
    }
}
