﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;

namespace _4915M_Project
{

    public partial class StaffOrder : UserControl
    {
        List<buyorder> reList;
        //login.id
        Boolean wasClicked = false;
        Form detail = new Form();
        //long
        public static long order_ID;
        int actualOrder_id;
        Boolean isDel = false;
        Boolean isSubmit = false;
        TextBox[,] tbMsg;

        public StaffOrder()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            fplSearchList.Controls.Clear();
            Boolean isOrder = true;
            int width = fplSearchList.ClientSize.Width;
            int height = 30;

            using (var classicContext = new Entities())
            {
                String searchQuery = tbSearch.Text;
                var receiptList = (from list in classicContext.buyorders
                                   select list);

                if (cbSearchBy.SelectedIndex == 0)
                {
                    btOrderID.SendToBack();
                    long sQ;
                    try
                    {
                        sQ = long.Parse(searchQuery);
                    }
                    catch (FormatException)
                    {
                        sQ = 0;
                    }
                        
                    receiptList = receiptList.Where(order => order.orderID == sQ);
                    isOrder = true;
                }
                else
                {
                    btCustID.SendToBack();
                    receiptList = receiptList.Where(order => order.customerID == searchQuery);
                    isOrder = false;
                }

                reList = receiptList.ToList();

                lblResult.Text = (reList.Count > 0)
                    ? reList.Count.ToString() + " results return."
                    : "No entry found!";

                foreach (var record in reList)
                {
                    /* int length = 9 - record.orderID.ToString().Length;
                     String eOrderID = record.orderID.ToString().PadLeft(length, '0');*/

                    Panel row = newPanel(width - 5, height, record.orderID.ToString());
                    fplSearchList.Controls.Add(row);

                    Panel editor = editor_Panel(width / 3 + 5, height, record.orderID.ToString());
                    row.Controls.Add(editor);

                    newButton(editor.Width / 4, height, record.orderID.ToString(), editor, "Delete");

                    newButton(editor.Width / 4, height, record.orderID.ToString(), editor, "Edit");

                    newButton(editor.Width / 4, height, record.orderID.ToString(), editor, "Print");

                    newButton(editor.Width / 4, height, record.orderID.ToString(), editor, "Browse");



                    newLabel(width, height, record.orderID.ToString(), record.totalAmount.ToString(), row);
                    newLabel(width, height, record.orderID.ToString(), record.orderDateTime.ToString(), row);

                    if (isOrder)
                    {
                        newLabel(width, height, record.orderID.ToString(), record.customerID, row);
                        newLabel(width, height, record.orderID.ToString(), record.orderID.ToString(), row);
                    }
                    else
                    {
                        newLabel(width, height, record.orderID.ToString(), record.orderID.ToString(), row);
                        newLabel(width, height, record.orderID.ToString(), record.customerID, row);
                    }
                }

            }
        }

        private Panel newPanel(int width, int height, String id)
        {
            Panel p = new Panel();
            p.Name = "pl" + id;
            p.Size = new Size(width, height);
            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.FixedSingle;
            Margin = new Padding(0, 0, 0, 0);
            Padding = new Padding(0, 0, 0, 0);
            return p;
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
            if (content == "Edit")
            {
                btProduct.Image = (Image)(new Bitmap(_4915M_Project.Properties.Resources.edit, new Size(10, 10)));
                btProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
                btProduct.Click += new EventHandler(editOrder_Click);
            }
            else if (content == "Delete")
            {
                btProduct.Image = (Image)(new Bitmap(_4915M_Project.Properties.Resources.delete, new Size(10, 10)));
                btProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
                btProduct.Click += new EventHandler(del_Click);
            }
            else if (content == "Browse")
            {
                btProduct.Image = (Image)(new Bitmap(_4915M_Project.Properties.Resources.browse, new Size(10, 10)));
                btProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
                btProduct.Click += new EventHandler(viewItem_Click);
            }
            else if (content == "Print")
            {
                btProduct.Image = (Image)(new Bitmap(_4915M_Project.Properties.Resources.bPrint, new Size(10, 10)));
                btProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
                btProduct.Click += new EventHandler(print_Click);
            }
            btProduct.MouseHover += new EventHandler(bt_Hover);
            btProduct.MouseLeave += new EventHandler(btCancel_Hover);
        }

