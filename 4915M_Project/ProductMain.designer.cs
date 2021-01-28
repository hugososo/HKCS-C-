namespace _4915M_Project
{
    partial class Productmain
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
            this.separate1 = new System.Windows.Forms.Label();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.pdtbSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.plResult = new System.Windows.Forms.Panel();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblSearchSentence = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.plProductList = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btNext = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.plHeading.SuspendLayout();
            this.pdtbSearch.SuspendLayout();
            this.plResult.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // plHeading
            // 
            this.plHeading.BackColor = System.Drawing.Color.Transparent;
            this.plHeading.Controls.Add(this.separate1);
            this.plHeading.Controls.Add(this.lblHeaderText);
            this.plHeading.Controls.Add(this.pdtbSearch);
            this.plHeading.Controls.Add(this.btSearch);
            this.plHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.plHeading.Location = new System.Drawing.Point(0, 0);
            this.plHeading.Name = "plHeading";
            this.plHeading.Size = new System.Drawing.Size(885, 127);
            this.plHeading.TabIndex = 12;
            // 
            // separate1
            // 
            this.separate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separate1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separate1.Location = new System.Drawing.Point(0, 124);
            this.separate1.Name = "separate1";
            this.separate1.Size = new System.Drawing.Size(885, 3);
            this.separate1.TabIndex = 18;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.Orange;
            this.lblHeaderText.Location = new System.Drawing.Point(330, 8);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(245, 43);
            this.lblHeaderText.TabIndex = 17;
            this.lblHeaderText.Text = "Product Page";
            this.lblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pdtbSearch
            // 
            this.pdtbSearch.BackColor = System.Drawing.Color.Black;
            this.pdtbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdtbSearch.Controls.Add(this.tbSearch);
            this.pdtbSearch.Location = new System.Drawing.Point(243, 66);
            this.pdtbSearch.Name = "pdtbSearch";
            this.pdtbSearch.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.pdtbSearch.Size = new System.Drawing.Size(377, 54);
            this.pdtbSearch.TabIndex = 16;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Black;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(5, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(365, 30);
            this.tbSearch.TabIndex = 3;
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(650, 73);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(102, 43);
            this.btSearch.TabIndex = 15;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // plResult
            // 
            this.plResult.BackColor = System.Drawing.Color.Transparent;
            this.plResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plResult.Controls.Add(this.lblKeyword);
            this.plResult.Controls.Add(this.lblSearchSentence);
            this.plResult.Controls.Add(this.lblRows);
            this.plResult.Location = new System.Drawing.Point(198, 133);
            this.plResult.Name = "plResult";
            this.plResult.Size = new System.Drawing.Size(456, 38);
            this.plResult.TabIndex = 13;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(263, 6);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(135, 26);
            this.lblKeyword.TabIndex = 2;
            this.lblKeyword.Text = "\"search items\"";
            // 
            // lblSearchSentence
            // 
            this.lblSearchSentence.AutoSize = true;
            this.lblSearchSentence.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSentence.Location = new System.Drawing.Point(108, 5);
            this.lblSearchSentence.Name = "lblSearchSentence";
            this.lblSearchSentence.Size = new System.Drawing.Size(97, 26);
            this.lblSearchSentence.TabIndex = 1;
            this.lblSearchSentence.Text = "results for";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(14, 5);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(23, 26);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "0";
            // 
            // plProductList
            // 
            this.plProductList.Location = new System.Drawing.Point(70, 238);
            this.plProductList.MaximumSize = new System.Drawing.Size(800, 600);
            this.plProductList.Name = "plProductList";
            this.plProductList.Size = new System.Drawing.Size(743, 600);
            this.plProductList.TabIndex = 16;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btNext);
            this.panel18.Controls.Add(this.button9);
            this.panel18.Location = new System.Drawing.Point(256, 177);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(319, 50);
            this.panel18.TabIndex = 17;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.White;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(222, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(85, 41);
            this.btNext.TabIndex = 6;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(14, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 41);
            this.button9.TabIndex = 5;
            this.button9.Text = "Previous";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Productmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.plProductList);
            this.Controls.Add(this.plResult);
            this.Controls.Add(this.plHeading);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.MaximumSize = new System.Drawing.Size(919, 639);
            this.Name = "Productmain";
            this.Size = new System.Drawing.Size(885, 639);
            this.Load += new System.EventHandler(this.Productmain_Load);
            this.plHeading.ResumeLayout(false);
            this.pdtbSearch.ResumeLayout(false);
            this.pdtbSearch.PerformLayout();
            this.plResult.ResumeLayout(false);
            this.plResult.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plHeading;
        private System.Windows.Forms.Label separate1;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Panel pdtbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Panel plResult;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblSearchSentence;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Panel plProductList;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button button9;
    }
}
