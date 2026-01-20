namespace Onana_Hospital_Management_System
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    public partial class Report1 : Telerik.Reporting.Report
    {
        clsSelect selectClass = new clsSelect();
        public Report1()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            var dt = selectClass.callmc();
            txtCardNo.Value = dt.Rows[0]["patid"].ToString().Trim();
            txtDiagnosis.Value = dt.Rows[0]["diagnosis"].ToString().Trim();
            txtAge.Value = dt.Rows[0]["age"].ToString().Trim();
            txtFullname.Value = dt.Rows[0]["fullname"].ToString().Trim();
            txtExaminedon.Value= DateTime.Parse( dt.Rows[0]["examinedon"].ToString()).Day +"/"+ DateTime.Parse(dt.Rows[0]["examinedon"].ToString()).Month+"/"+ DateTime.Parse(dt.Rows[0]["examinedon"].ToString()).Year;
            txtRecommendation.Value = dt.Rows[0]["recommendation"].ToString().Trim();
            txtRest.Value = dt.Rows[0]["rest"].ToString().Trim();
            txtDoctor.Value = dt.Rows[0]["doctor"].ToString().Trim();
            txtSpecialty.Value = dt.Rows[0]["specialty"].ToString().Trim();
            pcbLogo.Value = Properties.Resources.output_onlinepngtools;
            
            //pictureBox1.Value = Properties.Resources.output_onlinepngtools;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}