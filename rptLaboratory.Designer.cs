namespace Onana_Hospital_Management_System
{
    partial class rptLaboratory
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
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.testCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.sqlDSLaboratory = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.sexCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sexDataTextBox = new Telerik.Reporting.TextBox();
            this.fullnameDataTextBox = new Telerik.Reporting.TextBox();
            this.pcbLogo = new Telerik.Reporting.PictureBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.fullnameCaptionTextBox1 = new Telerik.Reporting.TextBox();
            this.chkUrgent = new Telerik.Reporting.CheckBox();
            this.chkRoutine = new Telerik.Reporting.CheckBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.testDataTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dateCaptionTextBox
            // 
            this.dateCaptionTextBox.CanGrow = true;
            this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2D), Telerik.Reporting.Drawing.Unit.Inch(1.619D));
            this.dateCaptionTextBox.Name = "dateCaptionTextBox";
            this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.dateCaptionTextBox.StyleName = "Caption";
            this.dateCaptionTextBox.Value = "Date";
            // 
            // testCaptionTextBox
            // 
            this.testCaptionTextBox.CanGrow = true;
            this.testCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(3.219D));
            this.testCaptionTextBox.Name = "testCaptionTextBox";
            this.testCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.468D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.testCaptionTextBox.StyleName = "Caption";
            this.testCaptionTextBox.Value = "Description";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Format = "{0:dd-MMM-yyyy}";
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7D), Telerik.Reporting.Drawing.Unit.Inch(1.619D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "= Fields.Date";
            // 
            // sqlDSLaboratory
            // 
            this.sqlDSLaboratory.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.sqlDSLaboratory.Name = "sqlDSLaboratory";
            this.sqlDSLaboratory.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@patname", System.Data.DbType.String, "= Parameters.patname.Value"));
            this.sqlDSLaboratory.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date", System.Data.DbType.DateTime, "= Parameters.date.Value"));
            this.sqlDSLaboratory.SelectCommand = "dbo.sp_get_laboratory_for_print";
            this.sqlDSLaboratory.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
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
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.468D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.509D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.468D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(3.419D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.textBox2,
            this.textBox3,
            this.textBox4,
            this.textBox5,
            this.sexCaptionTextBox,
            this.sexDataTextBox,
            this.fullnameDataTextBox,
            this.pcbLogo,
            this.textBox6,
            this.textBox7,
            this.dateCaptionTextBox,
            this.textBox1,
            this.fullnameCaptionTextBox1,
            this.chkUrgent,
            this.chkRoutine,
            this.textBox9,
            this.textBox8,
            this.textBox11,
            this.textBox10,
            this.testCaptionTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(1.59D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7D), Telerik.Reporting.Drawing.Unit.Inch(0.219D));
            this.titleTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.titleTextBox.Style.Font.Name = "Georgia";
            this.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Laboratory Request Form";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8D), Telerik.Reporting.Drawing.Unit.Inch(2.225D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.636D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox2.StyleName = "Caption";
            this.textBox2.Value = "Card No:";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6D), Telerik.Reporting.Drawing.Unit.Inch(2.219D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.994D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "= Fields.[Card No]";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(2.519D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.979D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox4.StyleName = "Caption";
            this.textBox4.Value = "Clinical Data:";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1D), Telerik.Reporting.Drawing.Unit.Inch(2.525D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.994D), Telerik.Reporting.Drawing.Unit.Inch(0.594D));
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "= Fields.[Clinical Data]";
            // 
            // sexCaptionTextBox
            // 
            this.sexCaptionTextBox.CanGrow = true;
            this.sexCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.509D), Telerik.Reporting.Drawing.Unit.Inch(1.925D));
            this.sexCaptionTextBox.Name = "sexCaptionTextBox";
            this.sexCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.394D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.sexCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.sexCaptionTextBox.StyleName = "Caption";
            this.sexCaptionTextBox.Value = "Sex:";
            // 
            // sexDataTextBox
            // 
            this.sexDataTextBox.CanGrow = true;
            this.sexDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.006D), Telerik.Reporting.Drawing.Unit.Inch(1.93D));
            this.sexDataTextBox.Name = "sexDataTextBox";
            this.sexDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.674D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.sexDataTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.sexDataTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.sexDataTextBox.StyleName = "Data";
            this.sexDataTextBox.Value = "= Fields.Sex";
            // 
            // fullnameDataTextBox
            // 
            this.fullnameDataTextBox.CanGrow = true;
            this.fullnameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1D), Telerik.Reporting.Drawing.Unit.Inch(1.925D));
            this.fullnameDataTextBox.Name = "fullnameDataTextBox";
            this.fullnameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.336D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameDataTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.fullnameDataTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.fullnameDataTextBox.StyleName = "Data";
            this.fullnameDataTextBox.Value = "= Fields.Fullname";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchoring = Telerik.Reporting.AnchoringStyles.Top;
            this.pcbLogo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5D), Telerik.Reporting.Drawing.Unit.Inch(0.119D));
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9D), Telerik.Reporting.Drawing.Unit.Inch(0.6D));
            this.pcbLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.pcbLogo.Style.BackgroundImage.ImageData = global::Onana_Hospital_Management_System.Properties.Resources.output_onlinepngtools;
            this.pcbLogo.Style.BackgroundImage.MimeType = "image/png";
            this.pcbLogo.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.509D), Telerik.Reporting.Drawing.Unit.Inch(0.819D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.textBox6.Style.Color = System.Drawing.Color.Goldenrod;
            this.textBox6.Style.Font.Bold = true;
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox6.Value = "Huderma Dermatology Specialty Clinic          ሁደርማ የቆዳ ልዩ ክሊኒክ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.309D), Telerik.Reporting.Drawing.Unit.Inch(1.319D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2D), Telerik.Reporting.Drawing.Unit.Inch(0.219D));
            this.textBox7.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox7.Value = "+251 949 74 44 44/+251 949 54 44 44";
            // 
            // fullnameCaptionTextBox1
            // 
            this.fullnameCaptionTextBox1.CanGrow = true;
            this.fullnameCaptionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(1.919D));
            this.fullnameCaptionTextBox1.Name = "fullnameCaptionTextBox1";
            this.fullnameCaptionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.979D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameCaptionTextBox1.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.fullnameCaptionTextBox1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.fullnameCaptionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.fullnameCaptionTextBox1.StyleName = "Caption";
            this.fullnameCaptionTextBox1.Value = "Patient\'s Name";
            // 
            // chkUrgent
            // 
            this.chkUrgent.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2D), Telerik.Reporting.Drawing.Unit.Inch(2.243D));
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.774D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.Value = "= Fields.Urgent";
            // 
            // chkRoutine
            // 
            this.chkRoutine.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2D), Telerik.Reporting.Drawing.Unit.Inch(2.548D));
            this.chkRoutine.Name = "chkRoutine";
            this.chkRoutine.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.774D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.chkRoutine.Text = "Routine";
            this.chkRoutine.Value = "= Fields.Routine";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.732D), Telerik.Reporting.Drawing.Unit.Inch(1.925D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.394D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox9.StyleName = "Caption";
            this.textBox9.Value = "Age";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2D), Telerik.Reporting.Drawing.Unit.Inch(1.919D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.674D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = true;
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.797D), Telerik.Reporting.Drawing.Unit.Inch(2.225D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.921D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox11.StyleName = "Data";
            this.textBox11.Value = "";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(2.219D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.679D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox10.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.textBox10.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox10.StyleName = "Caption";
            this.textBox10.Value = "Weight";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.2D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.testDataTextBox});
            this.detail.Name = "detail";
            // 
            // testDataTextBox
            // 
            this.testDataTextBox.CanGrow = true;
            this.testDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.testDataTextBox.Name = "testDataTextBox";
            this.testDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.039D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.testDataTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.testDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.testDataTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.testDataTextBox.StyleName = "Data";
            this.testDataTextBox.Value = "= Fields.Test";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.reportFooter.Name = "reportFooter";
            // 
            // rptLaboratory
            // 
            this.DataSource = this.sqlDSLaboratory;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "rptLaboratory";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A5;
            reportParameter1.Name = "patname";
            reportParameter1.Text = "patname";
            reportParameter2.Name = "date";
            reportParameter2.Text = "date";
            reportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime;
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Bold = true;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption"),
            new Telerik.Reporting.Drawing.StyleSelector("SubTotalCaption"),
            new Telerik.Reporting.Drawing.StyleSelector("GrandTotalCaption")});
            styleRule3.Style.Color = System.Drawing.Color.Black;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data"),
            new Telerik.Reporting.Drawing.StyleSelector("TotalData")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Font.Name = "Tahoma";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(5.039D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDSLaboratory;
        private Telerik.Reporting.TextBox dateCaptionTextBox;
        private Telerik.Reporting.TextBox testCaptionTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox sexCaptionTextBox;
        private Telerik.Reporting.TextBox sexDataTextBox;
        private Telerik.Reporting.TextBox fullnameDataTextBox;
        private Telerik.Reporting.TextBox testDataTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PictureBox pcbLogo;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox fullnameCaptionTextBox1;
        private Telerik.Reporting.CheckBox chkUrgent;
        private Telerik.Reporting.CheckBox chkRoutine;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.ReportFooterSection reportFooter;
    }
}