        private void AdminReceipt_Load(object sender, EventArgs e)
        {
            reload();
        }

        public void reload()
        {
            fplSearchList.Controls.Clear();
            if (!this.DesignMode)
            {
                int width = fplSearchList.ClientSize.Width;
                int height = 30;
                Boolean isOrder = true;

                using (var classicContext = new Entities())
                {
                    var receiptList = (from list in classicContext.buyorders
                                       select list);

                    reList = receiptList.ToList();

                    lblResult.Text = (reList.Count > 0)
                        ? "All results return." : "No results";


                    foreach (var record in reList)
                    {
                        Panel row = newPanel(width - 5, height, record.orderID.ToString());
                        fplSearchList.Controls.Add(row);

                        Panel editor = editor_Panel(width / 3 + 5, height, record.orderID.ToString());
                        row.Controls.Add(editor);

                        newButton(editor.Width / 4, height, record.orderID.ToString(), editor, "Delete");

                        newButton(editor.Width / 4, height, record.orderID.ToString(), editor, "Edit");

                        newButton(editor.Width / 4, height, record.orderID.ToString(), editor, "Print");

                        newButton(editor.Width / 4, height, record.orderID.ToString(), editor, "Browse");



                        newLabel(width, height, record.orderID.ToString(), record.totalAmount.ToString(), row);
                        newLabel(width, height, record.orderID.ToString(), record.orderDateTime.ToString(), row);

                        if (isOrder)
                        {
                            newLabel(width, height, record.orderID.ToString(), record.customerID, row);
                            newLabel(width, height, record.orderID.ToString(), record.orderID.ToString(), row);
                        }
                        else
                        {
                            newLabel(width, height, record.orderID.ToString(), record.orderID.ToString(), row);
                            newLabel(width, height, record.orderID.ToString(), record.customerID, row);
                        }
                    }

                }
                cbSearchBy.SelectedIndex = 1;
                btOrderID.Width = fplSearchList.ClientSize.Width / 6;
                btCustID.Width = fplSearchList.ClientSize.Width / 6;
                btOrderDate.Width = fplSearchList.ClientSize.Width / 6;
                btAmount.Width = fplSearchList.ClientSize.Width / 6;
                lblspacing.Width = fplSearchList.ClientSize.Width / 3;
                fplSearchList.HorizontalScroll.Maximum = 0;
                fplSearchList.AutoScroll = false;
                fplSearchList.VerticalScroll.Visible = false;
                fplSearchList.AutoScroll = true;
            }
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

        private void editOrder_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            String start = "bt";
            String s = bt.Name;
            String end = "Edit";
            int startIndex = s.IndexOf(start) + start.Length;
            int endIndex = s.IndexOf(end, startIndex);
            order_ID = long.Parse(s.Substring(startIndex, endIndex - startIndex));

            genForm(bt, true);
        }

