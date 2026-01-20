using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace Onana_Hospital_Management_System
{
    public partial class frmSalesReport : XtraForm
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            rptSalesReport mc = new rptSalesReport();
            reportViewer1.ReportSource = mc;
            reportViewer1.RefreshReport();
        }
    }
}
