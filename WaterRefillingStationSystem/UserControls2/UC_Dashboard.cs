using Dapper;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterRefillingStationSystem.UserControls2
{
    public partial class UC_Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        private string _connectionString = @"Data Source=C:\Users\Admin\source\repos\WaterRefillingStationSystem\WaterRefillingStationSystemDB.db;Version=3;";
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            LoadChartData();
        }
        private void LoadChartData()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                //Customers: Show "Customers" (X) vs. Total Count (Y)
                string queryCustomers = "SELECT 'Customers' AS Category, COUNT(CustomerID) AS Total FROM Customers";
                var customerTotal = connection.QuerySingle<(string Category, int Total)>(queryCustomers); //Execution

                Series customerSeries = new Series("Customers", ViewType.Bar);
                customerSeries.Points.Add(new SeriesPoint(customerTotal.Category, customerTotal.Total));

                //CustomerDebt: Show Customer Name (X) vs Total Debt (Y)
                string queryDebt = "SELECT Name, SUM(Debt) AS TotalDebt FROM CustomerDebt GROUP BY Name";
                var debtData = connection.Query<(string Name, decimal TotalDebt)>(queryDebt);

                Series debtSeries = new Series("Customer Debt", ViewType.Bar);
                foreach (var data in debtData)
                {
                    debtSeries.Points.Add(new SeriesPoint(data.Name, data.TotalDebt));
                }

                //StationSupplies: Show Item Name (X) vs Quantity (Y)
                string querySupplies = "SELECT ItemName, Quantity FROM StationSupplies";
                var supplyData = connection.Query<(string ItemName, int Quantity)>(querySupplies);

                Series suppliesSeries = new Series("Station Supplies", ViewType.Bar);
                foreach (var data in supplyData)
                {
                    suppliesSeries.Points.Add(new SeriesPoint(data.ItemName, data.Quantity));
                }

                //SalesDetails: Show Item Name (X) vs Total Sales (Y)
                string querySales = "SELECT ItemName, SUM(TotalPrice) AS TotalSales FROM SalesDetails GROUP BY ItemName";
                var salesData = connection.Query<(string ItemName, decimal TotalSales)>(querySales);

                Series salesSeries = new Series("Sales Overview", ViewType.Bar);
                foreach (var data in salesData)
                {
                    salesSeries.Points.Add(new SeriesPoint(data.ItemName, data.TotalSales));
                }

                //Add All Series to the Chart
                chartControlDashboard.Series.Clear();
                chartControlDashboard.Series.AddRange(new Series[] { customerSeries, debtSeries, suppliesSeries, salesSeries });

                //Customize Appearance (Optional)
                chartControlDashboard.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            }
        }
    }
}
