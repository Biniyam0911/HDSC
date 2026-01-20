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
    public delegate void AddItemHandlers(object sender, MedicationsClass itemToAdd);
    public partial class Medications : XtraForm
    {
        clsSelect selectClass = new clsSelect();
        float total = 0;
        public event AddItemHandlers AddItem;
        private frmPrescription prescriptionform;

        //private frmConsultation consultationform;
        public Medications(frmPrescription prescriptionform)
        {
            InitializeComponent();
            this.prescriptionform = prescriptionform;
            //this.consultationform = consultationform;
        }

        private void Medications_Load(object sender, EventArgs e)
        {
            selectClass.getMedications(dgvMedications);
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            //if (txtQuantity.Text == null || txtQuantity.Text.Length == 0 || int.Parse(txtQuantity.Text) == 0 || cmbFor.SelectedIndex == -1 || cmbFor.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please type Quanity");
            //}
            //else
            //{
                if(txtCMedname.Text.Length == 0 || txtCMedname.Text == null )
                {
                    
                    if (dgvMedications.SelectedRows.Count > 0)
                    {
                        MedicationsClass itemToAdd = new MedicationsClass();
                       
                        itemToAdd.Medicationname = dgvMedications.CurrentRow.Cells[0].Value.ToString();
                        itemToAdd.UnitPrice = float.Parse(dgvMedications.CurrentRow.Cells[1].Value.ToString());
                       
                        itemToAdd.UnitPrice = float.Parse(dgvMedications.CurrentRow.Cells[1].Value.ToString());
                        itemToAdd.TotalPrice = int.Parse("0") * float.Parse(dgvMedications.CurrentRow.Cells[1].Value.ToString());
                        itemToAdd.dosage = "";
                        itemToAdd.freqency = txtFrequency.Text;
                        itemToAdd.length ="";
                        total += int.Parse("0") * float.Parse(dgvMedications.CurrentRow.Cells[1].Value.ToString());

                        prescriptionform.dgvOrders.Rows.Add(itemToAdd.Medicationname, itemToAdd.freqency, itemToAdd.length, itemToAdd.dosage);
                      
                        prescriptionform.SetTotalTextBoxValue(Math.Round((total), 2).ToString());
                        //frmConsultation.txtMedications.Text += itemToAdd.Medicationname+"    "+ itemToAdd.freqency + "    " + itemToAdd.length + "    " + itemToAdd.dosage;
                        //txtQuantity.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Please select item");
                    }
                }
                else
                {
                    
                    if (dgvMedications.SelectedRows.Count > 0)
                    {
                        MedicationsClass itemToAdd = new MedicationsClass();
                       
                        itemToAdd.Medicationname = txtCMedname.Text;
                        itemToAdd.UnitPrice = float.Parse(dgvMedications.CurrentRow.Cells[1].Value.ToString());
                      
                        itemToAdd.UnitPrice = float.Parse(dgvMedications.CurrentRow.Cells[1].Value.ToString());
                        itemToAdd.TotalPrice = int.Parse("0") * float.Parse(dgvMedications.CurrentRow.Cells[1].Value.ToString());
                        itemToAdd.dosage = "";
                        itemToAdd.freqency = txtFrequency.Text;
                        itemToAdd.length = "";
                        total += int.Parse("0") * float.Parse(dgvMedications.CurrentRow.Cells[1].Value.ToString());

                        prescriptionform.dgvOrders.Rows.Add(itemToAdd.Medicationname, itemToAdd.freqency, itemToAdd.length, itemToAdd.dosage);
                      
                        prescriptionform.SetTotalTextBoxValue(Math.Round((total), 2).ToString());

                        //txtQuantity.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Please select item");
                    }
                    txtCMedname.Clear();
                //}

               
               
            }
        }
    }
}
