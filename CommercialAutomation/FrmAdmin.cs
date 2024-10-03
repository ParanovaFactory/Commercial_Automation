using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmAdmin : Form
    {
        Connection connect = new Connection();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Admins where Username=@p1 and Password=@p2", connect.connection());
            cmd.Parameters.AddWithValue("@p1", txtUserName.Text);
            cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                FrmMain frmHome = new FrmMain();
                frmHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check the username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUserName.Clear();
            }
        }
    }
}
