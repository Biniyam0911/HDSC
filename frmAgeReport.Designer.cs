namespace Onana_Hospital_Management_System
{
    partial class frmAgeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgeReport));
            this.grpAgeReport = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.cmbAgeRange = new System.Windows.Forms.ComboBox();
            this.lblAgeRange = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.grpAgeReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAgeReport
            // 
            this.grpAgeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAgeReport.Controls.Add(this.reportViewer1);
            this.grpAgeReport.Location = new System.Drawing.Point(6, 74);
            this.grpAgeReport.Margin = new System.Windows.Forms.Padding(2);
            this.grpAgeReport.Name = "grpAgeReport";
            this.grpAgeReport.Padding = new System.Windows.Forms.Padding(2);
            this.grpAgeReport.Size = new System.Drawing.Size(926, 514);
            this.grpAgeReport.TabIndex = 0;
            this.grpAgeReport.TabStop = false;
            this.grpAgeReport.Text = "Age Report";
            this.grpAgeReport.Enter += new System.EventHandler(this.grpAgeReport_Enter);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(2, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(922, 496);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbAgeRange
            // 
            this.cmbAgeRange.FormattingEnabled = true;
            this.cmbAgeRange.Items.AddRange(new object[] {
            "<1",
            "1-4",
            "5-14",
            "15-29",
            "30-64",
            ">65"});
            this.cmbAgeRange.Location = new System.Drawing.Point(122, 25);
            this.cmbAgeRange.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAgeRange.Name = "cmbAgeRange";
            this.cmbAgeRange.Size = new System.Drawing.Size(185, 21);
            this.cmbAgeRange.TabIndex = 1;
            this.cmbAgeRange.SelectedIndexChanged += new System.EventHandler(this.cmbAgeRange_SelectedIndexChanged);
            // 
            // lblAgeRange
            // 
            this.lblAgeRange.AutoSize = true;
            this.lblAgeRange.Location = new System.Drawing.Point(25, 25);
            this.lblAgeRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgeRange.Name = "lblAgeRange";
            this.lblAgeRange.Size = new System.Drawing.Size(60, 13);
            this.lblAgeRange.TabIndex = 2;
            this.lblAgeRange.Text = "Age Range";
            this.lblAgeRange.Click += new System.EventHandler(this.lblAgeRange_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(823, 21);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(107, 29);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(371, 26);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(183, 21);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(621, 26);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(181, 21);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(322, 29);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(31, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(574, 26);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(19, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // frmAgeReport
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 596);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblAgeRange);
            this.Controls.Add(this.cmbAgeRange);
            this.Controls.Add(this.grpAgeReport);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmAgeReport.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgeReport";
            this.Text = "Age Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAgeReport_Load);
            this.grpAgeReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgeReport;
        private System.Windows.Forms.ComboBox cmbAgeRange;
        private System.Windows.Forms.Label lblAgeRange;
        private System.Windows.Forms.Button btnShow;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
    }
}