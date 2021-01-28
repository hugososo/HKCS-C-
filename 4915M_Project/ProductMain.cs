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
    public partial class Productmain : UserControl
    {

        int panelCount = 1;
        int currentPage = 1;
        /*int width = plProductList.ClientSize.Width - 50;*/
        int width = 750;

        public Productmain()
        {
            InitializeComponent();
        }


        private void Productmain_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                reload();
        }

        public void reload()
        {
            using (var classicContext = new Entities())
            {
                var productlist = (from list in classicContext.products
                                   select list);

                product[] pList = productlist.ToArray();
                int subCounter = 1000;

                lblRows.Text = pList.Length.ToString();
                lblKeyword.Text = tbSearch.Text;

                if (pList.Length > 0)
                {
                    Panel page = newPanel(panelCount++, width, 600);
                    plProductList.Controls.Add(page);


                    for (int i = 0; i < pList.Length; i++)
                    {
                        if (i % 3 == 0 && i != 0)
                        {
                            /*page*/
                            page = newPanel(panelCount++, width, 600);
                            plProductList.Controls.Add(page);
                        }

                        /*Panel inside the page*/
                        Panel temp = newPanel(subCounter++, width, 200);
                        page.Controls.Add(temp);
                        //new
                        temp.BringToFront();

                        Button addToCart = newButton(subCounter++, 100, 200 / 4, temp);
                        addToCart.Text = "ADD TO Cart";

                        /*product price*/
                        Label price = newLabel(subCounter++, 100, 200 / 4, temp);
                        price.Text = "$ " + pList[i].unitPrice.ToString();

                        /*product stock*/
                        ComboBox stock = newComboBox(subCounter++, 100, 200 / 4, temp);
                        stock.Text = "QTY = " + pList[i].stockQuantity.ToString();

                        /*product name*/
                        Label name = newLabel(subCounter++, 100, 200 / 4, temp);
                        name.Text = "Name: " + pList[i].productName;

                        newPicBox(subCounter++, 200, 200, temp);

                        Panel index = (Panel)plProductList.Controls.Find("panel1", false).FirstOrDefault();
                        index.SendToBack();
                    }
                }
            }
        }

        private Panel newPanel(int count, int width, int height)
        {

            Panel p = new Panel();

            p.Name = "panel" + (count);
            p.Size = new Size(width, height);
            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Dock = DockStyle.Top;
            return p;

            /*x.BringToFront();*/
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
            String searchQuery = tbSearch.Text;

            using (var classicContext = new Entities())
            {
                var productlist = (from list in classicContext.products
                                   where list.productName.Contains(searchQuery)
                                   select list);

                product[] pList = productlist.ToArray();
                int subCounter = 1000;

                lblRows.Text = pList.Length.ToString();
                lblKeyword.Text = tbSearch.Text;

                if (pList.Length > 0)
                {
                    Panel page = newPanel(panelCount++, width, 600);
                    plProductList.Controls.Add(page);


                    for (int i = 0; i < pList.Length; i++)
                    {
                        if (i % 3 == 0 && i != 0)
                        {
                            /*page*/
                            page = newPanel(panelCount++, width, 600);
                            plProductList.Controls.Add(page);
                        }

                        /*Panel inside the page*/
                        Panel temp = newPanel(subCounter++, width, 200);
                        page.Controls.Add(temp);
                        //new
                        temp.BringToFront();

                        Button addToCart = newButton(subCounter++, 100, 200 / 4, temp);
                        addToCart.Text = "ADD TO Cart";

                        /*product price*/
                        Label price = newLabel(subCounter++, 100, 200 / 4, temp);
                        price.Text = "$ " + pList[i].unitPrice.ToString();

                        /*product stock*/
                        ComboBox stock = newComboBox(subCounter++, 100, 200 / 4, temp);
                        stock.Text = "QTY = " + pList[i].stockQuantity.ToString();

                        /*product name*/
                        Label name = newLabel(subCounter++, 100, 200 / 4, temp);
                        name.Text = "Name: " + pList[i].productName;

                        newPicBox(subCounter++, 200, 200, temp);

                        Panel index = (Panel)plProductList.Controls.Find("panel1", false).FirstOrDefault();
                        index.SendToBack();
                    }
                }
            }
        }

        private void newPicBox(int count, int width, int height, Panel p)
        {
            var picture = new PictureBox
            {
                Name = "pictureBox" + count,
                Size = new Size(width, height),
                Dock = DockStyle.Left,
                BorderStyle = BorderStyle.Fixed3D,
                SizeMode = PictureBoxSizeMode.StretchImage,
        };

            picture.ImageLocation = @"D:\im.JPG";
            p.Controls.Add(picture);
        }

        private Label newLabel(int count, int width, int height, Panel p)
        {
            var lblProduct = new Label
            {
                Name = "lbl" + count,
                Size = new Size(width, height),
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                BackColor = Color.DarkOrange,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Calibri", 14),
                BorderStyle = BorderStyle.FixedSingle,
        };

            p.Controls.Add(lblProduct);

            return lblProduct;
        }

        private Button newButton(int count, int width, int height, Panel p)
        {
            var btProduct = new Button
            {
                Name = "bt" + count,
                Size = new Size(width, height),
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Gray,
                ForeColor = Color.White,
            };

            p.Controls.Add(btProduct);

            btProduct.Click += new EventHandler(form_click);

            return btProduct;
        }

        private ComboBox newComboBox(int count, int width, int height, Panel p)
        {
            var cbProduct = new ComboBox
            {
                Name = "cb" + count,
                Size = new Size(width, height),
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                BackColor = Color.DarkOrange,
                Font = new Font("Calibri", 14),
            };

            p.Controls.Add(cbProduct);

            return cbProduct;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btNext.Enabled = (panelCount > 0) ? true : false;
            if ((panelCount - 1) == 0 || currentPage == 1)
            {
                button9.Enabled = false;
            }
            else
            {
                var index = plProductList.Controls.Find("panel" + (--currentPage), false).FirstOrDefault(); ;
                index.SendToBack();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ( (panelCount-1) == 0 || currentPage == (panelCount - 1) )
            {
                btNext.Enabled = false;
            }
            else
            {
               var index = plProductList.Controls.Find("panel" + (++currentPage), false).FirstOrDefault(); ;
                index.SendToBack();
                button9.Enabled = true;
            }


        }

        private void form_click(object sender, EventArgs e)
        {
            Form f1 = new Form();
            f1.Text = "Added successfully";
            f1.Controls.Add(new Button { Text = "ok", Width = f1.ClientSize.Width, }) ;
            f1.ShowDialog();
        }

    }
}
