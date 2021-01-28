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
    public partial class ForgetPw : Form
    {
        public ForgetPw()
        {
            InitializeComponent();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
        private void lbSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(tbEmail.Text);
                MessageBox.Show("The verification email has sent to your mailbox, Please reset the password");
                tbEmail.Text = "";
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
