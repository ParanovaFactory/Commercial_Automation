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
    public partial class FrmInvoices : Form
    {
        Connection connect = new Connection();

        public FrmInvoices()
        {
            InitializeComponent();
        }

        int id;

        void clear()
        {
            txtId.Clear();
            txtSerie.Clear();
            txtOrderNo.Clear();
            mskDate.Clear();
            mskHour.Clear();
            txtTax.Clear();
            txtCustomer.Clear();
            txtEmployee.Clear();
            txtReceiver.Clear();
            txtDID.Clear();
            txtProduct.Clear();
            txtPiece.Clear();
            txtPrice.Clear();
            txtTotalPrice.Clear();
            txtInvoiceId.Clear();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_InvoiceDetails where InvoiceId = @p1", connect.connection());
            cmd.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        void listBase()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_InvoiceBase", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl2.DataSource = dt;
            connect.connection().Close();
        }

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            clear();
            listBase();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceId.Text == "")
                {
                    SqlCommand sqlCommand = new SqlCommand("insert into Tbl_InvoiceBase (Serie, OrderNo, Date, Hour, TaxOffice, Buyer, Deliverer, Receiver) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connect.connection());
                    sqlCommand.Parameters.AddWithValue("@p1", txtSerie.Text);
                    sqlCommand.Parameters.AddWithValue("@p2", txtOrderNo.Text);
                    sqlCommand.Parameters.AddWithValue("@p3", mskDate.Text);
                    sqlCommand.Parameters.AddWithValue("@p4", mskHour.Text);
                    sqlCommand.Parameters.AddWithValue("@p5", txtTax.Text);
                    sqlCommand.Parameters.AddWithValue("@p6", txtCustomer.Text);
                    sqlCommand.Parameters.AddWithValue("@p7", txtEmployee.Text);
                    sqlCommand.Parameters.AddWithValue("@p8", txtReceiver.Text);
                    sqlCommand.ExecuteNonQuery();
                    connect.connection().Close();
                    MessageBox.Show("Invoice Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    listBase();
                }
                if (txtInvoiceId.Text != "")
                {
                    SqlCommand sql = new SqlCommand("insert into Tbl_InvoiceDetails(ProductId,Product, Piece, Price, TotalPrice, InvoiceId) values (@p9,@p10,@p11,@p12,@p13,@p14)", connect.connection());
                    sql.Parameters.AddWithValue("@p9", int.Parse(txtProductId.Text));
                    sql.Parameters.AddWithValue("@p10", txtProduct.Text);
                    sql.Parameters.AddWithValue("@p11", int.Parse(txtPiece.Text));
                    sql.Parameters.AddWithValue("@p12", decimal.Parse(txtPrice.Text));
                    sql.Parameters.AddWithValue("@p13", decimal.Parse(txtTotalPrice.Text));
                    sql.Parameters.AddWithValue("@p14", txtInvoiceId.Text);
                    sql.ExecuteNonQuery();
                    connect.connection().Close();
                    MessageBox.Show("Invoice Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    listBase();
                }

                if (txtCompanyDetail.Text != "")
                {
                    SqlCommand sql = new SqlCommand("insert into Tbl_CompanyOperations(ProductId, Employee, Company, Piece, Price, TotalPrice, Date, Notes) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connect.connection());
                    sql.Parameters.AddWithValue("@p1", int.Parse(txtProductId.Text));
                    sql.Parameters.AddWithValue("@p2", int.Parse(txtEmployeeDetail.Text));
                    sql.Parameters.AddWithValue("@p3", int.Parse(txtCompanyDetail.Text));
                    sql.Parameters.AddWithValue("@p4", int.Parse(txtPiece.Text));
                    sql.Parameters.AddWithValue("@p5", decimal.Parse(txtPrice.Text));
                    sql.Parameters.AddWithValue("@p6", decimal.Parse(txtTotalPrice.Text));
                    sql.Parameters.AddWithValue("@p7", mskDateDetail.Text);
                    sql.Parameters.AddWithValue("@p8", rhcNotes.Text);
                    sql.ExecuteNonQuery();
                    connect.connection().Close();
                    MessageBox.Show("Operation Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlCommand sqlCommand = new SqlCommand("update Tbl_Products set Piece -=@p9 where Id = @p10",connect.connection());
                    sqlCommand.Parameters.AddWithValue("@p9", int.Parse(txtPiece.Text));
                    sqlCommand.Parameters.AddWithValue("@p10", int.Parse(txtProductId.Text));
                    sqlCommand.ExecuteNonQuery();
                    connect.connection().Close();
                    MessageBox.Show("Stock has been remained", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    listBase();
                }

                if (txtCustomerDetail.Text != "")
                {
                    SqlCommand sql = new SqlCommand("insert into Tbl_CompanyOperations(ProductId, Employee, Customer, Piece, Price, TotalPrice, Date, Notes) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connect.connection());
                    sql.Parameters.AddWithValue("@p1", int.Parse(txtProductId.Text));
                    sql.Parameters.AddWithValue("@p2", int.Parse(txtEmployeeDetail.Text));
                    sql.Parameters.AddWithValue("@p3", int.Parse(txtCompanyDetail.Text));
                    sql.Parameters.AddWithValue("@p4", int.Parse(txtPiece.Text));
                    sql.Parameters.AddWithValue("@p5", decimal.Parse(txtPrice.Text));
                    sql.Parameters.AddWithValue("@p6", decimal.Parse(txtTotalPrice.Text));
                    sql.Parameters.AddWithValue("@p7", mskDateDetail.Text);
                    sql.Parameters.AddWithValue("@p8", rhcNotes.Text);
                    sql.ExecuteNonQuery();
                    connect.connection().Close();
                    MessageBox.Show("Operation Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SqlCommand sqlCommand = new SqlCommand("update Tbl_Products set Piece -=@p9 where Id = @p10", connect.connection());
                    sqlCommand.Parameters.AddWithValue("@p9", int.Parse(txtPiece.Text));
                    sqlCommand.Parameters.AddWithValue("@p10", int.Parse(txtProductId.Text));
                    sqlCommand.ExecuteNonQuery();
                    connect.connection().Close();
                    MessageBox.Show("Stock has been remained", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    listBase();
                }
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
                if (txtInvoiceId.Text == "")
                {
                    SqlCommand sqlCommand = new SqlCommand("update Tbl_InvoiceBase set Serie=@p1, OrderNo=@p2, Date=@p3, Hour=@p4, TaxOffice=@p5, Buyer=@p6, Deliverer=@p7, Receiver=@p8 where Id = @p14", connect.connection());
                    sqlCommand.Parameters.AddWithValue("@p1", txtSerie.Text);
                    sqlCommand.Parameters.AddWithValue("@p2", txtOrderNo.Text);
                    sqlCommand.Parameters.AddWithValue("@p3", mskDate.Text);
                    sqlCommand.Parameters.AddWithValue("@p4", mskHour.Text);
                    sqlCommand.Parameters.AddWithValue("@p5", txtTax.Text);
                    sqlCommand.Parameters.AddWithValue("@p6", txtCustomer.Text);
                    sqlCommand.Parameters.AddWithValue("@p7", txtEmployee.Text);
                    sqlCommand.Parameters.AddWithValue("@p8", txtReceiver.Text);
                    sqlCommand.Parameters.AddWithValue("@p14", int.Parse(txtId.Text));
                    sqlCommand.ExecuteNonQuery();
                    connect.connection().Close(); MessageBox.Show("Invoice Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    listBase();
                }

                if (txtInvoiceId.Text != "")
                {
                    SqlCommand sql = new SqlCommand("update Tbl_InvoiceDetails set ProductId=@p16, Product=@p9, Piece=@p10, Price=@p11, TotalPrice=@p12, InvoiceId=@p13 where Id=@p15", connect.connection());
                    sql.Parameters.AddWithValue("@p1", int.Parse(txtProductId.Text));
                    sql.Parameters.AddWithValue("@p9", txtProduct.Text);
                    sql.Parameters.AddWithValue("@p10", int.Parse(txtPiece.Text));
                    sql.Parameters.AddWithValue("@p11", decimal.Parse(txtPrice.Text));
                    sql.Parameters.AddWithValue("@p12", decimal.Parse(txtTotalPrice.Text));
                    sql.Parameters.AddWithValue("@p13", txtInvoiceId.Text);
                    sql.Parameters.AddWithValue("@p15", int.Parse(txtDID.Text));
                    sql.ExecuteNonQuery();
                    connect.connection().Close(); MessageBox.Show("Invoice Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                    listBase();
                }
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("select Name,SellingPrice from Tbl_Products where Id=@p1", connect.connection());
            sql.Parameters.AddWithValue("@p1", int.Parse(txtProductId.Text));
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                txtProduct.Text = reader.GetString(0);
                txtPrice.Text = reader[1].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    txtDID.Text = dr["Id"].ToString();
                    txtProduct.Text = dr["Product"].ToString();
                    txtPiece.Text = dr["Piece"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    txtTotalPrice.Text = dr["TotalPrice"].ToString();
                    txtInvoiceId.Text = dr["InvoiceId"].ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void gridView2_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                if (dr != null)
                {
                    id = int.Parse(dr["Id"].ToString());
                    txtId.Text = dr["Id"].ToString();
                    txtSerie.Text = dr["Serie"].ToString();
                    txtOrderNo.Text = dr["OrderNo"].ToString();
                    mskDate.Text = dr["Date"].ToString();
                    mskHour.Text = dr["Hour"].ToString();
                    txtTax.Text = dr["TaxOffice"].ToString();
                    txtCustomer.Text = dr["Buyer"].ToString();
                    txtEmployee.Text = dr["Deliverer"].ToString();
                    txtReceiver.Text = dr["Receiver"].ToString();
                    list();
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtPiece_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalPrice.Text = Convert.ToString(int.Parse(txtPiece.Text) * decimal.Parse(txtPrice.Text));
            }
            catch (Exception)
            {

            }
        }
    }
}
