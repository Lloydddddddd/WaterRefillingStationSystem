using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WaterRefillingStationSystem.Reports
{
    public partial class Report_Sales : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_Sales()
        {
            InitializeComponent();
            //Set default values dynamically when report loads
            this.Parameters["StartDate"].Value = DateTime.Today;
            this.Parameters["EndDate"].Value = DateTime.Today;
        }

    }
}
