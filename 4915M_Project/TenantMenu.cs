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
    public partial class TenantMenu : Form
    {
        public TenantMenu()
        {
            InitializeComponent();
            SidePanel.Height = btnPersonInfo.Height;
            SidePanel.Top = btnPersonInfo.Top;
            tenantProfile1.Visible = true;
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPersonInfo.Height;
            SidePanel.Top = btnPersonInfo.Top;
            productmain1.Visible = tenantShowcaseList1.Visible = tenantInventory1.Visible = billList1.Visible = false;
            tenantProfile1.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProduct.Height;
            SidePanel.Top = btnProduct.Top;
            tenantShowcaseList1.Visible = tenantInventory1.Visible = billList1.Visible = tenantProfile1.Visible = false;
            productmain1.Visible = true;
        }

        private void btnShowcaseList_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnShowcaseList.Height;
            SidePanel.Top = btnShowcaseList.Top;
            productmain1.Visible = tenantProfile1.Visible = tenantInventory1.Visible = billList1.Visible = false;
            tenantShowcaseList1.Visible = true;
        }

        private void btnInvMang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInvMang.Height;
            SidePanel.Top = btnInvMang.Top;
            productmain1.Visible = tenantProfile1.Visible = tenantShowcaseList1.Visible = billList1.Visible = false;
            tenantInventory1.Visible = true;
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
                var result = entities.tenants.Where(n => n.tenantID == Login.id).Select(n => n.name).FirstOrDefault();
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
            tenantProfile1.reload();
            tenantShowcaseList1.refresh();
            tenantInventory1.reload();
            productmain1.reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            tenantInventory1.Visible = productmain1.Visible = tenantProfile1.Visible = tenantShowcaseList1.Visible = false;
            billList1.Visible = true;
        }
    }
}
