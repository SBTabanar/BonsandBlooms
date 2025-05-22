namespace BonsandBlooms
{
    partial class BonsandBlooms
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFlower = new System.Windows.Forms.ToolStripButton();
            this.tsListofProducts = new System.Windows.Forms.ToolStripButton();
            this.tsStockin = new System.Windows.Forms.ToolStripButton();
            this.tsStockout = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsReport = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(135, 135);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFlower,
            this.tsListofProducts,
            this.tsStockin,
            this.tsStockout,
            this.tsUser,
            this.tsReport,
            this.tsLogin});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 354);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(996, 157);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsFlower
            // 
            this.tsFlower.Image = global::BonsandBlooms.Properties.Resources.product;
            this.tsFlower.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFlower.Name = "tsFlower";
            this.tsFlower.Size = new System.Drawing.Size(139, 154);
            this.tsFlower.Text = "Products";
            this.tsFlower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsFlower.Click += new System.EventHandler(this.tsProduct_Click);
            // 
            // tsListofProducts
            // 
            this.tsListofProducts.Image = global::BonsandBlooms.Properties.Resources.list;
            this.tsListofProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsListofProducts.Name = "tsListofProducts";
            this.tsListofProducts.Size = new System.Drawing.Size(139, 154);
            this.tsListofProducts.Text = "List of Products";
            this.tsListofProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsListofProducts.Click += new System.EventHandler(this.tsListofProducts_Click);
            // 
            // tsStockin
            // 
            this.tsStockin.Image = global::BonsandBlooms.Properties.Resources.stockin;
            this.tsStockin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockin.Name = "tsStockin";
            this.tsStockin.Size = new System.Drawing.Size(139, 154);
            this.tsStockin.Text = "Stockin";
            this.tsStockin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockin.Click += new System.EventHandler(this.tsStockin_Click);
            // 
            // tsStockout
            // 
            this.tsStockout.Image = global::BonsandBlooms.Properties.Resources.stockout2;
            this.tsStockout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockout.Name = "tsStockout";
            this.tsStockout.Size = new System.Drawing.Size(139, 154);
            this.tsStockout.Text = "Stockout";
            this.tsStockout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockout.Click += new System.EventHandler(this.tsStockout_Click);
            // 
            // tsUser
            // 
            this.tsUser.Image = global::BonsandBlooms.Properties.Resources.users;
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(139, 154);
            this.tsUser.Text = "Manage Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsReport
            // 
            this.tsReport.Image = global::BonsandBlooms.Properties.Resources.inventory;
            this.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(139, 154);
            this.tsReport.Text = "Inventory Reports";
            this.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.Image = global::BonsandBlooms.Properties.Resources.login1;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(139, 154);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alba Super", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(698, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "a Flower Shop Inventory System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::BonsandBlooms.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BonsandBlooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(996, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(1012, 550);
            this.MinimumSize = new System.Drawing.Size(1012, 550);
            this.Name = "BonsandBlooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BonsandBlooms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFlower;
        private System.Windows.Forms.ToolStripButton tsStockin;
        private System.Windows.Forms.ToolStripButton tsStockout;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsReport;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripButton tsListofProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

