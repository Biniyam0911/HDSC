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
    public partial class frmAppointment : XtraForm
    {
        clsInsert varInsert = new clsInsert();
        clsSelect selectClass = new clsSelect();
        DateTimePicker sys = new DateTimePicker();
        DateTimePicker syss = new DateTimePicker();
        ErrorProvider err = new ErrorProvider();
        public frmAppointment()
        {
            InitializeComponent();
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            selectClass.GetConsultationServices(cmbDiagnosisType);
            relay();
            
            
        }
        void relay()
        {
            cmbDiagnosisType.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            cmbVisitType.SelectedIndex = -1;
            cmbFilterCriteria.SelectedIndex = -1;

            if (txtSearch.Text.Length > 0)
            {
                cmbVisitType.Enabled = false;
                cmbDiagnosisType.Enabled = false;
                cmbDoctor.Enabled = false;
                dtpStartDate.Enabled = false;
                
            }
            else
            {
                cmbVisitType.Enabled = true;
                cmbDiagnosisType.Enabled = true;
                cmbDoctor.Enabled = true;
                dtpStartDate.Enabled = true;
               
            }

        }
        void clearAll()
        {
            //cmbVisitType.SelectedIndex = 0;
            txtNote.Text = "";
            //txtSubj.Text = "";
            dtpStartDate.Value = sys.Value.Date;
            cmbDoctor.SelectedIndex = -1;
            cmbVisitType.SelectedIndex = -1;
            cmbFilterCriteria.SelectedIndex = -1;
            cmbDiagnosisType.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            dgvPatientVisits.DataSource = null;
            txtSearch.Text = string.Empty;
        }

        //SAVE
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //validatesubj(txtSubj);

                //validateNote(txtNote);

                //if(err.GetError(txtSubj).Length !=0)
                //{
                //    err.SetError(txtSubj, "Please enter a value");

                //}
                //if(err.GetError(txtNote).Length !=0)
                //   {
                //       err.SetError(txtNote, "Please enter a value");
                //   }
                //else
                //{
                //if (dtpStartDate.Value.Date>= DateTime.Now)
                //{
                //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int cartnumber = selectClass.callCartNumber();
                if (cmbVisitType.Text == "Repeat")
                {
                    varInsert.insertIntoSchedule(DateTime.Parse(dtpStartDate.Text), txtNote.Text, dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString(), cmbDoctor.SelectedItem.ToString(), cmbVisitType.Text, cmbDiagnosisType.Text, cartnumber, true);
                    varInsert.InsertIntoOrder(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), cmbDoctor.Text, cmbDiagnosisType.Text, selectClass.getServicePrice(cmbDiagnosisType.Text), 1, cartnumber, "Consultation", true);
                    varInsert.insertIntocartNumbere();

                }
                else
                {
                    varInsert.insertIntoSchedule(DateTime.Parse(dtpStartDate.Text), txtNote.Text, dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString(), cmbDoctor.SelectedItem.ToString(), cmbVisitType.Text, cmbDiagnosisType.Text, cartnumber, false);
                    varInsert.InsertIntoOrder(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), cmbDoctor.Text, cmbDiagnosisType.Text, selectClass.getServicePrice(cmbDiagnosisType.Text), 1, cartnumber, "Consultation", false);
                    varInsert.insertIntocartNumbere();
                }

                clearAll();
                //}
                //else 
                //{

                //    MessageBox.Show("End date can not be less than start date", "Error - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //}

                //}

            }
            catch
            {
                MessageBox.Show("Please select patient first");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txtNote_TextChanged(object sender, EventArgs e)
        //{
        //    validateNote((Control)sender);
        //}

        private void txtSubj_TextChanged(object sender, EventArgs e)
        {
            //validatesubj((Control)sender);
        }

        //NOTE
        //void validateNote(Control ctrl)
        //{
        //    if (string.IsNullOrEmpty(txtNote.Text))
        //    {
        //        err.SetError(txtNote, "Please enter a value");
        //        return;
        //    }
        //    else if (string.IsNullOrWhiteSpace(txtNote.Text))
        //    {
        //        err.SetError(txtNote, "Please enter a value");
        //        return;
        //    }
        //    else
        //    {
        //        err.SetError(txtNote, string.Empty);
        //    }
        
        //}


        //SUBJ
        //void validatesubj(Control ctrl)
        //{

        //    if (string.IsNullOrEmpty(txtSubj.Text))
        //    {
        //        err.SetError(txtSubj, "Please enter a value");
        //        return;
        //    }
        //    else if (string.IsNullOrWhiteSpace(txtSubj.Text))
        //    {
        //        err.SetError(txtSubj, "Please enter a value");
        //        return;
        //    }
        //    else
        //    {
        //        err.SetError(txtSubj, string.Empty);
        //    }
        //}

        private void txtSubj_Leave(object sender, EventArgs e)
        {
            //validatesubj((Control)sender);
        }

        //private void txtNote_Leave(object sender, EventArgs e)
        //{
        //    validateNote((Control)sender);
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fname, lname, phone, card;            
                
            if (cmbFilterCriteria.SelectedIndex != -1 && txtSearch.Text.Length > 0)
            {
                if (cmbFilterCriteria.SelectedIndex == 0)
                {
                    fname = txtSearch.Text;
                    selectClass.searchPatient(txtSearch.Text, "sp_get_search_patient_by_fname", dataGridView1);
                }
                    
                else if (cmbFilterCriteria.SelectedIndex == 1)
                {
                    selectClass.searchPatient(txtSearch.Text, "sp_get_search_patient_by_sname", dataGridView1);
                    lname = txtSearch.Text;
                }
                    
                else if (cmbFilterCriteria.SelectedIndex == 2)
                {
                    selectClass.searchPatient(txtSearch.Text, "sp_get_search_patient_by_phone", dataGridView1);
                    phone = txtSearch.Text;
                }
                    
                else
                {
                    selectClass.searchPatient(txtSearch.Text, "sp_get_search_patient_by_id", dataGridView1);
                    card = txtSearch.Text;
                }  
            }
            else
            {
                MessageBox.Show("Please select either filter criteria or type search term");
            }
            cmbDoctor.Items.Clear();
            selectClass.selectEmployeesname(cmbDoctor);
            //clearAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectClass.getPatientVisits(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dgvPatientVisits);
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
