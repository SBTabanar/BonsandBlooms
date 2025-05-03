namespace BonsandBlooms
{
    partial class frmProduct
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
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPROCODE = new System.Windows.Forms.TextBox();
            this.TXTDESC = new System.Windows.Forms.RichTextBox();
            this.TXTPRICE = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TXTPRONAME = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCateg
            // 
            this.cboCateg.FormattingEnabled = true;
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
            this.cboCateg.Location = new System.Drawing.Point(140, 261);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(339, 21);
            this.cboCateg.TabIndex = 53;
            this.cboCateg.SelectedIndexChanged += new System.EventHandler(this.cboCateg_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(44, 128);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 15);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "Code:";
            // 
            // txtPROCODE
            // 
            this.txtPROCODE.Enabled = false;
            this.txtPROCODE.Location = new System.Drawing.Point(140, 127);
            this.txtPROCODE.Name = "txtPROCODE";
            this.txtPROCODE.Size = new System.Drawing.Size(339, 20);
            this.txtPROCODE.TabIndex = 51;
            // 
            // TXTDESC
            // 
            this.TXTDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDESC.Location = new System.Drawing.Point(140, 194);
            this.TXTDESC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.Size = new System.Drawing.Size(339, 60);
            this.TXTDESC.TabIndex = 44;
            this.TXTDESC.Text = "";
            this.TXTDESC.TextChanged += new System.EventHandler(this.TXTDESC_TextChanged);
            // 
            // TXTPRICE
            // 
            this.TXTPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRICE.Location = new System.Drawing.Point(140, 297);
            this.TXTPRICE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTPRICE.Name = "TXTPRICE";
            this.TXTPRICE.Size = new System.Drawing.Size(99, 30);
            this.TXTPRICE.TabIndex = 45;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(44, 164);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 15);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "Name :";
            // 
            // TXTPRONAME
            // 
            this.TXTPRONAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRONAME.Location = new System.Drawing.Point(140, 161);
            this.TXTPRONAME.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTPRONAME.Name = "TXTPRONAME";
            this.TXTPRONAME.Size = new System.Drawing.Size(339, 23);
            this.TXTPRONAME.TabIndex = 43;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(44, 262);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(75, 15);
            this.Label7.TabIndex = 49;
            this.Label7.Text = "Category : ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(247, 297);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(33, 16);
            this.Label4.TabIndex = 50;
            this.Label4.Text = "php";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(44, 297);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 15);
            this.Label6.TabIndex = 48;
            this.Label6.Text = "Price :";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.LightCoral;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(350, 359);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(97, 32);
            this.Button2.TabIndex = 42;
            this.Button2.Text = "Close";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Control;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(245, 359);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(97, 32);
            this.Button1.TabIndex = 41;
            this.Button1.Text = "New";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.BackColor = System.Drawing.Color.LightGreen;
            this.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAVE.Location = new System.Drawing.Point(140, 359);
            this.BTNSAVE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(97, 32);
            this.BTNSAVE.TabIndex = 40;
            this.BTNSAVE.Text = "Save";
            this.BTNSAVE.UseVisualStyleBackColor = false;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 42);
            this.label5.TabIndex = 71;
            this.label5.Text = "Add New Product";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BonsandBlooms.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(44, 197);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 15);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Description :";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(544, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCateg);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtPROCODE);
            this.Controls.Add(this.TXTDESC);
            this.Controls.Add(this.TXTPRICE);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TXTPRONAME);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.BTNSAVE);
            this.MaximumSize = new System.Drawing.Size(560, 484);
            this.MinimumSize = new System.Drawing.Size(560, 484);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboCateg;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPROCODE;
        internal System.Windows.Forms.RichTextBox TXTDESC;
        internal System.Windows.Forms.TextBox TXTPRICE;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TXTPRONAME;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button BTNSAVE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label3;
    }
}