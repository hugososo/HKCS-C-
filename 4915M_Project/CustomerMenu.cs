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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
            SidePanel.Height = btnPersonInfo.Height;
            SidePanel.Top = btnPersonInfo.Top;
            customerProfile1.Visible = true;
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPersonInfo.Height;
            SidePanel.Top = btnPersonInfo.Top;
            productmain1.Visible = customerShowcaseList1.Visible = customerOrder1.Visible= false;
            customerProfile1.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProduct.Height;
            SidePanel.Top = btnProduct.Top;
            customerProfile1.Visible = customerShowcaseList1.Visible = customerOrder1.Visible = false;
            productmain1.Visible = true;
        }

        private void btnShowcaseList_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnShowcaseList.Height;
            SidePanel.Top = btnShowcaseList.Top;
            productmain1.Visible = customerProfile1.Visible = customerOrder1.Visible = false;
            customerShowcaseList1.Visible = true;
        }
        private void btnQueries_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnQueries.Height;
            SidePanel.Top = btnQueries.Top;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            using(Entities entities = new Entities())
            {
                var result = entities.customers.Where(n => n.customerID == Login.id).Select(n => n.name).FirstOrDefault();
                lbCharacter.Text = "Welcome! " + result;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            Menu_Load(this, EventArgs.Empty);
            customerProfile1.reload();
            customerShowcaseList1.refresh();
            customerOrder1.reload();
            productmain1.reload();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnReceipt.Height;
            SidePanel.Top = btnReceipt.Top;
            productmain1.Visible = customerProfile1.Visible = customerShowcaseList1.Visible = false;
            customerOrder1.Visible = true;
        }
    }
}
