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
    public partial class CustomerOrder : UserControl
    {

        List<buyorder> reList;
        //Login.id;
        Boolean wasClicked = false;
        Form detail = new Form();
        //long
        public static long order_ID;
        int actualOrder_id;

        public CustomerOrder()
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
                    reList = (from list in classicContext.buyorders
                              where list.customerID == Login.id
                              select list).ToList();

                    lblResult.Text = (reList.Count > 0)
                        ? reList.Count.ToString() + " results return."
                        : "No entry found!";

                    foreach (var record in reList)
                    {
                        Panel row = newPanel(width - 5, height, record.orderID.ToString());
                        fplSearchList.Controls.Add(row);

                        Panel editor = editor_Panel(width / 3 + 5, height, record.orderID.ToString());
                        row.Controls.Add(editor);

                        newButton(editor.Width / 2, height, record.orderID.ToString(), editor, "Print");

                        newButton(editor.Width / 2, height, record.orderID.ToString(), editor, "Browse");



                        newLabel(width, height, record.orderID.ToString(), record.totalAmount.ToString(), row);
                        newLabel(width, height, record.orderID.ToString(), record.orderDateTime.ToString(), row);
                        newLabel(width, height, record.orderID.ToString(), record.customerID, row);
                        newLabel(width, height, record.orderID.ToString(), record.orderID.ToString(), row);

                    }

                }
                btOrderID.Width = fplSearchList.ClientSize.Width / 6;
                btCustID.Width = fplSearchList.ClientSize.Width / 6;
                btOrderDate.Width = fplSearchList.ClientSize.Width / 6;
                btAmount.Width = fplSearchList.ClientSize.Width / 6;
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

            if (content == "Browse")
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


            orderInfo.Controls.Add(newHeader4Form("orderID", eOrderID.ToString()));
            orderInfo.Controls.Add(newHeader4Form("customerID", record.customerID));
            orderInfo.Controls.Add(newHeader4Form("totalAmount", record.totalAmount.ToString()));
            orderInfo.Controls.Add(newHeader4Form("orderDateTime", record.orderDateTime.ToString()));
            orderInfo.Controls.Add(newHeader4Form("pickupPlace", record.pickupPlace));
            orderInfo.Controls.Add(newHeader4Form("status", record.status));
            orderInfo.Controls.Add(orderInfo_Bt("View"), 1, 6);




            orderInfo.Controls.Add(newHeader4Form("orderitems", "Order Items"), 0, 6);
            detail.Controls.Add(orderInfo);

            detail.ShowDialog();

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
                case "View":
                    bt.Click += viewOnly;
                    break;

                default:
                    break;
            }


            return bt;
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

        private Form newMsgForm()
        {
            Form sureMsg = new Form();
            sureMsg.Size = new Size(200, 200);
            sureMsg.Text = "Sure?";

            return sureMsg;
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
            showItem.Size = new Size(370, 280);
            showItem.Text = "Items in order";
            showItem.StartPosition = FormStartPosition.CenterParent;

            TableLayoutPanel Items;

            using (var classicContext = new Entities())
            {

                var itemSets = (from list in classicContext.orderitems
                                where list.orderID == order_ID
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
