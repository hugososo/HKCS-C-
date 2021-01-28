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
    public partial class CustomerShowcaseList : UserControl
    {
        long showcaseID;
        String isRented;
        tenant tenant = new tenant();
        DateTime localDate = DateTime.Now;
        public CustomerShowcaseList()
        {
            InitializeComponent();
        }
        /*
         * when load the from, show all the data in dataGridView
         */
        private void showcaseList_Load(object sender, EventArgs e)
        {
            refresh();
        }
        /*
         * show the Unavailable showcase list
         */
        private void RentedShowcase_Click(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                dataGridViewForCustomer.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases where list.status.Equals("Unavailable") select list);    // select Rented showcase from showcase 
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForCustomer.Rows.Add(data2.showcaseID, data2.branchID, data2.monthlyRent, data2.status);
                    }
                }
            }
        }
        /*
         * show the Available showcase
         */
        private void unRentShowcase_Click(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                dataGridViewForCustomer.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases where list.status.Equals("Available") select list);    // select Unrent showcase from showcase
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForCustomer.Rows.Add(data2.showcaseID, data2.branchID, data2.monthlyRent, data2.status);
                    }
                }
            }
        }
        /*
         * Show all data in DataGridView
         */
        private void showAll_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridViewForCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            using (var classicContext = new Entities())
            {
                var data = (from list in classicContext.tenants
                              where list.tenantID == Login.id select list).FirstOrDefault();
                if (showcaseID == 0)
                {
                    MessageBox.Show("Please select one row!");
                }
                else if (isRented == "Unavailable")
                {
                    MessageBox.Show("This showcase is rented by other! Please select other showcase!");
                }
                else if (data == null && isRented == "Available")
                {
                    classicContext.Configuration.ValidateOnSaveEnabled = false;
                    var data1 = (from list in classicContext.customers where list.customerID.Equals(Login.id) select list);
                    foreach (var data2 in data1.ToList())
                    {
                        tenant.tenantID = data2.customerID;
                        tenant.name = data2.name;
                        tenant.password = data2.password;
                        tenant.emailAddress = data2.emailAddress;
                        tenant.billingAddress = data2.billingAddress;
                        tenant.avatar = data2.avatar;
                        tenant.joinDate = localDate;
                        classicContext.tenants.Add(tenant);
                        classicContext.SaveChanges();
                    }
                    var showcase = new showcase() { showcaseID = showcaseID, status = "Unavailable", tenantID = Login.id };
                    classicContext.showcases.Attach(showcase);
                    classicContext.Entry(showcase).Property(s => s.status).IsModified = true;
                    classicContext.Entry(showcase).Property(s => s.tenantID).IsModified = true;
                    classicContext.SaveChanges();
                    MessageBox.Show("Rent success! You need select tenant to re-login!");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Your identity are tenant now!Please login by tenant!");
                }
            }
        }
        /*
         * Refresh the dataGridView
         */
        public void refresh()
        {
            if (!this.DesignMode)
            {
                dataGridViewForCustomer.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases select list); 
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForCustomer.Rows.Add(data2.showcaseID, data2.branchID, data2.monthlyRent, data2.status);
                    }
                }
            }
        }
        /*
         * when the dataGridView row is selected the showcaseID will change
         */
        private void dataGridViewForCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewForCustomer.Rows[e.RowIndex];
                showcaseID = Convert.ToInt32(row.Cells["Column1"].Value.ToString());
                isRented = row.Cells["Column4"].Value.ToString();
            }
        }
    }
}