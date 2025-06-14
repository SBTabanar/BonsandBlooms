﻿using System;
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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        DatabaseConnect config = new DatabaseConnect();
        usableFunction func = new usableFunction();
        string query;
        int maxrow;

        private void btnnew_Click(object sender, EventArgs e)
        {
            func.clearTxt(Panel2);
            cbotype.Text = "";
            LBLUSERID.Text = "USERID";

            query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username] ,U_TYPE AS [Role] FROM tblUser WHERE ( U_NAME  + ' ' +  U_UNAME  + ' ' +  U_TYPE) LIKE '%" + txtsearch.Text + "%'";
            config.Load_DTG(query, dtglist);
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if( txtname.Text != "" && txtusername.Text != "" && txtpass.Text  != "" && cbotype.Text != "" )
            {
                if (LBLUSERID.Text == "USERID")
                { 
                    query = "INSERT INTO tblUser ( U_NAME,U_UNAME,U_PASS,U_TYPE) VALUES ('" + txtname.Text + "','" + txtusername.Text 
                          + "','" + txtpass.Text + "','" + cbotype.Text + "')";
                    config.Execute_CUD(query, "User not saved.", "New user has been saved.");
                }
                else
                { 
                    query = "UPDATE tblUser SET U_NAME='" + txtname.Text + "',U_UNAME='" + txtusername.Text
                     + "',U_PASS='" + txtpass.Text + "',U_TYPE='" + cbotype.Text + "' WHERE USERID=" + LBLUSERID.Text;
                    config.Execute_CUD(query, "User is not updated.", "User has been updated.");
                }
                btnnew_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Fields are required!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
        }

        private void btndelete_Click(object sender, EventArgs e)
        { 
            query = "DELETE * FROM tblUser WHERE USERID = " + dtglist.CurrentRow.Cells[0].Value;
            config.Execute_CUD(query, "User is not deleted.", "User has been deleted.");

            btnnew_Click(sender, e);
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LBLUSERID.Text = dtglist.CurrentRow.Cells[0].Value.ToString();
            query = "SELECT * FROM tblUser WHERE USERID=" + LBLUSERID.Text;
            maxrow = config.maxrow(query);
            if(maxrow > 0)
            {
                foreach(DataRow r in config.dt.Rows)
                {
                    txtname.Text = r.Field<string>(1);
                    txtusername.Text = r.Field<string>(2);
                    txtpass.Text = r.Field<string>(3);
                    cbotype.Text = r.Field<string>(4);
                }
               
            }
          
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void dtglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtpass.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;  // Hide password
            }
        }

    }
}
