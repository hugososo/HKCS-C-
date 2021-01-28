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
    public partial class StaffProfile : UserControl
    {
        public StaffProfile()
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
                        var staffToUpdate = entities.staffs.Where(s => s.staffID == Login.id);
                        foreach (staff p in staffToUpdate)
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
                    var item = entities.staffs.Where(a => a.staffID == Login.id).SingleOrDefault();
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
                    var state = db.staffs.SingleOrDefault(x => x.staffID == Login.id);
                    state.staffName = tbName.Text;
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
                    var result = entities.staffs.Where(n => n.staffID == Login.id).Select(n => n).ToList();
                    foreach (var x in result)
                    {
                        tbName.Text = x.staffName;
                        lbID.Text = "User ID: " + x.staffID;
                        tbEmail.Text = x.emailAddress;
                        lbJoinDate.Text = "Join Date: " + x.hireDate.ToString("d");
                        lbCharacter.Text = x.position;
                        lbType.Text = "Type: " + x.hiringType;
                        tbPhone.Text = x.telephone;
                    }
                }
                lbSave1.Visible = lbSave2.Visible = lbSave3.Visible = lbSave4.Visible = lbMsg.Visible = false;
                tbNPw.Text = tbOPw.Text = tbRePw.Text = "";
            }
            catch (Exception ex) { }
        }

        private void btnChEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(tbEmail.Text);
                using(Entities entities = new Entities())
                {
                    var result = entities.staffs.Where(a => a.emailAddress == tbEmail.Text).SingleOrDefault();
                    var result2 = entities.tenants.Where(w => w.emailAddress == tbEmail.Text).SingleOrDefault();
                    var result3 = entities.customers.Where(i => i.emailAddress == tbEmail.Text).SingleOrDefault();

                    if (result != null || result2 != null || result3 != null)
                    {
                        MessageBox.Show("Repeated Email");
                    }
                    else
                    {
                        var state = entities.staffs.SingleOrDefault(x => x.staffID == Login.id);
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
                var state = db.staffs.FirstOrDefault(x => x.staffID == Login.id);
                if(tbNPw.Text =="" || tbOPw.Text =="" || tbRePw.Text=="")
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
                var state = db.staffs.FirstOrDefault(x => x.staffID == Login.id);
                state.telephone = tbPhone.Text;
                db.SaveChanges();
                lbSave4.Visible = true;
            }
        }
    }
}
