using DevExpress.XtraRichEdit.UI;
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
    public partial class FrmSettings : Form
    {
        Connection connect = new Connection();

        public FrmSettings()
        {
            InitializeComponent();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Admins", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into Tbl_Admins(Username, Password) values (@p1,@p2)", connect.connection());
                command.Parameters.AddWithValue("@p1", txtUsername.Text);
                command.Parameters.AddWithValue("@p2", txtPassword.Text);
                command.ExecuteNonQuery();
                connect.connection().Close();
                list();
                MessageBox.Show("Admin Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update Tbl_Admins set Username=@p1, Password=@p2 where Id = @p3", connect.connection());
                command.Parameters.AddWithValue("@p1", txtUsername.Text);
                command.Parameters.AddWithValue("@p2", txtPassword.Text);
                command.Parameters.AddWithValue("@p3", txtID.Text);
                command.ExecuteNonQuery();
                connect.connection().Close();
                list();
                MessageBox.Show("Admin Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["Id"].ToString();
                txtUsername.Text = dr["Username"].ToString();
                txtPassword.Text = dr["Password"].ToString();
            }
        }
    }
}
