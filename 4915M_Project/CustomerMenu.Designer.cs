namespace _4915M_Project
{
    partial class CustomerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnQueries = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnShowcaseList = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnPersonInfo = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.lbCharacter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.customerOrder1 = new _4915M_Project.CustomerOrder();
            this.customerShowcaseList1 = new _4915M_Project.CustomerShowcaseList();
            this.customerProfile1 = new _4915M_Project.CustomerProfile();
            this.productmain1 = new _4915M_Project.Productmain();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btnReceipt);
            this.panel1.Controls.Add(this.pbRefresh);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnQueries);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnShowcaseList);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnPersonInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 682);
            this.panel1.TabIndex = 0;
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(0, 216);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(135, 55);
            this.btnReceipt.TabIndex = 8;
            this.btnReceipt.Text = "Order Record";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pbRefresh
            // 
            this.pbRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::_4915M_Project.Properties.Resources.refresh2;
            this.pbRefresh.Location = new System.Drawing.Point(57, 12);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(31, 32);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 3;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.OrangeRed;
            this.SidePanel.Location = new System.Drawing.Point(134, 51);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(11, 55);
            this.SidePanel.TabIndex = 1;
            // 
            // btnQueries
            // 
            this.btnQueries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnQueries.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnQueries.FlatAppearance.BorderSize = 0;
            this.btnQueries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueries.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueries.ForeColor = System.Drawing.Color.White;
            this.btnQueries.Location = new System.Drawing.Point(0, 271);
            this.btnQueries.Margin = new System.Windows.Forms.Padding(0);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Size = new System.Drawing.Size(135, 55);
            this.btnQueries.TabIndex = 7;
            this.btnQueries.Text = "Shopping Cart";
            this.btnQueries.UseVisualStyleBackColor = false;
            this.btnQueries.Click += new System.EventHandler(this.btnQueries_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.OrangeRed;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(0, 641);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "Chinese(Traditional)";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnShowcaseList
            // 
            this.btnShowcaseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnShowcaseList.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShowcaseList.FlatAppearance.BorderSize = 0;
            this.btnShowcaseList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowcaseList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowcaseList.ForeColor = System.Drawing.Color.White;
            this.btnShowcaseList.Location = new System.Drawing.Point(0, 161);
            this.btnShowcaseList.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowcaseList.Name = "btnShowcaseList";
            this.btnShowcaseList.Size = new System.Drawing.Size(135, 55);
            this.btnShowcaseList.TabIndex = 2;
            this.btnShowcaseList.Text = "Showcase List";
            this.btnShowcaseList.UseVisualStyleBackColor = false;
            this.btnShowcaseList.Click += new System.EventHandler(this.btnShowcaseList_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(0, 106);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(135, 55);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnPersonInfo
            // 
            this.btnPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnPersonInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPersonInfo.FlatAppearance.BorderSize = 0;
            this.btnPersonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonInfo.ForeColor = System.Drawing.Color.White;
            this.btnPersonInfo.Location = new System.Drawing.Point(0, 51);
            this.btnPersonInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersonInfo.Name = "btnPersonInfo";
            this.btnPersonInfo.Size = new System.Drawing.Size(135, 55);
            this.btnPersonInfo.TabIndex = 0;
            this.btnPersonInfo.Text = "Personal Info";
            this.btnPersonInfo.UseVisualStyleBackColor = false;
            this.btnPersonInfo.Click += new System.EventHandler(this.btnPersonInfo_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.topPanel.Controls.Add(this.pbLogout);
            this.topPanel.Controls.Add(this.lbCharacter);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(145, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(919, 52);
            this.topPanel.TabIndex = 1;
            // 
            // pbLogout
            // 
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = global::_4915M_Project.Properties.Resources.logout__2_;
            this.pbLogout.Location = new System.Drawing.Point(866, 7);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(41, 37);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 3;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbCharacter
            // 
            this.lbCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCharacter.AutoSize = true;
            this.lbCharacter.Font = new System.Drawing.Font("BrowalliaUPC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharacter.ForeColor = System.Drawing.Color.White;
            this.lbCharacter.Location = new System.Drawing.Point(457, 13);
            this.lbCharacter.Margin = new System.Windows.Forms.Padding(0);
            this.lbCharacter.Name = "lbCharacter";
            this.lbCharacter.Size = new System.Drawing.Size(42, 27);
            this.lbCharacter.TabIndex = 2;
            this.lbCharacter.Text = "ABC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4915M_Project.Properties.Resources.companyname;
            this.pictureBox1.Location = new System.Drawing.Point(47, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(6, 3);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(38, 37);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // customerOrder1
            // 
            this.customerOrder1.BackColor = System.Drawing.Color.White;
            this.customerOrder1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOrder1.ForeColor = System.Drawing.Color.DarkOrange;
            this.customerOrder1.Location = new System.Drawing.Point(145, 51);
            this.customerOrder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerOrder1.MaximumSize = new System.Drawing.Size(919, 639);
            this.customerOrder1.Name = "customerOrder1";
            this.customerOrder1.Size = new System.Drawing.Size(919, 639);
            this.customerOrder1.TabIndex = 4;
            this.customerOrder1.Visible = false;
            // 
            // customerShowcaseList1
            // 
            this.customerShowcaseList1.BackColor = System.Drawing.Color.DarkOrange;
            this.customerShowcaseList1.Location = new System.Drawing.Point(145, 51);
            this.customerShowcaseList1.MaximumSize = new System.Drawing.Size(919, 639);
            this.customerShowcaseList1.Name = "customerShowcaseList1";
            this.customerShowcaseList1.Size = new System.Drawing.Size(919, 639);
            this.customerShowcaseList1.TabIndex = 3;
            this.customerShowcaseList1.Visible = false;
            // 
            // customerProfile1
            // 
            this.customerProfile1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customerProfile1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerProfile1.Location = new System.Drawing.Point(145, 71);
            this.customerProfile1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerProfile1.MaximumSize = new System.Drawing.Size(919, 639);
            this.customerProfile1.Name = "customerProfile1";
            this.customerProfile1.Size = new System.Drawing.Size(919, 639);
            this.customerProfile1.TabIndex = 2;
            // 
            // productmain1
            // 
            this.productmain1.AutoScroll = true;
            this.productmain1.AutoSize = true;
            this.productmain1.BackColor = System.Drawing.Color.White;
            this.productmain1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productmain1.ForeColor = System.Drawing.Color.DarkOrange;
            this.productmain1.Location = new System.Drawing.Point(145, 51);
            this.productmain1.MaximumSize = new System.Drawing.Size(919, 639);
            this.productmain1.Name = "productmain1";
            this.productmain1.Size = new System.Drawing.Size(919, 639);
            this.productmain1.TabIndex = 5;
            this.productmain1.Visible = false;
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 682);
            this.Controls.Add(this.productmain1);
            this.Controls.Add(this.customerOrder1);
            this.Controls.Add(this.customerShowcaseList1);
            this.Controls.Add(this.customerProfile1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "CustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HKCS Application";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnShowcaseList;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnPersonInfo;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCharacter;
        private System.Windows.Forms.Button btnQueries;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Button btnReceipt;
        private CustomerProfile customerProfile1;
        private CustomerShowcaseList customerShowcaseList1;
        private CustomerOrder customerOrder1;
        private Productmain productmain1;
    }
}