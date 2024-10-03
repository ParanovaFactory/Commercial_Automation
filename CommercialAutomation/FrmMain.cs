using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        FrmProducts products;
        FrmCustomers customers;
        FrmCompanies companies;
        FrmEmployee employee;
        FrmCosts costs;
        FrmBanks banks;
        FrmPhoneBook phoneBooks;
        FrmNotes notes;
        FrmInvoices invoices;
        FrmOperations operations;
        FrmStocks stocks;
        FrmSettings settings;
        FrmCashRegister cashRegister;
        FrmHome home;


        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (products == null || products.IsDisposed)
            {
                products = new FrmProducts();
                products.MdiParent = this;
                products.Show();
            }
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customers == null || customers.IsDisposed)
            {
                customers = new FrmCustomers();
                customers.MdiParent = this;
                customers.Show();
            }
        }

        private void btnCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (companies == null || companies.IsDisposed)
            {
                companies = new FrmCompanies();
                companies.MdiParent = this;
                companies.Show();
            }
        }

        private void btnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employee == null || employee.IsDisposed)
            {
                employee = new FrmEmployee();
                employee.MdiParent = this;
                employee.Show();
            }
        }

        private void btnCost_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (costs == null || costs.IsDisposed)
            {
                costs = new FrmCosts();
                costs.MdiParent = this;
                costs.Show();
            }
        }

        private void btnBank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (banks == null || banks.IsDisposed)
            {
                banks = new FrmBanks();
                banks.MdiParent = this;
                banks.Show();
            }
        }

        private void btnPhoneBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (phoneBooks == null || phoneBooks.IsDisposed)
            {
                phoneBooks = new FrmPhoneBook();
                phoneBooks.MdiParent = this;
                phoneBooks.Show();
            }
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notes == null || notes.IsDisposed)
            {
                notes = new FrmNotes();
                notes.MdiParent = this;
                notes.Show();
            }
        }

        private void btnBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (invoices == null || invoices.IsDisposed)
            {
                invoices = new FrmInvoices();
                invoices.MdiParent = this;
                invoices.Show();
            }
        }

        private void btnOperations_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (operations == null || operations.IsDisposed)
            {
                operations = new FrmOperations();
                operations.MdiParent = this;
                operations.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stocks == null || stocks.IsDisposed)
            {
                stocks = new FrmStocks();
                stocks.MdiParent = this;
                stocks.Show();
            }
        }

        private void btnSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new FrmSettings();
                settings.Show();
            }
        }

        private void btnCashRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cashRegister == null || cashRegister.IsDisposed)
            {
                cashRegister = new FrmCashRegister();
                cashRegister.MdiParent = this;
                cashRegister.Show();
            }
        }

        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (home == null || home.IsDisposed)
            {
                home = new FrmHome();
                home.MdiParent = this;
                home.Show();
            }
        }
    }
}
