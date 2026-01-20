namespace Onana_Hospital_Management_System
{
    partial class frmReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.dbOHMSDataSet1 = new Onana_Hospital_Management_System.dbOHMSDataSet1();
            this.tblConsultationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblConsultationTableAdapter = new Onana_Hospital_Management_System.dbOHMSDataSet1TableAdapters.tblConsultationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbOHMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConsultationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbOHMSDataSet1
            // 
            this.dbOHMSDataSet1.DataSetName = "dbOHMSDataSet1";
            this.dbOHMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblConsultationBindingSource
            // 
            this.tblConsultationBindingSource.DataMember = "tblConsultation";
            this.tblConsultationBindingSource.DataSource = this.dbOHMSDataSet1;
            // 
            // tblConsultationTableAdapter
            // 
            this.tblConsultationTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbOHMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConsultationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer rptviewerMC;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblConsultationBindingSource;
        private dbOHMSDataSet1 dbOHMSDataSet1;
        private dbOHMSDataSet1TableAdapters.tblConsultationTableAdapter tblConsultationTableAdapter;
    }
}