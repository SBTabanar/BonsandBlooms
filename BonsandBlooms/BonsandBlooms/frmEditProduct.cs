using System;
using System.Data;
using System.Windows.Forms;

namespace BonsandBlooms
{
    public partial class frmEditProduct : Form
    {
        DatabaseConnect config = new DatabaseConnect();
        usableFunction func = new usableFunction();
        string sql;
        int maxrow;
        frmListofProducts frm;

        public frmEditProduct(string id, frmListofProducts frm)
        {
            InitializeComponent();

            this.frm = frm;

            try
            {
                retrieveProduct(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void retrieveProduct(string id)
        {
            sql = "SELECT PROCODE, PRONAME, PRODESC, CATEGORY, PROPRICE FROM tblProductInfo WHERE PROCODE = '" + id + "'";
            maxrow = config.maxrow(sql);

            if (maxrow > 0)
            {
                foreach (DataRow r in config.dt.Rows)
                {
                    txtPROCODE.Text = r.Field<string>(0);
                    TXTPRONAME.Text = r.Field<string>(1);
                    TXTDESC.Text = r.Field<string>(2);
                    cboCateg.Text = r.Field<string>(3);
                    TXTPRICE.Text = r.Field<decimal>(4).ToString("F2");
                }
            }
            else
            {
                MessageBox.Show("Product not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(TXTPRONAME.Text))
            {
                MessageBox.Show("Product name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPRONAME.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TXTDESC.Text))
            {
                MessageBox.Show("Product description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTDESC.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboCateg.Text) || cboCateg.Text == "Select")
            {
                MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCateg.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TXTPRICE.Text))
            {
                MessageBox.Show("Price is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPRICE.Focus();
                return;
            }

            if (!decimal.TryParse(TXTPRICE.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid non-negative price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTPRICE.Focus();
                return;
            }

            try
            {
               
                sql = "UPDATE tblProductInfo SET PRONAME='" + TXTPRONAME.Text.Replace("'", "''") +
                      "', PRODESC='" + TXTDESC.Text.Replace("'", "''") +
                      "', CATEGORY='" + cboCateg.Text.Replace("'", "''") +
                      "', PROPRICE=" + price +
                      " WHERE PROCODE='" + txtPROCODE.Text.Replace("'", "''") + "'";

                config.Execute_CUD(sql, "Error updating product.", "Product has been updated.");

                frm?.refresh();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frm?.refresh();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {

        }

        private void cboCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
