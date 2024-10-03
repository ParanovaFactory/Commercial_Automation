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
    public partial class FrmStockDetails : Form
    {

        Connection connect = new Connection();

        public FrmStockDetails()
        {
            InitializeComponent();
        }

        public string name;

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Products where Name = @p1", connect.connection());
            cmd.Parameters.AddWithValue("@p1", name);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {
            list();
        }
    }
}
