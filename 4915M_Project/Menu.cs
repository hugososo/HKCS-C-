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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SidePanel.Height = btnPersonInfo.Height;
            SidePanel.Top = btnPersonInfo.Top;
            //Profile.BringToFront();
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPersonInfo.Height;
            SidePanel.Top = btnPersonInfo.Top;
            //UserControl1.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProduct.Height;
            SidePanel.Top = btnProduct.Top;
        }

        private void btnShowcaseList_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnShowcaseList.Height;
            SidePanel.Top = btnShowcaseList.Top;
        }

        private void btnInvMang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInvMang.Height;
            SidePanel.Top = btnInvMang.Top;
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

        private void btnContStaff_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnContStaff.Height;
            SidePanel.Top = btnContStaff.Top;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            lbCharacter.Text = Login.name;
        }
    }
}
