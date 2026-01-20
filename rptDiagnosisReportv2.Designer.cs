namespace Onana_Hospital_Management_System
{
    partial class rptDiagnosisReportv2
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.SortingAction sortingAction1 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.SortingAction sortingAction2 = new Telerik.Reporting.SortingAction();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector1 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector2 = new Telerik.Reporting.Drawing.DescendantSelector();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.467D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(3.29D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.727D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox4);
            this.table1.Body.SetCellContent(0, 1, this.textBox5);
            this.table1.Body.SetCellContent(0, 2, this.textBox6);
            tableGroup1.Name = "date";
            tableGroup1.ReportItem = this.textBox1;
            tableGroup2.Name = "diagnosis";
            tableGroup2.ReportItem = this.textBox2;
            tableGroup3.Name = "doctor";
            tableGroup3.ReportItem = this.textBox3;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.ColumnGroups.Add(tableGroup3);
            this.table1.ColumnHeadersPrintOnEveryPage = false;
            this.table1.DataSource = this.sqlDataSource1;
            this.table1.FreezeRowHeaders = true;
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.textBox1,
            this.textBox2,
            this.textBox3});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.table1.Name = "table1";
            tableGroup4.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup4.Name = "detail";
            this.table1.RowGroups.Add(tableGroup4);
            this.table1.RowHeadersPrintOnEveryPage = true;
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.484D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.table1.StyleName = "Corporate.TableNormal";
            // 
            // textBox4
            // 
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.467D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox4.StyleName = "Corporate.TableBody";
            this.textBox4.Value = "= Fields.Date";
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.29D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox5.StyleName = "Corporate.TableBody";
            this.textBox5.Value = "= Fields.Diagnosis";
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.727D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox6.StyleName = "Corporate.TableBody";
            this.textBox6.Value = "= Fields.Doctor";
            // 
            // textBox1
            // 
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.467D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.StyleName = "Corporate.TableHeader";
            this.textBox1.Value = "Date";
            // 
            // textBox2
            // 
            sortingAction1.SortingExpression = "= Fields.Diagnosis";
            sortingAction1.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            this.table1});
            this.textBox2.Action = sortingAction1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.29D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox2.StyleName = "Corporate.TableHeader";
            this.textBox2.Value = "Diagnosis";
            // 
            // textBox3
            // 
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.727D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.StyleName = "Corporate.TableHeader";
            this.textBox3.Value = "Doctor";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date1", System.Data.DbType.Date, "= Parameters.date1.Value"));
            this.sqlDataSource1.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date2", System.Data.DbType.Date, "= Parameters.date2.Value"));
            this.sqlDataSource1.SelectCommand = "dbo.sp_get_diagnosis_report";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // detailSection1
            // 
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1});
            this.detailSection1.Name = "detailSection1";
            this.detailSection1.PageBreak = Telerik.Reporting.PageBreak.After;
            // 
            // textBox7
            // 
            this.textBox7.Name = "ReportNameTextBox";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.906D), Telerik.Reporting.Drawing.Unit.Inch(0.787D));
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Style.Font.Name = "Segoe UI";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox7.Value = "Diagnosis Report";
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox7});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.925D), Telerik.Reporting.Drawing.Unit.Inch(0.8D));
            this.textBox8.Name = "ReportPageNumberTextBox";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.575D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.Style.Font.Name = "Segoe UI";
            this.textBox8.Value = "Page: {PageNumber}";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox8,
            this.currentTimeTextBox});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.8D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.198D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // rptDiagnosisReportv2
            // 
            sortingAction2.SortingExpression = "= Fields.Diagnosis";
            sortingAction2.Targets.AddRange(new Telerik.Reporting.IActionTarget[] {
            tableGroup2});
            this.Action = sortingAction2;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detailSection1,
            this.pageHeaderSection1,
            this.pageFooterSection1});
            this.Name = "rptDiagnosisReportv2";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(10D), Telerik.Reporting.Drawing.Unit.Mm(10D), Telerik.Reporting.Drawing.Unit.Mm(10D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.Name = "date1";
            reportParameter1.Text = "From";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter1.Visible = true;
            reportParameter2.Name = "date2";
            reportParameter2.Text = "To";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime;
            reportParameter2.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.Table), "Corporate.TableNormal")});
            styleRule2.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Corporate.TableBody")});
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector1});
            styleRule3.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Corporate.TableHeader")});
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector2});
            styleRule4.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule4.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule4.Style.Color = System.Drawing.Color.White;
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.5D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detailSection1;
        private Telerik.Reporting.Table table1;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.TextBox currentTimeTextBox;
    }
}