using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmCompanies : Form
    {
        Connection connect = new Connection();

        public FrmCompanies()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtStatus.Clear();
            txtAuthorized.Clear();
            txtAthurizedId.Clear();
            txtSector.Clear();
            mskPhone1.Clear();
            mskPhone2.Clear();
            mskPhone3.Clear();
            txtEMail.Clear();
            mskFax.Clear();
            cmbCountry.Clear();
            cmbCity.Clear();
            cmbProvince.Clear();
            rhcAddress.Clear();
            txtTax.Clear();
            txtCode1.Clear();
            txtCode2.Clear();
            txtCode3.Clear();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Companies", connect.connection());
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

        void codeList()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Codes", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rchCode1.Text = reader[0].ToString();
                rchCode2.Text = reader[1].ToString();
                rchCode3.Text = reader[2].ToString();
            }
            connect.connection().Close();

        }

        private void FrmCompanies_Load(object sender, EventArgs e)
        {
            list();
            countyList();
            codeList();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Companies(Name, AuthorizedStatus, AuthorizedNameAndSurname, Phone1, Phone2, Phone3, Mail, Fax, Country, City, Province, Address, TaxOffice, AuthorizedIdNo, Sector, SpecialCode1, SpecialCode2, SpecialCode3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18)", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtStatus.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtAuthorized.Text);
                sqlCommand.Parameters.AddWithValue("@p4", mskPhone1.Text);
                sqlCommand.Parameters.AddWithValue("@p5", mskPhone2.Text);
                sqlCommand.Parameters.AddWithValue("@p6", mskPhone3.Text);
                sqlCommand.Parameters.AddWithValue("@p7", txtEMail.Text);
                sqlCommand.Parameters.AddWithValue("@p8", mskFax.Text);
                sqlCommand.Parameters.AddWithValue("@p9", cmbCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p10", cmbCity.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p11", cmbProvince.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p12", rhcAddress.Text);
                sqlCommand.Parameters.AddWithValue("@p13", txtTax.Text);
                sqlCommand.Parameters.AddWithValue("@p14", txtAthurizedId.Text);
                sqlCommand.Parameters.AddWithValue("@p15", txtSector.Text);
                sqlCommand.Parameters.AddWithValue("@p16", txtCode1.Text);
                sqlCommand.Parameters.AddWithValue("@p17", txtCode2.Text);
                sqlCommand.Parameters.AddWithValue("@p18", txtCode3.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Company Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("delete from Tbl_Companies where Id=@p1", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Company Delete in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("update Tbl_Companies set Name=@p1, AuthorizedStatus=@p2, AuthorizedNameAndSurname=@p3, Phone1=@p4, Phone2=@p5, Phone3=@p6, Mail=@p7, Fax=@p8, Country=@p9, City=@p10,Province=@p11,Address=@p12,TaxOffice=@p13, AuthorizedIdNo=@p14, Sector=@p15, SpecialCode1=@p16, SpecialCode2=@p17, SpecialCode3=@p18 where Id=@p19", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtStatus.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtAuthorized.Text);
                sqlCommand.Parameters.AddWithValue("@p4", mskPhone1.Text);
                sqlCommand.Parameters.AddWithValue("@p5", mskPhone2.Text);
                sqlCommand.Parameters.AddWithValue("@p6", mskPhone3.Text);
                sqlCommand.Parameters.AddWithValue("@p7", txtEMail.Text);
                sqlCommand.Parameters.AddWithValue("@p8", mskFax.Text);
                sqlCommand.Parameters.AddWithValue("@p9", cmbCountry.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p10", cmbCity.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p11", cmbProvince.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@p12", rhcAddress.Text);
                sqlCommand.Parameters.AddWithValue("@p13", txtTax.Text);
                sqlCommand.Parameters.AddWithValue("@p14", txtAthurizedId.Text);
                sqlCommand.Parameters.AddWithValue("@p15", txtSector.Text);
                sqlCommand.Parameters.AddWithValue("@p16", txtCode1.Text);
                sqlCommand.Parameters.AddWithValue("@p17", txtCode2.Text);
                sqlCommand.Parameters.AddWithValue("@p18", txtCode3.Text);
                sqlCommand.Parameters.AddWithValue("@p19", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Company Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtStatus.Text = dr["AuthorizedStatus"].ToString();
                txtAuthorized.Text = dr["AuthorizedNameAndSurname"].ToString();
                mskPhone1.Text = dr["Phone1"].ToString();
                mskPhone2.Text = dr["Phone2"].ToString();
                mskPhone3.Text = dr["Phone3"].ToString();
                txtEMail.Text = dr["Mail"].ToString();
                mskFax.Text = dr["Fax"].ToString();
                cmbCountry.SelectedItem = dr["Country"].ToString();
                cmbCity.SelectedItem = dr["City"].ToString();
                cmbProvince.SelectedItem = dr["Province"].ToString();
                rhcAddress.Text = dr["Address"].ToString();
                txtTax.Text = dr["TaxOffice"].ToString();
                txtSector.Text = dr["Sector"].ToString();
                txtAthurizedId.Text = dr["AuthorizedIdNo"].ToString();
                txtCode1.Text = dr["SpecialCode1"].ToString();
                txtCode2.Text = dr["SpecialCode2"].ToString();
                txtCode3.Text = dr["SpecialCode3"].ToString();
            }
        }


        private void cmbCountry_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cmbCity_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCompanyDetails frmCompanyDetails = new FrmCompanyDetails();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frmCompanyDetails.id = int.Parse(dr["Id"].ToString());
            }
            frmCompanyDetails.Show();
        }
    }
}
