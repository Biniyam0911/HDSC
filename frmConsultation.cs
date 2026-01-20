using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using DevExpress.XtraEditors;


namespace Onana_Hospital_Management_System
{
    public partial class frmConsultation : XtraForm
    {
        
        //string dbPath = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";

        clsSelect selectClass = new clsSelect();
        clsInsert varInsert = new clsInsert();
        readonly ClsUpdate varUpdate = new ClsUpdate();
        DateTimePicker sysdate = new DateTimePicker();
        int countupload = 0;
        //int countFupload = 0;
        bool conupdate = false;
        //bool followupdate = false;
        //double consultBills = 40; //consultation bill
        double AddBill = 0;
        ErrorProvider err = new ErrorProvider();
        public string docName { get; set; }
        string patid = "";
        bool uploaded = false;
        public string FDARole { get; set; } 
        public frmConsultation()
        {
            InitializeComponent();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            validateMedication((Control)sender);
            
        }

        private void frmConsultation_Load(object sender, EventArgs e)
        {
            if(FDARole == "FDA")
            {
                btnProcedure.Visible = false;
            }
           // selectClass.selectDocName(comboBox1);

            clearAll();
        }

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    selectClass.ImageUpload(pcbCapure1);
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           

        }


        //CLEAR ALL
        void clearAll()
        {
            //radview_Click(radview, null);
            //cboFor.SelectedIndex = 0;
            //cboPatcode.SelectedIndex = 0;
            txtChiefCompliant.ResetText();
            txtHistory.ResetText();
            txtMedications.ResetText();
            txtPlan.ResetText();
            isPictures.Images.Clear();// = Properties.Resources.labs;
            uploaded = false;

        }

      


        //===================
        // SAVE BUTTON
        //==================
        private void btnSaveResult_Click(object sender, EventArgs e)
        {
          
            try
            {
                if(uploaded)
                {
                    varInsert.insertIntoConsultation(rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), docName.ToString(), sysdate, sysdate, txtChiefCompliant.Text, txtHistory.Text, txtPhysicalExamination.Text, txtDiagnosis.Text, txtPlan.Text, txtMedications.Text, isPictures);
                }
                else                
                    varInsert.insertIntoConsultation(rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), docName.ToString(), sysdate, sysdate, txtChiefCompliant.Text, txtHistory.Text, txtPhysicalExamination.Text, txtDiagnosis.Text,txtPlan.Text, txtMedications.Text,null);

                
                //UpdateBalance();
                //varInsert.ItemsBills(cboPatcode.SelectedItem.ToString(),txtPatName.Text,sysdate,sysdate,"Consultation",consultBills,docName);
                //cboPatcode.SelectedIndex = 0;
                //selectClass.selectIdForname(rgvPatientList, dtpAssignedDate, docName);
                //cboFor.SelectedIndex = 0;

                txtChiefCompliant.ResetText();
                txtHistory.ResetText();
                txtMedications.ResetText();
                txtDiagnosis.ResetText();
                txtPhysicalExamination.ResetText();
                txtPlan.ResetText();
                isPictures.Images.Clear();//.Image = Properties.Resources.labs;
                uploaded = false;
                //pcbCapure2.Image = Properties.Resources.labs;
                //pcbCapure3.Image = Properties.Resources.labs;
                //pcbCapure4.Image = Properties.Resources.labs;
                //pcbCapure5.Image = Properties.Resources.labs;
                //pcbCapure6.Image = Properties.Resources.labs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        //private void cboPatcode_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    selectClass.selectname(cboPatcode.SelectedItem.ToString());
        //    txtPatName.Text = selectClass.fullName;
        //}

