namespace _4915M_Project
{
    partial class StaffInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showcaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtstockQuantity = new System.Windows.Forms.TextBox();
            this.txtunitPrice = new System.Windows.Forms.TextBox();
            this.txtshowcaseID = new System.Windows.Forms.TextBox();
            this.txtproductName = new System.Windows.Forms.TextBox();
            this.txtproductID = new System.Windows.Forms.TextBox();
            this.lblremark = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lblstockQuantity = new System.Windows.Forms.Label();
            this.lblunitPrice = new System.Windows.Forms.Label();
            this.lblshowcaseID = new System.Windows.Forms.Label();
            this.lblproductName = new System.Windows.Forms.Label();
            this.lblproductID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 20;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.showcaseID,
            this.unitPrice,
            this.stockQuantity,
            this.discount,
            this.remark});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.Location = new System.Drawing.Point(0, 290);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(919, 455);
            this.dgvProduct.TabIndex = 113;
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "productID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "productName";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // showcaseID
            // 
            this.showcaseID.DataPropertyName = "showcaseID";
            this.showcaseID.HeaderText = "showcaseID";
            this.showcaseID.Name = "showcaseID";
            this.showcaseID.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.DataPropertyName = "unitPrice";
            this.unitPrice.HeaderText = "unitPrice";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // stockQuantity
            // 
            this.stockQuantity.DataPropertyName = "stockQuantity";
            this.stockQuantity.HeaderText = "stockQuantity";
            this.stockQuantity.Name = "stockQuantity";
            this.stockQuantity.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "remark";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(596, 118);
            this.txtremark.MaxLength = 50;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(100, 22);
            this.txtremark.TabIndex = 112;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(394, 238);
            this.txtdiscount.MaxLength = 3;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 22);
            this.txtdiscount.TabIndex = 111;
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // txtstockQuantity
            // 
            this.txtstockQuantity.Location = new System.Drawing.Point(394, 178);
            this.txtstockQuantity.MaxLength = 3;
            this.txtstockQuantity.Name = "txtstockQuantity";
            this.txtstockQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtstockQuantity.TabIndex = 110;
            this.txtstockQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstockQuantity_KeyPress);
            // 
            // txtunitPrice
            // 
            this.txtunitPrice.Location = new System.Drawing.Point(394, 118);
            this.txtunitPrice.MaxLength = 12;
            this.txtunitPrice.Name = "txtunitPrice";
            this.txtunitPrice.Size = new System.Drawing.Size(100, 22);
            this.txtunitPrice.TabIndex = 109;
            this.txtunitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtunitPrice_KeyPress);
            // 
            // txtshowcaseID
            // 
            this.txtshowcaseID.Location = new System.Drawing.Point(180, 238);
            this.txtshowcaseID.MaxLength = 8;
            this.txtshowcaseID.Name = "txtshowcaseID";
            this.txtshowcaseID.Size = new System.Drawing.Size(100, 22);
            this.txtshowcaseID.TabIndex = 108;
            this.txtshowcaseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtshowcaseID_KeyPress);
            // 
            // txtproductName
            // 
            this.txtproductName.Location = new System.Drawing.Point(180, 178);
            this.txtproductName.MaxLength = 30;
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(100, 22);
            this.txtproductName.TabIndex = 107;
            // 
            // txtproductID
            // 
            this.txtproductID.Location = new System.Drawing.Point(180, 118);
            this.txtproductID.MaxLength = 8;
            this.txtproductID.Name = "txtproductID";
            this.txtproductID.Size = new System.Drawing.Size(100, 22);
            this.txtproductID.TabIndex = 106;
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.BackColor = System.Drawing.Color.Transparent;
            this.lblremark.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremark.Location = new System.Drawing.Point(545, 121);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(45, 14);
            this.lblremark.TabIndex = 105;
            this.lblremark.Text = "remark";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.BackColor = System.Drawing.Color.Transparent;
            this.lbldiscount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(338, 240);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(54, 14);
            this.lbldiscount.TabIndex = 104;
            this.lbldiscount.Text = "discount";
            // 
            // lblstockQuantity
            // 
            this.lblstockQuantity.AutoSize = true;
            this.lblstockQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblstockQuantity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockQuantity.Location = new System.Drawing.Point(312, 182);
            this.lblstockQuantity.Name = "lblstockQuantity";
            this.lblstockQuantity.Size = new System.Drawing.Size(80, 14);
            this.lblstockQuantity.TabIndex = 103;
            this.lblstockQuantity.Text = "stockQuantity";
            // 
            // lblunitPrice
            // 
            this.lblunitPrice.AutoSize = true;
            this.lblunitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblunitPrice.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunitPrice.Location = new System.Drawing.Point(333, 121);
            this.lblunitPrice.Name = "lblunitPrice";
            this.lblunitPrice.Size = new System.Drawing.Size(55, 14);
            this.lblunitPrice.TabIndex = 102;
            this.lblunitPrice.Text = "unitPrice";
            // 
            // lblshowcaseID
            // 
            this.lblshowcaseID.AutoSize = true;
            this.lblshowcaseID.BackColor = System.Drawing.Color.Transparent;
            this.lblshowcaseID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowcaseID.Location = new System.Drawing.Point(105, 240);
            this.lblshowcaseID.Name = "lblshowcaseID";
            this.lblshowcaseID.Size = new System.Drawing.Size(73, 14);
            this.lblshowcaseID.TabIndex = 101;
            this.lblshowcaseID.Text = "showcaseID";
            // 
            // lblproductName
            // 
            this.lblproductName.AutoSize = true;
            this.lblproductName.BackColor = System.Drawing.Color.Transparent;
            this.lblproductName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductName.Location = new System.Drawing.Point(98, 182);
            this.lblproductName.Name = "lblproductName";
            this.lblproductName.Size = new System.Drawing.Size(82, 14);
            this.lblproductName.TabIndex = 100;
            this.lblproductName.Text = "Product Name";
            // 
            // lblproductID
            // 
            this.lblproductID.AutoSize = true;
            this.lblproductID.BackColor = System.Drawing.Color.Transparent;
            this.lblproductID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblproductID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductID.Location = new System.Drawing.Point(112, 121);
            this.lblproductID.Name = "lblproductID";
            this.lblproductID.Size = new System.Drawing.Size(62, 14);
            this.lblproductID.TabIndex = 99;
            this.lblproductID.Text = "Product ID";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(675, 35);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 41);
            this.btnReset.TabIndex = 98;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(553, 35);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 41);
            this.btnDelete.TabIndex = 97;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(421, 35);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 41);
            this.btnSave.TabIndex = 96;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(85, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 95;
            this.label1.Text = "Inventory management";
            // 
            // StaffInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txtremark);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtstockQuantity);
            this.Controls.Add(this.txtunitPrice);
            this.Controls.Add(this.txtshowcaseID);
            this.Controls.Add(this.txtproductName);
            this.Controls.Add(this.txtproductID);
            this.Controls.Add(this.lblremark);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lblstockQuantity);
            this.Controls.Add(this.lblunitPrice);
            this.Controls.Add(this.lblshowcaseID);
            this.Controls.Add(this.lblproductName);
            this.Controls.Add(this.lblproductID);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(919, 639);
            this.Name = "StaffInventory";
            this.Size = new System.Drawing.Size(919, 639);
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtstockQuantity;
        private System.Windows.Forms.TextBox txtunitPrice;
        private System.Windows.Forms.TextBox txtshowcaseID;
        private System.Windows.Forms.TextBox txtproductName;
        private System.Windows.Forms.TextBox txtproductID;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblstockQuantity;
        private System.Windows.Forms.Label lblunitPrice;
        private System.Windows.Forms.Label lblshowcaseID;
        private System.Windows.Forms.Label lblproductName;
        private System.Windows.Forms.Label lblproductID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}
