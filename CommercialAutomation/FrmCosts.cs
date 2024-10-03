using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmCosts : Form
    {
        Connection connect = new Connection();

        public FrmCosts()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtId.Clear();
            txtElectric.Clear();
            txtWater.Clear();
            textGas.Clear();
            txtEthernet.Clear();
            txtSalary.Clear();
            txtExtra.Clear();
            rhcDescription.Clear();
            cmbMonth.Text = "";
            mskYear.Clear();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Costs", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        private void FrmCosts_Load(object sender, EventArgs e)
        {
            list();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Costs(Electric, Water, Gas, Ethernet, Salaries, Extra, Desciription, Mounth, Year) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", decimal.Parse(txtElectric.Text));
                sqlCommand.Parameters.AddWithValue("@p2", decimal.Parse(txtWater.Text));
                sqlCommand.Parameters.AddWithValue("@p3", decimal.Parse(textGas.Text));
                sqlCommand.Parameters.AddWithValue("@p4", decimal.Parse(txtEthernet.Text));
                sqlCommand.Parameters.AddWithValue("@p5", decimal.Parse(txtSalary.Text));
                sqlCommand.Parameters.AddWithValue("@p6", decimal.Parse(txtExtra.Text));
                sqlCommand.Parameters.AddWithValue("@p7", rhcDescription.Text);
                sqlCommand.Parameters.AddWithValue("@p8", cmbMonth.SelectedText);
                sqlCommand.Parameters.AddWithValue("@p9", mskYear.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Cost Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                clear();
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
                SqlCommand sqlCommand = new SqlCommand("update Tbl_Costs set Electric=@p1, Water=@p2, Gas=@p3, Ethernet=@p4, Salaries=@p5, Extra=@p6, Desciription=@p7, Mounth=@p8, Year=@p9 where Id=@p10", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", decimal.Parse(txtElectric.Text));
                sqlCommand.Parameters.AddWithValue("@p2", decimal.Parse(txtWater.Text));
                sqlCommand.Parameters.AddWithValue("@p3", decimal.Parse(textGas.Text));
                sqlCommand.Parameters.AddWithValue("@p4", decimal.Parse(txtEthernet.Text));
                sqlCommand.Parameters.AddWithValue("@p5", decimal.Parse(txtSalary.Text));
                sqlCommand.Parameters.AddWithValue("@p6", decimal.Parse(txtExtra.Text));
                sqlCommand.Parameters.AddWithValue("@p7", rhcDescription.Text);
                sqlCommand.Parameters.AddWithValue("@p8", cmbMonth.SelectedText);
                sqlCommand.Parameters.AddWithValue("@p9", mskYear.Text);
                sqlCommand.Parameters.AddWithValue("@p10", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Cost Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cmbMonth.Clear();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                txtElectric.Text = dr["Electric"].ToString();
                txtWater.Text = dr["Water"].ToString();
                textGas.Text = dr["Gas"].ToString();
                txtEthernet.Text = dr["Ethernet"].ToString();
                txtSalary.Text = dr["Salaries"].ToString();
                txtExtra.Text = dr["Extra"].ToString();
                rhcDescription.Text = dr["Desciription"].ToString();
                cmbMonth.SelectedText = dr["Mounth"].ToString();
                mskYear.Text = dr["Year"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
