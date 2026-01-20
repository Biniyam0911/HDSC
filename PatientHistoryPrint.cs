using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onana_Hospital_Management_System
{
    public partial class PatientHistoryPrint : Form
    {
       public string patid { get; set; }
        public PatientHistoryPrint()
        {
            InitializeComponent();
        }

        private void PatientHistoryPrint_Load(object sender, EventArgs e)
        {
            Report2 mc = new Report2();
            mc.ReportParameters[0].Value = patid;
            //mc.ReportParameters[1].Value = requestDate;


            reportViewer1.ReportSource = mc;
            reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }
    }
}
