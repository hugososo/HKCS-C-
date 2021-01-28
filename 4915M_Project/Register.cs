using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M_Project
{
    public partial class Register : Form
    {
        customer customer = new customer();
        public Register()
        {
            InitializeComponent();
        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lbForgetPw_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPw findpw = new ForgetPw();
            findpw.Show();
        }

        void Clear()
        {
            tbRePw.Text = tbUserID.Text = tbPw.Text = tbName.Text = tbEmail.Text = "";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(tbEmail.Text);
                using (var search = new Entities())
                {
                    var result = (from list in search.customers
                                  where list.customerID == tbUserID.Text || list.emailAddress == tbEmail.Text
                                  select list).FirstOrDefault();
                    var result2 = (from list in search.tenants
                                   where list.tenantID == tbUserID.Text || list.emailAddress == tbEmail.Text
                                   select list).FirstOrDefault();
                    var result3 = (from list in search.staffs
                                   where list.staffID == tbUserID.Text || list.emailAddress == tbEmail.Text
                                   select list).FirstOrDefault();
                    if (result != null || result2 != null || result3 != null)
                    {
                        MessageBox.Show("Repeated UserID or Email");
                        Clear();
                    }
                    else if (tbRePw.Text == "" || tbUserID.Text == "" || tbPw.Text == "" || tbName.Text == "" || tbEmail.Text == "") {
                        MessageBox.Show("Please fill in all the blank");
                        Clear();
                    }
                    else if(tbPw.Text != tbRePw.Text)
                    {
                        tbRePw.Text = "";
                        MessageBox.Show("Re-Password incorrect");
                    }
                    else
                    {
                        customer.customerID = tbUserID.Text.Trim();
                        customer.name = tbName.Text.Trim();
                        customer.password = tbPw.Text.Trim(); 
                        customer.emailAddress = tbEmail.Text.Trim();
                        using (Entities db = new Entities())
                        {
                            db.customers.Add(customer);
                            db.SaveChanges();

                        }
                        Clear();
                        MessageBox.Show("Register Successful");
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Please input your email address");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid Email Address");
                tbEmail.Text = "";
            }
        }
    }
}
