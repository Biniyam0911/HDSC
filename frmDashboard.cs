using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace Onana_Hospital_Management_System
{
    public partial class frmDashboard : DevExpress.XtraEditors.XtraForm
    {
        private Dashboard model;
        clsSelect varSelect = new clsSelect();
        public decimal TotalServiceRevenue { get; set; }


        public frmDashboard()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
        }
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lblNumOrders.Text = model.NumOrders.ToString();
                lblTotalRevenue.Text = model.TotalRevenue.ToString("C2");
                //lblTotalProfit.Text = model.TotalProfit.ToString("C2");
                lblMale.Text = model.TotalMale.ToString();
                lblFemale.Text = model.TotalFemale.ToString();

                
                lblNumCustomers.Text = model.NumCustomers.ToString();
                //lblNumSuppliers.Text = model.NumSuppliers.ToString();
                lblNumProducts.Text = model.NumServices.ToString();

                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();

                chartTopProducts.DataSource = model.TopServiceList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();

                //chartTopServices.Series.Clear(); // Clear old data

                //Series series = new Series("Top Services", ViewType.Doughnut);
                //Series series = chartTopServices.Series["seriesTopProducts"];
                //if (chartTopServices.Series.Count > 0)
                //{
                //    Series series = chartTopServices.Series[0]; // First series
                //    series.Points.Clear();
                //    foreach (var item in model.TopServiceList)
                //    {
                //        series.Points.Add(new SeriesPoint(item.Key, item.Value));
                //    }

                //    chartTopServices.Series.Add(series);
                //    chartTopServices.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
                //}
                //foreach (var item in model.TopServiceList)
                //{
                //    series.Points.Add(new SeriesPoint(item.Key, item.Value));
                //}



                //dgvUnderstock.DataSource = model.UnderPerformingList;
                //dgvUnderstock.Columns[0].HeaderText = "Item";
                //dgvUnderstock.Columns[1].HeaderText = "Quantity";
                // Assign data source to DevExpress GridControl
                gridControlUnderstock.DataSource = model.UnderPerformingList;

                // Get the GridView associated with GridControl
                //GridView gridView = gridControlUnderstock.MainView as GridView;
                if (gridView1 != null)
                {
                    gridView1.Columns[0].Caption = "Item";
                    gridView1.Columns[1].Caption = "Quantity";
                    gridView1.Columns[2].Caption = "Total Price";
                    // Optional: Auto-size columns
                    gridView1.BestFitColumns();

                    // Optional: Make grid read-only
                    gridView1.OptionsBehavior.Editable = false;
                }

                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }

        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            serviceChart();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            serviceChart();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            serviceChart();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            serviceChart();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
            serviceChart();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

            btnLast7Days.Select();
            model = new Dashboard();
            cmbServoces.DataSource = varSelect.getServices();
            cmbServoces.DisplayMember = "servicename";
            cmbServoces.ValueMember = "serviceid";
            //cmbServoces.SelectedIndex = -1;
            
            LoadData();
        }  
        private void serviceChart()
        {
            if (cmbServoces.Text != "")
            {
                //model.selectedServiceName = cmbServoces.Text;
                model.GetOrderAnalisysbyService(cmbServoces.Text, dtpStartDate.Value, dtpEndDate.Value);
                chartServiceRevenue.DataSource = model.GrossServiceRevenueList;
                chartServiceRevenue.Series[0].XValueMember = "Date";
                chartServiceRevenue.Series[0].YValueMembers = "TotalAmount";
                chartServiceRevenue.DataBind();
            }
        }
        private void cmbServoces_SelectedIndexChanged(object sender, EventArgs e)
        {            
            serviceChart();
        }
    }
}