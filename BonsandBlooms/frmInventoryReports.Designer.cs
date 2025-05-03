namespace BonsandBlooms
{
    partial class frmInventoryReports
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.LBLLIST = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.BTNSEARCHGRID = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.rdoToday = new System.Windows.Forms.RadioButton();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.rdoStockIn = new System.Windows.Forms.RadioButton();
            this.rdoStockOut = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(590, 90);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 17);
            this.Label5.TabIndex = 43;
            this.Label5.Text = "Product";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label1.Location = new System.Drawing.Point(225, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(943, 64);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "Inventory Reports";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCateg
            // 
            this.cboCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCateg.Items.AddRange(new object[] {
            "Rose",
            "Carnations",
            "Sunflowers",
            "Tulips",
            "Baby\'s Breath",
            "Colored Rose",
            "Lilies",
            "Daisies",
            "Peonies",
            "Small Bouquet",
            "Medium Bouquet",
            "Large Bouquet"});
            this.cboCateg.Location = new System.Drawing.Point(1, -1);
            this.cboCateg.Margin = new System.Windows.Forms.Padding(4);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(352, 24);
            this.cboCateg.TabIndex = 6;
            this.cboCateg.Text = "Category";
            this.cboCateg.SelectedIndexChanged += new System.EventHandler(this.cboCateg_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1031, 560);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.dtglist);
            this.Panel3.Controls.Add(this.LBLLIST);
            this.Panel3.Location = new System.Drawing.Point(232, 153);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(925, 400);
            this.Panel3.TabIndex = 40;
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglist.Location = new System.Drawing.Point(0, 34);
            this.dtglist.Margin = new System.Windows.Forms.Padding(4);
            this.dtglist.Name = "dtglist";
            this.dtglist.ReadOnly = true;
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(925, 366);
            this.dtglist.TabIndex = 1;
            this.dtglist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellContentClick);
            // 
            // LBLLIST
            // 
            this.LBLLIST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(143)))), ((int)(((byte)(138)))));
            this.LBLLIST.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBLLIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLIST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBLLIST.Location = new System.Drawing.Point(0, 0);
            this.LBLLIST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLLIST.Name = "LBLLIST";
            this.LBLLIST.Size = new System.Drawing.Size(925, 34);
            this.LBLLIST.TabIndex = 2;
            this.LBLLIST.Text = "List";
            this.LBLLIST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(119, 113);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.AutoSize = true;
            this.rdoWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWeekly.Location = new System.Drawing.Point(21, 185);
            this.rdoWeekly.Margin = new System.Windows.Forms.Padding(4);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(67, 17);
            this.rdoWeekly.TabIndex = 2;
            this.rdoWeekly.TabStop = true;
            this.rdoWeekly.Text = "Weekly";
            this.rdoWeekly.UseVisualStyleBackColor = true;
            this.rdoWeekly.CheckedChanged += new System.EventHandler(this.rdoWeekly_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 43);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "From";
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonthly.Location = new System.Drawing.Point(119, 185);
            this.rdoMonthly.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(69, 17);
            this.rdoMonthly.TabIndex = 2;
            this.rdoMonthly.TabStop = true;
            this.rdoMonthly.Text = "Monthly";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            this.rdoMonthly.CheckedChanged += new System.EventHandler(this.rdoMonthly_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(15, 81);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(22, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(57, 43);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(142, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // BTNSEARCHGRID
            // 
            this.BTNSEARCHGRID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNSEARCHGRID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSEARCHGRID.Location = new System.Drawing.Point(897, 114);
            this.BTNSEARCHGRID.Margin = new System.Windows.Forms.Padding(4);
            this.BTNSEARCHGRID.Name = "BTNSEARCHGRID";
            this.BTNSEARCHGRID.Size = new System.Drawing.Size(79, 26);
            this.BTNSEARCHGRID.TabIndex = 41;
            this.BTNSEARCHGRID.Text = "Search";
            this.BTNSEARCHGRID.UseVisualStyleBackColor = false;
            this.BTNSEARCHGRID.Click += new System.EventHandler(this.BTNSEARCHGRID_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(594, 114);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(304, 26);
            this.txtSearch.TabIndex = 39;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(231, 90);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 17);
            this.Label4.TabIndex = 38;
            this.Label4.Text = "Categories";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoToday
            // 
            this.rdoToday.AutoSize = true;
            this.rdoToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoToday.Location = new System.Drawing.Point(21, 156);
            this.rdoToday.Margin = new System.Windows.Forms.Padding(4);
            this.rdoToday.Name = "rdoToday";
            this.rdoToday.Size = new System.Drawing.Size(60, 17);
            this.rdoToday.TabIndex = 2;
            this.rdoToday.TabStop = true;
            this.rdoToday.Text = "Today";
            this.rdoToday.UseVisualStyleBackColor = true;
            this.rdoToday.CheckedChanged += new System.EventHandler(this.rdoToday_CheckedChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(57, 81);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(142, 20);
            this.dtpTo.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.cboCateg);
            this.Panel1.Location = new System.Drawing.Point(232, 114);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(354, 30);
            this.Panel1.TabIndex = 42;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(143)))), ((int)(((byte)(138)))));
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.rdoWeekly);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.rdoMonthly);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.dtpFrom);
            this.GroupBox2.Controls.Add(this.rdoToday);
            this.GroupBox2.Controls.Add(this.dtpTo);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupBox2.Location = new System.Drawing.Point(4, 191);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(215, 228);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Date Filter";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.GroupBox2);
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(225, 606);
            this.Panel2.TabIndex = 44;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(143)))), ((int)(((byte)(138)))));
            this.GroupBox1.Controls.Add(this.rdoProduct);
            this.GroupBox1.Controls.Add(this.rdoStockIn);
            this.GroupBox1.Controls.Add(this.rdoStockOut);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(2, 4);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(216, 180);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Inventory of Products";
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Checked = true;
            this.rdoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoProduct.Location = new System.Drawing.Point(34, 34);
            this.rdoProduct.Margin = new System.Windows.Forms.Padding(4);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(39, 17);
            this.rdoProduct.TabIndex = 14;
            this.rdoProduct.TabStop = true;
            this.rdoProduct.Text = "All";
            this.rdoProduct.UseVisualStyleBackColor = true;
            this.rdoProduct.CheckedChanged += new System.EventHandler(this.rdoProduct_CheckedChanged);
            // 
            // rdoStockIn
            // 
            this.rdoStockIn.AutoSize = true;
            this.rdoStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStockIn.Location = new System.Drawing.Point(34, 69);
            this.rdoStockIn.Margin = new System.Windows.Forms.Padding(4);
            this.rdoStockIn.Name = "rdoStockIn";
            this.rdoStockIn.Size = new System.Drawing.Size(73, 17);
            this.rdoStockIn.TabIndex = 0;
            this.rdoStockIn.TabStop = true;
            this.rdoStockIn.Text = "Stock-In";
            this.rdoStockIn.UseVisualStyleBackColor = true;
            this.rdoStockIn.CheckedChanged += new System.EventHandler(this.rdoStockIn_CheckedChanged);
            // 
            // rdoStockOut
            // 
            this.rdoStockOut.AutoSize = true;
            this.rdoStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStockOut.Location = new System.Drawing.Point(34, 97);
            this.rdoStockOut.Margin = new System.Windows.Forms.Padding(4);
            this.rdoStockOut.Name = "rdoStockOut";
            this.rdoStockOut.Size = new System.Drawing.Size(50, 17);
            this.rdoStockOut.TabIndex = 0;
            this.rdoStockOut.TabStop = true;
            this.rdoStockOut.Text = "Sold";
            this.rdoStockOut.UseVisualStyleBackColor = true;
            this.rdoStockOut.CheckedChanged += new System.EventHandler(this.rdoStockOut_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BonsandBlooms.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(226, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // frmInventoryReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1168, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.BTNSEARCHGRID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1184, 645);
            this.MinimumSize = new System.Drawing.Size(1184, 645);
            this.Name = "frmInventoryReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmInventoryReports_Load);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboCateg;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DataGridView dtglist;
        internal System.Windows.Forms.Label LBLLIST;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.RadioButton rdoWeekly;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.RadioButton rdoMonthly;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpFrom;
        internal System.Windows.Forms.Button BTNSEARCHGRID;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RadioButton rdoToday;
        internal System.Windows.Forms.DateTimePicker dtpTo;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rdoProduct;
        internal System.Windows.Forms.RadioButton rdoStockIn;
        internal System.Windows.Forms.RadioButton rdoStockOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}