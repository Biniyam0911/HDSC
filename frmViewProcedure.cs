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
    public partial class frmViewProcedure : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        public frmViewProcedure()
        {
            InitializeComponent();
        }

        private void frmViewProcedure_Load(object sender, EventArgs e)
        {
            selectClass.selectPatientname(cmbFullname);
        }

        private void cmbFullName_SelectionChanged(object sender, EventArgs e)
        {
            selectClass.searchPatientbyFullname(cmbFullname.Text, dgvProcedures);
        }
    }
}
