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
    public partial class FrmCompanyDetails : Form
    {
        Connection connect = new Connection();

        public FrmCompanyDetails()
        {
            InitializeComponent();
        }

        public int id;

        void list()
        {
            SqlCommand cmd = new SqlCommand("select Tbl_InvoiceDetails.Id,Tbl_InvoiceBase.Buyer,Product,Piece,Piece,TotalPrice from Tbl_InvoiceDetails inner join Tbl_InvoiceBase on Tbl_InvoiceBase.Id = Tbl_InvoiceDetails.InvoiceId where Tbl_InvoiceBase.Buyer = (select Name from Tbl_Companies where Id = @p1)", connect.connection());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        private void FrmCompanyDetails_Load(object sender, EventArgs e)
        {
            list();
        }
    }
}
