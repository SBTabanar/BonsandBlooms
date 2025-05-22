using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BonsandBlooms.Properties;

namespace BonsandBlooms
{
    public partial class BonsandBlooms : Form
    {
        public BonsandBlooms()
        {
            InitializeComponent();
        }
        private void shwfrm( Form frm)
        { 
            frm.ShowDialog();
        }

        public void enable_menu()
        {
            tsFlower.Enabled = true;
            tsListofProducts.Enabled = true;
            tsLogin.Text = "Logout";
            tsReport.Enabled = true;
            tsStockin.Enabled = true;
            tsStockout.Enabled = true;
            tsUser.Enabled = true;

        }

        private void disable_menu()
        {
            tsFlower.Enabled = false;
            tsListofProducts.Enabled = false;
            tsLogin.Text = "Login";
            tsReport.Enabled = false;
            tsStockin.Enabled = false;
            tsStockout.Enabled = false;
            tsUser.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            disable_menu();
        }

        private void tsProduct_Click(object sender, EventArgs e)
        {
            shwfrm(new frmProduct());
        }

        private void tsListofProducts_Click(object sender, EventArgs e)
        {
            shwfrm(new frmListofProducts());
        }

        private void tsStockin_Click(object sender, EventArgs e)
        {
            shwfrm(new frmStockin());
        }

        private void tsStockout_Click(object sender, EventArgs e)
        {
            shwfrm(new frmStockout());
        }

        private void tsUser_Click(object sender, EventArgs e)
        {
            shwfrm(new frmUser());
        }

        private void tsReport_Click(object sender, EventArgs e)
        {
            shwfrm(new frmInventoryReports());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if(tsLogin.Text == "Login")
            {
                shwfrm(new frmLogin(this));
            }
            else
            {
                disable_menu();
            }
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
