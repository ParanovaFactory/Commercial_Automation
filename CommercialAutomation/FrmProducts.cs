using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmProducts : Form
    {
        Connection connect = new Connection();

        public FrmProducts()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            mskYear.Clear();
            nudPiece.Value = 0;
            txtBuy.Clear();
            txtSell.Clear();
            rhcDescription.Clear();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Products", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            list();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Products(Name, Brand, Model, Year, Piece, BuyingPrice, SellingPrice, Description) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtBrand.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtModel.Text);
                sqlCommand.Parameters.AddWithValue("@p4", mskYear.Text);
                sqlCommand.Parameters.AddWithValue("@p5", int.Parse((nudPiece.Value).ToString()));
                sqlCommand.Parameters.AddWithValue("@p6", decimal.Parse(txtBuy.Text));
                sqlCommand.Parameters.AddWithValue("@p7", decimal.Parse(txtSell.Text));
                sqlCommand.Parameters.AddWithValue("@p8", rhcDescription.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Product Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("delete from Tbl_Products where Id = @p1", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Product Delete in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("update Tbl_Products set Name=@p1, Brand=@p2, Model=@p3, Year=@p4, Piece=@p5, BuyingPrice=@p6, SellingPrice=@p7, Description=@p8 where Id=@p9", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtBrand.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtModel.Text);
                sqlCommand.Parameters.AddWithValue("@p4", mskYear.Text);
                sqlCommand.Parameters.AddWithValue("@p5", int.Parse((nudPiece.Value).ToString()));
                sqlCommand.Parameters.AddWithValue("@p6", decimal.Parse(txtBuy.Text));
                sqlCommand.Parameters.AddWithValue("@p7", decimal.Parse(txtSell.Text));
                sqlCommand.Parameters.AddWithValue("@p8", rhcDescription.Text);
                sqlCommand.Parameters.AddWithValue("@p9", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Product Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtBrand.Text = dr["Brand"].ToString();
                txtModel.Text = dr["Model"].ToString();
                mskYear.Text = dr["Year"].ToString();
                nudPiece.Value = int.Parse(dr["Piece"].ToString());
                txtBuy.Text = dr["BuyingPrice"].ToString();
                txtSell.Text = dr["SellingPrice"].ToString();
                rhcDescription.Text = dr["Description"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
