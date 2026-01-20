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
    public partial class frmDocTransfer : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        ClsUpdate varUpdate = new ClsUpdate();
        public frmDocTransfer()
        {
            InitializeComponent();
        }

        private void frmDocTransfer_Load(object sender, EventArgs e)
        {
            selectClass.selectPatientnameTransfer(cmbPatientName);
            selectClass.selectEmployeesname(cmbTransferTo);
        }

        private void cmbPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTransferFrom.Text = selectClass.getPatDoctor(cmbPatientName.Text);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            varUpdate.UpdateDoctor(cmbPatientName.Text, cmbTransferTo.Text);
            MessageBox.Show("Doctor transferred successfully","MediSphere",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtTransferFrom.Text = "";
            cmbPatientName.SelectedIndex = -1;
            cmbTransferTo.SelectedIndex = -1;
        }
    }
}
