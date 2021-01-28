namespace _4915M_Project
{
    partial class CustomerShowcaseList
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewForCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.Button();
            this.RentedShowcase = new System.Windows.Forms.Button();
            this.unRentShowcase = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForCustomer
            // 
            this.dataGridViewForCustomer.AllowUserToAddRows = false;
            this.dataGridViewForCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewForCustomer.AllowUserToResizeColumns = false;
            this.dataGridViewForCustomer.AllowUserToResizeRows = false;
            this.dataGridViewForCustomer.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewForCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewForCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewForCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewForCustomer.EnableHeadersVisualStyles = false;
            this.dataGridViewForCustomer.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewForCustomer.Name = "dataGridViewForCustomer";
            this.dataGridViewForCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewForCustomer.RowHeadersWidth = 35;
            this.dataGridViewForCustomer.RowTemplate.Height = 24;
            this.dataGridViewForCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForCustomer.Size = new System.Drawing.Size(919, 527);
            this.dataGridViewForCustomer.TabIndex = 0;
            this.dataGridViewForCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForCustomer_CellClick);
            this.dataGridViewForCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForCustomer_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "showcaseID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "branchID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "monthlyRent";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Showcase List";
            // 
            // Rent
            // 
            this.Rent.BackColor = System.Drawing.Color.OldLace;
            this.Rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rent.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.Location = new System.Drawing.Point(780, 22);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(109, 23);
            this.Rent.TabIndex = 2;
            this.Rent.Text = "Rent Showcase";
            this.Rent.UseVisualStyleBackColor = false;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // RentedShowcase
            // 
            this.RentedShowcase.BackColor = System.Drawing.Color.OldLace;
            this.RentedShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentedShowcase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentedShowcase.Location = new System.Drawing.Point(635, 22);
            this.RentedShowcase.Name = "RentedShowcase";
            this.RentedShowcase.Size = new System.Drawing.Size(128, 23);
            this.RentedShowcase.TabIndex = 3;
            this.RentedShowcase.Text = "Unavailable Showcase";
            this.RentedShowcase.UseVisualStyleBackColor = false;
            this.RentedShowcase.Click += new System.EventHandler(this.RentedShowcase_Click);
            // 
            // unRentShowcase
            // 
            this.unRentShowcase.BackColor = System.Drawing.Color.OldLace;
            this.unRentShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unRentShowcase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unRentShowcase.Location = new System.Drawing.Point(496, 22);
            this.unRentShowcase.Name = "unRentShowcase";
            this.unRentShowcase.Size = new System.Drawing.Size(123, 23);
            this.unRentShowcase.TabIndex = 4;
            this.unRentShowcase.Text = "Available Showcase";
            this.unRentShowcase.UseVisualStyleBackColor = false;
            this.unRentShowcase.Click += new System.EventHandler(this.unRentShowcase_Click);
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.Color.OldLace;
            this.showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll.Location = new System.Drawing.Point(372, 22);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(109, 23);
            this.showAll.TabIndex = 9;
            this.showAll.Text = "All showcase";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // CustomerShowcaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.unRentShowcase);
            this.Controls.Add(this.RentedShowcase);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewForCustomer);
            this.MaximumSize = new System.Drawing.Size(919, 590);
            this.Name = "CustomerShowcaseList";
            this.Size = new System.Drawing.Size(919, 590);
            this.Load += new System.EventHandler(this.showcaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.Button RentedShowcase;
        private System.Windows.Forms.Button unRentShowcase;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
