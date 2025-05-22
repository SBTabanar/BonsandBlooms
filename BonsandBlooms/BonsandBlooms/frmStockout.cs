using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BonsandBlooms
{
    public partial class frmStockout : Form
    {
        DatabaseConnect config = new DatabaseConnect();
        usableFunction func = new usableFunction();
        string query;
        int maxrow;

        public frmStockout()
        {
            InitializeComponent();
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            try
            {
                func.clearTxt(GroupBox1);
                func.clearTxt(GroupBox2);
                LBLMSG.Text = "";
                LBLMSG.BackColor = Color.Transparent;

                query = "SELECT PROCODE FROM tblProductInfo";
                config.autocomplete(query, txtPROCODE);

                config.autonumber_transaction(1, LBLTRANSNUM);
            }
            catch (Exception ex)
            {
                ShowError("Error initializing form: " + ex.Message);
            }
        }

        private void frmStockout_Load(object sender, EventArgs e)
        {
            try
            {
                BTNNEW_Click(sender, e);
            }
            catch (Exception ex)
            {
                ShowError("Error loading form: " + ex.Message);
            }
        }

        private void txtPROCODE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPROCODE.Text))
                {
                    ClearProductDetails();
                    return;
                }

                query = "SELECT * FROM tblProductInfo WHERE PROCODE = ?";
                var dt = config.Execute_Query(query, new System.Data.OleDb.OleDbParameter("PROCODE", txtPROCODE.Text));
                maxrow = dt.Rows.Count;

                if (maxrow > 0)
                {
                    var r = dt.Rows[0];
                    TXTPRODUCT.Text = r.Field<string>("PRONAME");
                    TXTDESC.Text = r.Field<string>("PRODESC") + " [" + r.Field<string>("CATEGORY") + "]";
                    TXTPRICE.Text = r.Field<decimal>("PROPRICE").ToString("F2");
                    TXTAVAILQTY.Text = r.Field<int>("PROQTY").ToString();
                }
                else
                {
                    ClearProductDetails();
                }
            }
            catch (Exception ex)
            {
                ShowError("Error loading product details: " + ex.Message);
            }
        }

        private void TXTQTY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(TXTAVAILQTY.Text, out double availableQty))
                    availableQty = 0;

                if (!double.TryParse(TXTQTY.Text, out double enteredQty) || string.IsNullOrWhiteSpace(TXTQTY.Text))
                {
                    TXTREMAINQTY.Text = availableQty.ToString();
                    TXTTOT.Text = "0";
                    return;
                }

                if (enteredQty > availableQty)
                {
                    enteredQty = availableQty;
                    TXTQTY.Text = availableQty.ToString();
                    TXTQTY.SelectionStart = TXTQTY.Text.Length;
                }

                double remainQty = availableQty - enteredQty;

                if (!double.TryParse(TXTPRICE.Text, out double price))
                    price = 0;

                double totalAmount = price * enteredQty;
                TXTTOT.Text = totalAmount.ToString("F2");
                TXTREMAINQTY.Text = remainQty.ToString();
            }
            catch (Exception ex)
            {
                ShowError("Error calculating quantity or total: " + ex.Message);
            }
        }

        private void BTNCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(TXTDESC.Text) ||
                    string.IsNullOrWhiteSpace(TXTQTY.Text) ||
                    string.IsNullOrWhiteSpace(txtPROCODE.Text) ||
                    string.IsNullOrWhiteSpace(TXTPRICE.Text))
                {
                    ShowWarning("Please fill in all required fields.");
                    return;
                }

                // Validate quantities
                if (!double.TryParse(TXTAVAILQTY.Text, out double availableQty))
                {
                    ShowWarning("Invalid available quantity.");
                    return;
                }

                if (!double.TryParse(TXTQTY.Text, out double qty) || qty <= 0)
                {
                    ShowWarning("Quantity must be a positive number.");
                    TXTQTY.Focus();
                    return;
                }

                if (qty > availableQty)
                {
                    ShowWarning("Entered quantity exceeds available quantity.");
                    TXTQTY.Focus();
                    return;
                }

                // Validate price
                if (!double.TryParse(TXTPRICE.Text, out double price) || price < 0)
                {
                    ShowWarning("Invalid price.");
                    return;
                }

                // Validate total price
                if (!double.TryParse(TXTTOT.Text, out double total) || total < 0)
                {
                    ShowWarning("Invalid total price.");
                    return;
                }

                // Insert stock out record with parameters to prevent SQL injection
                query = "INSERT INTO tblStockOut (TRANSNUM, PROCODE, DATEOUT, OUTQTY, OUTUNIT, OUTTOTPRICE) " +
                        "VALUES (?, ?, ?, ?, ?, ?)";
                var parametersInsert = new[]
                {
                    new System.Data.OleDb.OleDbParameter("TRANSNUM", LBLTRANSNUM.Text),
                    new System.Data.OleDb.OleDbParameter("PROCODE", txtPROCODE.Text),
                    new System.Data.OleDb.OleDbParameter("DATEOUT", DTPTRANSDATE.Value.Date),
                    new System.Data.OleDb.OleDbParameter("OUTQTY", qty),
                    new System.Data.OleDb.OleDbParameter("OUTUNIT", LBLUNIT.Text),
                    new System.Data.OleDb.OleDbParameter("OUTTOTPRICE", total)
                };
                config.Execute_CUD(query, "Error saving stock out record.", "Stock out record saved successfully.", parametersInsert);

                // Update product quantity safely
                query = "UPDATE tblProductInfo SET PROQTY = PROQTY - ? WHERE PROCODE = ?";
                var parametersUpdate = new[]
                {
                    new System.Data.OleDb.OleDbParameter("PROQTY", qty),
                    new System.Data.OleDb.OleDbParameter("PROCODE", txtPROCODE.Text)
                };
                config.Execute_CUD(query, "Error updating product quantity.", "Product quantity updated successfully.", parametersUpdate);

                double newQty = availableQty - qty;

                LBLMSG.Text = $"The {TXTPRODUCT.Text} has been deducted from the inventory.";
                LBLMSG.BackColor = Color.Aquamarine;
                LBLMSG.ForeColor = Color.Black;

                config.update_Autonumber(1);

                if (newQty < 10)
                {
                    MessageBox.Show(
                        $"Warning: The stock quantity for product '{TXTPRODUCT.Text}' has dropped below 10.\nPlease restock soon.",
                        "Low Stock Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                BTNNEW_Click(sender, e);
            }
            catch (Exception ex)
            {
                ShowError("Error saving stock out: " + ex.Message);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new frmListStockout();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowError("Error opening stock out list: " + ex.Message);
            }
        }

        private void ClearProductDetails()
        {
            TXTPRODUCT.Clear();
            TXTDESC.Clear();
            TXTPRICE.Clear();
            TXTQTY.Clear();
            TXTTOT.Clear();
            TXTAVAILQTY.Clear();
            TXTREMAINQTY.Clear();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
