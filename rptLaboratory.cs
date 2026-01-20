namespace Onana_Hospital_Management_System
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for rptLaboratory.
    /// </summary>
    public partial class rptLaboratory : Telerik.Reporting.Report
    {
        public rptLaboratory()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //chkUrgent.Value = urgent;
            //chkRoutine.Value = routine;
            pcbLogo.Value = Properties.Resources.output_onlinepngtools;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}