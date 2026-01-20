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
    public partial class frmPrescriptionPrint : XtraForm
    {
        public string patname { get; set; }
        //public int PrescID { get; set; }
        public DateTime PrescriptionDDate { get; set; }
        public frmPrescriptionPrint()
        {
            InitializeComponent();
        }

        private void frmPrescriptionPrint_Load(object sender, EventArgs e)
        {
            rptPrescription mc = new rptPrescription();
            mc.ReportParameters[0].Value = patname;
           // mc.ReportParameters[1].Value = PrescID;
            mc.ReportParameters[1].Value = PrescriptionDDate;

            reportViewer1.ReportSource = mc;
            reportViewer1.RefreshReport();
        }
    }
}
