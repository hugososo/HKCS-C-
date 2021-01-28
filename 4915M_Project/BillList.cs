using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M_Project
{
    public partial class BillList : UserControl
    {

        List<bill> reList;
        //Login.id;
        Boolean wasClicked = false;
        Form detail = new Form();
        //long
        public static long order_ID;
        int actualOrder_id;

        public BillList()
        {
            InitializeComponent();
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            reload();
        }

        public void reload()
        {
            int width = fplSearchList.ClientSize.Width;
            int height = 30;

            if (!this.DesignMode)
            {
                fplSearchList.Controls.Clear();

                using (var classicContext = new Entities())
                {
                    reList = (from list in classicContext.bills
                              where list.tenantID == Login.id
                              select list).ToList();

                    lblResult.Text = (reList.Count > 0)
                        ? reList.Count.ToString() + " results return."
                        : "No entry found!";

                    foreach (var record in reList)
                    {
                        Panel row = newPanel(width - 5, height, record.billID.ToString());
                        fplSearchList.Controls.Add(row);

                        Panel a = editor_Panel(width /6 + 5, height, record.billID.ToString());
                        row.Controls.Add(a);

                        Panel editor = editor_Panel(width /3 + 5, height, record.billID.ToString());
                        row.Controls.Add(editor);

                        newButton(editor.Width, height, record.billID.ToString(), editor, "Print");
                        newLabel(width, height, record.billID.ToString(), record.billDate.ToString("dd-MM-yyyy"), a);
                        newLabel(width, height, record.billID.ToString(), record.billID.ToString(), row);
                    }

                }
                btOrderID.Width = fplSearchList.ClientSize.Width / 3;
                btOrderDate.Width = fplSearchList.ClientSize.Width / 3;
                lblspacing.Width = fplSearchList.ClientSize.Width / 3;
                fplSearchList.AutoScroll = false;
                fplSearchList.HorizontalScroll.Maximum = 0;
                fplSearchList.AutoScroll = true;
            }
        }

        private Panel newPanel(int width, int height, String id)
        {

            Panel p = new Panel();
            p.Name = "pl" + id;
            p.Size = new Size(width, height);
            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.FixedSingle;/*
            p.Dock = DockStyle.Top;*/
            Margin = new Padding(0, 0, 0, 0);
            Padding = new Padding(0, 0, 0, 0);
            return p;
            /*x.BringToFront();*/
        }

        private Label newLabel(int width, int height, String id, string content, Panel row)
        {
            var lblcell = new Label
            {
                Name = "lbl" + id + content,
                Size = new Size(width / 6 - 2, height),
                Dock = DockStyle.Left,
                Text = content,
                ForeColor = Color.White,
                BackColor = Color.DarkOrange,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Calibri", 12, FontStyle.Bold),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 0),
                Padding = new Padding(0, 0, 0, 0),
            };

            row.Controls.Add(lblcell);
            lblcell.MouseHover += new EventHandler(lbl_Hover);
            lblcell.MouseLeave += new EventHandler(lblCancel_Hover);

            return lblcell;
        }

        private Panel editor_Panel(int width, int height, String id)
        {
            Panel p = new Panel();
            p.Name = "pl" + id + "ed";
            p.Size = new Size(width, height);
            p.BackColor = Color.Gray;
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Dock = DockStyle.Left;
            p.Cursor = Cursors.Hand;
            p.Padding = new Padding(5, 0, 0, 0);
            return p;
        }

        private void newButton(int width, int height, String id, Panel editor, String content)
        {
            var btProduct = new Button
            {
                Name = "bt" + id + content,
                Size = new Size(width, height),
                FlatStyle = FlatStyle.Flat,
                Dock = DockStyle.Left,
                BackColor = Color.White,
                ForeColor = Color.DarkMagenta,
                Font = new Font("Calibri", 10),
                Text = content,
            };
            editor.Controls.Add(btProduct);

            btProduct.Image = (Image)(new Bitmap(_4915M_Project.Properties.Resources.bPrint, new Size(10, 10)));
            btProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btProduct.Click += new EventHandler(print_Click);

            btProduct.MouseHover += new EventHandler(bt_Hover);
            btProduct.MouseLeave += new EventHandler(btCancel_Hover);
        }


        private void bt_Hover(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.DarkOrange;
            bt.ForeColor = Color.White;
        }

        private void btCancel_Hover(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.White;
            bt.ForeColor = Color.DarkMagenta;
        }

        private void lbl_Hover(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.Gray;
        }

        private void lblCancel_Hover(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.DarkOrange;
        }

        private void btOrderID_Click(object sender, EventArgs e)

        {
            List<bill> SortedRow;

            if (wasClicked)
            {
                SortedRow = reList.OrderBy(o => o.billID).ToList();
            }
            else
            {
                SortedRow = reList.OrderByDescending(o => o.billID).ToList();
            }

            btSort_Click(SortedRow);
        }

        private void btOrderDate_Click(object sender, EventArgs e)
        {
            List<bill> SortedRow;

            if (wasClicked)
            {
                SortedRow = reList.OrderBy(o => o.billDate).ToList();
            }
            else
            {
                SortedRow = reList.OrderByDescending(o => o.billDate).ToList();
            }

            btSort_Click(SortedRow);
        }

        private void btSort_Click(List<bill> SortedRow)
        {
            int counter = 0;
            foreach (var order in SortedRow)
            {
                /*int length = 9 - order.orderID.ToString().Length;
                String eOrderID = order.orderID.ToString().PadLeft(length, '0');*/

                Panel p = (Panel)fplSearchList.Controls.Find("pl" + order.billID, false).FirstOrDefault();

                if (wasClicked)
                {
                    fplSearchList.Controls.SetChildIndex(p, counter++);
                }
                else
                {
                    fplSearchList.Controls.SetChildIndex(p, counter++);
                }
            }
            wasClicked = (wasClicked) ? false : true;
        }
        //Method for print!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void print_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            String start = "bt";
            String s = bt.Name;
            String end = "Print";
            int startIndex = s.IndexOf(start) + start.Length;
            int endIndex = s.IndexOf(end, startIndex);
            order_ID = long.Parse(s.Substring(startIndex, endIndex - startIndex));
            CreateBill createBill = new CreateBill();
            createBill.ShowDialog();
        }
    }
}
