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
    public partial class frmViewLaboratory : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        public frmViewLaboratory()
        {
            InitializeComponent();
        }

        private void frmViewLaboratory_Load(object sender, EventArgs e)
        {
            //selectClass.selectPatientname(cmbFullname);

            cmbFullname.DataSource = selectClass.selectLabOrderPatientname(DateTime.Parse(dtpLabOrderDate.Text));
            cmbFullname.DisplayMember = "fullname";
            cmbFullname.ValueMember = "patid";
            cmbFullname.SelectedIndex = -1;
        }

        private void cmbFullname_IndexChanged(object sender, EventArgs e)
        {
            //selectClass.searchLaboratorybyFullname(cmbFullname.Text, dgvProcedures);

            dgvProcedures.DataSource = null;
            //MessageBox.Show(cmbFullname.SelectedValue.ToString());
            if (cmbFullname.SelectedIndex >= 0)
            {
                //MessageBox.Show(cmbFullname.SelectedValue.ToString());                
                selectClass.searchLaboratorybyFullname(cmbFullname.Text, DateTime.Parse(dtpLabOrderDate.Text), dgvProcedures);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmLaboratoryPrint laboratory = new frmLaboratoryPrint { patname = cmbFullname.Text, requestDate = DateTime.Parse(dtpLabOrderDate.Text) };
            laboratory.Show();
        }

        private void dtpLabOrderDate_ValueChanged(object sender, EventArgs e)
        {
            cmbFullname.DataSource = selectClass.selectLabOrderPatientname(DateTime.Parse(dtpLabOrderDate.Text));
            cmbFullname.DisplayMember = "fullname";
            cmbFullname.ValueMember = "patid";
            //cmbFullname.SelectedIndex = -1;
        }
    }
}
