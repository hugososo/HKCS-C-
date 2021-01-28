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
    public partial class CreateReceipt : Form
    {
        long orderID;
        public CreateReceipt()
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

            if(Login.character=="Staff")
            {
                orderID = StaffOrder.order_ID;
            }
            else if(Login.character=="Customer")
            {
                orderID = CustomerOrder.order_ID;
            }

            using (Entities db = new Entities())
            {
                var result = (from a in db.orderitems
                          join b in db.products
                          on a.productID equals b.productID
                          where a.orderID == orderID
                              select new
                          {
                              a.productID,
                              b.productName,
                              a.quantity,
                              a.sellingPrice,
                              a.totalPrice
                          }).ToList();

                dataGridView1.DataSource = result;
                dataGridView1.Refresh();

                var result2 = (from a in db.buyorders
                               join b in db.customers
                               on a.customerID equals b.customerID
                               where a.orderID == orderID
                               select b).ToList();

                foreach(var x in result2)
                {
                    lbName.Text = x.name;
                    lbAddress.Text = x.billingAddress;
                }

                var result3 = db.buyorders.Where(n => n.orderID == orderID).Select(n => n).SingleOrDefault();

                lbDate.Text = result3.orderDateTime.ToString();
                lbPlace.Text = result3.pickupPlace;
                lbPrice.Text = "$ "+ result3.totalAmount;

                var result4 = (from a in db.buyorders
                               join b in db.branches
                               on a.pickupPlace equals b.branchID
                               where a.orderID == orderID
                               select b).FirstOrDefault();

                lbPlace.Text = result4.branchID+"\n"+result4.billingAddress +"\n"+result4.branchName;
            }
        }
    }
}
