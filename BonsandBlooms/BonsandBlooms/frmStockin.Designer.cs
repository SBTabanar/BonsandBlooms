namespace BonsandBlooms
{
    partial class frmStockin
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
            this.btnList = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TXTTOT = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TXTQTY = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TXTPRICE = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPROCODE = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.TXTPRODUCT = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.LBLCURRENTQTY = new System.Windows.Forms.Label();
            this.LBLUNIT = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.BTNNEW = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.DTPTRANSDATE = new System.Windows.Forms.DateTimePicker();
            this.Label14 = new System.Windows.Forms.Label();
            this.BTNCLOSE = new System.Windows.Forms.Button();
            this.LBLTRANSNUM = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TXTDESC = new System.Windows.Forms.RichTextBox();
            this.CBOUNIT = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLMSG = new System.Windows.Forms.Label();
            this.btnProductList = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(216, 551);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(85, 44);
            this.btnList.TabIndex = 42;
            this.btnList.Text = "History";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(298, 44);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(35, 17);
            this.Label12.TabIndex = 17;
            this.Label12.Text = "php";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(299, 126);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(35, 17);
            this.Label11.TabIndex = 17;
            this.Label11.Text = "php";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 126);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 17);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Total Price:";
            // 
            // TXTTOT
            // 
            this.TXTTOT.Enabled = false;
            this.TXTTOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTOT.Location = new System.Drawing.Point(136, 118);
            this.TXTTOT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTTOT.Name = "TXTTOT";
            this.TXTTOT.Size = new System.Drawing.Size(154, 29);
            this.TXTTOT.TabIndex = 10;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(37, 85);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 17);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Quantity:";
            // 
            // TXTQTY
            // 
            this.TXTQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTQTY.Location = new System.Drawing.Point(136, 78);
            this.TXTQTY.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTQTY.Name = "TXTQTY";
            this.TXTQTY.Size = new System.Drawing.Size(154, 29);
            this.TXTQTY.TabIndex = 8;
            this.TXTQTY.TextChanged += new System.EventHandler(this.TXTQTY_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(59, 44);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 17);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Price :";
            // 
            // TXTPRICE
            // 
            this.TXTPRICE.Enabled = false;
            this.TXTPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRICE.Location = new System.Drawing.Point(136, 37);
            this.TXTPRICE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTPRICE.Name = "TXTPRICE";
            this.TXTPRICE.Size = new System.Drawing.Size(154, 29);
            this.TXTPRICE.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 47);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(111, 17);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Product Code:";
            // 
            // txtPROCODE
            // 
            this.txtPROCODE.Location = new System.Drawing.Point(169, 39);
            this.txtPROCODE.Margin = new System.Windows.Forms.Padding(4);
            this.txtPROCODE.Name = "txtPROCODE";
            this.txtPROCODE.Size = new System.Drawing.Size(377, 26);
            this.txtPROCODE.TabIndex = 0;
            this.txtPROCODE.TextChanged += new System.EventHandler(this.txtPROCODE_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(35, 126);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(95, 17);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Description:";
            // 
            // TXTPRODUCT
            // 
            this.TXTPRODUCT.Enabled = false;
            this.TXTPRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRODUCT.Location = new System.Drawing.Point(169, 78);
            this.TXTPRODUCT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTPRODUCT.Name = "TXTPRODUCT";
            this.TXTPRODUCT.Size = new System.Drawing.Size(480, 23);
            this.TXTPRODUCT.TabIndex = 3;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.LBLCURRENTQTY);
            this.GroupBox3.Controls.Add(this.LBLUNIT);
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.TXTTOT);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.TXTQTY);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.TXTPRICE);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(38, 235);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox3.Size = new System.Drawing.Size(539, 172);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Summary";
            // 
            // LBLCURRENTQTY
            // 
            this.LBLCURRENTQTY.AutoSize = true;
            this.LBLCURRENTQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCURRENTQTY.Location = new System.Drawing.Point(361, 154);
            this.LBLCURRENTQTY.Name = "LBLCURRENTQTY";
            this.LBLCURRENTQTY.Size = new System.Drawing.Size(95, 16);
            this.LBLCURRENTQTY.TabIndex = 18;
            this.LBLCURRENTQTY.Text = "Current Qty : ";
            // 
            // LBLUNIT
            // 
            this.LBLUNIT.AutoSize = true;
            this.LBLUNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUNIT.Location = new System.Drawing.Point(298, 85);
            this.LBLUNIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLUNIT.Name = "LBLUNIT";
            this.LBLUNIT.Size = new System.Drawing.Size(42, 17);
            this.LBLUNIT.TabIndex = 13;
            this.LBLUNIT.Text = "Unit:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(18, 87);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(113, 17);
            this.Label15.TabIndex = 37;
            this.Label15.Text = "Transaction #:";
            // 
            // BTNNEW
            // 
            this.BTNNEW.BackColor = System.Drawing.SystemColors.Control;
            this.BTNNEW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNNEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNEW.Location = new System.Drawing.Point(307, 551);
            this.BTNNEW.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(85, 44);
            this.BTNNEW.TabIndex = 33;
            this.BTNNEW.Text = "New";
            this.BTNNEW.UseVisualStyleBackColor = false;
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.BackColor = System.Drawing.Color.LightGreen;
            this.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNADD.Location = new System.Drawing.Point(21, 551);
            this.BTNADD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(85, 44);
            this.BTNADD.TabIndex = 34;
            this.BTNADD.Text = "Save";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // DTPTRANSDATE
            // 
            this.DTPTRANSDATE.CustomFormat = "MM/dd/yyyy";
            this.DTPTRANSDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPTRANSDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPTRANSDATE.Location = new System.Drawing.Point(749, 87);
            this.DTPTRANSDATE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DTPTRANSDATE.Name = "DTPTRANSDATE";
            this.DTPTRANSDATE.Size = new System.Drawing.Size(180, 23);
            this.DTPTRANSDATE.TabIndex = 40;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(603, 92);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(138, 17);
            this.Label14.TabIndex = 39;
            this.Label14.Text = "Transaction Date:";
            // 
            // BTNCLOSE
            // 
            this.BTNCLOSE.BackColor = System.Drawing.Color.LightCoral;
            this.BTNCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNCLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCLOSE.Location = new System.Drawing.Point(400, 551);
            this.BTNCLOSE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BTNCLOSE.Name = "BTNCLOSE";
            this.BTNCLOSE.Size = new System.Drawing.Size(85, 44);
            this.BTNCLOSE.TabIndex = 35;
            this.BTNCLOSE.Text = "Close";
            this.BTNCLOSE.UseVisualStyleBackColor = false;
            this.BTNCLOSE.Click += new System.EventHandler(this.BTNCLOSE_Click);
            // 
            // LBLTRANSNUM
            // 
            this.LBLTRANSNUM.AutoSize = true;
            this.LBLTRANSNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTRANSNUM.Location = new System.Drawing.Point(158, 87);
            this.LBLTRANSNUM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTRANSNUM.Name = "LBLTRANSNUM";
            this.LBLTRANSNUM.Size = new System.Drawing.Size(52, 17);
            this.LBLTRANSNUM.TabIndex = 38;
            this.LBLTRANSNUM.Text = "NONE";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtPROCODE);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.TXTPRODUCT);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.TXTDESC);
            this.GroupBox1.Controls.Add(this.CBOUNIT);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(21, 111);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox1.Size = new System.Drawing.Size(909, 411);
            this.GroupBox1.TabIndex = 32;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Details";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(58, 84);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 17);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Product:";
            // 
            // TXTDESC
            // 
            this.TXTDESC.Enabled = false;
            this.TXTDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDESC.Location = new System.Drawing.Point(169, 122);
            this.TXTDESC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.Size = new System.Drawing.Size(480, 82);
            this.TXTDESC.TabIndex = 9;
            this.TXTDESC.Text = "";
            // 
            // CBOUNIT
            // 
            this.CBOUNIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOUNIT.FormattingEnabled = true;
            this.CBOUNIT.Location = new System.Drawing.Point(562, 126);
            this.CBOUNIT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CBOUNIT.Name = "CBOUNIT";
            this.CBOUNIT.Size = new System.Drawing.Size(17, 28);
            this.CBOUNIT.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BonsandBlooms.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(383, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // LBLMSG
            // 
            this.LBLMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMSG.Location = new System.Drawing.Point(14, 64);
            this.LBLMSG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLMSG.Name = "LBLMSG";
            this.LBLMSG.Size = new System.Drawing.Size(915, 23);
            this.LBLMSG.TabIndex = 36;
            this.LBLMSG.Text = "Label11";
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductList.Location = new System.Drawing.Point(493, 551);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(85, 44);
            this.btnProductList.TabIndex = 74;
            this.btnProductList.Text = "Product List";
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // frmStockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(945, 663);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.BTNNEW);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.DTPTRANSDATE);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.BTNCLOSE);
            this.Controls.Add(this.LBLTRANSNUM);
            this.Controls.Add(this.LBLMSG);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(961, 702);
            this.MinimumSize = new System.Drawing.Size(961, 702);
            this.Name = "frmStockin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock-in";
            this.Load += new System.EventHandler(this.frmStockin_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnList;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TXTTOT;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TXTQTY;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TXTPRICE;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPROCODE;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox TXTPRODUCT;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button BTNNEW;
        internal System.Windows.Forms.Button BTNADD;
        internal System.Windows.Forms.DateTimePicker DTPTRANSDATE;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button BTNCLOSE;
        internal System.Windows.Forms.Label LBLTRANSNUM;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.RichTextBox TXTDESC;
        internal System.Windows.Forms.ComboBox CBOUNIT;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label LBLUNIT;
        internal System.Windows.Forms.Label LBLMSG;
        private System.Windows.Forms.Label LBLCURRENTQTY;
        internal System.Windows.Forms.Button btnProductList;
    }
}