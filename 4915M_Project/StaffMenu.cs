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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
            SidePanel.Height = btnPersonInfo.Height;
            SidePanel.Top = btnPersonInfo.Top;
            profile.Visible = true;
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPersonInfo.Height;
            SidePanel.Top = btnPersonInfo.Top;
            productmain1.Visible = staffShowcaseList1.Visible = staffOrder1.Visible = staffInventory1.Visible = false;
            profile.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProduct.Height;
            SidePanel.Top = btnProduct.Top;
            profile.Visible = staffShowcaseList1.Visible = staffOrder1.Visible = staffInventory1.Visible = false;
            productmain1.Visible = true;
        }

        private void btnShowcaseList_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnShowcaseList.Height;
            SidePanel.Top = btnShowcaseList.Top;
            productmain1.Visible = profile.Visible = staffOrder1.Visible = staffInventory1.Visible = false;
            staffShowcaseList1.Visible = true;
        }

        private void btnInvMang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInvMang.Height;
            SidePanel.Top = btnInvMang.Top;
            productmain1.Visible = profile.Visible = staffShowcaseList1.Visible = staffOrder1.Visible = false;
            staffInventory1.Visible = true;
        }

        private void btnRecTrac_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnRecTrac.Height;
            SidePanel.Top = btnRecTrac.Top;
        }

        private void btnShowcaseMang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnShowcaseMang.Height;
            SidePanel.Top = btnShowcaseMang.Top;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            using(Entities entities = new Entities())
            {
                var result = entities.staffs.Where(n => n.staffID == Login.id).Select(n => n.staffName).FirstOrDefault();
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
            profile.reload();
            staffShowcaseList1.refresh();
            staffOrder1.reload();
            staffInventory1.reload();
            productmain1.reload();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnReceipt.Height;
            SidePanel.Top = btnReceipt.Top;
            productmain1.Visible = profile.Visible = staffShowcaseList1.Visible = staffInventory1.Visible = false;
            staffOrder1.Visible = true;
        }
    }
}
