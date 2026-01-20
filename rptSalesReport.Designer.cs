namespace Onana_Hospital_Management_System
{
    partial class rptSalesReport
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
            this.invoiceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.fullnameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.descriptionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.quantityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.dsCashiers = new Telerik.Reporting.SqlDataSource();
            this.dsSalesReport = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.txtTotalSales = new Telerik.Reporting.TextBox();
            this.lblTotalSales = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.invoiceDataTextBox = new Telerik.Reporting.TextBox();
            this.fullnameDataTextBox = new Telerik.Reporting.TextBox();
            this.descriptionDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.quantityDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.cashierCaptionTextBox = new Telerik.Reporting.TextBox();
            this.cashierDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.txtFrom = new Telerik.Reporting.TextBox();
            this.txtTo = new Telerik.Reporting.TextBox();
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
            this.invoiceCaptionTextBox,
            this.fullnameCaptionTextBox,
            this.descriptionCaptionTextBox,
            this.textBox1,
            this.quantityCaptionTextBox,
            this.textBox2,
            this.textBox3});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // invoiceCaptionTextBox
            // 
            this.invoiceCaptionTextBox.CanGrow = true;
            this.invoiceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.invoiceCaptionTextBox.Name = "invoiceCaptionTextBox";
            this.invoiceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.invoiceCaptionTextBox.StyleName = "Caption";
            this.invoiceCaptionTextBox.Value = "Invoice";
            // 
            // fullnameCaptionTextBox
            // 
            this.fullnameCaptionTextBox.CanGrow = true;
            this.fullnameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.081D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.fullnameCaptionTextBox.Name = "fullnameCaptionTextBox";
            this.fullnameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameCaptionTextBox.StyleName = "Caption";
            this.fullnameCaptionTextBox.Value = "Fullname";
            // 
            // descriptionCaptionTextBox
            // 
            this.descriptionCaptionTextBox.CanGrow = true;
            this.descriptionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.14D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.descriptionCaptionTextBox.Name = "descriptionCaptionTextBox";
            this.descriptionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.descriptionCaptionTextBox.StyleName = "Caption";
            this.descriptionCaptionTextBox.Value = "Description";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Unit Price";
            // 
            // quantityCaptionTextBox
            // 
            this.quantityCaptionTextBox.CanGrow = true;
            this.quantityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.26D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.quantityCaptionTextBox.Name = "quantityCaptionTextBox";
            this.quantityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.64D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.quantityCaptionTextBox.StyleName = "Caption";
            this.quantityCaptionTextBox.Value = "Quantity";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox2.StyleName = "Caption";
            this.textBox2.Value = "Total Price";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.939D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.479D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.StyleName = "Caption";
            this.textBox3.Value = "Paid Date";
            // 
            // dsCashiers
            // 
            this.dsCashiers.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.dsCashiers.Name = "dsCashiers";
            this.dsCashiers.SelectCommand = "dbo.sp_get_select_cashiers";
            this.dsCashiers.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // dsSalesReport
            // 
            this.dsSalesReport.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.dsSalesReport.Name = "dsSalesReport";
            this.dsSalesReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date1", System.Data.DbType.Date, "= Parameters.date1.Value"));
            this.dsSalesReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date2", System.Data.DbType.Date, "= Parameters.date2.Value"));
            this.dsSalesReport.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@cashier", System.Data.DbType.String, "= Parameters.cashier.Value"));
            this.dsSalesReport.SelectCommand = "dbo.sp_get_sales_report";
            this.dsSalesReport.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.397D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "Sales Report";
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
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.747D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtTotalSales,
            this.lblTotalSales});
            this.reportFooter.Name = "reportFooter";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Format = "{0:C2}";
            this.txtTotalSales.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.584D), Telerik.Reporting.Drawing.Unit.Inch(0.547D));
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.txtTotalSales.Style.Font.Bold = true;
            this.txtTotalSales.Style.Font.Name = "Georgia";
            this.txtTotalSales.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.txtTotalSales.Style.Font.Underline = true;
            this.txtTotalSales.Value = "= Sum(Fields.[Total Price])";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.364D), Telerik.Reporting.Drawing.Unit.Inch(0.547D));
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.lblTotalSales.Style.Font.Bold = true;
            this.lblTotalSales.Style.Font.Name = "Georgia";
            this.lblTotalSales.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12D);
            this.lblTotalSales.Style.Font.Underline = true;
            this.lblTotalSales.Value = "Total Sales";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceDataTextBox,
            this.fullnameDataTextBox,
            this.descriptionDataTextBox,
            this.textBox6,
            this.quantityDataTextBox,
            this.textBox7,
            this.textBox8});
            this.detail.Name = "detail";
            // 
            // invoiceDataTextBox
            // 
            this.invoiceDataTextBox.CanGrow = true;
            this.invoiceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.invoiceDataTextBox.Name = "invoiceDataTextBox";
            this.invoiceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.invoiceDataTextBox.StyleName = "Data";
            this.invoiceDataTextBox.Value = "= Fields.Invoice";
            // 
            // fullnameDataTextBox
            // 
            this.fullnameDataTextBox.CanGrow = true;
            this.fullnameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.081D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.fullnameDataTextBox.Name = "fullnameDataTextBox";
            this.fullnameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameDataTextBox.StyleName = "Data";
            this.fullnameDataTextBox.Value = "= Fields.Fullname";
            // 
            // descriptionDataTextBox
            // 
            this.descriptionDataTextBox.CanGrow = true;
            this.descriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.14D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.descriptionDataTextBox.Name = "descriptionDataTextBox";
            this.descriptionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.descriptionDataTextBox.StyleName = "Data";
            this.descriptionDataTextBox.Value = "= Fields.Description";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "= Fields.[Unit Price]";
            // 
            // quantityDataTextBox
            // 
            this.quantityDataTextBox.CanGrow = true;
            this.quantityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.26D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.quantityDataTextBox.Name = "quantityDataTextBox";
            this.quantityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.64D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.quantityDataTextBox.StyleName = "Data";
            this.quantityDataTextBox.Value = "= Fields.Quantity";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = true;
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox7.StyleName = "Data";
            this.textBox7.Value = "= Fields.[Total Price]";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.939D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.479D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "= Fields.[Paid Date]";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.029D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.cashierCaptionTextBox,
            this.cashierDataTextBox,
            this.textBox4,
            this.textBox5,
            this.txtFrom,
            this.txtTo});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.439D), Telerik.Reporting.Drawing.Unit.Inch(0.787D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Sales Report From                    To";
            // 
            // cashierCaptionTextBox
            // 
            this.cashierCaptionTextBox.CanGrow = true;
            this.cashierCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.808D));
            this.cashierCaptionTextBox.Name = "cashierCaptionTextBox";
            this.cashierCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.cashierCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.cashierCaptionTextBox.StyleName = "Caption";
            this.cashierCaptionTextBox.Value = "Cashier:";
            // 
            // cashierDataTextBox
            // 
            this.cashierDataTextBox.CanGrow = true;
            this.cashierDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.875D), Telerik.Reporting.Drawing.Unit.Inch(0.808D));
            this.cashierDataTextBox.Name = "cashierDataTextBox";
            this.cashierDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.cashierDataTextBox.StyleName = "Data";
            this.cashierDataTextBox.Value = "= Fields.Cashier";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.73D), Telerik.Reporting.Drawing.Unit.Inch(0.808D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox4.StyleName = "Caption";
            this.textBox4.Value = "Paid Date:";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.584D), Telerik.Reporting.Drawing.Unit.Inch(0.808D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "= Fields.[Paid Date]";
            // 
            // txtFrom
            // 
            this.txtFrom.Format = "{0:d}";
            this.txtFrom.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.324D));
            this.txtFrom.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.txtFrom.Style.Font.Bold = true;
            this.txtFrom.Style.Font.Name = "Georgia";
            this.txtFrom.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.txtFrom.Value = "= Parameters.date1.Value";
            // 
            // txtTo
            // 
            this.txtTo.Format = "{0:d}";
            this.txtTo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.399D), Telerik.Reporting.Drawing.Unit.Inch(0.324D));
            this.txtTo.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.txtTo.Style.Font.Bold = true;
            this.txtTo.Style.Font.Name = "Georgia";
            this.txtTo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.txtTo.Value = "= Parameters.date2.Value";
            // 
            // rptSalesReport
            // 
            this.DataSource = this.dsSalesReport;
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
            this.Name = "rptSalesReport";
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
            reportParameter3.AvailableValues.DataSource = this.dsCashiers;
            reportParameter3.AvailableValues.DisplayMember = "cashier";
            reportParameter3.AvailableValues.ValueMember = "cashier";
            reportParameter3.Name = "cashier";
            reportParameter3.Text = "Cashier";
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

        private Telerik.Reporting.SqlDataSource dsSalesReport;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox invoiceCaptionTextBox;
        private Telerik.Reporting.TextBox fullnameCaptionTextBox;
        private Telerik.Reporting.TextBox descriptionCaptionTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox quantityCaptionTextBox;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox invoiceDataTextBox;
        private Telerik.Reporting.TextBox fullnameDataTextBox;
        private Telerik.Reporting.TextBox descriptionDataTextBox;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox quantityDataTextBox;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.SqlDataSource dsCashiers;
        private Telerik.Reporting.TextBox txtTotalSales;
        private Telerik.Reporting.TextBox lblTotalSales;
        private Telerik.Reporting.TextBox txtTo;
        private Telerik.Reporting.TextBox txtFrom;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox cashierDataTextBox;
        private Telerik.Reporting.TextBox cashierCaptionTextBox;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
    }
}