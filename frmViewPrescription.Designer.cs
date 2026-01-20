namespace Onana_Hospital_Management_System
{
    partial class frmViewPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPrescription));
            this.lblFullname = new System.Windows.Forms.Label();
            this.cmbFullname = new System.Windows.Forms.ComboBox();
            this.grpProcedures = new System.Windows.Forms.GroupBox();
            this.dgvProcedures = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpPrescriptionDate = new System.Windows.Forms.DateTimePicker();
            this.grpProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedures)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(328, 24);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(50, 13);
            this.lblFullname.TabIndex = 5;
            this.lblFullname.Text = "FullName";
            // 
            // cmbFullname
            // 
            this.cmbFullname.FormattingEnabled = true;
            this.cmbFullname.Location = new System.Drawing.Point(424, 22);
            this.cmbFullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFullname.Name = "cmbFullname";
            this.cmbFullname.Size = new System.Drawing.Size(239, 21);
            this.cmbFullname.TabIndex = 4;
            this.cmbFullname.SelectedValueChanged += new System.EventHandler(this.cmbFullname_SelectoinChanged);
            // 
            // grpProcedures
            // 
            this.grpProcedures.Controls.Add(this.dgvProcedures);
            this.grpProcedures.Location = new System.Drawing.Point(9, 59);
            this.grpProcedures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProcedures.Name = "grpProcedures";
            this.grpProcedures.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProcedures.Size = new System.Drawing.Size(781, 342);
            this.grpProcedures.TabIndex = 3;
            this.grpProcedures.TabStop = false;
            this.grpProcedures.Text = "Procedures";
            // 
            // dgvProcedures
            // 
            this.dgvProcedures.AllowUserToAddRows = false;
            this.dgvProcedures.AllowUserToDeleteRows = false;
            this.dgvProcedures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcedures.Location = new System.Drawing.Point(2, 16);
            this.dgvProcedures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProcedures.Name = "dgvProcedures";
            this.dgvProcedures.ReadOnly = true;
            this.dgvProcedures.RowTemplate.Height = 24;
            this.dgvProcedures.Size = new System.Drawing.Size(777, 324);
            this.dgvProcedures.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(710, 17);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 28);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 24);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // dtpPrescriptionDate
            // 
            this.dtpPrescriptionDate.Location = new System.Drawing.Point(78, 23);
            this.dtpPrescriptionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPrescriptionDate.Name = "dtpPrescriptionDate";
            this.dtpPrescriptionDate.Size = new System.Drawing.Size(195, 21);
            this.dtpPrescriptionDate.TabIndex = 8;
            this.dtpPrescriptionDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmViewPrescription
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 418);
            this.Controls.Add(this.dtpPrescriptionDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.cmbFullname);
            this.Controls.Add(this.grpProcedures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmViewPrescription.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Prescription";
            this.Load += new System.EventHandler(this.frmViewPrescription_Load);
            this.grpProcedures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.ComboBox cmbFullname;
        private System.Windows.Forms.GroupBox grpProcedures;
        private System.Windows.Forms.DataGridView dgvProcedures;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpPrescriptionDate;
    }
}