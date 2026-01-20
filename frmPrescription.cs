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
    public partial class frmPrescription : XtraForm
    {
        public List<MedicationsClass> medicationDM { get; set; } = new List<MedicationsClass>();
        clsInsert varInsert = new clsInsert();
        clsSelect selectClass = new clsSelect();
        private frmConsultation consultationform;
        //public string med { get; set; }
        public string patid { get; set; }
        public string patname { get; set; }
        public string doctor { get; set; }
        public string diagnosis { get; set; }
        public string visittype { get; set; }
        public string sex { get; set; }
        public string age { get; set; }

        //int count = 0;

        public frmPrescription(frmConsultation consultationform)
        {
            InitializeComponent();
            this.consultationform = consultationform;
        }

        private void btnSelectService_Click(object sender, EventArgs e)
        {
            Medications microStore = new Medications(this);
            microStore.AddItem += new AddItemHandlers(winAdd_AddItem);

            //microStore.TextBoxValueChanged += OtherWindowOnTextBoxValueChanged;
            microStore.Show();
        }
        void winAdd_AddItem(object sender, MedicationsClass itemToAdd)
        {
            medicationDM.Add(itemToAdd);
        }        

        public void SetTotalTextBoxValue(string value)
        {
            txtTotalPrice.Text = value;
        }

        private void frmPrescription_Load(object sender, EventArgs e)
        {
            txtCardno.Text = patid;
            txtFullname.Text = patname;
            txtDiagnosis.Text = diagnosis;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(dgvOrders.RowCount>1)
            {
                //consultationform.txtMedications.Text = "test";
                //med = "test";
                int prescID = selectClass.callPrescNumber();
                if (visittype == "consult")
                {
                    for (int i = 0; i < dgvOrders.RowCount - 1; i++)
                    {
                        consultationform.txtMedications.Text += dgvOrders.Rows[i].Cells[0].Value.ToString() + "   " + dgvOrders.Rows[i].Cells[1].Value.ToString() + "   " + dgvOrders.Rows[i].Cells[2].Value.ToString() + "   " + dgvOrders.Rows[i].Cells[3].Value.ToString() + Environment.NewLine;
                        varInsert.insertToPrescription(dgvOrders.Rows[i].Cells[0].Value.ToString(), dgvOrders.Rows[i].Cells[1].Value.ToString(), dgvOrders.Rows[i].Cells[2].Value.ToString(), dgvOrders.Rows[i].Cells[3].Value.ToString(), txtCardno.Text, txtFullname.Text, doctor, diagnosis,age,sex, prescID);
                        varInsert.insertIntoPrescNumbere();
                    }
                }
                //else
                //{
                //    for (int i = 0; i < dgvOrders.RowCount - 1; i++)
                //    {
                //        consultationform.txtMedication.Text += dgvOrders.Rows[i].Cells[0].Value.ToString() + "   " + dgvOrders.Rows[i].Cells[1].Value.ToString() + "   " + dgvOrders.Rows[i].Cells[2].Value.ToString() + "   " + dgvOrders.Rows[i].Cells[3].Value.ToString() + Environment.NewLine;
                //        varInsert.insertToPrescription(dgvOrders.Rows[i].Cells[0].Value.ToString(), dgvOrders.Rows[i].Cells[1].Value.ToString(), dgvOrders.Rows[i].Cells[2].Value.ToString(), dgvOrders.Rows[i].Cells[3].Value.ToString(), txtCardno.Text, txtFullname.Text, doctor,diagnosis);
                //    }
                //}

                frmPrescriptionPrint prescription = new frmPrescriptionPrint { patname = txtFullname.Text, PrescriptionDDate = DateTime.Today };
                prescription.Show();
                // MessageBox.Show("Prescription successfully added", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
           
            
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if(dgvOrders.RowCount>1)
            {
                dgvOrders.Rows.Remove(dgvOrders.CurrentRow);
            }
            // dataGridView1.CurrentRow.Cells[0].Value.ToString()
        }
    }
}
