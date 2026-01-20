using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.ReportViewer.WinForms;
using Telerik.WinControls.UI;
using DevExpress.XtraEditors;

namespace Onana_Hospital_Management_System
{
    public partial class MedicalCertificate : XtraForm
    {
        //private IContainer components = null;
        //clsSelect selectclass = new clsSelect();
       // private ReportViewer reportViewer1;       
        public MedicalCertificate()
        {
            InitializeComponent();
            


            //this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            //((System.ComponentModel.ISupportInitialize)this).BeginInit();
            //base.SuspendLayout();
            //this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            //this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.Size = new System.Drawing.Size(1241, 799);
            //this.reportViewer1.TabIndex = 0;
            //this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            //base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
            //base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //base.ClientSize = new System.Drawing.Size(1241, 799);
            //base.Controls.Add(this.reportViewer1);
            //base.Margin = new System.Windows.Forms.Padding(4);
            //base.Name = "MedicalCertificate";
            //base.RootElement.ApplyShapeToControl = true;
            //this.Text = "MedicalCertificate";
            //base.ThemeName = "TelerikMetroBlue";
            //base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //((System.ComponentModel.ISupportInitialize)this).EndInit();
            //base.ResumeLayout(false);
        }

      

        //private void InitializeComponent()
        //{
           
        //}
        //public MedicalCertificate()
        //{
        //    InitializeComponent();
            

        //    this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
        //    ((System.ComponentModel.ISupportInitialize)this).BeginInit();
        //    base.SuspendLayout();
        //    this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.reportViewer1.Location = new System.Drawing.Point(0, 0);
        //    this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        //    this.reportViewer1.Name = "reportViewer1";
        //    this.reportViewer1.Size = new System.Drawing.Size(1241, 799);
        //    this.reportViewer1.TabIndex = 0;
        //    this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
        //    base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
        //    base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    base.ClientSize = new System.Drawing.Size(1241, 799);
        //    base.Controls.Add(this.reportViewer1);
        //    base.Margin = new System.Windows.Forms.Padding(4);
        //    base.Name = "MedicalCertificate";
        //    //base.RootElement.ApplyShapeToControl = true;
        //    this.Text = "MedicalCertificate";
        //    //base.ThemeName = "TelerikMetroBlue";
        //    base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        //    ((System.ComponentModel.ISupportInitialize)this).EndInit();
        //    base.ResumeLayout(false);
        //}

        private void MedicalCertificate_Load(object sender, EventArgs e)
        {
            Report1 mc = new Report1();
            reportViewer1.ReportSource = mc;
            reportViewer1.RefreshReport();
            
        }

        private void rptMedicalCertificate_Load(object sender, EventArgs e)
        {

        }
    }
}
