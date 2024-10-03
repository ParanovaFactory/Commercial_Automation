using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmPhoneBook : Form
    {
        Connection connect = new Connection();

        public FrmPhoneBook()
        {
            InitializeComponent();
        }

        public string mail;

        void clearCustomer()
        {
            rhcCustomerMessage.ClearUndo();
            txtCustomerMailAddress.Clear();
            txtCustomerSubject.Clear();
        }

        void clearCompany()
        {
            rchCompanyMessage.ClearUndo();
            txtCompanyMailAddress.Clear();
            txtCompanySubject.Clear();
        }

        private void FrmPhoneBook_Load(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("select Name, Surname, Phone1, Phone2, Mail from Tbl_Customers", connect.connection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sqlDataAdapter.Fill(dt2);
            gridControl1.DataSource = dt2;
            connect.connection().Close();

            SqlCommand cmd = new SqlCommand("select Name, AuthorizedNameAndSurname, Phone1, Phone2, Phone3, Mail, Fax from Tbl_Companies", connect.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridControl2.DataSource = dt;
            connect.connection().Close();
            clearCompany();
            clearCustomer();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                txtCustomerMailAddress.Text = dr["Mail"].ToString();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                txtCompanyMailAddress.Text = dr["Mail"].ToString();
            }
        }

        private void btnCompanySend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential("Mail Address", "Password");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            mail.To.Add(rchCompanyMessage.Text);
            mail.From = new MailAddress(txtCompanyMailAddress.Text);
            mail.Subject = txtCompanyMailAddress.Text;
            mail.Body = rchCompanyMessage.Text;
            MessageBox.Show("E-mail sent success fully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearCompany();
        }

        private void btnCustomerSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential("Mail Address", "Password");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            mail.To.Add(rhcCustomerMessage.Text);
            mail.From = new MailAddress(txtCustomerMailAddress.Text);
            mail.Subject = txtCustomerSubject.Text;
            mail.Body = rhcCustomerMessage.Text; MessageBox.Show("E-mail sent success fully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearCustomer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCompany();
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            clearCustomer();
        }
    }
}
