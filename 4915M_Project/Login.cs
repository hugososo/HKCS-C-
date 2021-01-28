using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M_Project
{
    public partial class Login : Form
    {
        public static string name = "";
        public static string id = "";
        public static string character = "";
        public Login()
        {
            InitializeComponent();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void lbForgetPw_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPw findpw = new ForgetPw();
            findpw.Show();
        }
        //Entities db = new Entities();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (var search = new Entities())
            {
                var result = (from list in search.customers
                              where list.customerID.Equals(tbUserID.Text) && list.password.Equals(tbPw.Text)
                              select list).FirstOrDefault();
                var result2 = (from list in search.tenants
                               where list.tenantID.Equals(tbUserID.Text) && list.password.Equals(tbPw.Text)
                               select list).FirstOrDefault();
                var result3 = (from list in search.staffs
                               where list.staffID.Equals(tbUserID.Text) && list.password.Equals(tbPw.Text)
                               select list).FirstOrDefault();

                if (rbtnCustomer.Checked&&result!=null)
                {
                    MessageBox.Show("Login Successful, Welcome " + result.name);
                    name = result.name;
                    id = result.customerID;
                    character = "Customer";
                    this.Hide();
                    CustomerMenu menu = new CustomerMenu();
                    menu.ShowDialog();
                    
                }
                else if(rbtnTenant.Checked&&result2!=null)
                {
                    MessageBox.Show("Login Successful, Welcome " + result2.name);
                    name = result2.name;
                    id = result2.tenantID;
                    character = "Tenant";
                    this.Hide();
                    TenantMenu menu = new TenantMenu();
                    menu.Show();
                }
                else if (rbtnStaff.Checked && result3 != null)
                {
                    MessageBox.Show("Login Successful, Welcome " + result3.staffName);
                    name = result3.staffName;
                    id = result3.staffID;
                    character = "Staff";
                    this.Hide();
                    StaffMenu menu = new StaffMenu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password or UserID, Please input again");
                    tbUserID.Text = tbPw.Text = "";
                }
            }
        }
    }
}
