using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.Charts;

namespace CommercialAutomation
{
    public partial class FrmCashRegister : Form
    {
        Connection connect = new Connection();

        public FrmCashRegister()
        {
            InitializeComponent();
        }

        void listInComeCompayn()
        {
            SqlCommand cmd = new SqlCommand("execute companyOperation", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        void listInComeCustomer()
        {
            SqlCommand cmd = new SqlCommand("execute customerOperation", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl3.DataSource = dt;
            connect.connection().Close();
        }

        void listCost()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Costs", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl2.DataSource = dt;
            connect.connection().Close();
        }

        void totalPrice()
        {
            SqlCommand cmd = new SqlCommand("select sum(TotalPrice) from Tbl_InvoiceDetails", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblAmount.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        void totalCost()
        {
            SqlCommand cmd = new SqlCommand("select (Electric + Ethernet + Gas + Water + Salaries + Extra) from Tbl_Costs order by Id asc", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblPurcashe.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        void totalCustomer()
        {
            SqlCommand cmd = new SqlCommand("select count(Id) from Tbl_Customers", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblCustomer.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        void totalCompany()
        {
            SqlCommand cmd = new SqlCommand("select count(Id) from Tbl_Companies", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblCompany.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        void totalSalary()
        {
            SqlCommand cmd = new SqlCommand("select Salaries from Tbl_Costs order by Id asc", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblSalary.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        void totalCountyr()
        {
            SqlCommand cmd = new SqlCommand("select count(Id) from Tbl_Countries", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblCounty.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        void totalCity()
        {
            SqlCommand cmd = new SqlCommand("select count(Id) from Tbl_Cities", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblCity.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        void totalBrand()
        {
            SqlCommand cmd = new SqlCommand("select count(distinct Brand) from Tbl_Products", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblBrand.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        void totalStock()
        {
            SqlCommand cmd = new SqlCommand("select sum(Piece) from Tbl_Products", connect.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblStock.Text = reader[0].ToString();
            }
            connect.connection().Close();
        }

        private void FrmCashRegister_Load(object sender, EventArgs e)
        {
            listInComeCompayn();
            listInComeCustomer();
            listCost();
            totalPrice();
            totalCost();
            totalCustomer();
            totalCompany();
            totalSalary();
            totalCountyr();
            totalCity();
            totalBrand();
            totalStock();
        }

        int counter = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > 0 && counter <= 5)
            {
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Electric from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter > 5 && counter <= 10)
            {
                chartControl2.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Water from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter > 10 && counter <= 15)
            {
                chartControl2.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Gas from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter > 15 && counter <= 20)
            {
                chartControl2.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Ethernet from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter > 20 && counter <= 25)
            {
                chartControl2.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Salaries from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter > 25 && counter <= 30)
            {
                chartControl2.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Extra from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl2.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else
            {
                counter = 1;
                chartControl2.Series["Mounth"].Points.Clear();
            }
        }

        int counter1 = 1;

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter1++;
            if (counter1 > 0 && counter1 <= 5)
            {
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Electric from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter1 > 5 && counter1 <= 10)
            {
                chartControl1.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Water from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter1 > 10 && counter1 <= 15)
            {
                chartControl1.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Gas from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter1 > 15 && counter1 <= 20)
            {
                chartControl1.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Ethernet from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter1 > 20 && counter1 <= 25)
            {
                chartControl1.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Salaries from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else if (counter1 > 25 && counter1 <= 30)
            {
                chartControl1.Series["Mounth"].Points.Clear();
                SqlCommand cmd = new SqlCommand("select top 12 Mounth, Extra from Tbl_Costs order by Id desc", connect.connection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartControl1.Series["Mounth"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                }
                connect.connection().Close();
            }
            else
            {
                counter1 = 1;
                chartControl1.Series["Mounth"].Points.Clear();
            }
        }
    }
}
