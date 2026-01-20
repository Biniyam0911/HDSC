namespace Onana_Hospital_Management_System
{
    partial class rptSexReport
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
            this.ageCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.fullnameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.sexCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.ageDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.fullnameDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.sexDataTextBox = new Telerik.Reporting.TextBox();
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
            this.ageCaptionTextBox,
            this.textBox1,
            this.textBox2,
            this.fullnameCaptionTextBox,
            this.textBox3,
            this.sexCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // ageCaptionTextBox
            // 
            this.ageCaptionTextBox.CanGrow = true;
            this.ageCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.ageCaptionTextBox.Name = "ageCaptionTextBox";
            this.ageCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.979D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.ageCaptionTextBox.StyleName = "Caption";
            this.ageCaptionTextBox.Value = "Age";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.215D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Card No";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.221D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.679D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox2.StyleName = "Caption";
            this.textBox2.Value = "Consult Date";
            // 
            // fullnameCaptionTextBox
            // 
            this.fullnameCaptionTextBox.CanGrow = true;
            this.fullnameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.fullnameCaptionTextBox.Name = "fullnameCaptionTextBox";
            this.fullnameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameCaptionTextBox.StyleName = "Caption";
            this.fullnameCaptionTextBox.Value = "Fullname";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.StyleName = "Caption";
            this.textBox3.Value = "Phone No";
            // 
            // sexCaptionTextBox
            // 
            this.sexCaptionTextBox.CanGrow = true;
            this.sexCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.sexCaptionTextBox.Name = "sexCaptionTextBox";
            this.sexCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.997D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.sexCaptionTextBox.StyleName = "Caption";
            this.sexCaptionTextBox.Value = "Sex";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@sex", System.Data.DbType.String, "= Parameters.sex.Value"));
            this.sqlDataSource1.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@datefrom", System.Data.DbType.DateTime, "= Parameters.datefrom.Value"));
            this.sqlDataSource1.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@dateto", System.Data.DbType.DateTime, "= Parameters.dateto.Value"));
            this.sqlDataSource1.SelectCommand = "dbo.sp_get_sex_report";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
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
            this.titleTextBox.Value = "Sex Report";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.311D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.ageDataTextBox,
            this.textBox4,
            this.textBox5,
            this.fullnameDataTextBox,
            this.textBox6,
            this.sexDataTextBox});
            this.detail.Name = "detail";
            // 
            // ageDataTextBox
            // 
            this.ageDataTextBox.CanGrow = true;
            this.ageDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.ageDataTextBox.Name = "ageDataTextBox";
            this.ageDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.979D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.ageDataTextBox.StyleName = "Data";
            this.ageDataTextBox.Value = "= Fields.Age";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.215D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= Fields.[Card No]";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.221D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.679D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "= Fields.[Consult Date]";
            // 
            // fullnameDataTextBox
            // 
            this.fullnameDataTextBox.CanGrow = true;
            this.fullnameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.fullnameDataTextBox.Name = "fullnameDataTextBox";
            this.fullnameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameDataTextBox.StyleName = "Data";
            this.fullnameDataTextBox.Value = "= Fields.Fullname";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "= Fields.[Phone No]";
            // 
            // sexDataTextBox
            // 
            this.sexDataTextBox.CanGrow = true;
            this.sexDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.sexDataTextBox.Name = "sexDataTextBox";
            this.sexDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.998D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.sexDataTextBox.StyleName = "Data";
            this.sexDataTextBox.Value = "= Fields.Sex";
            // 
            // rptSexReport
            // 
            this.DataSource = this.sqlDataSource1;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "rptSexReport";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.Name = "sex";
            reportParameter1.Text = "sex";
            reportParameter2.Name = "datefrom";
            reportParameter2.Text = "datefrom";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter3.Name = "dateto";
            reportParameter3.Text = "dateto";
            reportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime;
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

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox ageCaptionTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox fullnameCaptionTextBox;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox sexCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox ageDataTextBox;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox fullnameDataTextBox;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox sexDataTextBox;
        private Telerik.Reporting.DetailSection detail;
    }
}