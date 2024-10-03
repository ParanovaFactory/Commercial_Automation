namespace CommercialAutomation
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnStock = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompany = new DevExpress.XtraBars.BarButtonItem();
            this.btnHome = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnCost = new DevExpress.XtraBars.BarButtonItem();
            this.btnCashRegister = new DevExpress.XtraBars.BarButtonItem();
            this.btnNote = new DevExpress.XtraBars.BarButtonItem();
            this.btnBank = new DevExpress.XtraBars.BarButtonItem();
            this.btnBill = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhoneBook = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaperts = new DevExpress.XtraBars.BarButtonItem();
            this.btnOperations = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnProduct,
            this.btnStock,
            this.btnCustomer,
            this.btnCompany,
            this.btnHome,
            this.btnEmployee,
            this.btnCost,
            this.btnCashRegister,
            this.btnNote,
            this.btnBank,
            this.btnBill,
            this.btnSetting,
            this.btnPhoneBook,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnRaperts,
            this.btnOperations,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 220;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1940, 150);
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "PRODUCTS";
            this.btnProduct.Id = 1;
            this.btnProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.LargeImage")));
            this.btnProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnStock
            // 
            this.btnStock.Caption = "STOCKS";
            this.btnStock.Id = 2;
            this.btnStock.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStock.ImageOptions.LargeImage")));
            this.btnStock.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStock.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStock.Name = "btnStock";
            this.btnStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStock_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "CUSTOMERS";
            this.btnCustomer.Id = 3;
            this.btnCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.LargeImage")));
            this.btnCustomer.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomer.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCustomer.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomer.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnCompany
            // 
            this.btnCompany.Caption = "COMPANIES";
            this.btnCompany.Id = 4;
            this.btnCompany.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCompany.ImageOptions.LargeImage")));
            this.btnCompany.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompany.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCompany.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompany.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompany_ItemClick);
            // 
            // btnHome
            // 
            this.btnHome.Caption = "HOME";
            this.btnHome.Id = 5;
            this.btnHome.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHome.ImageOptions.LargeImage")));
            this.btnHome.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHome.Name = "btnHome";
            this.btnHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHome_ItemClick);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Caption = "EMPLOYEES";
            this.btnEmployee.Id = 6;
            this.btnEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmployee.ImageOptions.LargeImage")));
            this.btnEmployee.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployee.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployee_ItemClick);
            // 
            // btnCost
            // 
            this.btnCost.Caption = "COSTS";
            this.btnCost.Id = 7;
            this.btnCost.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCost.ImageOptions.LargeImage")));
            this.btnCost.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCost.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCost.Name = "btnCost";
            this.btnCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCost_ItemClick);
            // 
            // btnCashRegister
            // 
            this.btnCashRegister.Caption = "CASH REGISTER";
            this.btnCashRegister.Id = 8;
            this.btnCashRegister.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCashRegister.ImageOptions.LargeImage")));
            this.btnCashRegister.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCashRegister.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCashRegister.Name = "btnCashRegister";
            this.btnCashRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCashRegister_ItemClick);
            // 
            // btnNote
            // 
            this.btnNote.Caption = "NOTES";
            this.btnNote.Id = 9;
            this.btnNote.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNote.ImageOptions.LargeImage")));
            this.btnNote.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNote.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNote.Name = "btnNote";
            this.btnNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNote_ItemClick);
            // 
            // btnBank
            // 
            this.btnBank.Caption = "BANKS";
            this.btnBank.Id = 10;
            this.btnBank.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBank.ImageOptions.LargeImage")));
            this.btnBank.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBank.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBank.Name = "btnBank";
            this.btnBank.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBank_ItemClick);
            // 
            // btnBill
            // 
            this.btnBill.Caption = "INVOICES";
            this.btnBill.Id = 11;
            this.btnBill.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBill.ImageOptions.LargeImage")));
            this.btnBill.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBill.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBill.Name = "btnBill";
            this.btnBill.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBill_ItemClick);
            // 
            // btnSetting
            // 
            this.btnSetting.Caption = "SETTINGS";
            this.btnSetting.Id = 12;
            this.btnSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.ImageOptions.LargeImage")));
            this.btnSetting.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetting.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetting_ItemClick);
            // 
            // btnPhoneBook
            // 
            this.btnPhoneBook.Caption = "PHONE BOOK";
            this.btnPhoneBook.Id = 13;
            this.btnPhoneBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhoneBook.ImageOptions.LargeImage")));
            this.btnPhoneBook.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhoneBook.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPhoneBook.Name = "btnPhoneBook";
            this.btnPhoneBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhoneBook_ItemClick);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "barButtonItem14";
            this.barButtonItem14.Id = 14;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "barButtonItem15";
            this.barButtonItem15.Id = 15;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "OPERATIONS";
            this.barButtonItem2.Id = 17;
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // 
            // btnOperations
            // 
            this.btnOperations.Caption = "OPERATİONS";
            this.btnOperations.Id = 19;
            this.btnOperations.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOperations.ImageOptions.LargeImage")));
            this.btnOperations.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOperations.ItemAppearance.Normal.Options.UseFont = true;
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOperations_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "ADMIN";
            this.barButtonItem3.Id = 20;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "LOGOUT";
            this.barButtonItem4.Id = 21;
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Commerical Automation";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHome);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStock);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOperations);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomer);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCompany);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEmployee);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCost);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCashRegister);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNote);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBank);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBill);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhoneBook);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSetting);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 929);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commerical Automation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarButtonItem btnStock;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarButtonItem btnCompany;
        private DevExpress.XtraBars.BarButtonItem btnHome;
        private DevExpress.XtraBars.BarButtonItem btnEmployee;
        private DevExpress.XtraBars.BarButtonItem btnCost;
        private DevExpress.XtraBars.BarButtonItem btnCashRegister;
        private DevExpress.XtraBars.BarButtonItem btnNote;
        private DevExpress.XtraBars.BarButtonItem btnBank;
        private DevExpress.XtraBars.BarButtonItem btnBill;
        private DevExpress.XtraBars.BarButtonItem btnSetting;
        private DevExpress.XtraBars.BarButtonItem btnPhoneBook;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnRaperts;
        private DevExpress.XtraBars.BarButtonItem btnOperations;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}