        //UPdate Balance
        void UpdateBalance()
        {
            //string updateBillString;
            SqlConnection con;
            // SqlCommand cmd;
            try
            {
               
                con = new SqlConnection(varInsert.ConString);
              

                // ADD CONSULTATION FEE WHEN IGNORE CONSULTATION FEE IS UNCHECKED

               
                //if (chkNocharge.Checked == false)
                //{
                   
                //    try
                //    {
                //        //selectClass.selectname(cboPatcode);
                //        //AddBill = consultBills + selectClass.patientBills;
                //        //updateBillString = "update tblPatientBill set Amts = '" + AddBill.ToString() + "' where patID = '" + cboPatcode.SelectedItem.ToString() + "'And  patName= '" + txtPatName.Text + "'";
                //        //con.Open();
                //        //SqlCommand cmd = new SqlCommand(updateBillString, con);

                //        //cmd.ExecuteNonQuery();

                //        MessageBox.Show("bill updated successfully", "Save Data - MediSphere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);

                //    }
                //    con.Close();
                   
                //}


                //    //IF CHECKED
                //else
                //{
                //    try
                //    {
                //    //selectClass.selectname(cboPatcode);
                //    AddBill = selectClass.patientBills;
                //    updateBillString = "update tblPatientBill set Amts = '" + AddBill + "' where patID = '" + "cboPatcode" + "'And  patName= '" + "txtPatName.Text" + "'";
                //    con.Open();
                //        SqlCommand cmd = new SqlCommand(updateBillString, con);
                    
                //        cmd.ExecuteNonQuery();

                //        MessageBox.Show("bill updated successfully", "Save Data - Onana HMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);

                //    }
                //    con.Close();
                    
                //}
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void chkNocharge_CheckedChanged(object sender, EventArgs e)
        {
           
        }


        //diagnose
        private void txtDiagnose_TextChanged(object sender, EventArgs e)
        {
            validateDiagnosis((Control)sender);
        }

        private void txtDiagnose_Leave(object sender, EventArgs e)
        {
            validateDiagnosis((Control)sender);
        }


        //TREATMENT
        private void txtTreatment_TextChanged(object sender, EventArgs e)
        {
            validateTreatment((Control)sender);
        }

        private void txtTreatment_Leave(object sender, EventArgs e)
        {
            validateTreatment((Control)sender);
        }




        //VALIDATIONS
        //DIAGNOSE
        void validateDiagnosis(Control ctrl)
        {
            if (txtChiefCompliant.Text.Trim() == string.Empty)
            {
                err.SetError(txtChiefCompliant, "Please field can not be empty");
                return;

            }
            else {

                err.SetError(txtChiefCompliant, string.Empty);
            }
        
        }


        //TREAT
        void validateTreatment(Control ctrl)
        {
            if (txtHistory.Text.Trim() == string.Empty)
            {
                err.SetError(txtHistory, "Please field can not be empty");
                return;

            }
            else
            {

                err.SetError(txtHistory, string.Empty);
            }

        }


        //medication
         void validateMedication(Control ctrl)
        {
            if (txtMedications.Text.Trim() == string.Empty)
            {
                err.SetError(txtMedications, "Please field can not be empty");
                return;

            }
            else
            {

                err.SetError(txtMedications, string.Empty);
            }

        }

         private void txtMedications_Leave(object sender, EventArgs e)
         {
             validateMedication((Control)sender);
         }

        private void btnAssigned_Click(object sender, EventArgs e)
        {
            selectClass.selectIdForname(rgvPatientList, dtpAssignedDate, docName);
            ColorCoding();
        }

        private void ColorCoding()
        {
            ConditionalFormattingObject conditionPaid = new ConditionalFormattingObject("Paid", ConditionTypes.Equal, "True", "", applyToRow: false);
            conditionPaid.RowBackColor = Color.LightGreen;
            conditionPaid.ApplyToRow = true;
            rgvPatientList.Columns["Paid"].ConditionalFormattingObjectList.Add(conditionPaid);
            ConditionalFormattingObject conditionNotPaid = new ConditionalFormattingObject("Paid", ConditionTypes.Equal, "False", "", applyToRow: false);
            conditionNotPaid.RowBackColor = Color.LightPink;
            conditionNotPaid.ApplyToRow = true;
            rgvPatientList.Columns["Paid"].ConditionalFormattingObjectList.Add(conditionNotPaid);
        }
        //private void ColorFCoding()
        //{
        //    ConditionalFormattingObject conditionPaid = new ConditionalFormattingObject("Paid", ConditionTypes.Equal, "True", "", applyToRow: false);
        //    conditionPaid.RowBackColor = Color.LightGreen;
        //    conditionPaid.ApplyToRow = true;
        //    rgvFPatientList.Columns["Paid"].ConditionalFormattingObjectList.Add(conditionPaid);
        //    ConditionalFormattingObject conditionNotPaid = new ConditionalFormattingObject("Paid", ConditionTypes.Equal, "False", "", applyToRow: false);
        //    conditionNotPaid.RowBackColor = Color.LightPink;
        //    conditionNotPaid.ApplyToRow = true;
        //    rgvFPatientList.Columns["Paid"].ConditionalFormattingObjectList.Add(conditionNotPaid);
        //}

        private void rgvPatientList_Click(object sender, EventArgs e)
        {
            try
            {
                txtChiefCompliant.ResetText();
                txtDiagnosis.ResetText();
                txtHistory.ResetText();
                txtPhysicalExamination.ResetText();
                txtPlan.ResetText();
                txtMedications.ResetText();
                countupload = 0;
                isPictures.Images.Clear();// = Properties.Resources.labs;
                uploaded = false;

                //MessageBox.Show(rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString());
                selectClass.getVitalSignsList(rgvVitalSign, rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString());
                label2.Text = selectClass.selectAge(rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString());
                patid = rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString();
                var dt = selectClass.callConsultaionHistory(docName, rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(),isPictures);
                //MessageBox.Show(dt.Rows.Count.ToString());
                if (dt.Rows.Count > 0)
                {
                    conupdate = true;
                    txtChiefCompliant.Text = dt.Rows[0]["chiefcompliant"].ToString().Trim();
                    txtHistory.Text = dt.Rows[0]["history"].ToString().Trim();
                    txtPhysicalExamination.Text = dt.Rows[0]["pe"].ToString().Trim();
                    txtDiagnosis.Text = dt.Rows[0]["diagnosis"].ToString().Trim();
                    txtPlan.Text = dt.Rows[0]["plan"].ToString().Trim();
                    txtMedications.Text = dt.Rows[0]["medication"].ToString().Trim();

                    


                    //byte[] ba1 = (byte[])dt.Rows[0][13];
                    //System.IO.MemoryStream ms1 = new System.IO.MemoryStream(ba1);
                    //pcbCapure1.Image = new Bitmap(ms1);

                    //byte[] ba2 = (byte[])dt.Rows[0][14];
                    //System.IO.MemoryStream ms2 = new System.IO.MemoryStream(ba2);
                    //pcbCapure2.Image = new Bitmap(ms2);

                    //byte[] ba3 = (byte[])dt.Rows[0][15];
                    //System.IO.MemoryStream ms3 = new System.IO.MemoryStream(ba3);
                    //pcbCapure3.Image = new Bitmap(ms3);

                    //byte[] ba4 = (byte[])dt.Rows[0][16];
                    //System.IO.MemoryStream ms4 = new System.IO.MemoryStream(ba4);
                    //pcbCapure4.Image = new Bitmap(ms4);

                    //byte[] ba5 = (byte[])dt.Rows[0][17];
                    //System.IO.MemoryStream ms5 = new System.IO.MemoryStream(ba5);
                    //pcbCapure5.Image = new Bitmap(ms5);

                    //byte[] ba6 = (byte[])dt.Rows[0][18];
                    //System.IO.MemoryStream ms6 = new System.IO.MemoryStream(ba6);
                    //pcbCapure6.Image = new Bitmap(ms6);


                }
            }
            catch
            {
                MessageBox.Show("Please click on assigned button");
            }
           

        }

        private void rgvVitalSign_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rgvVitalSign.SelectedRows[0].Cells["ID"].Value.ToString());
            try
            {
                SqlDataReader reader = selectClass.getVitalSignsListforConsultation(rgvVitalSign.SelectedRows[0].Cells["ID"].Value.ToString());
                if (reader.Read())
                {
                    lblCardNo.Visible = true;
                    lblHeight.Visible = true;
                    lblFullname.Visible = true;
                    lblBMI.Visible = true;
                    lblPressure.Visible = true;
                    lblPulseRate.Visible = true;
                    lblRespiratoryRate.Visible = true;
                    lblWeight.Visible = true;
                    lblTemprature.Visible = true;

                    lblCardNo.Text = reader["ID"].ToString().ToUpper();
                    lblFullname.Text = reader["Patient Name"].ToString().ToUpper();
                    lblBMI.Text = reader["BMI"].ToString().ToUpper();
                    lblPressure.Text = reader["Pressure"].ToString().ToUpper();
                    lblTemprature.Text = reader["Temperature"].ToString().ToUpper();
                    lblPulseRate.Text = reader["Pulse Rate"].ToString().ToUpper();
                    lblRespiratoryRate.Text = reader["Respiratory Rate"].ToString().ToUpper();
                    lblWeight.Text = reader["Weight"].ToString().ToUpper();
                    lblHeight.Text = reader["Height"].ToString().ToUpper();

                    // lv.Items.Add(reader["patID"].ToString());
                }
                else
                {
                    lblCardNo.Visible = false;
                    lblHeight.Visible = false;
                    lblFullname.Visible = false;
                    lblBMI.Visible = false;
                    lblPressure.Visible = false;
                    lblPulseRate.Visible = false;
                    lblRespiratoryRate.Visible = false;
                    lblWeight.Visible = false;
                    lblTemprature.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("No Vitalsign Recorded!");
            }
           
        }

        //private void btnFAssigned_Click(object sender, EventArgs e)
        //{
        //    selectClass.FollowupList(rgvFPatientList, dtpFAssignedDate, docName);
        //    ColorFCoding();
        //}

        //private void rgvFPatientList_Click(object sender, EventArgs e)
        //{
        //    txtProblem.ResetText();
        //    txtSubjective.ResetText();
        //    txtObjective.ResetText();
        //    txtAssessment.ResetText();
        //    txtPlan.ResetText();
        //    txtMedication.ResetText();
        //    countFupload = 0;
        //    pcbFCapture1.Image = Properties.Resources.labs;
        //    pcbFCapture2.Image = Properties.Resources.labs;
        //    pcbFCapture3.Image = Properties.Resources.labs;
        //    pcbFCapture4.Image = Properties.Resources.labs;
        //    pcbFCapture5.Image = Properties.Resources.labs;
        //    pcbFCapture6.Image = Properties.Resources.labs;

        //    selectClass.getVitalSignsList(rgvFVitalSign, rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString());
        //    var dt = selectClass.callConsultaionHistory(docName, rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString());
        //    if (dt.Rows.Count > 0)
        //    {
        //        followupdate = true;
        //        txtProblem.Text = dt.Rows[0]["problem"].ToString().Trim();
        //        txtSubjective.Text = dt.Rows[0]["subjective"].ToString().Trim();
        //        txtObjective.Text = dt.Rows[0]["objective"].ToString().Trim();
        //        txtAssessment.Text = dt.Rows[0]["assessment"].ToString().Trim();
        //        txtFPlan.Text = dt.Rows[0]["plan2"].ToString().Trim();
        //        txtMedication.Text = dt.Rows[0]["medication2"].ToString().Trim();

        //        byte[] fba1 = (byte[])dt.Rows[0][13];
        //        System.IO.MemoryStream fms1 = new System.IO.MemoryStream(fba1);
        //        pcbFCapture1.Image = new Bitmap(fms1);

        //        byte[] ba2 = (byte[])dt.Rows[0][14];
        //        System.IO.MemoryStream ms2 = new System.IO.MemoryStream(ba2);
        //        pcbFCapture2.Image = new Bitmap(ms2);

        //        byte[] ba3 = (byte[])dt.Rows[0][15];
        //        System.IO.MemoryStream ms3 = new System.IO.MemoryStream(ba3);
        //        pcbFCapture3.Image = new Bitmap(ms3);

        //        byte[] ba4 = (byte[])dt.Rows[0][16];
        //        System.IO.MemoryStream ms4 = new System.IO.MemoryStream(ba4);
        //        pcbFCapture4.Image = new Bitmap(ms4);

        //        byte[] ba5 = (byte[])dt.Rows[0][17];
        //        System.IO.MemoryStream ms5 = new System.IO.MemoryStream(ba5);
        //        pcbFCapture5.Image = new Bitmap(ms5);

        //        byte[] ba6 = (byte[])dt.Rows[0][18];
        //        System.IO.MemoryStream ms6 = new System.IO.MemoryStream(ba6);
        //        pcbFCapture6.Image = new Bitmap(ms6);
        //        //MessageBox.Show(dt.Rows[0]["problem"].ToString().Trim());

        //        //txtMedications.Text = dt.Rows[0]["medication"].ToString().Trim();
        //    }

        //}

        //private void rgvFVitalSign_Click(object sender, EventArgs e)
        //{
        //    SqlDataReader reader = selectClass.getVitalSignsListforConsultation(rgvFVitalSign.SelectedRows[0].Cells["ID"].Value.ToString());
        //    if (reader.Read())
        //    {
        //        lblFCardNo.Visible = true;
        //        lblFHeight.Visible = true;
        //        lblFFullname.Visible = true;
        //        lblFBMI.Visible = true;
        //        lblFPressure.Visible = true;
        //        lblFPulseRate.Visible = true;
        //        lblFRespiratoryRate.Visible = true;
        //        lblFWeight.Visible = true;
        //        lblFTemprature.Visible = true;

        //        lblFCardNo.Text = reader["ID"].ToString().ToUpper();
        //        lblFFullname.Text = reader["Patient Name"].ToString().ToUpper();
        //        lblFBMI.Text = reader["BMI"].ToString().ToUpper();
        //        lblFPressure.Text = reader["Pressure"].ToString().ToUpper();
        //        lblFTemprature.Text = reader["Temperature"].ToString().ToUpper();
        //        lblFPulseRate.Text = reader["Pulse Rate"].ToString().ToUpper();
        //        lblFRespiratoryRate.Text = reader["Respiratory Rate"].ToString().ToUpper();
        //        lblFWeight.Text = reader["Weight"].ToString().ToUpper();
        //        lblFHeight.Text = reader["Height"].ToString().ToUpper();

        //        // lv.Items.Add(reader["patID"].ToString());
        //    }
        //    else
        //    {
        //        lblFCardNo.Visible = false;
        //        lblFHeight.Visible = false;
        //        lblFFullname.Visible = false;
        //        lblFBMI.Visible = false;
        //        lblFPressure.Visible = false;
        //        lblFPulseRate.Visible = false;
        //        lblFRespiratoryRate.Visible = false;
        //        lblFWeight.Visible = false;
        //        lblFTemprature.Visible = false;
        //    }
        //}

        private void btnFClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnFSaveResult_Click(object sender, EventArgs e)
        //{
        //    if(followupdate)
        //    {
         //       varUpdate.updateIntoFollowupConsultation(rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), docName.ToString(), sysdate, sysdate, txtProblem.Text, txtSubjective.Text, txtObjective.Text, txtAssessment.Text, txtFPlan.Text,txtMedication.Text, pcbCapure1);
//
        //    }
        //    else
        //    {
        //        varInsert.insertIntoFollowupConsultation(rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), docName.ToString(), sysdate, sysdate, txtProblem.Text, txtSubjective.Text, txtObjective.Text, txtAssessment.Text, txtFPlan.Text,txtMedication.Text, pcbFCapture1, pcbFCapture2, pcbFCapture3, pcbFCapture4, pcbFCapture5, pcbFCapture6);
        //    }
        //    txtProblem.ResetText();
        //    txtSubjective.ResetText();
        //    txtObjective.ResetText();
        //    txtAssessment.ResetText();
        //    txtFPlan.ResetText();
        //    txtMedication.ResetText();
        //    //cboFor.SelectedIndex = 0;
        //    pcbFCapture1.Image = Properties.Resources.labs;
        //    pcbFCapture2.Image = Properties.Resources.labs;
        //    pcbFCapture3.Image = Properties.Resources.labs;
        //    pcbFCapture4.Image = Properties.Resources.labs;
        //    pcbFCapture5.Image = Properties.Resources.labs;
        //    pcbFCapture6.Image = Properties.Resources.labs;
        //}

        private void btnMC_Click(object sender, EventArgs e)
        {
            try
            {
                frmMedicalCertficateInfo frmReport = new frmMedicalCertficateInfo { patid = rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), diagnosis = txtDiagnosis.Text, patname = rgvPatientList.SelectedRows[0].Cells["Fullname"].Value.ToString(), age = selectClass.getAge(rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString()), doctor = docName, address = selectClass.getAddress(rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString()) };
                frmReport.Show();
            }
            catch
            {
                MessageBox.Show("Please select Patient");
            }
            
        }

