namespace WaterRefillingStationSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.POStab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciDashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciNewSale = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciStationSupplies = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciCustomerList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciCustomerDebt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aciSalesReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.aciLogout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Group.Hovered.BackColor = System.Drawing.Color.DarkGray;
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.accordionControl1.Appearance.Group.Hovered.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Hovered.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Group.Pressed.BackColor = System.Drawing.Color.Gray;
            this.accordionControl1.Appearance.Group.Pressed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Pressed.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.BackColor = System.Drawing.Color.DarkGray;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.BackColor = System.Drawing.Color.Gray;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Pressed.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.POStab});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(301, 765);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // POStab
            // 
            this.POStab.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aciDashboard,
            this.accordionControlElement2,
            this.accordionControlElement1,
            this.accordionControlSeparator2,
            this.accordionControlElement9,
            this.accordionControlSeparator3,
            this.accordionControlElement12,
            this.accordionControlSeparator4,
            this.aciLogout});
            this.POStab.Expanded = true;
            this.POStab.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("POStab.ImageOptions.Image")));
            this.POStab.Name = "POStab";
            this.POStab.Text = "POS";
            // 
            // aciDashboard
            // 
            this.aciDashboard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aciDashboard.ImageOptions.Image")));
            this.aciDashboard.Name = "aciDashboard";
            this.aciDashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciDashboard.Text = "Dashboard";
            this.aciDashboard.Click += new System.EventHandler(this.aciDashboard_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aciNewSale,
            this.accordionControlSeparator1});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Sales";
            // 
            // aciNewSale
            // 
            this.aciNewSale.Name = "aciNewSale";
            this.aciNewSale.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciNewSale.Text = "New Sale";
            this.aciNewSale.Click += new System.EventHandler(this.aciNewSale_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aciStationSupplies});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Inventory";
            // 
            // aciStationSupplies
            // 
            this.aciStationSupplies.Name = "aciStationSupplies";
            this.aciStationSupplies.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciStationSupplies.Text = "Station Supplies";
            this.aciStationSupplies.Click += new System.EventHandler(this.aciStationSupplies_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aciCustomerList,
            this.aciCustomerDebt});
            this.accordionControlElement9.Expanded = true;
            this.accordionControlElement9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement9.ImageOptions.Image")));
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Text = "Customer Management";
            // 
            // aciCustomerList
            // 
            this.aciCustomerList.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.aciCustomerList.Name = "aciCustomerList";
            this.aciCustomerList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciCustomerList.Text = "Customer List";
            this.aciCustomerList.Click += new System.EventHandler(this.aciCustomerList_Click);
            // 
            // aciCustomerDebt
            // 
            this.aciCustomerDebt.Name = "aciCustomerDebt";
            this.aciCustomerDebt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciCustomerDebt.Text = "Customer Debt";
            this.aciCustomerDebt.Click += new System.EventHandler(this.aciCustomerDebt_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aciSalesReport});
            this.accordionControlElement12.Expanded = true;
            this.accordionControlElement12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement12.ImageOptions.Image")));
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Text = "Reports";
            // 
            // aciSalesReport
            // 
            this.aciSalesReport.Name = "aciSalesReport";
            this.aciSalesReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciSalesReport.Text = "Sales Report";
            this.aciSalesReport.Click += new System.EventHandler(this.aciSalesReport_Click);
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // aciLogout
            // 
            this.aciLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aciLogout.ImageOptions.Image")));
            this.aciLogout.Name = "aciLogout";
            this.aciLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aciLogout.Text = "Logout";
            this.aciLogout.Click += new System.EventHandler(this.aciLogout_Click);
            // 
            // panelBody
            // 
            this.panelBody.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelBody.Appearance.Options.UseBackColor = true;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(301, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(944, 765);
            this.panelBody.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 765);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.accordionControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement POStab;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciNewSale;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciStationSupplies;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciCustomerList;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciSalesReport;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciLogout;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciCustomerDebt;
        public DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aciDashboard;
    }
}