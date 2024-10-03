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
    public partial class FrmOperations : Form
    {
        Connection connect = new Connection();

        public FrmOperations()
        {
            InitializeComponent();
        }

        void listCompany()
        {
            SqlCommand cmd = new SqlCommand("execute companyOperation", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gcCompany.DataSource = dataTable;
            connect.connection().Close();
        }

        void listCustomer()
        {
            SqlCommand cmd = new SqlCommand("execute customerOperation", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            gcCustomer.DataSource = dataTable;
            connect.connection().Close();
        }

        private void FrmOperations_Load(object sender, EventArgs e)
        {
            listCompany();
            listCustomer();
        }
    }
}
