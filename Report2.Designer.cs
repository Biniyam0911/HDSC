namespace Onana_Hospital_Management_System
{
    partial class Report2
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.TextWatermark textWatermark1 = new Telerik.Reporting.Drawing.TextWatermark();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.consultDateGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.consultDateGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.diagnosisCaptionTextBox = new Telerik.Reporting.TextBox();
            this.historyCaptionTextBox = new Telerik.Reporting.TextBox();
            this.medicationCaptionTextBox = new Telerik.Reporting.TextBox();
            this.peCaptionTextBox = new Telerik.Reporting.TextBox();
            this.planCaptionTextBox = new Telerik.Reporting.TextBox();
            this.chiefcompliantCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.patIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.patIDDataTextBox = new Telerik.Reporting.TextBox();
            this.docCodeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.docCodeDataTextBox = new Telerik.Reporting.TextBox();
            this.pcbLogo = new Telerik.Reporting.PictureBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.diagnosisDataTextBox = new Telerik.Reporting.TextBox();
            this.historyDataTextBox = new Telerik.Reporting.TextBox();
            this.medicationDataTextBox = new Telerik.Reporting.TextBox();
            this.peDataTextBox = new Telerik.Reporting.TextBox();
            this.planDataTextBox = new Telerik.Reporting.TextBox();
            this.chiefcompliantDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // consultDateGroupFooterSection
            // 
            this.consultDateGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.consultDateGroupFooterSection.Name = "consultDateGroupFooterSection";
            // 
            // consultDateGroupHeaderSection
            // 
            this.consultDateGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.consultDateGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2});
            this.consultDateGroupHeaderSection.Name = "consultDateGroupHeaderSection";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Visit Date:";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.242D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.155D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox2.Style.Color = System.Drawing.Color.DarkRed;
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "= Fields.consultDate";
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.419D);
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // diagnosisCaptionTextBox
            // 
            this.diagnosisCaptionTextBox.CanGrow = true;
            this.diagnosisCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.01D), Telerik.Reporting.Drawing.Unit.Inch(1.3D));
            this.diagnosisCaptionTextBox.Name = "diagnosisCaptionTextBox";
            this.diagnosisCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.diagnosisCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White;
            this.diagnosisCaptionTextBox.Style.Color = System.Drawing.Color.Black;
            this.diagnosisCaptionTextBox.StyleName = "Caption";
            this.diagnosisCaptionTextBox.Value = "Diagnosis";
            // 
            // historyCaptionTextBox
            // 
            this.historyCaptionTextBox.CanGrow = true;
            this.historyCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.historyCaptionTextBox.Name = "historyCaptionTextBox";
            this.historyCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.historyCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White;
            this.historyCaptionTextBox.Style.Color = System.Drawing.Color.Black;
            this.historyCaptionTextBox.StyleName = "Caption";
            this.historyCaptionTextBox.Value = "History";
            // 
            // medicationCaptionTextBox
            // 
            this.medicationCaptionTextBox.CanGrow = true;
            this.medicationCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(2.1D));
            this.medicationCaptionTextBox.Name = "medicationCaptionTextBox";
            this.medicationCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.medicationCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White;
            this.medicationCaptionTextBox.Style.Color = System.Drawing.Color.Black;
            this.medicationCaptionTextBox.StyleName = "Caption";
            this.medicationCaptionTextBox.Value = "Medication";
            // 
            // peCaptionTextBox
            // 
            this.peCaptionTextBox.CanGrow = true;
            this.peCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.9D));
            this.peCaptionTextBox.Name = "peCaptionTextBox";
            this.peCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.peCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White;
            this.peCaptionTextBox.Style.Color = System.Drawing.Color.Black;
            this.peCaptionTextBox.StyleName = "Caption";
            this.peCaptionTextBox.Value = "P/E";
            // 
            // planCaptionTextBox
            // 
            this.planCaptionTextBox.CanGrow = true;
            this.planCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(1.7D));
            this.planCaptionTextBox.Name = "planCaptionTextBox";
            this.planCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.planCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White;
            this.planCaptionTextBox.Style.Color = System.Drawing.Color.Black;
            this.planCaptionTextBox.StyleName = "Caption";
            this.planCaptionTextBox.Value = "Plan";
            // 
            // chiefcompliantCaptionTextBox
            // 
            this.chiefcompliantCaptionTextBox.CanGrow = true;
            this.chiefcompliantCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.1D));
            this.chiefcompliantCaptionTextBox.Name = "chiefcompliantCaptionTextBox";
            this.chiefcompliantCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.chiefcompliantCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White;
            this.chiefcompliantCaptionTextBox.Style.Color = System.Drawing.Color.Black;
            this.chiefcompliantCaptionTextBox.StyleName = "Caption";
            this.chiefcompliantCaptionTextBox.Value = "Chief Compliant";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@patid", System.Data.DbType.String, "= Parameters.patid.Value"));
            this.sqlDataSource1.SelectCommand = "dbo.sp_get_patient_history";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
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
            this.reportNameTextBox.Value = "Patient History";
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
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(3.019D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.patIDCaptionTextBox,
            this.patIDDataTextBox,
            this.docCodeCaptionTextBox,
            this.docCodeDataTextBox,
            this.pcbLogo,
            this.textBox3,
            this.textBox5,
            this.textBox4,
            this.textBox8,
            this.textBox7,
            this.textBox9,
            this.textBox6,
            this.textBox11,
            this.textBox10});
            this.reportHeader.Name = "reportHeader";
            // 
            // patIDCaptionTextBox
            // 
            this.patIDCaptionTextBox.CanGrow = true;
            this.patIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(1.319D));
            this.patIDCaptionTextBox.Name = "patIDCaptionTextBox";
            this.patIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.patIDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.patIDCaptionTextBox.StyleName = "Caption";
            this.patIDCaptionTextBox.Value = "Card No.";
            // 
            // patIDDataTextBox
            // 
            this.patIDDataTextBox.CanGrow = true;
            this.patIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.875D), Telerik.Reporting.Drawing.Unit.Inch(1.319D));
            this.patIDDataTextBox.Name = "patIDDataTextBox";
            this.patIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.patIDDataTextBox.StyleName = "Data";
            this.patIDDataTextBox.Value = "= Fields.patID";
            // 
            // docCodeCaptionTextBox
            // 
            this.docCodeCaptionTextBox.CanGrow = true;
            this.docCodeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.73D), Telerik.Reporting.Drawing.Unit.Inch(1.313D));
            this.docCodeCaptionTextBox.Name = "docCodeCaptionTextBox";
            this.docCodeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.docCodeCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.docCodeCaptionTextBox.StyleName = "Caption";
            this.docCodeCaptionTextBox.Value = "Doctor Code:";
            // 
            // docCodeDataTextBox
            // 
            this.docCodeDataTextBox.CanGrow = true;
            this.docCodeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.605D), Telerik.Reporting.Drawing.Unit.Inch(1.313D));
            this.docCodeDataTextBox.Name = "docCodeDataTextBox";
            this.docCodeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.docCodeDataTextBox.StyleName = "Data";
            this.docCodeDataTextBox.Value = "= Fields.DocCode";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchoring = Telerik.Reporting.AnchoringStyles.Top;
            this.pcbLogo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.01D), Telerik.Reporting.Drawing.Unit.Inch(0.019D));
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8D), Telerik.Reporting.Drawing.Unit.Inch(0.789D));
            this.pcbLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.pcbLogo.Style.BackgroundImage.ImageData = global::Onana_Hospital_Management_System.Properties.Resources.output_onlinepngtools;
            this.pcbLogo.Style.BackgroundImage.MimeType = "image/png";
            this.pcbLogo.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.644D), Telerik.Reporting.Drawing.Unit.Inch(0.019D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.1D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.textBox3.Style.Color = System.Drawing.Color.Goldenrod;
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.Value = "Huderma Dermatology Specialty Clinic          ሁደርማ የቆዳ ልዩ ክሊኒክ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.644D), Telerik.Reporting.Drawing.Unit.Inch(0.619D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.textBox5.Value = "Kirkos Sub City, Woreda 01, H. No. 062 ቂርቆስ ክፍለ ከተማ/ ወረዳ 01 ቤ.ቁ 062";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.144D), Telerik.Reporting.Drawing.Unit.Inch(0.519D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.656D), Telerik.Reporting.Drawing.Unit.Inch(0.794D));
            this.textBox4.Value = "hudermacare@gmail.com www.huderma.com                 +251 949 74 44 44          " +
    " +251 949 54 44 44";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(1.719D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox8.StyleName = "Caption";
            this.textBox8.Value = "Patient Name";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = true;
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.875D), Telerik.Reporting.Drawing.Unit.Inch(1.719D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox7.StyleName = "Data";
            this.textBox7.Value = "= Fields.Fullname";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(2.119D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox9.StyleName = "Caption";
            this.textBox9.Value = "Age";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.875D), Telerik.Reporting.Drawing.Unit.Inch(2.119D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "= Fields.age";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = true;
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(2.519D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox11.StyleName = "Caption";
            this.textBox11.Value = "Gender";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.875D), Telerik.Reporting.Drawing.Unit.Inch(2.519D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.834D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox10.StyleName = "Data";
            this.textBox10.Value = "= Fields.pGender";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(4.7D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.diagnosisDataTextBox,
            this.historyDataTextBox,
            this.medicationDataTextBox,
            this.peDataTextBox,
            this.planDataTextBox,
            this.chiefcompliantDataTextBox,
            this.chiefcompliantCaptionTextBox,
            this.diagnosisCaptionTextBox,
            this.historyCaptionTextBox,
            this.medicationCaptionTextBox,
            this.peCaptionTextBox,
            this.planCaptionTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed;
            // 
            // diagnosisDataTextBox
            // 
            this.diagnosisDataTextBox.CanGrow = true;
            this.diagnosisDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.11D), Telerik.Reporting.Drawing.Unit.Inch(1.3D));
            this.diagnosisDataTextBox.Name = "diagnosisDataTextBox";
            this.diagnosisDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.diagnosisDataTextBox.StyleName = "Data";
            this.diagnosisDataTextBox.Value = "= Fields.diagnosis";
            // 
            // historyDataTextBox
            // 
            this.historyDataTextBox.CanGrow = true;
            this.historyDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1D), Telerik.Reporting.Drawing.Unit.Inch(0.506D));
            this.historyDataTextBox.Name = "historyDataTextBox";
            this.historyDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.historyDataTextBox.StyleName = "Data";
            this.historyDataTextBox.Value = "= Fields.history";
            // 
            // medicationDataTextBox
            // 
            this.medicationDataTextBox.CanGrow = true;
            this.medicationDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.121D), Telerik.Reporting.Drawing.Unit.Inch(2.1D));
            this.medicationDataTextBox.Name = "medicationDataTextBox";
            this.medicationDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.medicationDataTextBox.StyleName = "Data";
            this.medicationDataTextBox.Value = "= Fields.medication";
            // 
            // peDataTextBox
            // 
            this.peDataTextBox.CanGrow = true;
            this.peDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.121D), Telerik.Reporting.Drawing.Unit.Inch(0.906D));
            this.peDataTextBox.Name = "peDataTextBox";
            this.peDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.peDataTextBox.StyleName = "Data";
            this.peDataTextBox.Value = "= Fields.pe";
            // 
            // planDataTextBox
            // 
            this.planDataTextBox.CanGrow = true;
            this.planDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.121D), Telerik.Reporting.Drawing.Unit.Inch(1.706D));
            this.planDataTextBox.Name = "planDataTextBox";
            this.planDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.planDataTextBox.StyleName = "Data";
            this.planDataTextBox.Value = "= Fields.plan";
            // 
            // chiefcompliantDataTextBox
            // 
            this.chiefcompliantDataTextBox.CanGrow = true;
            this.chiefcompliantDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1D), Telerik.Reporting.Drawing.Unit.Inch(0.1D));
            this.chiefcompliantDataTextBox.Name = "chiefcompliantDataTextBox";
            this.chiefcompliantDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.chiefcompliantDataTextBox.StyleName = "Data";
            this.chiefcompliantDataTextBox.Value = "= Fields.chiefcompliant";
            // 
            // Report2
            // 
            this.DataSource = this.sqlDataSource1;
            group1.GroupFooter = this.consultDateGroupFooterSection;
            group1.GroupHeader = this.consultDateGroupHeaderSection;
            group1.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.consultDate"));
            group1.Name = "consultDateGroup";
            group2.GroupFooter = this.labelsGroupFooterSection;
            group2.GroupHeader = this.labelsGroupHeaderSection;
            group2.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.consultDateGroupHeaderSection,
            this.consultDateGroupFooterSection,
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "Report2";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            textWatermark1.Font.Italic = true;
            textWatermark1.Font.Size = Telerik.Reporting.Drawing.Unit.Point(50D);
            textWatermark1.Opacity = 0.1D;
            textWatermark1.Orientation = Telerik.Reporting.Drawing.WatermarkOrientation.Diagonal;
            textWatermark1.Text = "Huderma DSC";
            this.PageSettings.Watermarks.Add(textWatermark1);
            reportParameter1.Name = "patid";
            reportParameter1.Text = "patid";
            reportParameter1.Visible = true;
            this.ReportParameters.Add(reportParameter1);
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
        private Telerik.Reporting.GroupHeaderSection consultDateGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.GroupFooterSection consultDateGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox chiefcompliantCaptionTextBox;
        private Telerik.Reporting.TextBox diagnosisCaptionTextBox;
        private Telerik.Reporting.TextBox historyCaptionTextBox;
        private Telerik.Reporting.TextBox medicationCaptionTextBox;
        private Telerik.Reporting.TextBox peCaptionTextBox;
        private Telerik.Reporting.TextBox planCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox patIDCaptionTextBox;
        private Telerik.Reporting.TextBox patIDDataTextBox;
        private Telerik.Reporting.TextBox docCodeCaptionTextBox;
        private Telerik.Reporting.TextBox docCodeDataTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox chiefcompliantDataTextBox;
        private Telerik.Reporting.TextBox diagnosisDataTextBox;
        private Telerik.Reporting.TextBox historyDataTextBox;
        private Telerik.Reporting.TextBox medicationDataTextBox;
        private Telerik.Reporting.TextBox peDataTextBox;
        private Telerik.Reporting.TextBox planDataTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PictureBox pcbLogo;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox10;
    }
}