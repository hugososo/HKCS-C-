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
    public partial class TenantShowcaseList : UserControl
    {
        long showcaseID;
        String isRented;
        public TenantShowcaseList()
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
                dataGridViewForTenant.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases where list.status.Equals("Unavailable") select list);    // select Rented showcase from showcase 
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForTenant.Rows.Add(data2.showcaseID, data2.branchID, data2.monthlyRent, data2.status);
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
                dataGridViewForTenant.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases where list.status.Equals("Available") select list);    // select Unrent showcase from showcase 
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForTenant.Rows.Add(data2.showcaseID, data2.branchID, data2.monthlyRent, data2.status);
                    }
                }
            }
        }
        /*
         * Rent showcase
         */
        private void Rent_Click(object sender, EventArgs e)
        {
            if (showcaseID == 0)
            {
                MessageBox.Show("Please select one row!");
            }
            else if (isRented == "Unavailable")
            {
                MessageBox.Show("This showcase is rented by other! Please select other showcase!");
            }
            else
            {
                using (var classicContext = new Entities())
                {
                    classicContext.Configuration.ValidateOnSaveEnabled = false;
                    var showcase = new showcase() { showcaseID = showcaseID, status = "Unavailable", tenantID = Login.id };
                    classicContext.showcases.Attach(showcase);
                    classicContext.Entry(showcase).Property(s => s.status).IsModified = true;
                    classicContext.Entry(showcase).Property(s => s.tenantID).IsModified = true;
                    classicContext.SaveChanges();
                    MessageBox.Show("Rent success!");
                    refresh();
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
                dataGridViewForTenant.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases select list);    // select * from employees 
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForTenant.Rows.Add(data2.showcaseID, data2.branchID, data2.monthlyRent, data2.status);
                    }
                }
            }
        }
        /*
         * Refresh the dataGridView
         */
        private void showAll_Click(object sender, EventArgs e)
        {
            refresh();
        }

        /*
         * when the dataGridView row is selected the showcaseID will change
         */
        private void dataGridViewForTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewForTenant.Rows[e.RowIndex];
                showcaseID = Convert.ToInt32(row.Cells["Column1"].Value.ToString());
                isRented = row.Cells["Column4"].Value.ToString();
            }
        }
    }
}