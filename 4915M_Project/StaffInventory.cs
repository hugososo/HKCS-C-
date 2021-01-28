using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M_Project
{
    public partial class StaffInventory : UserControl
    {
        product product = new product();
        public StaffInventory()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtproductID.Text = txtproductName.Text = txtshowcaseID.Text = txtunitPrice.Text = txtstockQuantity.Text = txtdiscount.Text = txtremark.Text = "";
            btnSave.Text = "Add";
            btnDelete.Enabled = false;
            product.productID = null;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                reload();
            }
        }

        public void reload()
        {
            Clear();
            populateDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                product.productID = txtproductID.Text.Trim();
                product.productName = txtproductName.Text.Trim();
                product.showcaseID = Int32.Parse(txtshowcaseID.Text.Trim());
                product.unitPrice = Convert.ToDecimal(txtunitPrice.Text.Trim());
                product.stockQuantity = Int32.Parse(txtstockQuantity.Text.Trim());
                product.remark = txtremark.Text.Trim();
                if (txtdiscount.Text == "")
                    product.discount = null;
                else
                    product.discount = Convert.ToDecimal(txtdiscount.Text.Trim());
                using (Entities db = new Entities())
                {
                    var data = (from list in db.products where list.productID.Equals(txtproductID.Text) select list).SingleOrDefault();

                    if (data == null)
                        db.products.Add(product);

                    else
                    {
                        data.productID = txtproductID.Text.Trim();
                        data.productName = txtproductName.Text.Trim();
                        data.showcaseID = Int32.Parse(txtshowcaseID.Text.Trim());
                        data.unitPrice = Convert.ToDecimal(txtunitPrice.Text.Trim());
                        data.stockQuantity = Int32.Parse(txtstockQuantity.Text.Trim());
                        data.remark = txtremark.Text.Trim();
                        if (txtdiscount.Text == "")
                            data.discount = null;
                        else
                            data.discount = Convert.ToDecimal(txtdiscount.Text.Trim());
                    }
                    db.SaveChanges();
                }
                Clear();
                populateDataGridView();
                MessageBox.Show("Saved!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please fill in all the fields");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("The showcase is not exist");
            }
        }

        void populateDataGridView()
        {
            dgvProduct.AutoGenerateColumns = false;
            using (Entities db = new Entities())
            {
                dgvProduct.DataSource = db.products.ToList();
            }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow.Index != -1)
            {
                product.productID = Convert.ToString(dgvProduct.CurrentRow.Cells["productID"].Value);
                using (Entities db = new Entities())
                {
                    product = db.products.Where(x => x.productID == product.productID).FirstOrDefault();
                    txtproductID.Text = product.productID;
                    txtproductName.Text = product.productName;
                    txtshowcaseID.Text = Convert.ToString(product.showcaseID);
                    txtunitPrice.Text = Convert.ToString(product.unitPrice);
                    txtstockQuantity.Text = Convert.ToString(product.stockQuantity);
                    txtdiscount.Text = Convert.ToString(product.discount);
                    txtremark.Text = product.remark;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm to delete", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Entities db = new Entities())
                {
                    var entry = db.Entry(product);
                    if (entry.State == EntityState.Detached)
                        db.products.Attach(product);
                    db.products.Remove(product);
                    db.SaveChanges();
                    populateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted");
                }
            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please input just number!");
            }
        }

        private void txtstockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please input just number!");
            }
        }

        private void txtunitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please input just number!");
            }
        }

        private void txtshowcaseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please input just number!");
            }
        }
    }
}
