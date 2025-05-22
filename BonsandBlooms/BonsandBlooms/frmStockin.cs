using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BonsandBlooms
{
    public partial class frmStockin : Form
    {
        DatabaseConnect config = new DatabaseConnect();
        usableFunction func = new usableFunction();
        string sql;
        int maxrow;

        public frmStockin()
        {
            InitializeComponent();

            TXTPRODUCT.TextChanged += TXTPRODUCT_TextChanged;
            txtPROCODE.TextChanged += txtPROCODE_TextChanged;
        }

        private void frmStockin_Load(object sender, EventArgs e)
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

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            try
            {
                func.clearTxt(GroupBox1);
                func.clearTxt(GroupBox3);
                CBOUNIT.Text = "";
                LBLMSG.Text = "";
                LBLUNIT.Text = "";
                LBLMSG.BackColor = Color.Transparent;

                config.autonumber_transaction(1, LBLTRANSNUM);

                config.autocomplete("SELECT PROCODE FROM tblProductInfo", txtPROCODE);

                config.autocomplete("SELECT PRONAME FROM tblProductInfo", TXTPRODUCT);

                TXTPRODUCT.Enabled = true;
                TXTPRODUCT.ReadOnly = false;
            }
            catch (Exception ex)
            {
                ShowError("Error initializing form: " + ex.Message);
            }
        }

        private void BTNCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTDESC.Text) ||
                    string.IsNullOrWhiteSpace(TXTQTY.Text) ||
                    string.IsNullOrWhiteSpace(txtPROCODE.Text) ||
                    string.IsNullOrWhiteSpace(TXTPRICE.Text))
                {
                    ShowWarning("Please fill in all required fields.");
                    return;
                }

                if (!int.TryParse(TXTQTY.Text, out int qty) || qty <= 0)
                {
                    ShowWarning("Quantity must be a positive whole number.");
                    TXTQTY.Focus();
                    return;
                }

                if (!double.TryParse(TXTPRICE.Text, out double price) || price < 0)
                {
                    ShowWarning("Price must be a valid non-negative number.");
                    return;
                }

                if (!double.TryParse(TXTTOT.Text, out double total) || total < 0)
                {
                    ShowWarning("Total price is invalid.");
                    return;
                }

                if (!int.TryParse(LBLTRANSNUM.Text, out int transnum))
                {
                    ShowWarning("Invalid transaction number.");
                    return;
                }

                sql = "INSERT INTO tblStockIn (TRANSNUM, PROCODE, DATERECEIVED, RECEIVEDQTY, RECEIVEDTOTPRICE) " +
                      "VALUES (?, ?, ?, ?, ?)";
                var parametersInsert = new[]
                {
                    new System.Data.OleDb.OleDbParameter("TRANSNUM", transnum),
                    new System.Data.OleDb.OleDbParameter("PROCODE", txtPROCODE.Text),
                    new System.Data.OleDb.OleDbParameter("DATERECEIVED", DTPTRANSDATE.Value.Date),
                    new System.Data.OleDb.OleDbParameter("RECEIVEDQTY", qty),
                    new System.Data.OleDb.OleDbParameter("RECEIVEDTOTPRICE", total)
                };
                config.Execute_CUD(sql, "Error adding stock-in record.", "Stock-in record added successfully.", parametersInsert);

                sql = "UPDATE tblProductInfo SET PROQTY = PROQTY + ? WHERE PROCODE = ?";
                var parametersUpdate = new[]
                {
                    new System.Data.OleDb.OleDbParameter("PROQTY", qty),
                    new System.Data.OleDb.OleDbParameter("PROCODE", txtPROCODE.Text)
                };
                config.Execute_CUD(sql, "Error updating product quantity.", "Product quantity updated successfully.", parametersUpdate);

                LBLMSG.Text = $"The {TXTPRODUCT.Text} has been added into the inventory.";
                LBLMSG.BackColor = Color.Aquamarine;
                LBLMSG.ForeColor = Color.Black;

                config.update_Autonumber(1);

                BTNNEW_Click(sender, e);
            }
            catch (Exception ex)
            {
                ShowError("Error adding stock-in: " + ex.Message);
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

                sql = "SELECT * FROM tblProductInfo WHERE PROCODE = ?";
                var dt = config.Execute_Query(sql, new System.Data.OleDb.OleDbParameter("PROCODE", txtPROCODE.Text));
                maxrow = dt.Rows.Count;
                if (maxrow > 0)
                {
                    var r = dt.Rows[0];
                    if (TXTPRODUCT.Text != r.Field<string>("PRONAME"))
                        TXTPRODUCT.Text = r.Field<string>("PRONAME");
                    TXTDESC.Text = r.Field<string>("PRODESC") + " [" + r.Field<string>("CATEGORY") + "]";
                    TXTPRICE.Text = r.Field<decimal>("PROPRICE").ToString("F2");

                    int currentQty = r.Field<int>("PROQTY");
                    LBLCURRENTQTY.Text = "Current Quantity: " + currentQty.ToString();
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

        private void TXTPRODUCT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTPRODUCT.Text))
                {
                    txtPROCODE.Clear();
                    ClearProductDetails();
                    return;
                }

                sql = "SELECT * FROM tblProductInfo WHERE PRONAME = ?";
                var dt = config.Execute_Query(sql, new System.Data.OleDb.OleDbParameter("PRONAME", TXTPRODUCT.Text));
                maxrow = dt.Rows.Count;
                if (maxrow > 0)
                {
                    var r = dt.Rows[0];
                    if (txtPROCODE.Text != r.Field<string>("PROCODE"))
                        txtPROCODE.Text = r.Field<string>("PROCODE");
                    TXTDESC.Text = r.Field<string>("PRODESC") + " [" + r.Field<string>("CATEGORY") + "]";
                    TXTPRICE.Text = r.Field<decimal>("PROPRICE").ToString("F2");
                    int currentQty = r.Field<int>("PROQTY");
                    LBLCURRENTQTY.Text = "Current Quantity: " + currentQty.ToString();
                }
                else
                {
                    txtPROCODE.Clear();
                    TXTDESC.Clear();
                    TXTPRICE.Clear();
                    LBLCURRENTQTY.Text = "Current Quantity: 0";
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
                if (string.IsNullOrWhiteSpace(TXTQTY.Text) || string.IsNullOrWhiteSpace(TXTPRICE.Text))
                {
                    TXTTOT.Text = "0";
                    return;
                }

                if (double.TryParse(TXTPRICE.Text, out double price) &&
                    int.TryParse(TXTQTY.Text, out int qty))
                {
                    double total = price * qty;
                    TXTTOT.Text = total.ToString("F2");
                }
                else
                {
                    TXTTOT.Text = "0";
                }
            }
            catch (Exception ex)
            {
                ShowError("Error calculating total price: " + ex.Message);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                using (var listForm = new frmListStockin())
                {
                    if (listForm.ShowDialog() == DialogResult.OK)
                    {
                        txtPROCODE.Text = listForm.SelectedProductCode;
                        TXTPRODUCT.Text = listForm.SelectedProductName;
                        TXTDESC.Text = listForm.SelectedDesc +
                            (string.IsNullOrEmpty(listForm.SelectedCategory) ? "" : " [" + listForm.SelectedCategory + "]");
                        TXTPRICE.Text = listForm.SelectedPrice;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Error opening stock-in list: " + ex.Message);
            }
        }



        private void ClearProductDetails()
        {
            TXTPRODUCT.Clear();
            TXTDESC.Clear();
            TXTPRICE.Clear();
            TXTQTY.Clear();
            TXTTOT.Clear();
            LBLCURRENTQTY.Text = "Current Quantity: 0";
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

        private void btnProductList_Click(object sender, EventArgs e)
        {
            using (var listForm = new frmListofProducts())
            {
                if (listForm.ShowDialog() == DialogResult.OK)
                {
                    txtPROCODE.Text = listForm.SelectedProductCode;
                    TXTPRODUCT.Text = listForm.SelectedProductName;
                }
            }
        }

    }
}
