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
    public partial class CreateBill : Form
    {
        long orderID;
        public CreateBill()
        {
            InitializeComponent();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
        }

        private void CreateReceipt_Load(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                var result = (from a in db.tenants
                               where a.tenantID == Login.id
                               select a).ToList();

                foreach (var x in result)
                {
                    lbName.Text = x.name;
                    lbAddress.Text = x.billingAddress;
                }

                int todayYear = DateTime.Today.Year;
                int todayMonth = DateTime.Today.Month;

                var result2 = (from a in db.bills
                               where a.tenantID == Login.id
                               where a.billDate.Year == todayYear
                               where a.billDate.Month == todayMonth - 1
                               select a).SingleOrDefault();

                lbNum.Text = result2.billID.ToString();
                lbDate.Text = result2.billDate.ToString("dd-MM-yyyy");
                label15.Text = result2.rentalCharge.ToString();
                label11.Text = result2.income.ToString();
                lbPrice.Text = result2.totalCharge.ToString();
                label18.Text = result2.billDate.AddDays(14).ToString("dd-MM-yyyy");

            }

        }
    }
}
