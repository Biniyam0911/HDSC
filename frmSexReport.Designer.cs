namespace Onana_Hospital_Management_System
{
    partial class frmSexReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSexReport));
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblSex = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.grpAgeReport = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.grpAgeReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(576, 18);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(19, 13);
            this.lblTo.TabIndex = 15;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(324, 21);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(31, 13);
            this.lblFrom.TabIndex = 14;
            this.lblFrom.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(623, 18);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(181, 21);
            this.dtpTo.TabIndex = 13;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(373, 18);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(183, 21);
            this.dtpFrom.TabIndex = 12;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(825, 14);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(107, 29);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(27, 17);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "Sex";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(61, 16);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(245, 21);
            this.cmbSex.TabIndex = 9;
            // 
            // grpAgeReport
            // 
            this.grpAgeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAgeReport.Controls.Add(this.reportViewer1);
            this.grpAgeReport.Location = new System.Drawing.Point(8, 66);
            this.grpAgeReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAgeReport.Name = "grpAgeReport";
            this.grpAgeReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAgeReport.Size = new System.Drawing.Size(924, 525);
            this.grpAgeReport.TabIndex = 8;
            this.grpAgeReport.TabStop = false;
            this.grpAgeReport.Text = "Age Report";
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(2, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(920, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmSexReport
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.grpAgeReport);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSexReport.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSexReport";
            this.Text = "Sex Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpAgeReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.GroupBox grpAgeReport;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}