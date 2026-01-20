namespace Onana_Hospital_Management_System
{
    partial class rptDiagnosisReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.doctorCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.diagnosisCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dsDiagnosisReport = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.doctorDataTextBox = new Telerik.Reporting.TextBox();
            this.dateDataTextBox = new Telerik.Reporting.TextBox();
            this.diagnosisDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.doctorCaptionTextBox,
            this.dateCaptionTextBox,
            this.diagnosisCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // doctorCaptionTextBox
            // 
            this.doctorCaptionTextBox.CanGrow = true;
            this.doctorCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.doctorCaptionTextBox.Name = "doctorCaptionTextBox";
            this.doctorCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.125D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorCaptionTextBox.StyleName = "Caption";
            this.doctorCaptionTextBox.Value = "Doctor";
            // 
            // dateCaptionTextBox
            // 
            this.dateCaptionTextBox.CanGrow = true;
            this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.167D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.dateCaptionTextBox.Name = "dateCaptionTextBox";
            this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.125D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.dateCaptionTextBox.StyleName = "Caption";
            this.dateCaptionTextBox.Value = "Date";
            // 
            // diagnosisCaptionTextBox
            // 
            this.diagnosisCaptionTextBox.Action = null;
            this.diagnosisCaptionTextBox.CanGrow = true;
            this.diagnosisCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.312D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.diagnosisCaptionTextBox.Name = "diagnosisCaptionTextBox";
            this.diagnosisCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.125D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.diagnosisCaptionTextBox.StyleName = "Caption";
            this.diagnosisCaptionTextBox.Value = "Diagnosis";
            // 
            // dsDiagnosisReport
            // 
            this.dsDiagnosisReport.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.dsDiagnosisReport.Name = "dsDiagnosisReport";
            this.dsDiagnosisReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date2", System.Data.DbType.Date, "= Parameters.date2.Value"));
            this.dsDiagnosisReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date1", System.Data.DbType.Date, "= Parameters.date1.Value"));
            this.dsDiagnosisReport.SelectCommand = "dbo.sp_get_diagnosis_report";
            this.dsDiagnosisReport.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.pageHeader.Name = "pageHeader";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.198D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.24D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.198D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.808D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.458D), Telerik.Reporting.Drawing.Unit.Inch(0.787D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Diagnosis Report";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.doctorDataTextBox,
            this.dateDataTextBox,
            this.diagnosisDataTextBox});
            this.detail.Name = "detail";
            // 
            // doctorDataTextBox
            // 
            this.doctorDataTextBox.CanGrow = true;
            this.doctorDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.doctorDataTextBox.Name = "doctorDataTextBox";
            this.doctorDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.125D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorDataTextBox.StyleName = "Data";
            this.doctorDataTextBox.Value = "= Fields.Doctor";
            // 
            // dateDataTextBox
            // 
            this.dateDataTextBox.CanGrow = true;
            this.dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.167D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.dateDataTextBox.Name = "dateDataTextBox";
            this.dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.125D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.dateDataTextBox.StyleName = "Data";
            this.dateDataTextBox.Value = "= Fields.Date";
            // 
            // diagnosisDataTextBox
            // 
            this.diagnosisDataTextBox.CanGrow = true;
            this.diagnosisDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.312D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.diagnosisDataTextBox.Name = "diagnosisDataTextBox";
            this.diagnosisDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.125D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.diagnosisDataTextBox.StyleName = "Data";
            this.diagnosisDataTextBox.Value = "= Fields.Diagnosis";
            // 
            // rptDiagnosisReport
            // 
            this.DataSource = this.dsDiagnosisReport;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "rptDiagnosisReport";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "date1";
            reportParameter1.Text = "From";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter1.Visible = true;
            reportParameter2.AutoRefresh = true;
            reportParameter2.Name = "date2";
            reportParameter2.Text = "To";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter2.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Diagnosis", Telerik.Reporting.SortDirection.Asc));
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption"),
            new Telerik.Reporting.Drawing.StyleSelector("SubTotalCaption"),
            new Telerik.Reporting.Drawing.StyleSelector("GrandTotalCaption")});
            styleRule3.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule3.Style.Color = System.Drawing.Color.White;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data"),
            new Telerik.Reporting.Drawing.StyleSelector("TotalData")});
            styleRule4.Style.Color = System.Drawing.Color.Black;
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Color = System.Drawing.Color.Black;
            styleRule5.Style.Font.Name = "Tahoma";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.458D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dsDiagnosisReport;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox doctorCaptionTextBox;
        private Telerik.Reporting.TextBox dateCaptionTextBox;
        private Telerik.Reporting.TextBox diagnosisCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox doctorDataTextBox;
        private Telerik.Reporting.TextBox dateDataTextBox;
        private Telerik.Reporting.TextBox diagnosisDataTextBox;
        private Telerik.Reporting.DetailSection detail;
    }
}