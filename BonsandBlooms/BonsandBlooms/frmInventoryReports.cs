﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonsandBlooms
{
    public partial class frmInventoryReports : Form
    {
        public frmInventoryReports()
        {
            InitializeComponent();
        }
        DatabaseConnect config = new DatabaseConnect();
        usableFunction func = new usableFunction();
        string query;
        int maxrow;

        private void RDOSELECT(RadioButton RDO)
        {
            if (RDO.Checked)
            {
                switch (RDO.Text)
                {
                    case "All":
                        query = "SELECT P.PROCODE AS [ProductCode], (PRONAME + ' ' + PRODESC) AS [Product],CATEGORY AS [Category], PROPRICE AS [Price],PROQTY AS [Quantity] " +
                                " FROM tblProductInfo AS P WHERE CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                        break;
                    case "Stock-In":
                        query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME + ' ' + PRODESC) AS [Product], PROPRICE AS [Price],RECEIVEDQTY AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " +
                                " FROM tblStockIn AS S, tblProductInfo AS P WHERE S.PROCODE=P.PROCODE AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                        break;
                    case "Sold":
                        query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME + ' ' + PRODESC) AS [Product], PROPRICE AS [Price],OUTQTY AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " +
                                " FROM tblStockOut AS S, tblProductInfo AS P WHERE S.PROCODE=P.PROCODE AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                        break;
                    case "Today":
                        if (RDO.Text == "Stock-In")
                        {
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME + ' ' + PRODESC) AS [Product], PROPRICE AS [Price],RECEIVEDQTY AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " +
                                    " FROM tblStockIn AS S, tblProductInfo AS P " +
                                    " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) = DATEVALUE(NOW()) AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                        }
                        else if (RDO.Text == "Sold")
                        {
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS Price,OUTQTY AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " +
                                    " FROM tblStockOut AS S, tblProductInfo AS P WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATEOUT) = DATEVALUE(NOW()) AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                        }
                        break;
                    case "Monthly":
                        if (RDO.Text == "Stock-In")
                        {
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS [Price],RECEIVEDQTY AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " +
                                    " FROM tblStockIn AS S, tblProductInfo AS P " +
                                    " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                        }
                        else if (RDO.Text == "Sold")
                        {
                            query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS Price,OUTQTY AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " +
                                    " FROM tblStockOut AS S, tblProductInfo AS P WHERE S.PROCODE=P.PROCODE AND MONTH(DATEOUT) = MONTH(NOW()) AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                        }
                        break;
                }
                config.Load_DTG(query, dtglist);
            }
        }

        private void RDOCLEAR(string ACTIONS, RadioButton rdo)
        {
            if (rdo.Checked)
            {
                switch (ACTIONS)
                {
                    case "Product":
                        rdoProduct.Checked = false;
                        break;
                    case "Transaction":
                        rdoStockIn.Checked = false;
                        rdoStockOut.Checked = false;
                        rdoMonthly.Checked = false;
                        rdoToday.Checked = false;
                        break;
                }

                if (rdo.Text != "Today" && rdo.Text != "Monthly")
                {
                    LBLLIST.Text = "List of " + rdo.Text + " (" + cboCateg.Text + ")";
                }
            }
        }

        private void RDOCLEARDATE()
        {
            rdoMonthly.Checked = false;
            rdoToday.Checked = false;
        }

        private void frmInventoryReports_Load(object sender, EventArgs e)
        {
            RDOCLEAR("Transaction", rdoProduct);
            LBLLIST.Text = "List of Products (" + cboCateg.Text + ")";
            RDOSELECT(rdoProduct);
        }

        private void rdoProduct_CheckedChanged(object sender, EventArgs e)
        {
            RDOCLEAR("Transaction", rdoProduct);
            LBLLIST.Text = "List of Products (" + cboCateg.Text + ")";
            RDOSELECT(rdoProduct);
        }

        private void rdoStockIn_CheckedChanged(object sender, EventArgs e)
        {
            RDOCLEAR("Product", rdoStockIn);
            RDOCLEARDATE();
            RDOSELECT(rdoStockIn);
        }

        private void rdoStockOut_CheckedChanged(object sender, EventArgs e)
        {
            RDOCLEAR("Product", rdoStockOut);
            RDOCLEARDATE();
            RDOSELECT(rdoStockOut);
        }

        private void rdoToday_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStockIn.Checked)
            {
                RDOCLEAR("Product", rdoStockIn);
                query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS [Price],RECEIVEDQTY AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " +
                        " FROM tblStockIn AS S, tblProductInfo AS P " +
                        " WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATERECEIVED) = DATEVALUE(NOW()) AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
            else if (rdoStockOut.Checked)
            {
                RDOCLEAR("Product", rdoStockOut);
                query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS [Price],OUTQTY AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " +
                        " FROM tblStockOut AS S, tblProductInfo AS P WHERE S.PROCODE=P.PROCODE AND DATEVALUE(DATEOUT) = DATEVALUE(NOW()) AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
        }

        private void rdoMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStockIn.Checked)
            {
                RDOCLEAR("Product", rdoStockIn);
                query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATERECEIVED) AS [ReceivedDate], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS [Price],RECEIVEDQTY AS [Quantity],(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " +
                        " FROM tblStockIn AS S, tblProductInfo AS P " +
                        " WHERE S.PROCODE=P.PROCODE AND MONTH(DATERECEIVED) = MONTH(NOW()) AND PRODESC LIKE '%" + txtSearch.Text + "%' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
            else if (rdoStockOut.Checked)
            {
                RDOCLEAR("Product", rdoStockOut);
                query = "SELECT P.PROCODE AS [ProductCode],DATEVALUE(DATEOUT) AS [TransactionDate], (PRONAME + ' ' + PRODESC) AS [Product],PROPRICE AS [Price],OUTQTY AS [Quantity],(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " +
                        " FROM tblStockOut AS S, tblProductInfo AS P " +
                        " WHERE S.PROCODE=P.PROCODE AND MONTH(DATEOUT) = MONTH(NOW()) AND CATEGORY ='" + cboCateg.Text + "' AND PRONAME LIKE '%" + txtSearch.Text + "%'";
                config.Load_DTG(query, dtglist);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dfrom = dtpFrom.Value.ToString("MM/dd/yyyy");
            string dto = dtpTo.Value.ToString("MM/dd/yyyy");

            if (rdoStockIn.Checked)
            {
                LBLLIST.Text = "Stock of " + cboCateg.Text + " from " + dfrom + " to " + dto;
                query = "SELECT P.PROCODE AS [ProductCode], DATEVALUE(DATERECEIVED) AS [ReceivedDate], " +
                        "(PRONAME + ' ' + PRODESC) AS [Product], PROPRICE AS [Price], RECEIVEDQTY AS [Quantity], " +
                        "(ROUND(RECEIVEDQTY * PROPRICE)) AS [TotalPrice] " +
                        "FROM tblStockIn AS S, tblProductInfo AS P " +
                        "WHERE S.PROCODE=P.PROCODE " +
                        "AND DATEVALUE(DATERECEIVED) BETWEEN #" + dfrom + "# AND #" + dto + "# " +
                        "AND (PRODESC LIKE '%" + txtSearch.Text + "%' OR PRONAME LIKE '%" + txtSearch.Text + "%')";
                config.Load_DTG(query, dtglist);
            }
            else if (rdoStockOut.Checked)
            {
                LBLLIST.Text = "Sold " + cboCateg.Text + " from " + dfrom + " to " + dto;
                query = "SELECT P.PROCODE AS [ProductCode], DATEVALUE(DATEOUT) AS [TransactionDate], " +
                        "(PRONAME + ' ' + PRODESC) AS [Product], PROPRICE AS [Price], OUTQTY AS [Quantity], " +
                        "(ROUND(OUTQTY * PROPRICE)) AS [TotalPrice] " +
                        "FROM tblStockOut AS S, tblProductInfo AS P " +
                        "WHERE S.PROCODE=P.PROCODE " +
                        "AND DATEVALUE(DATEOUT) BETWEEN #" + dfrom + "# AND #" + dto + "# " +
                        "AND CATEGORY ='" + cboCateg.Text + "' " +
                        "AND (PRODESC LIKE '%" + txtSearch.Text + "%' OR PRONAME LIKE '%" + txtSearch.Text + "%')";
                config.Load_DTG(query, dtglist);
            }
        }

        private void BTNSEARCHGRID_Click(object sender, EventArgs e)
        {
            RDOCLEAR("Transaction", rdoProduct);
            LBLLIST.Text = "List of Products (" + cboCateg.Text + ")";
            RDOSELECT(rdoProduct);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
