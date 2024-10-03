using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmEmployee : Form
    {
        Connection connect = new Connection();

        public FrmEmployee()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            mskPhone.Clear();
            mskIdentity.Clear();
            txtEMail.Clear();
            cmbCountry.Clear();
            cmbCity.Clear();
            cmbProvince.Clear();
            rhcAddress.Clear();
            txtDepartment.Clear();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Employees", connect.connection());
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

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            list();
            countyList();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Employees(Name, Surname, Phone, IdentityNumber, Mail, Country, City, Province, Address, Department) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p3", mskPhone.Text);
                sqlCommand.Parameters.AddWithValue("@p4", mskIdentity.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtEMail.Text);
                sqlCommand.Parameters.AddWithValue("@p6", cmbCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p7", cmbCity.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p8", cmbProvince.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p9", rhcAddress.Text);
                sqlCommand.Parameters.AddWithValue("@p10", txtDepartment.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Employee Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("delete from Tbl_Employees where Id=@p1", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Employee Delete in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("update Tbl_Employees set Name=@p1, Surname=@p2, Phone=@p3, IdentityNumber=@p4, Mail=@p5, Country=@p6, City=@p7, Province=@p8, Address=@p9, Department=@p10 where Id=@p11", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p3", mskPhone.Text);
                sqlCommand.Parameters.AddWithValue("@p4", mskIdentity.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtEMail.Text);
                sqlCommand.Parameters.AddWithValue("@p6", cmbCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p7", cmbCity.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p8", cmbProvince.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p9", rhcAddress.Text);
                sqlCommand.Parameters.AddWithValue("@p10", txtDepartment.Text);
                sqlCommand.Parameters.AddWithValue("@p11", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Employee Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                mskPhone.Text = dr["Phone"].ToString();
                mskIdentity.Text = dr["IdentityNumber"].ToString();
                txtEMail.Text = dr["Mail"].ToString();
                cmbCountry.SelectedItem = dr["Country"].ToString();
                cmbCity.SelectedItem = dr["City"].ToString();
                cmbProvince.SelectedItem = dr["Province"].ToString();
                rhcAddress.Text = dr["Address"].ToString();
                txtDepartment.Text = dr["Department"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
