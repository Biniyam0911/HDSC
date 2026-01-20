namespace Onana_Hospital_Management_System
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for rptPrescription.
    /// </summary>
    public partial class rptPrescription : Telerik.Reporting.Report
    {
        public rptPrescription()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            chkOutPatient.Value = true;
            pcbLogo.Value = Properties.Resources.output_onlinepngtools;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}