        //private void btnFProcedure_Click(object sender, EventArgs e)
        //{
        //    frmProcedure proced = new frmProcedure { doctor = docName, patid = rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), patname = rgvFPatientList.SelectedRows[0].Cells["Fullname"].Value.ToString() };
        //    proced.Show();
        //}

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            try
            {
                frmProcedure proced = new frmProcedure { doctor = docName, patid = rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), patname = rgvPatientList.SelectedRows[0].Cells["Fullname"].Value.ToString() };
                proced.Show();
            }
            catch
            {
                MessageBox.Show("Please select Patient");
            }
        }

        //private void btnFMC_Click(object sender, EventArgs e)
        //{
        //    frmMedicalCertficateInfo frmReport = new frmMedicalCertficateInfo { patid = rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), diagnosis = txtDiagnosis.Text, patname = rgvFPatientList.SelectedRows[0].Cells["Fullname"].Value.ToString(), age = selectClass.getAge(rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString()), doctor = docName, address = selectClass.getAddress(rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString()) };
        //    frmReport.Show();
        //}

        private void btnMedication_Click(object sender, EventArgs e)
        {

            try
            {
                frmPrescription proced = new frmPrescription(this) { doctor = docName, patid = rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), patname = rgvPatientList.SelectedRows[0].Cells["Fullname"].Value.ToString(), visittype = "consult", diagnosis = txtDiagnosis.Text, age = selectClass.getAge(rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString()), sex = selectClass.getSex(rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString()) };
                proced.Show();
            }
            catch
            {
                MessageBox.Show("Please select patient");
            }
            //frmDocPrescription frmprescription = new frmDocPrescription();
            //frmprescription.Show();
        }

        private void btnPatientHistory_Click(object sender, EventArgs e)
        {
            try
            {
                
                frmPatientHistory patHistory = new frmPatientHistory { PatientMRN = patid };
                patHistory.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select Patient" + ex.Message);
            }            
            
        }

       

        //private void btnFPrescription_Click(object sender, EventArgs e)
        //{
        //    frmPrescription proced = new frmPrescription (this) { doctor = docName, patid = rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), patname = rgvFPatientList.SelectedRows[0].Cells["Fullname"].Value.ToString(), visittype = "Followup",diagnosis = txtProblem.Text };
        //    proced.Show();
        //}

        //private void btnFPatientHistory_Click(object sender, EventArgs e)
        //{
        //    frmPatientHistory patHistory = new frmPatientHistory { patid = rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString() };
        //    patHistory.Show();
        //}

        private void btnUpload_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true; // Allow multiple files
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select Up to 6 Images";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    isPictures.Images.Clear(); // Clear existing images
                    string[] selectedFiles = openFileDialog.FileNames;

                    // Limit to 6 images
                    int imageCount = Math.Min(selectedFiles.Length, 6);
                    for (int i = 0; i < imageCount; i++)
                    {
                        isPictures.Images.Add(Image.FromFile(selectedFiles[i]));
                    }
                }
                uploaded = true;
            }

        }

        //private void btnFUpload_Click(object sender, EventArgs e)
        //{
        //    if (countFupload == 0)
        //    {
        //        selectClass.ImageUpload(pcbFCapture1);
        //        countFupload++;
        //    }
        //    else if (countFupload == 1)
        //    {
        //        selectClass.ImageUpload(pcbFCapture2);
        //        countFupload++;
        //    }
        //    else if (countFupload == 2)
        //    {
        //        selectClass.ImageUpload(pcbFCapture3);
        //        countFupload++;
        //    }
        //    else if (countFupload == 3)
        //    {
        //        selectClass.ImageUpload(pcbFCapture4);
        //        countFupload++;
        //    }
        //    else if (countFupload == 4)
        //    {
        //        selectClass.ImageUpload(pcbFCapture5);
        //        countFupload++;
        //    }
        //    else if (countFupload == 5)
        //    {
        //        selectClass.ImageUpload(pcbFCapture6);
        //        countFupload++;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Image upload full");
        //    }
        //}

        private void btnOrderLaboratory_Click(object sender, EventArgs e)
        {
            try
            {
                frmLaboratory lab = new frmLaboratory { patid = rgvPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), fullname = rgvPatientList.SelectedRows[0].Cells["Fullname"].Value.ToString() };
                lab.Show();
            }
            catch
            {
                MessageBox.Show("Please select Patient");
            }
            
        }

        private void chkNocharge_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void tbpNewConsult_Click(object sender, EventArgs e)
        {

        }

        //private void pcbCapure1_DoubleClick(object sender, EventArgs e)
        //{
        //    frmPicture frmpic = new frmPicture { pic = pcbCapure1.Image };
        //    frmpic.Show();
        //}

        //private void pcbCapure4_DoubleClick(object sender, EventArgs e)
        //{
        //    frmPicture frmpic = new frmPicture { pic = pcbCapure4.Image };
        //    frmpic.Show();
        //}

        //private void pcbCapure2_DoubleClick(object sender, EventArgs e)
        //{
        //    frmPicture frmpic = new frmPicture { pic = pcbCapure2.Image };
        //    frmpic.Show();
        //}

        //private void pcbCapure5_DoubleClick(object sender, EventArgs e)
        //{
        //    frmPicture frmpic = new frmPicture { pic = pcbCapure5.Image };
        //    frmpic.Show();
        //}

        //private void pcbCapure6_DoubleClick(object sender, EventArgs e)
        //{
        //    frmPicture frmpic = new frmPicture { pic = pcbCapure6.Image };
        //    frmpic.Show();
        //}

        //private void pcbCapure3_DoubleClick(object sender, EventArgs e)
        //{
        //    frmPicture frmpic = new frmPicture { pic = pcbCapure3.Image };
        //    frmpic.Show();
        //}

        //private void btnFOrderLaboratory_Click(object sender, EventArgs e)
        //{
        //    frmLaboratory lab = new frmLaboratory { patid = rgvFPatientList.SelectedRows[0].Cells["Card No"].Value.ToString(), fullname = rgvFPatientList.SelectedRows[0].Cells["Fullname"].Value.ToString() };
        //    lab.Show();
        //}
    }
}
