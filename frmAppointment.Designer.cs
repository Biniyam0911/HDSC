namespace Onana_Hospital_Management_System
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            this.cmbVisitType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbDiagnosisType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFilterCriteria = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPatientVisits = new System.Windows.Forms.GroupBox();
            this.dgvPatientVisits = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpPatientVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVisitType
            // 
            this.cmbVisitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisitType.FormattingEnabled = true;
            this.cmbVisitType.Items.AddRange(new object[] {
            "New",
            "New Repeat",
            "Repeat"});
            this.cmbVisitType.Location = new System.Drawing.Point(178, 452);
            this.cmbVisitType.Name = "cmbVisitType";
            this.cmbVisitType.Size = new System.Drawing.Size(292, 21);
            this.cmbVisitType.Sorted = true;
            this.cmbVisitType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visit Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Assignment Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(178, 485);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(293, 21);
            this.dtpStartDate.TabIndex = 3;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(623, 378);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(415, 128);
            this.txtNote.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Doctor";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(178, 376);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(293, 21);
            this.cmbDoctor.TabIndex = 7;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // cmbDiagnosisType
            // 
            this.cmbDiagnosisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnosisType.FormattingEnabled = true;
            this.cmbDiagnosisType.Location = new System.Drawing.Point(179, 416);
            this.cmbDiagnosisType.Name = "cmbDiagnosisType";
            this.cmbDiagnosisType.Size = new System.Drawing.Size(292, 21);
            this.cmbDiagnosisType.Sorted = true;
            this.cmbDiagnosisType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Diagnosis Type";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(636, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbFilterCriteria);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 86);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Patient";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Filter Criteria";
            // 
            // cmbFilterCriteria
            // 
            this.cmbFilterCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCriteria.FormattingEnabled = true;
            this.cmbFilterCriteria.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Phone No.",
            "Card No."});
            this.cmbFilterCriteria.Location = new System.Drawing.Point(93, 18);
            this.cmbFilterCriteria.Name = "cmbFilterCriteria";
            this.cmbFilterCriteria.Size = new System.Drawing.Size(247, 24);
            this.cmbFilterCriteria.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(359, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 227);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Note";
            // 
            // grpPatientVisits
            // 
            this.grpPatientVisits.Controls.Add(this.dgvPatientVisits);
            this.grpPatientVisits.Location = new System.Drawing.Point(623, 105);
            this.grpPatientVisits.Name = "grpPatientVisits";
            this.grpPatientVisits.Size = new System.Drawing.Size(414, 227);
            this.grpPatientVisits.TabIndex = 23;
            this.grpPatientVisits.TabStop = false;
            this.grpPatientVisits.Text = "Patient Visits";
            // 
            // dgvPatientVisits
            // 
            this.dgvPatientVisits.AllowUserToAddRows = false;
            this.dgvPatientVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientVisits.Location = new System.Drawing.Point(3, 17);
            this.dgvPatientVisits.Name = "dgvPatientVisits";
            this.dgvPatientVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientVisits.Size = new System.Drawing.Size(408, 207);
            this.dgvPatientVisits.TabIndex = 0;
            // 
            // frmAppointment
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 637);
            this.Controls.Add(this.grpPatientVisits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDiagnosisType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cmbVisitType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmAppointment.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appoint/Assign Patient - MediSphere";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpPatientVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVisitType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDoctor;
        public System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cmbDiagnosisType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFilterCriteria;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpPatientVisits;
        private System.Windows.Forms.DataGridView dgvPatientVisits;
    }
}