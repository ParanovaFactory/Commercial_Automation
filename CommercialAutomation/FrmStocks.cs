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
    public partial class FrmStocks : Form
    {
        Connection connect = new Connection();

        public FrmStocks()
        {
            InitializeComponent();
        }

        void product()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select Name, sum(Piece) as 'Piece' from Tbl_Products group by Name", connect.connection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();

            SqlCommand cmd = new SqlCommand("select Name, sum(Piece) from Tbl_Products group by Name", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(reader[0]), Convert.ToUInt32(reader[1]));
            }
        }

        void city()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select City, count(City) as 'Number of City' from Tbl_Companies group by City", connect.connection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl2.DataSource = dt;
            connect.connection().Close();

            SqlCommand cmd = new SqlCommand("select City, count(City) from Tbl_Companies group by City", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartControl2.Series["Cities"].Points.AddPoint(Convert.ToString(reader[0]), Convert.ToUInt32(reader[1]));
            }
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            product();
            city();
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            chartControl3.Series["Brands"].Points.Clear();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                SqlCommand cmd = new SqlCommand("select Brand, sum(Piece) from Tbl_Products where Name = @p1 group by Brand", connect.connection());
                cmd.Parameters.AddWithValue("@p1", dr["Name"].ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl3.Series["Brands"].Points.AddPoint(Convert.ToString(reader[0]), Convert.ToUInt32(reader[1]));
                }
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmStockDetails stockDetails = new FrmStockDetails();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                stockDetails.name = dr["Name"].ToString();
            }
            stockDetails.Show();
        }
    }
}
