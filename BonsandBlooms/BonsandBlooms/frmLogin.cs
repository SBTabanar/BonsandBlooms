using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BonsandBlooms
{
    public partial class frmLogin : Form
    {
        BonsandBlooms frm;
        DatabaseConnect config = new DatabaseConnect();
        usableFunction func = new usableFunction();
        string query;
        int maxrow;

        public frmLogin(BonsandBlooms frm)
        {
            InitializeComponent();
            this.frm = frm;

            // Set the AcceptButton so Enter key triggers OK button click
            this.AcceptButton = OK;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Optional: any initialization code here
        }

        private void OK_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM tblUser WHERE U_UNAME ='" + UsernameTextBox.Text + "' AND U_PASS = '" + PasswordTextBox.Text + "'";
            maxrow = config.maxrow(query);

            if (maxrow > 0)
            {
                MessageBox.Show("User successfully logged in");
                string userRole = GetUserRole(UsernameTextBox.Text);
                frm.enable_menu(userRole);
                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUserRole(string username)
        {
            string role = string.Empty;
            string query = "SELECT U_TYPE FROM tblUser WHERE U_UNAME = ?";
            DataTable dt = config.Execute_Query(query, new OleDbParameter("@username", username));

            if (dt.Rows.Count > 0)
            {
                role = dt.Rows[0]["U_TYPE"].ToString();
            }

            return role;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Other event handlers can remain empty or be removed if unused
        private void Label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e) { }
        private void Panel1_Paint(object sender, PaintEventArgs e) { }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