        private void genForm(Button bt, Boolean isAble)
        {
            detail = new Form();
            detail.Text = "Order Item";
            buyorder record;

            String start = "bt";
            String s = bt.Name;
            String end;
            String name;
            TableLayoutPanel orderInfo;

            if (isAble)
            {
                orderInfo = newTableLayout("orderInfo", 2, 8, 50F, 16F);
                end = "Edit";
                int startIndex = s.IndexOf(start) + start.Length;
                int endIndex = s.IndexOf(end, startIndex);
                name = s.Substring(startIndex, endIndex - startIndex);
            }
            else
            {
                end = "Browse";
                int startIndex = s.IndexOf(start) + start.Length;
                int endIndex = s.IndexOf(end, startIndex);
                name = s.Substring(startIndex, endIndex - startIndex);
                orderInfo = newTableLayout("orderInfo", 2, 7, 50F, 16F);
            }

            actualOrder_id = Int32.Parse(name);
            record = reList.Find(i => i.orderID.ToString().Contains(actualOrder_id.ToString()));

            /*int length = 9 - record.orderID.ToString().Length;
            String eOrderID = record.orderID.ToString().PadLeft(length, '0');*/
            long eOrderID = record.orderID;


            detail.Size = new Size(330, 300);
            detail.MinimumSize = new Size(320, 300);
            detail.BackColor = Color.White;
            detail.StartPosition = FormStartPosition.CenterParent;

            orderInfo.Controls.Add(newHeader4Form("orderID", "Order ID"), 0, 0);
            orderInfo.Controls.Add(newHeader4Form("customerID", "Customer ID"), 0, 1);
            orderInfo.Controls.Add(newHeader4Form("totalAmount", "TotalAmount"), 0, 2);
            orderInfo.Controls.Add(newHeader4Form("orderDateTime", "Order Date Time"), 0, 3);
            orderInfo.Controls.Add(newHeader4Form("pickupPlace", "Pickup Place"), 0, 4);
            orderInfo.Controls.Add(newHeader4Form("status", "Status"), 0, 5);

            if (isAble)
            {
                orderInfo.Controls.Add(newHeader4Form("a_orderID", eOrderID.ToString()));
                orderInfo.Controls.Add(newHeader4Form("customerID", record.customerID));
                orderInfo.Controls.Add(orderInfo_newTB("totalAmount", record.totalAmount.ToString()));
                DateTime dt = Convert.ToDateTime(record.orderDateTime);
                orderInfo.Controls.Add(orderInfo_newTime("orderDateTime", dt));

                orderInfo.Controls.Add(orderInfo_newCB("pickupPlace", record.pickupPlace));
                orderInfo.Controls.Add(orderInfo_newTB("status", record.status));
                orderInfo.Controls.Add(orderInfo_Bt("Submit"), 0, 7);
                orderInfo.Controls.Add(orderInfo_Bt("Cancel"), 1, 7);

                orderInfo.Controls.Add(orderInfo_Bt("Check"), 1, 6);
            }
            else
            {
                orderInfo.Controls.Add(newHeader4Form("orderID", eOrderID.ToString()));
                orderInfo.Controls.Add(newHeader4Form("customerID", record.customerID));
                orderInfo.Controls.Add(newHeader4Form("totalAmount", record.totalAmount.ToString()));
                orderInfo.Controls.Add(newHeader4Form("orderDateTime", record.orderDateTime.ToString()));
                orderInfo.Controls.Add(newHeader4Form("pickupPlace", record.pickupPlace));
                orderInfo.Controls.Add(newHeader4Form("status", record.status));
                orderInfo.Controls.Add(orderInfo_Bt("View"), 1, 6);
            }



            orderInfo.Controls.Add(newHeader4Form("orderitems", "Order Items"), 0, 6);
            detail.Controls.Add(orderInfo);

            detail.ShowDialog();

            if (isSubmit)
            {
                EditOrderData(orderInfo);
                isSubmit = false;
                btSearch.PerformClick();
            }
        }

