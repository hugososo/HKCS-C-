using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Data.Common.CommandTrees;
using System.IO;
using System.Data.Entity.Validation;
using System.Reflection;

namespace _4915M_Project
{
    public partial class TenantProfile : UserControl
    {
        public TenantProfile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void Profile_VisibleChanged(object sender, EventArgs e)
        {
            Profile_Load(this, EventArgs.Empty);
            tbNPw.Text = tbOPw.Text = tbRePw.Text = "";
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            openFileDialog.FilterIndex = 0;

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                var fileSizeInBytes = new FileInfo(openFileDialog.FileName).Length;
                if (fileSizeInBytes > 65535)
                {
                    lbMsg.Visible = true;
                }
                else
                {
                    Image img = Image.FromFile(openFileDialog.FileName);
                    MemoryStream memoryStream = new MemoryStream();
                    img.Save(memoryStream, img.RawFormat);

                    using (Entities entities = new Entities())
                    {
                        var tenantToUpdate = entities.tenants.Where(s => s.tenantID == Login.id);
                        foreach (tenant p in tenantToUpdate)
                            p.avatar = memoryStream.ToArray();
                        entities.SaveChanges();
                        loadAvatar();
                    }
                    lbMsg.Visible = false; 
                }

            }
        }

        private void loadAvatar()
        {
            MemoryStream memoryStream = new MemoryStream();
            using (Entities entities = new Entities())
            {
                try
                {
                    var item = entities.tenants.Where(a => a.tenantID == Login.id).SingleOrDefault();
                    byte[] arr = item.avatar;
                    memoryStream = new MemoryStream(arr);
                    pbAvatar.Image = Image.FromStream(memoryStream);
                }catch(Exception ex) { }
            }
        }

        private void btnChName_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Please input your name");
            }
            else
            {
                using (Entities db = new Entities())
                {
                    var state = db.tenants.SingleOrDefault(x => x.tenantID == Login.id);
                    state.name = tbName.Text;
                    db.SaveChanges();
                    lbSave1.Visible = true;
                }
            }
        }

        public void reload()
        {
            try
            {
                loadAvatar();
                using (Entities entities = new Entities())
                {
                    var result = entities.tenants.Where(n => n.tenantID == Login.id).Select(n => n).ToList();
                    foreach (var x in result)
                    {
                        tbName.Text = x.name;
                        lbID.Text = "User ID: " + x.tenantID;
                        tbEmail.Text = x.emailAddress;
                        lbJoinDate.Text = "Join Date: " + x.joinDate.ToString("d");
                        lbAddress.Text = "Billing Address: " + x.billingAddress;
                        tbPhone.Text = x.telephone;
                    }
                }

                lbSave1.Visible = lbSave2.Visible = lbSave3.Visible = lbSave4.Visible= lbMsg.Visible = false;
                tbNPw.Text = tbOPw.Text = tbRePw.Text = "";
            }
            catch (Exception ex)
            {
            }
        }

        private void btnChEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(tbEmail.Text);
                using(Entities entities = new Entities())
                {
                    var result = entities.tenants.Where(a => a.emailAddress == tbEmail.Text).FirstOrDefault();
                    var result2 = entities.tenants.Where(w => w.emailAddress == tbEmail.Text).FirstOrDefault();
                    var result3 = entities.customers.Where(i => i.emailAddress == tbEmail.Text).FirstOrDefault();

                    if (result != null || result2 != null || result3 != null)
                    {
                        MessageBox.Show("Repeated Email");
                    }
                    else
                    {
                        var state = entities.tenants.SingleOrDefault(x => x.tenantID == Login.id);
                        state.emailAddress = tbEmail.Text;
                        entities.SaveChanges();
                        lbSave2.Visible = true;
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
            }
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            using(Entities db = new Entities())
            {
                var state = db.tenants.FirstOrDefault(x => x.tenantID == Login.id);
                if (tbNPw.Text =="" || tbOPw.Text =="" || tbRePw.Text=="")
                {
                    MessageBox.Show("Please input your password first");
                }
                else if(state.password != tbOPw.Text)
                {
                    MessageBox.Show("Your old password is wrong");
                }
                else if(tbRePw.Text!=tbNPw.Text)
                {
                    MessageBox.Show("Your new password is not match with re-password");
                }
                else
                {
                    state.password = tbNPw.Text;
                    db.SaveChanges();
                    lbSave3.Visible = true;
                }
            }
        }

        private void btnChPhone_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                var state = db.tenants.FirstOrDefault(x => x.tenantID == Login.id);
                state.telephone = tbPhone.Text;
                db.SaveChanges();
                lbSave4.Visible = true;
            }
        }

        private void btnChBillAddress_Click(object sender, EventArgs e)
        {
            ChangeAddress changeAddress = new ChangeAddress();
            changeAddress.ShowDialog();
        }
        

        bill bill = new bill();
        private void button1_Click(object sender, EventArgs e)
        {
            int todayYear = DateTime.Today.Year;
            int todayMonth = DateTime.Today.Month;
            decimal rentCharge = 0;
            decimal incomePrice = 0;

            using (Entities db = new Entities())
            {
                var rent = (from list in db.rentrecords
                             where list.tenantID == Login.id
                             where list.endday.Year == todayYear
                             where list.endday.Month >= todayMonth
                             select list.rentprice).ToList();

                

                foreach (var x in rent)
                {
                    rentCharge += x;
                }

                var income = (from a in db.showcases
                              join b in db.products
                              on a.showcaseID equals b.showcaseID
                              join c in db.orderitems
                              on b.productID equals c.productID
                              join d in db.buyorders
                              on c.orderID equals d.orderID
                              where a.tenantID == Login.id
                              where d.orderDateTime.Year == todayYear
                              where d.orderDateTime.Month == todayMonth-1
                              where d.status == "Completed"
                              select c.totalPrice).ToList();

                foreach (var i in income)
                {
                    incomePrice += i;
                }
                DateTime dt = DateTime.Now;
                DateTime startMonth = dt.AddDays(1 - dt.Day);
                DateTime endMonth = startMonth.AddDays(-1);

                var searchBill = db.bills.SingleOrDefault(x => x.tenantID == Login.id && x.billDate.Year == todayYear && x.billDate.Month == todayMonth-1);
                if (searchBill == null) {
                    bill.tenantID = Login.id;
                    bill.billDate = endMonth;
                    bill.rentalCharge = rentCharge;
                    bill.income = incomePrice;
                    bill.totalCharge = incomePrice - rentCharge;
                    db.bills.Add(bill);
                    db.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("Added");
                } else
                {
                    searchBill.rentalCharge = rentCharge;
                    searchBill.income = incomePrice;
                    searchBill.totalCharge = incomePrice - rentCharge;
                    db.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("Updated");
                }
            }
            CreateBill createBill = new CreateBill();
            createBill.ShowDialog();
            System.Diagnostics.Debug.WriteLine("ShowBill");
        }
    }
}
