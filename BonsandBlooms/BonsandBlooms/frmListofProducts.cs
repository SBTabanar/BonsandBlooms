using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BonsandBlooms
{
    public partial class frmListofProducts : Form
    {
        public string SelectedProductCode { get; private set; }
        public string SelectedProductName { get; private set; }

        DatabaseConnect config = new DatabaseConnect();
        usableFunction func = new usableFunction();
        string sql;
        int maxrow;

        public frmListofProducts()
        {
            InitializeComponent();
            DTGLIST.CellDoubleClick += DTGLIST_CellDoubleClick;
        }

        private void frmListofProducts_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }
        public void refresh()
        {
            sql = "SELECT PROCODE as [ProductCode], PRONAME AS [ProductName], PRODESC AS [Description], CATEGORY AS [Category], PROPRICE AS [Price], PROQTY AS [Quantity] FROM tblProductInfo";
            config.Load_DTG(sql, DTGLIST);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql = "SELECT PROCODE as [ProductCode], PRONAME AS [ProductName], PRODESC AS [Description], CATEGORY AS [Category], PROPRICE AS [Price], PROQTY AS [Quantity] FROM tblProductInfo";
            config.Load_DTG(sql, DTGLIST);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct();
            frm.ShowDialog();
            btnRefresh_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DTGLIST.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form frm = new frmEditProduct(DTGLIST.CurrentRow.Cells["ProductCode"].Value.ToString(), this);
            frm.ShowDialog();
            btnRefresh_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DTGLIST.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected product? This action cannot be undone.",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string productCode = DTGLIST.CurrentRow.Cells["ProductCode"].Value.ToString();

                    sql = "DELETE FROM tblStockIn WHERE PROCODE = '" + productCode + "'";
                    config.Execute_Query(sql);

                    sql = "DELETE FROM tblStockOut WHERE PROCODE = '" + productCode + "'";
                    config.Execute_Query(sql);

                    sql = "DELETE FROM tblProductInfo WHERE PROCODE = '" + productCode + "'";
                    config.Execute_CUD(sql, "Failed to delete product.", "Product has been deleted.");

                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DTGLIST_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DTGLIST.Rows[e.RowIndex];
                SelectedProductCode = row.Cells["ProductCode"].Value.ToString();
                SelectedProductName = row.Cells["ProductName"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT PROCODE as [ProductCode], PRONAME AS [ProductName], PRODESC AS [Description], CATEGORY AS [Category], PROPRICE AS [Price], PROQTY AS [Quantity] " +
                  "FROM tblProductInfo WHERE (PROCODE + ' ' + PRONAME + ' ' + PRODESC + ' ' + CATEGORY) LIKE '%" + TXTSEARCH.Text + "%'";
            config.Load_DTG(sql, DTGLIST);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void DTGLIST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
