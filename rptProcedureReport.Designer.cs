namespace Onana_Hospital_Management_System
{
    partial class rptProcedureReport
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
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.doctorCaptionTextBox = new Telerik.Reporting.TextBox();
            this.doctorCaptionTextBox1 = new Telerik.Reporting.TextBox();
            this.invoicenoCaptionTextBox = new Telerik.Reporting.TextBox();
            this.itemCaptionTextBox = new Telerik.Reporting.TextBox();
            this.orderdateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.patnameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.totalpriceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.unitpriceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dsDoctors = new Telerik.Reporting.SqlDataSource();
            this.dsProcedureReport = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.doctorDataTextBox = new Telerik.Reporting.TextBox();
            this.invoicenoDataTextBox = new Telerik.Reporting.TextBox();
            this.itemDataTextBox = new Telerik.Reporting.TextBox();
            this.orderdateDataTextBox = new Telerik.Reporting.TextBox();
            this.patnameDataTextBox = new Telerik.Reporting.TextBox();
            this.totalpriceDataTextBox = new Telerik.Reporting.TextBox();
            this.unitpriceDataTextBox = new Telerik.Reporting.TextBox();
            this.txtTotalSales = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
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
            this.doctorCaptionTextBox1,
            this.invoicenoCaptionTextBox,
            this.itemCaptionTextBox,
            this.orderdateCaptionTextBox,
            this.patnameCaptionTextBox,
            this.totalpriceCaptionTextBox,
            this.unitpriceCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // doctorCaptionTextBox
            // 
            this.doctorCaptionTextBox.CanGrow = true;
            this.doctorCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.doctorCaptionTextBox.Name = "doctorCaptionTextBox";
            this.doctorCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorCaptionTextBox.StyleName = "Caption";
            this.doctorCaptionTextBox.Value = "Doctor";
            // 
            // doctorCaptionTextBox1
            // 
            this.doctorCaptionTextBox1.CanGrow = true;
            this.doctorCaptionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.948D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.doctorCaptionTextBox1.Name = "doctorCaptionTextBox1";
            this.doctorCaptionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorCaptionTextBox1.StyleName = "Caption";
            this.doctorCaptionTextBox1.Value = "Invoice No";
            // 
            // invoicenoCaptionTextBox
            // 
            this.invoicenoCaptionTextBox.CanGrow = true;
            this.invoicenoCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.875D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.invoicenoCaptionTextBox.Name = "invoicenoCaptionTextBox";
            this.invoicenoCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.invoicenoCaptionTextBox.StyleName = "Caption";
            this.invoicenoCaptionTextBox.Value = "Procedure";
            // 
            // itemCaptionTextBox
            // 
            this.itemCaptionTextBox.CanGrow = true;
            this.itemCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.803D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.itemCaptionTextBox.Name = "itemCaptionTextBox";
            this.itemCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.itemCaptionTextBox.StyleName = "Caption";
            this.itemCaptionTextBox.Value = "Quantity";
            // 
            // orderdateCaptionTextBox
            // 
            this.orderdateCaptionTextBox.CanGrow = true;
            this.orderdateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.73D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.orderdateCaptionTextBox.Name = "orderdateCaptionTextBox";
            this.orderdateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.orderdateCaptionTextBox.StyleName = "Caption";
            this.orderdateCaptionTextBox.Value = "Order Date";
            // 
            // patnameCaptionTextBox
            // 
            this.patnameCaptionTextBox.CanGrow = true;
            this.patnameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.657D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.patnameCaptionTextBox.Name = "patnameCaptionTextBox";
            this.patnameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.patnameCaptionTextBox.StyleName = "Caption";
            this.patnameCaptionTextBox.Value = "Patient";
            // 
            // totalpriceCaptionTextBox
            // 
            this.totalpriceCaptionTextBox.CanGrow = true;
            this.totalpriceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.584D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.totalpriceCaptionTextBox.Name = "totalpriceCaptionTextBox";
            this.totalpriceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.totalpriceCaptionTextBox.StyleName = "Caption";
            this.totalpriceCaptionTextBox.Value = "Total Price";
            // 
            // unitpriceCaptionTextBox
            // 
            this.unitpriceCaptionTextBox.CanGrow = true;
            this.unitpriceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.511D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.unitpriceCaptionTextBox.Name = "unitpriceCaptionTextBox";
            this.unitpriceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.unitpriceCaptionTextBox.StyleName = "Caption";
            this.unitpriceCaptionTextBox.Value = "Unit Price";
            // 
            // dsDoctors
            // 
            this.dsDoctors.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.dsDoctors.Name = "dsDoctors";
            this.dsDoctors.SelectCommand = "dbo.sp_get_select_doctors";
            this.dsDoctors.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // dsProcedureReport
            // 
            this.dsProcedureReport.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.dsProcedureReport.Name = "dsProcedureReport";
            this.dsProcedureReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date1", System.Data.DbType.Date, "= Parameters.date1.Value"));
            this.dsProcedureReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date2", System.Data.DbType.Date, "= Parameters.date2.Value"));
            this.dsProcedureReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@doctor", System.Data.DbType.String, "= Parameters.doctor.Value"));
            this.dsProcedureReport.SelectCommand = "dbo.sp_get_paid_procedure_for_report";
            this.dsProcedureReport.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
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
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.808D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.439D), Telerik.Reporting.Drawing.Unit.Inch(0.787D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Procedure Report";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox9,
            this.txtTotalSales});
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.doctorDataTextBox,
            this.invoicenoDataTextBox,
            this.itemDataTextBox,
            this.orderdateDataTextBox,
            this.patnameDataTextBox,
            this.totalpriceDataTextBox,
            this.unitpriceDataTextBox,
            this.textBox1});
            this.detail.Name = "detail";
            // 
            // doctorDataTextBox
            // 
            this.doctorDataTextBox.CanGrow = true;
            this.doctorDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.doctorDataTextBox.Name = "doctorDataTextBox";
            this.doctorDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.doctorDataTextBox.StyleName = "Data";
            this.doctorDataTextBox.Value = "= Fields.doctor";
            // 
            // invoicenoDataTextBox
            // 
            this.invoicenoDataTextBox.CanGrow = true;
            this.invoicenoDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.948D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.invoicenoDataTextBox.Name = "invoicenoDataTextBox";
            this.invoicenoDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.invoicenoDataTextBox.StyleName = "Data";
            this.invoicenoDataTextBox.Value = "= Fields.invoiceno";
            // 
            // itemDataTextBox
            // 
            this.itemDataTextBox.CanGrow = true;
            this.itemDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.itemDataTextBox.Name = "itemDataTextBox";
            this.itemDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.itemDataTextBox.StyleName = "Data";
            this.itemDataTextBox.Value = "= Fields.item";
            // 
            // orderdateDataTextBox
            // 
            this.orderdateDataTextBox.CanGrow = true;
            this.orderdateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.73D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.orderdateDataTextBox.Name = "orderdateDataTextBox";
            this.orderdateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.orderdateDataTextBox.StyleName = "Data";
            this.orderdateDataTextBox.Value = "= Fields.orderdate";
            // 
            // patnameDataTextBox
            // 
            this.patnameDataTextBox.CanGrow = true;
            this.patnameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.657D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.patnameDataTextBox.Name = "patnameDataTextBox";
            this.patnameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.patnameDataTextBox.StyleName = "Data";
            this.patnameDataTextBox.Value = "= Fields.patname";
            // 
            // totalpriceDataTextBox
            // 
            this.totalpriceDataTextBox.CanGrow = true;
            this.totalpriceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.584D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.totalpriceDataTextBox.Name = "totalpriceDataTextBox";
            this.totalpriceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.totalpriceDataTextBox.StyleName = "Data";
            this.totalpriceDataTextBox.Value = "= Fields.totalprice";
            // 
            // unitpriceDataTextBox
            // 
            this.unitpriceDataTextBox.CanGrow = true;
            this.unitpriceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.511D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.unitpriceDataTextBox.Name = "unitpriceDataTextBox";
            this.unitpriceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.unitpriceDataTextBox.StyleName = "Data";
            this.unitpriceDataTextBox.Value = "= Fields.unitprice";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Format = "{0:N0}";
            this.txtTotalSales.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2D), Telerik.Reporting.Drawing.Unit.Inch(0.081D));
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.txtTotalSales.Style.Font.Bold = true;
            this.txtTotalSales.Style.Font.Name = "Georgia";
            this.txtTotalSales.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtTotalSales.Style.Font.Underline = true;
            this.txtTotalSales.Value = "= Sum(Fields.quantity)";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9D), Telerik.Reporting.Drawing.Unit.Inch(0.081D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Style.Font.Name = "Georgia";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.textBox9.Style.Font.Underline = true;
            this.textBox9.Value = "Total no of Procedures";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.824D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.906D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "= Fields.quantity";
            // 
            // rptProcedureReport
            // 
            this.DataSource = this.dsProcedureReport;
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
            this.Name = "rptProcedureReport";
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
            reportParameter3.AvailableValues.DisplayMember = "fullname";
            reportParameter3.AvailableValues.ValueMember = "fullname";
            reportParameter3.Name = "doctor";
            reportParameter3.Text = "Doctor";
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

        private Telerik.Reporting.SqlDataSource dsProcedureReport;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox doctorCaptionTextBox;
        private Telerik.Reporting.TextBox doctorCaptionTextBox1;
        private Telerik.Reporting.TextBox invoicenoCaptionTextBox;
        private Telerik.Reporting.TextBox itemCaptionTextBox;
        private Telerik.Reporting.TextBox orderdateCaptionTextBox;
        private Telerik.Reporting.TextBox patnameCaptionTextBox;
        private Telerik.Reporting.TextBox totalpriceCaptionTextBox;
        private Telerik.Reporting.TextBox unitpriceCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox doctorDataTextBox;
        private Telerik.Reporting.TextBox invoicenoDataTextBox;
        private Telerik.Reporting.TextBox itemDataTextBox;
        private Telerik.Reporting.TextBox orderdateDataTextBox;
        private Telerik.Reporting.TextBox patnameDataTextBox;
        private Telerik.Reporting.TextBox totalpriceDataTextBox;
        private Telerik.Reporting.TextBox unitpriceDataTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.SqlDataSource dsDoctors;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox txtTotalSales;
        private Telerik.Reporting.TextBox textBox1;
    }
}