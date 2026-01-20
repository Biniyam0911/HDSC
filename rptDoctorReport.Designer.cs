namespace Onana_Hospital_Management_System
{
    partial class rptDoctorReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.dsDoctors = new Telerik.Reporting.SqlDataSource();
            this.fullnameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.descriptionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.quantityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.invoiceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.doctorCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dsDoctorReport = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.doctorCaptionTextBox1 = new Telerik.Reporting.TextBox();
            this.doctorDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.txtTotalSales = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.fullnameDataTextBox = new Telerik.Reporting.TextBox();
            this.descriptionDataTextBox = new Telerik.Reporting.TextBox();
            this.quantityDataTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDataTextBox = new Telerik.Reporting.TextBox();
            this.doctorDataTextBox1 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dsDoctors
            // 
            this.dsDoctors.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.dsDoctors.Name = "dsDoctors";
            this.dsDoctors.SelectCommand = "dbo.sp_get_select_doctors_for_report";
            this.dsDoctors.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // fullnameCaptionTextBox
            // 
            this.fullnameCaptionTextBox.CanGrow = true;
            this.fullnameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(1.219D));
            this.fullnameCaptionTextBox.Name = "fullnameCaptionTextBox";
            this.fullnameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.279D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameCaptionTextBox.StyleName = "Caption";
            this.fullnameCaptionTextBox.Value = "Fullname";
            // 
            // descriptionCaptionTextBox
            // 
            this.descriptionCaptionTextBox.CanGrow = true;
            this.descriptionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4D), Telerik.Reporting.Drawing.Unit.Inch(1.219D));
            this.descriptionCaptionTextBox.Name = "descriptionCaptionTextBox";
            this.descriptionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.descriptionCaptionTextBox.StyleName = "Caption";
            this.descriptionCaptionTextBox.Value = "Description";
            // 
            // quantityCaptionTextBox
            // 
            this.quantityCaptionTextBox.CanGrow = true;
            this.quantityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6D), Telerik.Reporting.Drawing.Unit.Inch(1.219D));
            this.quantityCaptionTextBox.Name = "quantityCaptionTextBox";
            this.quantityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.quantityCaptionTextBox.StyleName = "Caption";
            this.quantityCaptionTextBox.Value = "Quantity";
            // 
            // invoiceCaptionTextBox
            // 
            this.invoiceCaptionTextBox.CanGrow = true;
            this.invoiceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.584D), Telerik.Reporting.Drawing.Unit.Inch(1.219D));
            this.invoiceCaptionTextBox.Name = "invoiceCaptionTextBox";
            this.invoiceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.invoiceCaptionTextBox.StyleName = "Caption";
            this.invoiceCaptionTextBox.Value = "Invoice";
            // 
            // doctorCaptionTextBox
            // 
            this.doctorCaptionTextBox.CanGrow = true;
            this.doctorCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.511D), Telerik.Reporting.Drawing.Unit.Inch(1.219D));
            this.doctorCaptionTextBox.Name = "doctorCaptionTextBox";
            this.doctorCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorCaptionTextBox.StyleName = "Caption";
            this.doctorCaptionTextBox.Value = "Doctor";
            // 
            // dsDoctorReport
            // 
            this.dsDoctorReport.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.dsDoctorReport.Name = "dsDoctorReport";
            this.dsDoctorReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date1", System.Data.DbType.Date, "= Parameters.date1.Value"));
            this.dsDoctorReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date2", System.Data.DbType.Date, "= Parameters.date2.Value"));
            this.dsDoctorReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@doctor", System.Data.DbType.String, "= Parameters.doctor.Value"));
            this.dsDoctorReport.SelectCommand = "dbo.sp_get_doctor_report";
            this.dsDoctorReport.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
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
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.688D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.73D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.688D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.419D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.doctorCaptionTextBox1,
            this.doctorDataTextBox,
            this.fullnameCaptionTextBox,
            this.descriptionCaptionTextBox,
            this.quantityCaptionTextBox,
            this.invoiceCaptionTextBox,
            this.doctorCaptionTextBox,
            this.textBox1});
            this.reportHeader.Name = "reportHeader";
            // 
            // doctorCaptionTextBox1
            // 
            this.doctorCaptionTextBox1.CanGrow = true;
            this.doctorCaptionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.519D));
            this.doctorCaptionTextBox1.Name = "doctorCaptionTextBox1";
            this.doctorCaptionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.679D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorCaptionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.doctorCaptionTextBox1.StyleName = "Caption";
            this.doctorCaptionTextBox1.Value = "Doctor:";
            // 
            // doctorDataTextBox
            // 
            this.doctorDataTextBox.CanGrow = true;
            this.doctorDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.7D), Telerik.Reporting.Drawing.Unit.Inch(0.525D));
            this.doctorDataTextBox.Name = "doctorDataTextBox";
            this.doctorDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.688D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorDataTextBox.StyleName = "Data";
            this.doctorDataTextBox.Value = "= Fields.Doctor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.679D), Telerik.Reporting.Drawing.Unit.Inch(0.319D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.textBox1.Value = "Doctor Report";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.285D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox9,
            this.txtTotalSales});
            this.reportFooter.Name = "reportFooter";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8D), Telerik.Reporting.Drawing.Unit.Inch(0.085D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Style.Font.Name = "Georgia";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox9.Style.Font.Underline = true;
            this.textBox9.Value = "Total no of Patients";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Format = "{0:N0}";
            this.txtTotalSales.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8D), Telerik.Reporting.Drawing.Unit.Inch(0.085D));
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.txtTotalSales.Style.Font.Bold = true;
            this.txtTotalSales.Style.Font.Name = "Georgia";
            this.txtTotalSales.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtTotalSales.Style.Font.Underline = true;
            this.txtTotalSales.Value = "= Sum(Fields.[Quantity])";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.fullnameDataTextBox,
            this.descriptionDataTextBox,
            this.quantityDataTextBox,
            this.invoiceDataTextBox,
            this.doctorDataTextBox1});
            this.detail.Name = "detail";
            // 
            // fullnameDataTextBox
            // 
            this.fullnameDataTextBox.CanGrow = true;
            this.fullnameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.fullnameDataTextBox.Name = "fullnameDataTextBox";
            this.fullnameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.279D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameDataTextBox.StyleName = "Data";
            this.fullnameDataTextBox.Value = "= Fields.Fullname";
            // 
            // descriptionDataTextBox
            // 
            this.descriptionDataTextBox.CanGrow = true;
            this.descriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.descriptionDataTextBox.Name = "descriptionDataTextBox";
            this.descriptionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.descriptionDataTextBox.StyleName = "Data";
            this.descriptionDataTextBox.Value = "= Fields.Description";
            // 
            // quantityDataTextBox
            // 
            this.quantityDataTextBox.CanGrow = true;
            this.quantityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.quantityDataTextBox.Name = "quantityDataTextBox";
            this.quantityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.quantityDataTextBox.StyleName = "Data";
            this.quantityDataTextBox.Value = "= Fields.Quantity";
            // 
            // invoiceDataTextBox
            // 
            this.invoiceDataTextBox.CanGrow = true;
            this.invoiceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.584D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.invoiceDataTextBox.Name = "invoiceDataTextBox";
            this.invoiceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.invoiceDataTextBox.StyleName = "Data";
            this.invoiceDataTextBox.Value = "= Fields.Invoice";
            // 
            // doctorDataTextBox1
            // 
            this.doctorDataTextBox1.CanGrow = true;
            this.doctorDataTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.511D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.doctorDataTextBox1.Name = "doctorDataTextBox1";
            this.doctorDataTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorDataTextBox1.StyleName = "Data";
            this.doctorDataTextBox1.Value = "= Fields.Doctor";
            // 
            // rptDoctorReport
            // 
            this.DataSource = this.dsDoctorReport;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "rptDoctorReport";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.Name = "date1";
            reportParameter1.Text = "From";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter1.Visible = true;
            reportParameter2.Name = "date2";
            reportParameter2.Text = "To";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter2.Visible = true;
            reportParameter3.AvailableValues.DataSource = this.dsDoctors;
            reportParameter3.AvailableValues.DisplayMember = "Doctor";
            reportParameter3.AvailableValues.ValueMember = "Doctor";
            reportParameter3.Name = "doctor";
            reportParameter3.Text = "doctor";
            reportParameter3.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(7.439D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dsDoctorReport;
        private Telerik.Reporting.SqlDataSource dsDoctors;
        private Telerik.Reporting.TextBox fullnameCaptionTextBox;
        private Telerik.Reporting.TextBox descriptionCaptionTextBox;
        private Telerik.Reporting.TextBox quantityCaptionTextBox;
        private Telerik.Reporting.TextBox invoiceCaptionTextBox;
        private Telerik.Reporting.TextBox doctorCaptionTextBox;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox doctorCaptionTextBox1;
        private Telerik.Reporting.TextBox doctorDataTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox fullnameDataTextBox;
        private Telerik.Reporting.TextBox descriptionDataTextBox;
        private Telerik.Reporting.TextBox quantityDataTextBox;
        private Telerik.Reporting.TextBox invoiceDataTextBox;
        private Telerik.Reporting.TextBox doctorDataTextBox1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox txtTotalSales;
        private Telerik.Reporting.TextBox textBox1;
    }
}