        private TableLayoutPanel newTableLayout(String name, int colCount, int rowCount, float colSize, float rowSize)
        {
            TableLayoutPanel t = new TableLayoutPanel();
            t.Name = name;
            t.Size = new System.Drawing.Size(228, 200);
            t.Dock = DockStyle.Fill;
            t.BackColor = Color.White;
            t.ColumnCount = colCount;
            t.RowCount = rowCount;
            t.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int i = 0; i < colCount; i++)
            {
                t.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colSize));
            }

            for (int i = 0; i < rowCount; i++)
            {
                t.RowStyles.Add(new RowStyle(SizeType.Percent, rowSize));
            }

            return t;
        }

        private Label newHeader4Form(String name, String Text)
        {
            var l = new Label
            {
                Name = "lb" + name,
                Dock = DockStyle.Fill,
                Text = Text,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.DarkOrange,
                Font = new Font("Calibri", 14),
                BackColor = Color.White,
            };

            return l;
        }

        private TextBox orderInfo_newTB(String name, String Text)
        {
            var t = new TextBox
            {
                Name = "tb" + name,
                Dock = DockStyle.Fill,
                Text = Text,
                AutoSize = false,
                ForeColor = Color.White,
                BackColor = Color.DarkOrange,
                TextAlign = HorizontalAlignment.Center,
                BorderStyle = BorderStyle.None,
                Font = new Font("Calibri", 20),
                Margin = new Padding(0),
            };

            return t;
        }

        private DateTimePicker orderInfo_newTime(String name, DateTime Text)
        {
            var d = new DateTimePicker
            {
                Name = "dt" + name,
                Dock = DockStyle.Fill,
                Format = DateTimePickerFormat.Custom,
                Value = Text,
                CustomFormat = "yyyy-MM-dd HH:mm:ss",
                Enabled = false,
            };

            return d;
        }

        private ComboBox orderInfo_newCB(String name, String Text)
        {
            var box = new ComboBox
            {
                Name = "CB" + name,
                ForeColor = Color.White,
                BackColor = Color.DarkOrange,
                Font = new Font("Calibri", 12),
            };
            box.Items.Add(Text);

            using(var classicContext = new Entities())
            {
                List<branch> branchLists = (from list in classicContext.branches
                                   where list.branchID != Text
                                    select list).ToList();

                foreach(var b in branchLists)
                {
                    box.Items.Add(b.branchID);
                }
            }
            box.SelectedIndex = 0;

            return box;
        }

        private Button orderInfo_Bt(String name)
        //, Form detail
        {
            var bt = new Button
            {
                Name = "bt" + name,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                ForeColor = Color.DarkMagenta,
                Cursor = Cursors.Hand,
                Text = name,
            };

            Form sureMsg = newMsgForm();

            switch (name)
            {
                case "Submit":
                    bt.Click += sure_Click;
                    break;

                case "Cancel":
                    bt.Click += cancel_EditForm;
                    detail.Refresh();
                    break;

                case "Yes":
                    bt.Click += change_Yes;
                    break;

                case "No":
                    bt.Click += change_No;
                    break;

                case "Check":
                    bt.Click += showItem;
                    break;

                case "View":
                    bt.Click += viewOnly;
                    break;
                case "Delete":
                    bt.Click += delRow;
                    break;

                default:
                    break;
            }


            return bt;
        }

        private void TbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btSearch.PerformClick();
            }
        }

        private void btSort_Click(List<buyorder> SortedRow)
        {
            int counter = 0;
            foreach (var order in SortedRow)
            {
                /*int length = 9 - order.orderID.ToString().Length;
                String eOrderID = order.orderID.ToString().PadLeft(length, '0');*/

                Panel p = (Panel)fplSearchList.Controls.Find("pl" + order.orderID, false).FirstOrDefault();

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

        private void btOrderID_Click(object sender, EventArgs e)
        {
            List<buyorder> SortedRow;

            if (wasClicked)
            {
                SortedRow = reList.OrderBy(o => o.orderID).ToList();
            }
            else
            {
                SortedRow = reList.OrderByDescending(o => o.orderID).ToList();
            }

            btSort_Click(SortedRow);
        }

        private void btCustID_Click(object sender, EventArgs e)
        {
            List<buyorder> SortedRow;
            if (wasClicked)
            {
                SortedRow = reList.OrderBy(o => o.customerID).ToList();
            }
            else
            {
                SortedRow = reList.OrderByDescending(o => o.customerID).ToList();
            }
            btSort_Click(SortedRow);
        }

        private void btOrderDate_Click(object sender, EventArgs e)
        {
            List<buyorder> SortedRow;

            if (wasClicked)
            {
                SortedRow = reList.OrderBy(o => o.orderDateTime).ToList();
            }
            else
            {
                SortedRow = reList.OrderByDescending(o => o.orderDateTime).ToList();
            }

            btSort_Click(SortedRow);
        }

        private void btAmount_Click(object sender, EventArgs e)
        {
            List<buyorder> SortedRow;
            if (wasClicked)
            {
                SortedRow = reList.OrderBy(o => o.totalAmount).ToList();
            }
            else
            {
                SortedRow = reList.OrderByDescending(o => o.totalAmount).ToList();
            }


            btSort_Click(SortedRow);
        }



        private void sure_Click(object sender, EventArgs e)
        {
            Button lb = (Button)sender;
            Form sureMsg = newMsgForm();
            TableLayoutPanel t = newTableLayout("tblSure", 2, 2, 50F, 50F);
            Label msg = newHeader4Form("remindMsg", "Are You Sure?");
            t.Controls.Add(msg, 0, 0);
            t.SetColumnSpan(msg, 2);

            t.Controls.Add(orderInfo_Bt("Yes"), 0, 1);
            t.Controls.Add(orderInfo_Bt("No"), 1, 1);

            sureMsg.Controls.Add(t);
            sureMsg.ShowDialog();
        }

        private Form newMsgForm()
        {
            Form sureMsg = new Form();
            sureMsg.StartPosition = FormStartPosition.CenterParent;
            sureMsg.Size = new Size(300, 200);
            sureMsg.MinimumSize = new Size(200, 200);
            sureMsg.Text = "Sure?";

            return sureMsg;
        }

        private void cancel_EditForm(object sender, EventArgs e)
        {
            Button lb = (Button)sender;
            detail.Close();
            if (lb.Parent.Name == "orItems")
            {
                Form f1 = (Form)lb.Parent.Parent;
                f1.Close();
            }
        }

        private void change_Yes(object sender, EventArgs e)
        {
            Button lb = (Button)sender;
            isSubmit = true;
            TableLayoutPanel p = (TableLayoutPanel)lb.Parent;
            Form sureMsg = (Form)p.Parent;

            lb.Enabled = false;

            sureMsg.Close();
            detail.Close();
        }

        private void change_No(object sender, EventArgs e)
        {
            isSubmit = false;
            isDel = false;
            Button lb = (Button)sender;
            TableLayoutPanel p = (TableLayoutPanel)lb.Parent;
            Form sureMsg = (Form)p.Parent;
            sureMsg.Close();
        }

        private void showItem(object sender, EventArgs e)
        {
            Button lb = (Button)sender;

            Form showItem = new Form();
            showItem.Size = new Size(400, 300);
            showItem.MinimumSize = new Size(370, 280);
            showItem.Text = "Items in order";
            showItem.StartPosition = FormStartPosition.CenterParent;

            TableLayoutPanel Items;

            using (var classicContext = new Entities())
            {
                var itemSets = (from list in classicContext.orderitems
                                where (list.orderID) == order_ID
                                select list).ToArray();


                var nameLists = (from list in classicContext.orderitems
                                 join p in classicContext.products on
                                 list.productID equals p.productID
                                 where list.orderID == order_ID
                                 select p).ToArray();


                Items = newTableLayout("orItems", (itemSets.Length + 1), 5, 50F, 25F);

                Items.Controls.Add(newHeader4Form("productID", "Product ID"), 0, 0);
                Items.Controls.Add(newHeader4Form("productName", "Name"), 0, 1);
                Items.Controls.Add(newHeader4Form("quantity", "Quantity"), 0, 2);
                Items.Controls.Add(newHeader4Form("sellingPrice", "Selling Price"), 0, 3);

                tbMsg = new TextBox[nameLists.Length, 4];

                for (int i = 0; i < nameLists.Length; i++)
                {
                    tbMsg[i, 1] = orderInfo_newTB("productName" + nameLists[i].productID, nameLists[i].productName);
                    Items.Controls.Add(tbMsg[i, 1], (i + 1), 1);

                    tbMsg[i, 0] = orderInfo_newTB("productID" + (itemSets[i].productID), itemSets[i].productID);
                    Items.Controls.Add(tbMsg[i, 0], (i + 1), 0);

                    tbMsg[i, 2] = orderInfo_newTB("quantity" + (itemSets[i].productID), itemSets[i].quantity.ToString());
                    Items.Controls.Add(tbMsg[i, 2], (i + 1), 2);

                    tbMsg[i, 3] = orderInfo_newTB("sellingPrice" + (itemSets[i].productID), itemSets[i].sellingPrice.ToString());
                    Items.Controls.Add(tbMsg[i, 3], (i + 1), 3);
                }

                Button submit = orderInfo_Bt("Submit");
                Items.Controls.Add(submit, 0, 4);
                Items.Controls.Add(orderInfo_Bt("Cancel"), 1, 4);
                //Items.SetColumnSpan(submit, 2);

                showItem.Controls.Add(Items);

                showItem.ShowDialog();
            }

            if (isSubmit)
            {
                editProInfo(Items);
            }
        }

        private void viewItem_Click(object sender, EventArgs e)
        {
            Button lb = (Button)sender;
            String start = "bt";
            String s = lb.Name;
            String end = "Browse";
            int startIndex = s.IndexOf(start) + start.Length;
            int endIndex = s.IndexOf(end, startIndex);
            order_ID = long.Parse(s.Substring(startIndex, endIndex - startIndex));

            genForm(lb, false);
        }


        private void viewOnly(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            readOnlyOrders(bt);
        }

        private void readOnlyOrders(Button bt)
        {
            Form showItem = new Form();
            showItem.Size = new Size(400, 300);
            showItem.MinimumSize = new Size(370, 280);
            showItem.Text = "Items in order";
            showItem.StartPosition = FormStartPosition.CenterParent;

            TableLayoutPanel Items;

            using (var classicContext = new Entities())
            {

                var itemSets = (from list in classicContext.orderitems
                                where list.orderID.Equals(order_ID)
                                select list).ToArray();

                Items = newTableLayout("orItems", (itemSets.Length + 1), 4, 50F, 25F);

                Items.Controls.Add(newHeader4Form("productID", "Product ID"), 0, 0);
                Items.Controls.Add(newHeader4Form("productName", "Name"), 0, 1);
                Items.Controls.Add(newHeader4Form("quantity", "Quantity"), 0, 2);
                Items.Controls.Add(newHeader4Form("sellingPrice", "Selling Price"), 0, 3);



                for (int i = 0; i < itemSets.Length; i++)
                {

                    Items.Controls.Add(newHeader4Form("productID", itemSets[i].productID), (i + 1), 0);
                    Items.Controls.Add(newHeader4Form("quantity", itemSets[i].quantity.ToString()), (i + 1), 2);
                    Items.Controls.Add(newHeader4Form("sellingPrice", itemSets[i].sellingPrice.ToString()), (i + 1), 3);
                }

                var nameLists = (from list in classicContext.orderitems
                                 join p in classicContext.products on
                                 list.productID equals p.productID
                                 where list.orderID == order_ID
                                 select p).ToArray();

                for (int i = 0; i < nameLists.Length; i++)
                {
                    Items.Controls.Add(newHeader4Form("productName", nameLists[i].productName), (i + 1), 1);
                }

                showItem.Controls.Add(Items);

                showItem.ShowDialog();
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            Form sureMsg = newMsgForm();
            TableLayoutPanel t = newTableLayout("ask", 2, 2, 50F, 50F);
            Label msg = newHeader4Form("ask", "Do you wish to delete it?");
            t.Controls.Add(msg, 0, 0);
            t.SetColumnSpan(msg, 2);
            t.Controls.Add(orderInfo_Bt("Delete"), 0, 1);
            t.Controls.Add(orderInfo_Bt("No"), 1, 1);
            sureMsg.Controls.Add(t);
            sureMsg.ShowDialog();
            //bt.Parent
            if (isDel)
            {
                String rowID = bt.Parent.Name;

                String start = "bt";
                String s = bt.Name;
                String end = "Delete";
                int startIndex = s.IndexOf(start) + start.Length;
                int endIndex = s.IndexOf(end, startIndex);
                String name = s.Substring(startIndex, endIndex - startIndex);

                rowID = name;
                Panel row = (Panel)fplSearchList.Controls.Find("pl" + rowID, false).FirstOrDefault();
                //this.Controls.Remove(row);
                row.Dispose();

                using (var classicContext = new Entities())
                {
                    var x = (from list in classicContext.orderitems
                             where list.orderID.ToString().Contains(rowID)
                             select list
                              );

                    foreach (var it in x)
                    {

                        classicContext.orderitems.Remove(it);
                    }
                    classicContext.SaveChanges();

                }
                using (var classicContext = new Entities())
                {
                    var x = (from list in classicContext.buyorders
                             where list.orderID.ToString().Contains(rowID)
                             select list
                             ).FirstOrDefault();
                    classicContext.buyorders.Remove(x);
                    classicContext.SaveChanges();
                }

                isDel = false;
            }
        }




        private void delRow(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            isDel = true;
            Form p = (Form)bt.Parent.Parent;
            p.Close();
        }

        private void EditOrderData(TableLayoutPanel orderInfo)
        {
            Label oidLbL = (Label)orderInfo.Controls.Find("lb" + "a_orderID", false).FirstOrDefault();
            long o_id = long.Parse(oidLbL.Text);
            /*o_id = o_id.PadLeft((9- o_id.Length), '0');*/

            TextBox box = (TextBox)orderInfo.Controls.Find("tb" + "totalAmount", false).FirstOrDefault();
            String amount = box.Text;

            DateTimePicker time = (DateTimePicker)orderInfo.Controls.Find("dt" + "orderDateTime", false).FirstOrDefault();
            DateTime myDate = time.Value.Date +
                    time.Value.TimeOfDay;
            //String dateTime = time.Value; 

            ComboBox cb = (ComboBox)orderInfo.Controls.Find("CB" + "pickupPlace", false).FirstOrDefault();
            String place = cb.SelectedItem.ToString();

            box = (TextBox)orderInfo.Controls.Find("tb" + "status", false).FirstOrDefault();
            String status = box.Text;

            using (var classicContext = new Entities())
            {
                List<buyorder> sets = (from list in classicContext.buyorders
                                       where list.orderID == o_id
                                       select list).ToList();

                buyorder b = reList.Find(o => o.orderID == o_id);

                Panel p = (Panel)fplSearchList.Controls.Find("pl" + o_id, false).FirstOrDefault();
                Label l = (Label)p.Controls.Find("lbl" + o_id + b.totalAmount.ToString(), false).FirstOrDefault();

                foreach (var set in sets)
                {
                    set.totalAmount = decimal.Parse(amount, new CultureInfo("en-US"));
                    set.orderDateTime = myDate;
                    set.pickupPlace = place;
                    set.status = status;
                }

                classicContext.SaveChanges();

            }

        }
        private void editProInfo(TableLayoutPanel Items)
        {
            using (var classicContext = new Entities())
            {
                var nameLists = (from list in classicContext.orderitems
                                 join p in classicContext.products on
                                 list.productID equals p.productID
                                 where list.orderID == order_ID
                                 select p).ToArray();


                var results = (from list in classicContext.orderitems
                               where order_ID == list.orderID
                               select list).ToArray();

                for (int i = 0; i < results.Length; i++)
                {
                    results[i].productID = tbMsg[i, 0].Text;
                    results[i].quantity = Int32.Parse(tbMsg[i, 2].Text);

                    var culture = new CultureInfo("en-US");
                    results[i].sellingPrice = Convert.ToDecimal(tbMsg[i, 3].Text, culture);
                }

                for (int i = 0; i < nameLists.Length; i++)
                {
                    nameLists[i].productName = tbMsg[i, 1].Text;
                }

                isSubmit = false;
                classicContext.SaveChanges();
            }
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
            CreateReceipt createReceipt = new CreateReceipt();
            createReceipt.ShowDialog();
        }
    }
}
