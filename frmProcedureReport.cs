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
    public partial class frmProcedureReport : XtraForm
    {
        public frmProcedureReport()
        {
            InitializeComponent();
        }

        private void frmProcedureReport_Load(object sender, EventArgs e)
        {
            rptProcedureReport mc = new rptProcedureReport();
            //mc.ReportParameters[0].Value = patname;

            reportViewer1.ReportSource = mc;
            reportViewer1.RefreshReport();
        }
    }
}
