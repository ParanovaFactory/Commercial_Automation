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
    public partial class FrmHome : Form
    {

        Connection connect = new Connection();

        public FrmHome()
        {
            InitializeComponent();
        }

        void listStock()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Products where piece < 50", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        void listNotes()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Notes", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl2.DataSource = dt;
            connect.connection().Close();
        }

        void listCompanyOperation()
        {
            SqlCommand cmd = new SqlCommand("execute top10CompanyOperation", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl3.DataSource = dt;
            connect.connection().Close();
        }

        void listCoustomerOperation()
        {
            SqlCommand cmd = new SqlCommand("execute top10CustomerOperation", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl4.DataSource = dt;
            connect.connection().Close();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            listStock();
            listNotes();
            listCompanyOperation();
            listCoustomerOperation();

        }
    }
}
