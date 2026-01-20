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
    public partial class frmViewPrescription : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        public frmViewPrescription()
        {
            InitializeComponent();
        }

        private void frmViewPrescription_Load(object sender, EventArgs e)
        {
            cmbFullname.DataSource = selectClass.selectPrescriptionPatientname(DateTime.Parse(dtpPrescriptionDate.Text));
            cmbFullname.DisplayMember = "fullname";
            cmbFullname.ValueMember = "patid";
            cmbFullname.SelectedIndex = -1;
        }

        private void cmbFullname_SelectoinChanged(object sender, EventArgs e)
        {
            dgvProcedures.DataSource = null;
            //MessageBox.Show(cmbFullname.SelectedValue.ToString());
            if (cmbFullname.SelectedIndex >= 0)
            {
                try
                {
                    //MessageBox.Show(cmbFullname.SelectedValue.ToString());
                    selectClass.searchPrescriptionbyFullname(cmbFullname.Text, DateTime.Parse(dtpPrescriptionDate.Text), dgvProcedures);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            //MessageBox.Show(cmbFullname.SelectedValue.ToString());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrescriptionPrint prescription = new frmPrescriptionPrint { patname = cmbFullname.Text, PrescriptionDDate = DateTime.Parse(dtpPrescriptionDate.Text)};
            prescription.Show();
            // MessageBox.Show("Prescription successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cmbFullname.DataSource = selectClass.selectPrescriptionPatientname(DateTime.Parse(dtpPrescriptionDate.Text));
            cmbFullname.DisplayMember = "fullname";
            cmbFullname.ValueMember = "patid";
            cmbFullname.SelectedIndex = -1;
            //selectClass.selectPrescriptionPatientname(cmbFullname,DateTime.Parse(dtpPrescriptionDate.Text));
        }
    }
}
