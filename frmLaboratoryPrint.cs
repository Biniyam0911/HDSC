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
    public partial class frmLaboratoryPrint : XtraForm
    {
        public string patname { get; set; }
        public DateTime requestDate { get; set; }
        public frmLaboratoryPrint()
        {
            InitializeComponent();
        }

        private void frmLaboratoryPrint_Load(object sender, EventArgs e)
        {
            rptLaboratory mc = new rptLaboratory();
            mc.ReportParameters[0].Value = patname;
            mc.ReportParameters[1].Value = requestDate;


            reportViewer1.ReportSource = mc;
            reportViewer1.RefreshReport();
        }
    }
}
