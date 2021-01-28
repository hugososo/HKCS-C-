namespace _4915M_Project
{
    partial class BillList
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
            this.separate1 = new System.Windows.Forms.Label();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.fplContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.plColumn = new System.Windows.Forms.Panel();
            this.lblspacing = new System.Windows.Forms.Label();
            this.btOrderDate = new System.Windows.Forms.Button();
            this.btOrderID = new System.Windows.Forms.Button();
            this.fplSearchList = new System.Windows.Forms.FlowLayoutPanel();
            this.plHeading.SuspendLayout();
            this.fplContainer.SuspendLayout();
            this.plColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // plHeading
            // 
            this.plHeading.BackColor = System.Drawing.Color.Transparent;
            this.plHeading.Controls.Add(this.lblResult);
            this.plHeading.Controls.Add(this.separate1);
            this.plHeading.Controls.Add(this.lblHeaderText);
            this.plHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.plHeading.Location = new System.Drawing.Point(0, 0);
            this.plHeading.Name = "plHeading";
            this.plHeading.Size = new System.Drawing.Size(919, 98);
            this.plHeading.TabIndex = 15;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Orange;
            this.lblResult.Location = new System.Drawing.Point(124, 54);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(651, 32);
            this.lblResult.TabIndex = 21;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separate1
            // 
            this.separate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separate1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separate1.Location = new System.Drawing.Point(0, 95);
            this.separate1.Name = "separate1";
            this.separate1.Size = new System.Drawing.Size(919, 3);
            this.separate1.TabIndex = 18;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.Orange;
            this.lblHeaderText.Location = new System.Drawing.Point(317, 10);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(242, 33);
            this.lblHeaderText.TabIndex = 17;
            this.lblHeaderText.Text = "Bill List";
            this.lblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fplContainer
            // 
            this.fplContainer.Controls.Add(this.plColumn);
            this.fplContainer.Controls.Add(this.fplSearchList);
            this.fplContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.fplContainer.Location = new System.Drawing.Point(0, 98);
            this.fplContainer.MaximumSize = new System.Drawing.Size(919, 637);
            this.fplContainer.Name = "fplContainer";
            this.fplContainer.Size = new System.Drawing.Size(919, 637);
            this.fplContainer.TabIndex = 16;
            // 
            // plColumn
            // 
            this.plColumn.Controls.Add(this.lblspacing);
            this.plColumn.Controls.Add(this.btOrderDate);
            this.plColumn.Controls.Add(this.btOrderID);
            this.plColumn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plColumn.Location = new System.Drawing.Point(0, 0);
            this.plColumn.Margin = new System.Windows.Forms.Padding(0);
            this.plColumn.MaximumSize = new System.Drawing.Size(915, 93);
            this.plColumn.Name = "plColumn";
            this.plColumn.Size = new System.Drawing.Size(915, 31);
            this.plColumn.TabIndex = 15;
            // 
            // lblspacing
            // 
            this.lblspacing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblspacing.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblspacing.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspacing.Location = new System.Drawing.Point(150, 0);
            this.lblspacing.Margin = new System.Windows.Forms.Padding(0);
            this.lblspacing.Name = "lblspacing";
            this.lblspacing.Size = new System.Drawing.Size(212, 31);
            this.lblspacing.TabIndex = 4;
            this.lblspacing.Text = "Operation";
            this.lblspacing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOrderDate
            // 
            this.btOrderDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOrderDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderDate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrderDate.Location = new System.Drawing.Point(75, 0);
            this.btOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btOrderDate.Name = "btOrderDate";
            this.btOrderDate.Size = new System.Drawing.Size(75, 31);
            this.btOrderDate.TabIndex = 2;
            this.btOrderDate.Text = "Bill Date";
            this.btOrderDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOrderDate.UseVisualStyleBackColor = true;
            this.btOrderDate.Click += new System.EventHandler(this.btOrderDate_Click);
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
            this.btOrderID.Size = new System.Drawing.Size(75, 31);
            this.btOrderID.TabIndex = 0;
            this.btOrderID.Text = "Bill ID";
            this.btOrderID.UseVisualStyleBackColor = true;
            this.btOrderID.Click += new System.EventHandler(this.btOrderID_Click);
            // 
            // fplSearchList
            // 
            this.fplSearchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fplSearchList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fplSearchList.Location = new System.Drawing.Point(0, 31);
            this.fplSearchList.Margin = new System.Windows.Forms.Padding(0);
            this.fplSearchList.MaximumSize = new System.Drawing.Size(915, 630);
            this.fplSearchList.Name = "fplSearchList";
            this.fplSearchList.Size = new System.Drawing.Size(915, 630);
            this.fplSearchList.TabIndex = 16;
            // 
            // BillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fplContainer);
            this.Controls.Add(this.plHeading);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(919, 639);
            this.Name = "BillList";
            this.Size = new System.Drawing.Size(919, 639);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.plHeading.ResumeLayout(false);
            this.fplContainer.ResumeLayout(false);
            this.plColumn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plHeading;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label separate1;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.FlowLayoutPanel fplContainer;
        private System.Windows.Forms.Panel plColumn;
        private System.Windows.Forms.Label lblspacing;
        private System.Windows.Forms.Button btOrderDate;
        private System.Windows.Forms.Button btOrderID;
        private System.Windows.Forms.FlowLayoutPanel fplSearchList;
    }
}
