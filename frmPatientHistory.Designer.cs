namespace Onana_Hospital_Management_System
{
    partial class frmPatientHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientHistory));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.Silver;
            this.accordionControl1.Appearance.AccordionControl.ForeColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Default.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accordionControl1.Appearance.Item.Default.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Item.Default.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Default.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlSeparator1});
            this.accordionControl1.FilterText = "Search here...";
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.accordionControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(1039, 710);
            this.accordionControl1.TabIndex = 0;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(861, 650);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 47);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPatientHistory
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 710);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.accordionControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmPatientHistory.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPatientHistory";
            this.Text = "Patient History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatientHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}