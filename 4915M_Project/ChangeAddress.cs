using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M_Project
{
    public partial class ChangeAddress : Form
    {
        public ChangeAddress()
        {
            InitializeComponent();
            this.cbRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        Entities db = new Entities();
        private void ChangeAddress_Load(object sender, EventArgs e)
        {
            cbRegion.DataSource = db.regions.ToList();
            cbRegion.DisplayMember = "regionName";
            cbRegion.ValueMember = "regionID";
            cbRegion_SelectedIndexChanged(this, EventArgs.Empty);

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rid;
            bool p = Int32.TryParse(cbRegion.SelectedValue.ToString(), out rid);
            var dname = from r in db.districts where r.regionID == rid select new { r.districtID, r.districtName };
            var comboDistrict = dname.ToList();
            if (comboDistrict.Count > 0)
            {
                cbDistrict.DataSource = comboDistrict;
                cbDistrict.DisplayMember = "districtName";
                cbDistrict.ValueMember = "districtID";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                if(tbAddress.Text=="")
                {
                    MessageBox.Show("Please enter your address.");
                }
                else try
                {
                    if (Login.character.Equals("Tenant"))
                    {
                        var state = db.tenants.SingleOrDefault(x => x.tenantID == Login.id);
                        state.billingAddress = tbAddress.Text + ", " + cbDistrict.Text + ", " + cbRegion.Text;
                        db.SaveChanges();
                        MessageBox.Show("Submitted");
                    }
                    else
                    {
                        var state = db.customers.SingleOrDefault(x => x.customerID == Login.id);
                        state.billingAddress = tbAddress.Text + ", " + cbDistrict.Text + ", " + cbRegion.Text;
                        db.SaveChanges();
                        MessageBox.Show("Submitted");
                    }
                    this.Close();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    MessageBox.Show("Your Address is too long");
                }
            }
        }
    }
}
