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
    public partial class frmSexReport : XtraForm
    {
        public frmSexReport()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rptSexReport mc = new rptSexReport();
            mc.ReportParameters[0].Value = cmbSex.Text;
            mc.ReportParameters[1].Value = DateTime.Parse(dtpFrom.Text);
            mc.ReportParameters[2].Value = DateTime.Parse(dtpTo.Text);
            reportViewer1.ReportSource = mc;
            reportViewer1.RefreshReport();
        }
    }
}
