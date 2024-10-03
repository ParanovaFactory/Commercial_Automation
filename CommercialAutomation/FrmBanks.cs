using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmBanks : Form
    {
        Connection connect = new Connection();

        public FrmBanks()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtBranch.Clear();
            textIBAN.Clear();
            txtAccountNo.Clear();
            txtAccountType.Clear();
            txtAuthorized.Clear();
            mskDate.Clear();
            cmbCompany.Clear();
            cmbCountry.Clear();
            cmbCity.Clear();
            cmbProvince.Clear();
            mskPhone.Clear();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("execute bankList", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        void countyList()
        {
            SqlCommand cmd = new SqlCommand("select Name from Tbl_Countries", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbCountry.Properties.Items.Add(reader[0]);
            }
            connect.connection().Close();
        }

        void listCompany()
        {
            SqlCommand cmd = new SqlCommand("select Name from Tbl_Companies", connect.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCompany.Properties.Items.Add(dr[0].ToString());
            }
            connect.connection().Close();
        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            list();
            listCompany();
            countyList();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Banks(Name, Branch, IBAN, AccountNo, AccountType, Authorized, Date, CompanyId, Country, City, Province, Phone) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7, @p8,@p9,@p10,@p11,@p12)", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtBranch.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textIBAN.Text);
                sqlCommand.Parameters.AddWithValue("@p4", txtAccountNo.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtAccountType.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtAuthorized.Text);
                sqlCommand.Parameters.AddWithValue("@p7", mskDate.Text);
                sqlCommand.Parameters.AddWithValue("@p8", cmbCompany.SelectedIndex + 1);
                sqlCommand.Parameters.AddWithValue("@p9", cmbCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p10", cmbCity.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p11", cmbProvince.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p12", mskPhone.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Bank Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("delete from Tbl_Banks where Id=@p1", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Bank Delete in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("update Tbl_Banks set Name=@p1, Branch=@p2, IBAN=@p3, AccountNo=@p4, AccountType=@p5, Authorized=@p6, Date=@p7, CompanyId=@p8, Country=@p9, City=@p10, Province=@p11, Phone=@p12 where Id=@p13", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtBranch.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textIBAN.Text);
                sqlCommand.Parameters.AddWithValue("@p4", txtAccountNo.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtAccountType.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtAuthorized.Text);
                sqlCommand.Parameters.AddWithValue("@p7", mskDate.Text);
                sqlCommand.Parameters.AddWithValue("@p8", cmbCompany.SelectedIndex + 1);
                sqlCommand.Parameters.AddWithValue("@p9", cmbCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p10", cmbCity.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p11", cmbProvince.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p12", mskPhone.Text);
                sqlCommand.Parameters.AddWithValue("@p13", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Bank Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtBranch.Text = dr["Branch"].ToString();
                textIBAN.Text = dr["IBAN"].ToString();
                txtAccountNo.Text = dr["AccountNo"].ToString();
                txtAccountType.Text = dr["AccountType"].ToString();
                txtAuthorized.Text = dr["Authorized"].ToString();
                mskDate.Text = dr["Date"].ToString();
                mskPhone.Text = dr["Phone"].ToString();
                cmbCompany.Text = dr["Company Name"].ToString();
                cmbCountry.SelectedItem = dr["Country"].ToString();
                cmbCity.SelectedItem = dr["City"].ToString();
                cmbProvince.SelectedItem = dr["Province"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCity.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("select Name from Tbl_Cities where countryId = @p1", connect.connection());
            cmd.Parameters.AddWithValue("@p1", cmbCountry.SelectedIndex + 1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbCity.Properties.Items.Add(reader[0]);
            }
            connect.connection().Close();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProvince.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("select Name from Tbl_Provinces where CityId = (select Id from Tbl_Cities where Name = @p1)", connect.connection());
            cmd.Parameters.AddWithValue("@p1", cmbCity.SelectedItem.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbProvince.Properties.Items.Add(reader[0]);
            }
            connect.connection().Close();
        }
    }
}
