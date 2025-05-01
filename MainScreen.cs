using System.CodeDom.Compiler;

namespace Inventory_ManagementC968
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            Inventory.GetExampleInputs();


            var partsTable = new BindingSource();
            partsTable.DataSource = Inventory.AllParts;
            partsDGV.DataSource = partsTable;

            var productTable = new BindingSource();
            productTable.DataSource = Inventory.Products;
            productsDGV.DataSource = productTable;
        }

        public void RemoveSelectedRow()
        {
            
            productsDGV.Rows.Remove(productsDGV.CurrentRow);
        }
        public void AddPartToDGV()
        {

            partsDGV.DataSource = null;
            partsDGV.DataSource = Inventory.AllParts;
        }

        public void AddProdToDGV(Product prod)
        {
            productsDGV.Refresh();
           
        }
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.mainScreenObject = this;
            addPart.ShowDialog();
        }

        private void btnModPart_Click(object sender, EventArgs e)
        {
            ModifyPart modPart = new ModifyPart();
            modPart.mainScreenObject = this;
            modPart.selectedPartID = Int32.Parse(partsDGV.Rows[partsDGV.CurrentCell.RowIndex].Cells[partsDGV.CurrentCell.ColumnIndex].Value.ToString());
            modPart.ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            AddProduct addProd = new AddProduct();
            addProd.mainScreenObject = this;
            addProd.ShowDialog();
        }

        private void btnModProd_Click(object sender, EventArgs e)
        {
            ModifyProduct modProd = new ModifyProduct();
            modProd.mainScreenObject = this;
            modProd.selectedProdID = int.Parse(productsDGV.Rows[productsDGV.CurrentCell.RowIndex].Cells[productsDGV.CurrentCell.ColumnIndex].Value.ToString());
            modProd.ShowDialog();
        }

        private void btnExitMainScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            int searchObject;
            try
            {
                searchObject = int.Parse(txtBoxPartsSearch.Text);
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

            foreach (DataGridViewRow row in partsDGV.Rows)
            {
                Part part = (Part)row.DataBoundItem;


                if (part.PartID == matchPart.PartID)
                {
                    row.Selected = true;
                    return;
                }

                

                else
                {

                    row.Selected = false;
                }
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            int searchObject;
            try
            {
                searchObject = int.Parse(txtBoxProdSearch.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("You can only search for the ID number. Please enter a valid input.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (searchObject < 1) return;

            Product matchProd = Inventory.LookUpProduct(searchObject);

            if (matchProd == null)
            {
                MessageBox.Show("That Product does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in productsDGV.Rows)
            {
                Product product = (Product)row.DataBoundItem;


                if (product.ProductID == matchProd.ProductID)
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

        private void btnDeletePart_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to permanently delete this part?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partsDGV.SelectedRows)
                {
                    partsDGV.Rows.RemoveAt(row.Index);
                }

            }
            return;
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in productsDGV.SelectedRows)
            {
                Product product = (Product)row.DataBoundItem;

                if (product.AssociatedParts.Count > 0) // Check if the product has associated parts
                {
                    MessageBox.Show("This product has associated parts and cannot be deleted", "Information", MessageBoxButtons.OK);
                    return;
                }
            }

            DialogResult result = MessageBox.Show("Do you want to permanently delete this product?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in productsDGV.SelectedRows)
                {
                    productsDGV.Rows.RemoveAt(row.Index);
                }
            }
            return;
        }
    }
}
