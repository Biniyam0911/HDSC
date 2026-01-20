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
    public partial class frmAgeReport : XtraForm
    {
        public frmAgeReport()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rptAgeReport mc = new rptAgeReport();
            mc.ReportParameters[0].Value = cmbAgeRange.Text;
            mc.ReportParameters[1].Value = DateTime.Parse(dtpFrom.Text);
            mc.ReportParameters[2].Value = DateTime.Parse(dtpTo.Text);
            reportViewer1.ReportSource = mc;
            reportViewer1.RefreshReport();
        }

        private void frmAgeReport_Load(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAgeRange_Click(object sender, EventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void grpAgeReport_Enter(object sender, EventArgs e)
        {

        }
    }
}
