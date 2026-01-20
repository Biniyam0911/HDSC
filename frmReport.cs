using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Telerik.Reporting;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class frmReport : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            frmReport rptMC = new frmReport();
            rptMC.Show();
            //// TODO: This line of code loads data into the 'dbOHMSDataSet1.tblConsultation' table. You can move, or remove it, as needed.
            //this.tblConsultationTableAdapter.Fill(this.dbOHMSDataSet1.tblConsultation);
            //DataTable dataSource = GetYourDataSource();
            //LocalReport localReport = new LocalReport();
            //localReport.ReportEmbeddedResource = "D:\\HDSC\\Onana Hospital Management System\\rptMedicalCertificate.rdlc";
            //localReport.DataSources.Add(new ReportDataSource("dbOHMSDataSet1", dataSource));
            //rptviewerMC.LocalReport.ReportPath = localReport.ReportEmbeddedResource;
            //rptviewerMC.LocalReport.DataSources.Clear();
            //rptviewerMC.LocalReport.DataSources.Add(new ReportDataSource("dbOHMSDataSet1", dataSource));
            //rptviewerMC.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        //private DataTable GetYourDataSource()
        //{
        //    DataTable dt = new DataTable("dbOHMSDataSet1");
        //    dt.Rows.Add("patID", typeof(string));
        //    dt.Rows.Add(dt.Columns.Count, typeof(string));
        //    return dt;
        //}
    }
}
