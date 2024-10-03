using DevExpress.XtraRichEdit.UI;
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
    public partial class FrmNotes : Form
    {
        Connection connect = new Connection();

        public FrmNotes()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtId.Clear();
            mskDate.Clear();
            mskHour.Clear();
            txtTitle.Clear();
            rhcContent.Clear();
            txtAuthor.Clear();
        }

        void list()
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Notes", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            connect.connection().Close();
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            list();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Notes(Date, Hour, Title, NoteContent, Author) values (@p1,@p2,@p3,@p4,@p5)", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", mskDate.Text);
                sqlCommand.Parameters.AddWithValue("@p2", mskHour.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtTitle.Text);
                sqlCommand.Parameters.AddWithValue("@p4", rhcContent.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtAuthor.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Note Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("delete from Tbl_Notes where Id=@p1", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Note Delete in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand sqlCommand = new SqlCommand("update Tbl_Notes set Date=@p1, Hour=@p2, Title=@p3, NoteContent=@p4, Author=@p5 where Id=@p6", connect.connection());
                sqlCommand.Parameters.AddWithValue("@p1", mskDate.Text);
                sqlCommand.Parameters.AddWithValue("@p2", mskHour.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtTitle.Text);
                sqlCommand.Parameters.AddWithValue("@p4", rhcContent.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtAuthor.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtId.Text);
                sqlCommand.ExecuteNonQuery();
                connect.connection().Close();
                MessageBox.Show("Note Update in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                mskDate.Text = dr["Date"].ToString();
                mskHour.Text = dr["Hour"].ToString();
                txtTitle.Text = dr["Title"].ToString();
                rhcContent.Text = dr["NoteContent"].ToString();
                txtAuthor.Text = dr["Author"].ToString();
            }
        }
    }
}
