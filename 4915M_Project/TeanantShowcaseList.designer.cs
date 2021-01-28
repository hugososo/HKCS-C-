namespace _4915M_Project
{
    partial class TenantShowcaseList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewForTenant = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.Button();
            this.ReNew = new System.Windows.Forms.Button();
            this.RentedShowcase = new System.Windows.Forms.Button();
            this.unRentShowcase = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForTenant
            // 
            this.dataGridViewForTenant.AllowUserToAddRows = false;
            this.dataGridViewForTenant.AllowUserToDeleteRows = false;
            this.dataGridViewForTenant.AllowUserToResizeColumns = false;
            this.dataGridViewForTenant.AllowUserToResizeRows = false;
            this.dataGridViewForTenant.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewForTenant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewForTenant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForTenant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewForTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForTenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForTenant.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewForTenant.EnableHeadersVisualStyles = false;
            this.dataGridViewForTenant.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewForTenant.Name = "dataGridViewForTenant";
            this.dataGridViewForTenant.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForTenant.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewForTenant.RowTemplate.Height = 24;
            this.dataGridViewForTenant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForTenant.Size = new System.Drawing.Size(919, 576);
            this.dataGridViewForTenant.TabIndex = 0;
            this.dataGridViewForTenant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForTenant_CellClick);
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
            // ReNew
            // 
            this.ReNew.BackColor = System.Drawing.Color.OldLace;
            this.ReNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReNew.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReNew.Location = new System.Drawing.Point(644, 22);
            this.ReNew.Name = "ReNew";
            this.ReNew.Size = new System.Drawing.Size(112, 23);
            this.ReNew.TabIndex = 3;
            this.ReNew.Text = "Renew Showcase";
            this.ReNew.UseVisualStyleBackColor = false;
            // 
            // RentedShowcase
            // 
            this.RentedShowcase.BackColor = System.Drawing.Color.OldLace;
            this.RentedShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentedShowcase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentedShowcase.Location = new System.Drawing.Point(486, 22);
            this.RentedShowcase.Name = "RentedShowcase";
            this.RentedShowcase.Size = new System.Drawing.Size(141, 23);
            this.RentedShowcase.TabIndex = 6;
            this.RentedShowcase.Text = "Unavailable Showcase";
            this.RentedShowcase.UseVisualStyleBackColor = false;
            this.RentedShowcase.Click += new System.EventHandler(this.RentedShowcase_Click);
            // 
            // unRentShowcase
            // 
            this.unRentShowcase.BackColor = System.Drawing.Color.OldLace;
            this.unRentShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unRentShowcase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unRentShowcase.Location = new System.Drawing.Point(327, 22);
            this.unRentShowcase.Name = "unRentShowcase";
            this.unRentShowcase.Size = new System.Drawing.Size(141, 23);
            this.unRentShowcase.TabIndex = 7;
            this.unRentShowcase.Text = "Available Showcase";
            this.unRentShowcase.UseVisualStyleBackColor = false;
            this.unRentShowcase.Click += new System.EventHandler(this.unRentShowcase_Click);
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.Color.OldLace;
            this.showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll.Location = new System.Drawing.Point(207, 22);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(109, 23);
            this.showAll.TabIndex = 8;
            this.showAll.Text = "All showcase";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // TenantShowcaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.unRentShowcase);
            this.Controls.Add(this.RentedShowcase);
            this.Controls.Add(this.ReNew);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewForTenant);
            this.MaximumSize = new System.Drawing.Size(919, 639);
            this.Name = "TenantShowcaseList";
            this.Size = new System.Drawing.Size(919, 639);
            this.Load += new System.EventHandler(this.showcaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForTenant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForTenant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.Button ReNew;
        private System.Windows.Forms.Button RentedShowcase;
        private System.Windows.Forms.Button unRentShowcase;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
