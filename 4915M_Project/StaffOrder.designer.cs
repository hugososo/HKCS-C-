namespace _4915M_Project
{
    partial class StaffOrder
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
            this.plHeading = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSearchRemind = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.separate1 = new System.Windows.Forms.Label();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.pdtbSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.fplContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.plColumn = new System.Windows.Forms.Panel();
            this.lblspacing = new System.Windows.Forms.Label();
            this.btAmount = new System.Windows.Forms.Button();
            this.btOrderDate = new System.Windows.Forms.Button();
            this.btCustID = new System.Windows.Forms.Button();
            this.btOrderID = new System.Windows.Forms.Button();
            this.fplSearchList = new System.Windows.Forms.FlowLayoutPanel();
            this.plHeading.SuspendLayout();
            this.pdtbSearch.SuspendLayout();
            this.fplContainer.SuspendLayout();
            this.plColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // plHeading
            // 
            this.plHeading.BackColor = System.Drawing.Color.Transparent;
            this.plHeading.Controls.Add(this.lblResult);
            this.plHeading.Controls.Add(this.lblSearchRemind);
            this.plHeading.Controls.Add(this.cbSearchBy);
            this.plHeading.Controls.Add(this.separate1);
            this.plHeading.Controls.Add(this.lblHeaderText);
            this.plHeading.Controls.Add(this.pdtbSearch);
            this.plHeading.Controls.Add(this.btSearch);
            this.plHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.plHeading.Location = new System.Drawing.Point(0, 0);
            this.plHeading.Name = "plHeading";
            this.plHeading.Size = new System.Drawing.Size(919, 191);
            this.plHeading.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Orange;
            this.lblResult.Location = new System.Drawing.Point(123, 146);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(642, 30);
            this.lblResult.TabIndex = 21;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchRemind
            // 
            this.lblSearchRemind.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRemind.ForeColor = System.Drawing.Color.Orange;
            this.lblSearchRemind.Location = new System.Drawing.Point(56, 61);
            this.lblSearchRemind.Name = "lblSearchRemind";
            this.lblSearchRemind.Size = new System.Drawing.Size(184, 31);
            this.lblSearchRemind.TabIndex = 20;
            this.lblSearchRemind.Text = "Search By";
            this.lblSearchRemind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.BackColor = System.Drawing.Color.DarkOrange;
            this.cbSearchBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchBy.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchBy.ForeColor = System.Drawing.Color.White;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.ItemHeight = 23;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Order ID",
            "Customer ID"});
            this.cbSearchBy.Location = new System.Drawing.Point(41, 98);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(230, 31);
            this.cbSearchBy.TabIndex = 19;
            // 
            // separate1
            // 
            this.separate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separate1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separate1.Location = new System.Drawing.Point(0, 188);
            this.separate1.Name = "separate1";
            this.separate1.Size = new System.Drawing.Size(919, 3);
            this.separate1.TabIndex = 18;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.Orange;
            this.lblHeaderText.Location = new System.Drawing.Point(329, 12);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(242, 38);
            this.lblHeaderText.TabIndex = 17;
            this.lblHeaderText.Text = "Receipt Query";
            this.lblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pdtbSearch
            // 
            this.pdtbSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.pdtbSearch.Controls.Add(this.tbSearch);
            this.pdtbSearch.Location = new System.Drawing.Point(314, 79);
            this.pdtbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.pdtbSearch.Name = "pdtbSearch";
            this.pdtbSearch.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.pdtbSearch.Size = new System.Drawing.Size(396, 50);
            this.pdtbSearch.TabIndex = 16;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.LightSalmon;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(5, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(386, 30);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSearch_KeyPress);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(765, 79);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(102, 50);
            this.btSearch.TabIndex = 15;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // fplContainer
            // 
            this.fplContainer.Controls.Add(this.plColumn);
            this.fplContainer.Controls.Add(this.fplSearchList);
            this.fplContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.fplContainer.Location = new System.Drawing.Point(0, 191);
            this.fplContainer.MaximumSize = new System.Drawing.Size(919, 445);
            this.fplContainer.Name = "fplContainer";
            this.fplContainer.Size = new System.Drawing.Size(919, 445);
            this.fplContainer.TabIndex = 14;
            // 
            // plColumn
            // 
            this.plColumn.Controls.Add(this.lblspacing);
            this.plColumn.Controls.Add(this.btAmount);
            this.plColumn.Controls.Add(this.btOrderDate);
            this.plColumn.Controls.Add(this.btCustID);
            this.plColumn.Controls.Add(this.btOrderID);
            this.plColumn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plColumn.Location = new System.Drawing.Point(0, 0);
            this.plColumn.Margin = new System.Windows.Forms.Padding(0);
            this.plColumn.MaximumSize = new System.Drawing.Size(915, 80);
            this.plColumn.Name = "plColumn";
            this.plColumn.Size = new System.Drawing.Size(915, 37);
            this.plColumn.TabIndex = 15;
            // 
            // lblspacing
            // 
            this.lblspacing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblspacing.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblspacing.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspacing.Location = new System.Drawing.Point(300, 0);
            this.lblspacing.Margin = new System.Windows.Forms.Padding(0);
            this.lblspacing.Name = "lblspacing";
            this.lblspacing.Size = new System.Drawing.Size(212, 37);
            this.lblspacing.TabIndex = 4;
            this.lblspacing.Text = "Operation";
            this.lblspacing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAmount
            // 
            this.btAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAmount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAmount.Location = new System.Drawing.Point(225, 0);
            this.btAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btAmount.Name = "btAmount";
            this.btAmount.Size = new System.Drawing.Size(75, 37);
            this.btAmount.TabIndex = 3;
            this.btAmount.Text = "Total Amount";
            this.btAmount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAmount.UseVisualStyleBackColor = true;
            this.btAmount.Click += new System.EventHandler(this.btAmount_Click);
            // 
            // btOrderDate
            // 
            this.btOrderDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOrderDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderDate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderDate.Location = new System.Drawing.Point(150, 0);
            this.btOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btOrderDate.Name = "btOrderDate";
            this.btOrderDate.Size = new System.Drawing.Size(75, 37);
            this.btOrderDate.TabIndex = 2;
            this.btOrderDate.Text = "Order Date";
            this.btOrderDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOrderDate.UseVisualStyleBackColor = true;
            this.btOrderDate.Click += new System.EventHandler(this.btOrderDate_Click);
            // 
            // btCustID
            // 
            this.btCustID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCustID.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCustID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCustID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustID.Location = new System.Drawing.Point(75, 0);
            this.btCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btCustID.Name = "btCustID";
            this.btCustID.Size = new System.Drawing.Size(75, 37);
            this.btCustID.TabIndex = 1;
            this.btCustID.Text = "Customer ID";
            this.btCustID.UseVisualStyleBackColor = true;
            this.btCustID.Click += new System.EventHandler(this.btCustID_Click);
            // 
            // btOrderID
            // 
            this.btOrderID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderID.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderID.Location = new System.Drawing.Point(0, 0);
            this.btOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btOrderID.Name = "btOrderID";
            this.btOrderID.Size = new System.Drawing.Size(75, 37);
            this.btOrderID.TabIndex = 0;
            this.btOrderID.Text = "Order ID";
            this.btOrderID.UseVisualStyleBackColor = true;
            this.btOrderID.Click += new System.EventHandler(this.btOrderID_Click);
            // 
            // fplSearchList
            // 
            this.fplSearchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fplSearchList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fplSearchList.Location = new System.Drawing.Point(0, 37);
            this.fplSearchList.Margin = new System.Windows.Forms.Padding(0);
            this.fplSearchList.MaximumSize = new System.Drawing.Size(915, 400);
            this.fplSearchList.Name = "fplSearchList";
            this.fplSearchList.Size = new System.Drawing.Size(915, 400);
            this.fplSearchList.TabIndex = 16;
            // 
            // AdminOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fplContainer);
            this.Controls.Add(this.plHeading);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.MaximumSize = new System.Drawing.Size(919, 639);
            this.Name = "AdminOrder";
            this.Size = new System.Drawing.Size(919, 639);
            this.Load += new System.EventHandler(this.AdminReceipt_Load);
            this.plHeading.ResumeLayout(false);
            this.pdtbSearch.ResumeLayout(false);
            this.pdtbSearch.PerformLayout();
            this.fplContainer.ResumeLayout(false);
            this.plColumn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plHeading;
        private System.Windows.Forms.Label separate1;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Panel pdtbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lblSearchRemind;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.FlowLayoutPanel fplContainer;
        private System.Windows.Forms.FlowLayoutPanel fplSearchList;
        private System.Windows.Forms.Panel plColumn;
        private System.Windows.Forms.Label lblspacing;
        private System.Windows.Forms.Button btAmount;
        private System.Windows.Forms.Button btOrderDate;
        private System.Windows.Forms.Button btCustID;
        private System.Windows.Forms.Button btOrderID;
    }
}
