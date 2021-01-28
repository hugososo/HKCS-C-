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
    public partial class StaffShowcaseList : UserControl
    {
        long showcaseID;
        public StaffShowcaseList()
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
                dataGridViewForStaff.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases where list.status.Equals("Unavailable") select list);    // select Rented showcase from showcase  
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForStaff.Rows.Add(data2.showcaseID, data2.tenantID, data2.branchID, data2.monthlyRent, data2.status);
                    }
                }
            }
        }
        /*
         * show the Available showcase
         */
        private void unRentShowcase_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                dataGridViewForStaff.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases where list.status.Equals("Available") select list);    // select Unrent showcase from showcase
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForStaff.Rows.Add(data2.showcaseID, data2.tenantID, data2.branchID, data2.monthlyRent, data2.status);
                    }
                }
            }
        }

        /*
         * Edit the rent
         */
        private void editShowcaseRent_bt_Click(object sender, EventArgs e)
        {
            if(showcaseID == 0)
            {
                MessageBox.Show("Please select one row!");
            }else if(textBox1.Text == "")
            {
                MessageBox.Show("Please input number in text box!");
            }
            else
            {
                using (var classicContext = new Entities())
                {
                    classicContext.Configuration.ValidateOnSaveEnabled = false;
                    var showcase = new showcase() { showcaseID = showcaseID, monthlyRent = textBox1.Text};
                    classicContext.showcases.Attach(showcase);
                    classicContext.Entry(showcase).Property(s => s.monthlyRent).IsModified = true;
                    classicContext.SaveChanges();
                    MessageBox.Show("Updata Success");
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
                dataGridViewForStaff.Rows.Clear();
                using (var classicContext = new Entities())
                {
                    var data = (from list in classicContext.showcases select list);
                    foreach (var data2 in data.ToList())
                    {
                        dataGridViewForStaff.Rows.Add(data2.showcaseID, data2.tenantID, data2.branchID, data2.monthlyRent, data2.status);
                    }
                }
            }
        }
        /*
         * show all the data in dataGridView
         */
        private void showAll_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void DataGridViewForStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        /*
         * when the dataGridView row is selected the showcaseID will change
         */
        private void dataGridViewForStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewForStaff.Rows[e.RowIndex];
                showcaseID = Convert.ToInt32(row.Cells["Column1"].Value.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*
         * Make user just can input number
         */
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please input just number!");
            }
        }
    }
}