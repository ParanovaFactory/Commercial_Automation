using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmCustomers : Form
    {
        Connection connect = new Connection();

        public FrmCustomers()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            mskPhone1.Clear();
            mskPhone2.Clear();
            mskIdentity.Clear();
            txtEMail.Clear();
            cmbCountry.Clear();
            cmbCity.Clear();
            cmbProvince.Clear();
            rhcAddress.Clear();
            txtTax.Clear();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Customers", connect.connection());
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

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            list();
            countyList();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Customers(Name, Surname, Phone1, Phone2, IdentityNumber, Mail, Country, City,Province,Address,TaxOffice) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p3", mskPhone1.Text);
                sqlCommand.Parameters.AddWithValue("@p4", mskPhone2.Text);
                sqlCommand.Parameters.AddWithValue("@p5", mskIdentity.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtEMail.Text);
                sqlCommand.Parameters.AddWithValue("@p7", cmbCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p8", cmbCity.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p9", cmbProvince.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p10", rhcAddress.Text);
                sqlCommand.Parameters.AddWithValue("@p11", txtTax.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Customer Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("delete from Tbl_Customers where Id=@p1", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Customer Delete in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("update Tbl_Customers set Name=@p1, Surname=@p2, Phone1=@p3, Phone2=@p4, IdentityNumber=@p5, Mail=@p6, Country=@p7, City=@p8,Province=@p9,Address=@p10,TaxOffice=@p11 where Id=@p12", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p3", mskPhone1.Text);
                sqlCommand.Parameters.AddWithValue("@p4", mskPhone2.Text);
                sqlCommand.Parameters.AddWithValue("@p5", mskIdentity.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtEMail.Text);
                sqlCommand.Parameters.AddWithValue("@p7", cmbCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p8", cmbCity.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p9", cmbProvince.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p10", rhcAddress.Text);
                sqlCommand.Parameters.AddWithValue("@p11", txtTax.Text);
                sqlCommand.Parameters.AddWithValue("@p12", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Customer Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtSurname.Text = dr["Surname"].ToString();
                mskPhone1.Text = dr["Phone1"].ToString();
                mskPhone2.Text = dr["Phone2"].ToString();
                mskIdentity.Text = dr["IdentityNumber"].ToString();
                txtEMail.Text = dr["Mail"].ToString();
                cmbCountry.SelectedItem = dr["Country"].ToString();
                cmbCity.SelectedItem = dr["City"].ToString();
                cmbProvince.SelectedItem = dr["Province"].ToString();
                rhcAddress.Text = dr["Address"].ToString();
                txtTax.Text = dr["TaxOffice"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
