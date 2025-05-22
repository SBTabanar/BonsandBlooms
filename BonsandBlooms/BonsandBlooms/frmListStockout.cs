using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonsandBlooms
{
    public partial class frmListStockout : Form
    {
        public string SelectedProductCode { get; private set; }
        public string SelectedProductName { get; private set; }
        public string SelectedCategory { get; private set; }
        public string SelectedDesc { get; private set; }
        public string SelectedPrice { get; private set; }
        public string SelectedQty { get; private set; }

        public frmListStockout()
        {
            InitializeComponent();
            DTGLIST.CellDoubleClick += DTGLIST_CellDoubleClick;

        }
        DatabaseConnect config = new DatabaseConnect();
        usableFunction func = new usableFunction();
        string query;
        int maxrow;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            query = " SELECT TRANSNUM AS [Transaction#],P.PROCODE as [ProductCode], PRONAME AS [Product], CATEGORY AS [Category],DATEOUT AS  [TransactionDate],OUTQTY AS [Quantity],OUTTOTPRICE AS [Price] " +
               " FROM tblStockOut as O, tblProductInfo AS P  " +
               " WHERE P.PROCODE=O.PROCODE  AND (PRONAME + ' ' + PRODESC + ' ' + CATEGORY) LIKE '%" + TXTSEARCH.Text + "%'";
            config.Load_DTG(query, DTGLIST);
        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private void DTGLIST_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DTGLIST.Rows[e.RowIndex];
                SelectedProductCode = row.Cells["ProductCode"].Value.ToString();
                SelectedProductName = row.Cells["Product"].Value.ToString();
                SelectedCategory = row.Cells["Category"].Value.ToString();
                SelectedDesc = row.Cells["Product"].Value.ToString(); 
                SelectedPrice = row.Cells["Price"].Value.ToString();
                SelectedQty = row.Cells["Quantity"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DTGLIST.CurrentRow == null)
            {
                MessageBox.Show("Please select a transaction to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected transaction? This action cannot be undone.",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string transNum = DTGLIST.CurrentRow.Cells["Transaction#"].Value.ToString();

                    // Update product quantity
                    query = "UPDATE tblProductInfo AS P, tblStockOut AS S SET PROQTY = PROQTY + OUTQTY WHERE P.PROCODE=S.PROCODE AND TRANSNUM = " + transNum;
                    config.Execute_Query(query);

                    // Delete the transaction
                    query = "DELETE * FROM tblStockOut WHERE TRANSNUM = " + transNum;
                    config.Execute_Query(query);

                    MessageBox.Show("Transaction has been deleted.");
                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void frmListStockout_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private void DTGLIST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
