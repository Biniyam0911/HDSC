namespace Onana_Hospital_Management_System
{
    partial class frmConsultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultation));
            this.tbpNewConsult = new System.Windows.Forms.TabPage();
            this.btnOrderLaboratory = new DevExpress.XtraEditors.SimpleButton();
            this.btnPatientHistory = new DevExpress.XtraEditors.SimpleButton();
            this.btnProcedure = new DevExpress.XtraEditors.SimpleButton();
            this.btnMC = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrescription = new DevExpress.XtraEditors.SimpleButton();
            this.isPictures = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.txtPhysicalExamination = new System.Windows.Forms.TextBox();
            this.txtMedications = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.txtChiefCompliant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblRespiratoryRate = new System.Windows.Forms.Label();
            this.lblPulseRate = new System.Windows.Forms.Label();
            this.lblTemprature = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rgvVitalSign = new Telerik.WinControls.UI.RadGridView();
            this.btnAssigned = new System.Windows.Forms.Button();
            this.dtpAssignedDate = new System.Windows.Forms.DateTimePicker();
            this.rgvPatientList = new Telerik.WinControls.UI.RadGridView();
            this.tbcConsultation = new System.Windows.Forms.TabControl();
            this.tbpNewConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isPictures)).BeginInit();
            this.lblAge.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvVitalSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvVitalSign.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPatientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPatientList.MasterTemplate)).BeginInit();
            this.tbcConsultation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpNewConsult
            // 
            this.tbpNewConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.tbpNewConsult.Controls.Add(this.btnOrderLaboratory);
            this.tbpNewConsult.Controls.Add(this.btnPatientHistory);
            this.tbpNewConsult.Controls.Add(this.btnProcedure);
            this.tbpNewConsult.Controls.Add(this.btnMC);
            this.tbpNewConsult.Controls.Add(this.btnPrescription);
            this.tbpNewConsult.Controls.Add(this.isPictures);
            this.tbpNewConsult.Controls.Add(this.btnUpload);
            this.tbpNewConsult.Controls.Add(this.txtPlan);
            this.tbpNewConsult.Controls.Add(this.txtDiagnosis);
            this.tbpNewConsult.Controls.Add(this.txtPhysicalExamination);
            this.tbpNewConsult.Controls.Add(this.txtMedications);
            this.tbpNewConsult.Controls.Add(this.txtHistory);
            this.tbpNewConsult.Controls.Add(this.txtChiefCompliant);
            this.tbpNewConsult.Controls.Add(this.label6);
            this.tbpNewConsult.Controls.Add(this.lblAge);
            this.tbpNewConsult.Controls.Add(this.label9);
            this.tbpNewConsult.Controls.Add(this.label8);
            this.tbpNewConsult.Controls.Add(this.btnClose);
            this.tbpNewConsult.Controls.Add(this.btnSaveResult);
            this.tbpNewConsult.Controls.Add(this.label7);
            this.tbpNewConsult.Controls.Add(this.label5);
            this.tbpNewConsult.Controls.Add(this.label4);
            this.tbpNewConsult.Controls.Add(this.panel1);
            this.tbpNewConsult.Location = new System.Drawing.Point(4, 22);
            this.tbpNewConsult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpNewConsult.Name = "tbpNewConsult";
            this.tbpNewConsult.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpNewConsult.Size = new System.Drawing.Size(3724, 1381);
            this.tbpNewConsult.TabIndex = 0;
            this.tbpNewConsult.Text = "Evaluation Form";
            this.tbpNewConsult.Click += new System.EventHandler(this.tbpNewConsult_Click);
            // 
            // btnOrderLaboratory
            // 
            this.btnOrderLaboratory.Location = new System.Drawing.Point(1068, 15);
            this.btnOrderLaboratory.Name = "btnOrderLaboratory";
            this.btnOrderLaboratory.Size = new System.Drawing.Size(138, 30);
            this.btnOrderLaboratory.TabIndex = 74;
            this.btnOrderLaboratory.Text = "Order Laboratory";
            this.btnOrderLaboratory.Click += new System.EventHandler(this.btnOrderLaboratory_Click);
            // 
            // btnPatientHistory
            // 
            this.btnPatientHistory.Location = new System.Drawing.Point(924, 15);
            this.btnPatientHistory.Name = "btnPatientHistory";
            this.btnPatientHistory.Size = new System.Drawing.Size(138, 30);
            this.btnPatientHistory.TabIndex = 73;
            this.btnPatientHistory.Text = "View Patient Past History";
            this.btnPatientHistory.Click += new System.EventHandler(this.btnPatientHistory_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(780, 15);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(138, 30);
            this.btnProcedure.TabIndex = 72;
            this.btnProcedure.Text = "Order Procedure";
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(636, 15);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(138, 30);
            this.btnMC.TabIndex = 71;
            this.btnMC.Text = "Write Medical Certificate";
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.Location = new System.Drawing.Point(492, 15);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(138, 30);
            this.btnPrescription.TabIndex = 70;
            this.btnPrescription.Text = "Write Prescription";
            this.btnPrescription.Click += new System.EventHandler(this.btnMedication_Click);
            // 
            // isPictures
            // 
            this.isPictures.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.isPictures.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.isPictures.Location = new System.Drawing.Point(1410, 467);
            this.isPictures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isPictures.Name = "isPictures";
            this.isPictures.Size = new System.Drawing.Size(321, 249);
            this.isPictures.TabIndex = 69;
            this.isPictures.Text = "Upload Images";
            this.isPictures.ToolTip = "Upload Images";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(1507, 743);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(162, 43);
            this.btnUpload.TabIndex = 67;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(493, 488);
            this.txtPlan.MaxLength = 800;
            this.txtPlan.Multiline = true;
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(766, 49);
            this.txtPlan.TabIndex = 60;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(495, 395);
            this.txtDiagnosis.MaxLength = 800;
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(765, 49);
            this.txtDiagnosis.TabIndex = 35;
            // 
            // txtPhysicalExamination
            // 
            this.txtPhysicalExamination.Location = new System.Drawing.Point(495, 305);
            this.txtPhysicalExamination.MaxLength = 800;
            this.txtPhysicalExamination.Multiline = true;
            this.txtPhysicalExamination.Name = "txtPhysicalExamination";
            this.txtPhysicalExamination.Size = new System.Drawing.Size(765, 49);
            this.txtPhysicalExamination.TabIndex = 33;
            // 
            // txtMedications
            // 
            this.txtMedications.Location = new System.Drawing.Point(495, 612);
            this.txtMedications.MaxLength = 800;
            this.txtMedications.Multiline = true;
            this.txtMedications.Name = "txtMedications";
            this.txtMedications.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMedications.Size = new System.Drawing.Size(765, 74);
            this.txtMedications.TabIndex = 18;
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(495, 212);
            this.txtHistory.MaxLength = 800;
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(765, 49);
            this.txtHistory.TabIndex = 17;
            // 
            // txtChiefCompliant
            // 
            this.txtChiefCompliant.Location = new System.Drawing.Point(495, 106);
            this.txtChiefCompliant.MaxLength = 800;
            this.txtChiefCompliant.Multiline = true;
            this.txtChiefCompliant.Name = "txtChiefCompliant";
            this.txtChiefCompliant.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChiefCompliant.Size = new System.Drawing.Size(765, 73);
            this.txtChiefCompliant.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Plan";
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Controls.Add(this.label2);
            this.lblAge.Controls.Add(this.label3);
            this.lblAge.Controls.Add(this.lblWeight);
            this.lblAge.Controls.Add(this.lblHeight);
            this.lblAge.Controls.Add(this.label23);
            this.lblAge.Controls.Add(this.label24);
            this.lblAge.Controls.Add(this.lblRespiratoryRate);
            this.lblAge.Controls.Add(this.lblPulseRate);
            this.lblAge.Controls.Add(this.lblTemprature);
            this.lblAge.Controls.Add(this.lblPressure);
            this.lblAge.Controls.Add(this.lblBMI);
            this.lblAge.Controls.Add(this.lblFullname);
            this.lblAge.Controls.Add(this.lblCardNo);
            this.lblAge.Controls.Add(this.label16);
            this.lblAge.Controls.Add(this.label15);
            this.lblAge.Controls.Add(this.label14);
            this.lblAge.Controls.Add(this.label13);
            this.lblAge.Controls.Add(this.label12);
            this.lblAge.Controls.Add(this.label11);
            this.lblAge.Controls.Add(this.label10);
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(1410, 16);
            this.lblAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAge.Name = "lblAge";
            this.lblAge.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAge.Size = new System.Drawing.Size(321, 447);
            this.lblAge.TabIndex = 39;
            this.lblAge.TabStop = false;
            this.lblAge.Text = "Vital Sign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Age";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(135, 149);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 17;
            this.lblWeight.Text = "Weight";
            this.lblWeight.Visible = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(135, 122);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 16;
            this.lblHeight.Text = "Height";
            this.lblHeight.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 149);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Weight";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Height";
            // 
            // lblRespiratoryRate
            // 
            this.lblRespiratoryRate.AutoSize = true;
            this.lblRespiratoryRate.Location = new System.Drawing.Point(135, 296);
            this.lblRespiratoryRate.Name = "lblRespiratoryRate";
            this.lblRespiratoryRate.Size = new System.Drawing.Size(89, 13);
            this.lblRespiratoryRate.TabIndex = 13;
            this.lblRespiratoryRate.Text = "Respiratory Rate";
            this.lblRespiratoryRate.Visible = false;
            // 
            // lblPulseRate
            // 
            this.lblPulseRate.AutoSize = true;
            this.lblPulseRate.Location = new System.Drawing.Point(135, 264);
            this.lblPulseRate.Name = "lblPulseRate";
            this.lblPulseRate.Size = new System.Drawing.Size(58, 13);
            this.lblPulseRate.TabIndex = 12;
            this.lblPulseRate.Text = "Pulse Rate";
            this.lblPulseRate.Visible = false;
            // 
            // lblTemprature
            // 
            this.lblTemprature.AutoSize = true;
            this.lblTemprature.Location = new System.Drawing.Point(135, 232);
            this.lblTemprature.Name = "lblTemprature";
            this.lblTemprature.Size = new System.Drawing.Size(63, 13);
            this.lblTemprature.TabIndex = 11;
            this.lblTemprature.Text = "Temprature";
            this.lblTemprature.Visible = false;
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(135, 204);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(49, 13);
            this.lblPressure.TabIndex = 10;
            this.lblPressure.Text = "Pressure";
            this.lblPressure.Visible = false;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(135, 178);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(25, 13);
            this.lblBMI.TabIndex = 9;
            this.lblBMI.Text = "BMI";
            this.lblBMI.Visible = false;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(135, 91);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(49, 13);
            this.lblFullname.TabIndex = 8;
            this.lblFullname.Text = "Fullname";
            this.lblFullname.Visible = false;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(135, 63);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(50, 13);
            this.lblCardNo.TabIndex = 7;
            this.lblCardNo.Text = "Card No.";
            this.lblCardNo.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Respiratory Rate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Pulse Rate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Temprature";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Pressure";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "BMI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fullname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Card No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(491, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Diagnosis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(491, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Physical Examination";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(723, 711);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 34);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(495, 711);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(121, 34);
            this.btnSaveResult.TabIndex = 31;
            this.btnSaveResult.Text = "Save Result";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 583);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Medication Details(Drug name, Dosage, Qty)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "History";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Chief Compliant";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.rgvVitalSign);
            this.panel1.Controls.Add(this.btnAssigned);
            this.panel1.Controls.Add(this.dtpAssignedDate);
            this.panel1.Controls.Add(this.rgvPatientList);
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 1185);
            this.panel1.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::Onana_Hospital_Management_System.Properties.Resources.IMG_5512;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 702);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 316);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // rgvVitalSign
            // 
            this.rgvVitalSign.Location = new System.Drawing.Point(11, 400);
            this.rgvVitalSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            this.rgvVitalSign.MasterTemplate.AllowAddNewRow = false;
            this.rgvVitalSign.MasterTemplate.AllowColumnChooser = false;
            this.rgvVitalSign.MasterTemplate.AllowDeleteRow = false;
            this.rgvVitalSign.MasterTemplate.AllowDragToGroup = false;
            this.rgvVitalSign.MasterTemplate.AllowEditRow = false;
            this.rgvVitalSign.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvVitalSign.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvVitalSign.Name = "rgvVitalSign";
            this.rgvVitalSign.Size = new System.Drawing.Size(439, 289);
            this.rgvVitalSign.TabIndex = 8;
            this.rgvVitalSign.Text = "Patient List";
            this.rgvVitalSign.Click += new System.EventHandler(this.rgvVitalSign_Click);
            // 
            // btnAssigned
            // 
            this.btnAssigned.Location = new System.Drawing.Point(219, 12);
            this.btnAssigned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssigned.Name = "btnAssigned";
            this.btnAssigned.Size = new System.Drawing.Size(71, 27);
            this.btnAssigned.TabIndex = 9;
            this.btnAssigned.Text = "Assigned";
            this.btnAssigned.UseVisualStyleBackColor = true;
            this.btnAssigned.Click += new System.EventHandler(this.btnAssigned_Click);
            // 
            // dtpAssignedDate
            // 
            this.dtpAssignedDate.Location = new System.Drawing.Point(11, 15);
            this.dtpAssignedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAssignedDate.Name = "dtpAssignedDate";
            this.dtpAssignedDate.Size = new System.Drawing.Size(205, 21);
            this.dtpAssignedDate.TabIndex = 8;
            // 
            // rgvPatientList
            // 
            this.rgvPatientList.BackColor = System.Drawing.Color.Gainsboro;
            this.rgvPatientList.Location = new System.Drawing.Point(11, 47);
            this.rgvPatientList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            this.rgvPatientList.MasterTemplate.AllowAddNewRow = false;
            this.rgvPatientList.MasterTemplate.AllowColumnChooser = false;
            this.rgvPatientList.MasterTemplate.AllowDeleteRow = false;
            this.rgvPatientList.MasterTemplate.AllowDragToGroup = false;
            this.rgvPatientList.MasterTemplate.AllowEditRow = false;
            this.rgvPatientList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvPatientList.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvPatientList.Name = "rgvPatientList";
            this.rgvPatientList.Size = new System.Drawing.Size(439, 329);
            this.rgvPatientList.TabIndex = 7;
            this.rgvPatientList.Text = "Patient List";
            this.rgvPatientList.Click += new System.EventHandler(this.rgvPatientList_Click);
            // 
            // tbcConsultation
            // 
            this.tbcConsultation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcConsultation.Controls.Add(this.tbpNewConsult);
            this.tbcConsultation.Location = new System.Drawing.Point(9, 8);
            this.tbcConsultation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcConsultation.Name = "tbcConsultation";
            this.tbcConsultation.SelectedIndex = 0;
            this.tbcConsultation.Size = new System.Drawing.Size(3732, 1407);
            this.tbcConsultation.TabIndex = 0;
            // 
            // frmConsultation
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 852);
            this.Controls.Add(this.tbcConsultation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmConsultation.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Name = "frmConsultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultation_Load);
            this.tbpNewConsult.ResumeLayout(false);
            this.tbpNewConsult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isPictures)).EndInit();
            this.lblAge.ResumeLayout(false);
            this.lblAge.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvVitalSign.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvVitalSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPatientList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvPatientList)).EndInit();
            this.tbcConsultation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcConsultation;
        private Telerik.WinControls.UI.RadGridView rgvPatientList;
        private System.Windows.Forms.DateTimePicker dtpAssignedDate;
        private System.Windows.Forms.Button btnAssigned;
        private Telerik.WinControls.UI.RadGridView rgvVitalSign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblTemprature;
        private System.Windows.Forms.Label lblPulseRate;
        private System.Windows.Forms.Label lblRespiratoryRate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.GroupBox lblAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChiefCompliant;
        private System.Windows.Forms.TextBox txtHistory;
        public System.Windows.Forms.TextBox txtMedications;
        private System.Windows.Forms.TextBox txtPhysicalExamination;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TabPage tbpNewConsult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.Controls.ImageSlider isPictures;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnOrderLaboratory;
        private DevExpress.XtraEditors.SimpleButton btnPatientHistory;
        private DevExpress.XtraEditors.SimpleButton btnProcedure;
        private DevExpress.XtraEditors.SimpleButton btnMC;
        private DevExpress.XtraEditors.SimpleButton btnPrescription;
    }
}