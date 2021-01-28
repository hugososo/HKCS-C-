namespace _4915M_Project
{
    partial class StaffShowcaseList
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
            this.dataGridViewForStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.editShowcaseRent_bt = new System.Windows.Forms.Button();
            this.RentedShowcase = new System.Windows.Forms.Button();
            this.unRentShowcase = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setRent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForStaff
            // 
            this.dataGridViewForStaff.AllowUserToAddRows = false;
            this.dataGridViewForStaff.AllowUserToDeleteRows = false;
            this.dataGridViewForStaff.AllowUserToResizeColumns = false;
            this.dataGridViewForStaff.AllowUserToResizeRows = false;
            this.dataGridViewForStaff.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewForStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewForStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewForStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForStaff.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewForStaff.EnableHeadersVisualStyles = false;
            this.dataGridViewForStaff.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewForStaff.Name = "dataGridViewForStaff";
            this.dataGridViewForStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewForStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewForStaff.RowTemplate.Height = 24;
            this.dataGridViewForStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewForStaff.Size = new System.Drawing.Size(919, 576);
            this.dataGridViewForStaff.TabIndex = 0;
            this.dataGridViewForStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewForStaff_CellClick);
            this.dataGridViewForStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewForStaff_CellContentClick);
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
            this.Column2.HeaderText = "tenantID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "branchID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "monthlyRent";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // editShowcaseRent_bt
            // 
            this.editShowcaseRent_bt.BackColor = System.Drawing.Color.OldLace;
            this.editShowcaseRent_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editShowcaseRent_bt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editShowcaseRent_bt.Location = new System.Drawing.Point(637, 22);
            this.editShowcaseRent_bt.Name = "editShowcaseRent_bt";
            this.editShowcaseRent_bt.Size = new System.Drawing.Size(141, 23);
            this.editShowcaseRent_bt.TabIndex = 4;
            this.editShowcaseRent_bt.Text = "Edit Showcase Rent";
            this.editShowcaseRent_bt.UseVisualStyleBackColor = false;
            this.editShowcaseRent_bt.Click += new System.EventHandler(this.editShowcaseRent_bt_Click);
            // 
            // RentedShowcase
            // 
            this.RentedShowcase.BackColor = System.Drawing.Color.OldLace;
            this.RentedShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentedShowcase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentedShowcase.Location = new System.Drawing.Point(490, 22);
            this.RentedShowcase.Name = "RentedShowcase";
            this.RentedShowcase.Size = new System.Drawing.Size(141, 23);
            this.RentedShowcase.TabIndex = 5;
            this.RentedShowcase.Text = "Unavailable Showcase";
            this.RentedShowcase.UseVisualStyleBackColor = false;
            this.RentedShowcase.Click += new System.EventHandler(this.RentedShowcase_Click);
            // 
            // unRentShowcase
            // 
            this.unRentShowcase.BackColor = System.Drawing.Color.OldLace;
            this.unRentShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unRentShowcase.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unRentShowcase.Location = new System.Drawing.Point(343, 22);
            this.unRentShowcase.Name = "unRentShowcase";
            this.unRentShowcase.Size = new System.Drawing.Size(141, 23);
            this.unRentShowcase.TabIndex = 6;
            this.unRentShowcase.Text = "Available Showcase";
            this.unRentShowcase.UseVisualStyleBackColor = false;
            this.unRentShowcase.Click += new System.EventHandler(this.unRentShowcase_Click);
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.Color.OldLace;
            this.showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll.Location = new System.Drawing.Point(228, 22);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(109, 23);
            this.showAll.TabIndex = 9;
            this.showAll.Text = "All showcase";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(788, 24);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // setRent
            // 
            this.setRent.AutoSize = true;
            this.setRent.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setRent.Location = new System.Drawing.Point(784, 7);
            this.setRent.Name = "setRent";
            this.setRent.Size = new System.Drawing.Size(106, 14);
            this.setRent.TabIndex = 11;
            this.setRent.Text = "Input rent amount";
            // 
            // StaffShowcaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.setRent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.unRentShowcase);
            this.Controls.Add(this.RentedShowcase);
            this.Controls.Add(this.editShowcaseRent_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewForStaff);
            this.MaximumSize = new System.Drawing.Size(919, 639);
            this.Name = "StaffShowcaseList";
            this.Size = new System.Drawing.Size(919, 639);
            this.Load += new System.EventHandler(this.showcaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editShowcaseRent_bt;
        private System.Windows.Forms.Button RentedShowcase;
        private System.Windows.Forms.Button unRentShowcase;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label setRent;
    }
}
