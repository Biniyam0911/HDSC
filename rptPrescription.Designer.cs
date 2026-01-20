namespace Onana_Hospital_Management_System
{
    partial class rptPrescription
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
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.dsPrescription = new Telerik.Reporting.SqlDataSource();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.textBox25 = new Telerik.Reporting.TextBox();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.pcbLogo = new Telerik.Reporting.PictureBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.fullnameCaptionTextBox1 = new Telerik.Reporting.TextBox();
            this.fullnameDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.chkOutPatient = new Telerik.Reporting.CheckBox();
            this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.treatmentCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox27 = new Telerik.Reporting.TextBox();
            this.textBox26 = new Telerik.Reporting.TextBox();
            this.treatmentDataTextBox = new Telerik.Reporting.TextBox();
            this.dateDataTextBox = new Telerik.Reporting.TextBox();
            this.fullnameDataTextBox1 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.533D), Telerik.Reporting.Drawing.Unit.Inch(1.6D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox1.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.textBox1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Date:";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Format = "{0:d}";
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.919D), Telerik.Reporting.Drawing.Unit.Inch(1.6D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.058D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "= Fields.Date";
            // 
            // dsPrescription
            // 
            this.dsPrescription.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.dsPrescription.Name = "dsPrescription";
            this.dsPrescription.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@patname", System.Data.DbType.String, "= Parameters.patname.Value"));
            this.dsPrescription.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@date", System.Data.DbType.DateTime, "= Parameters.date.Value"));
            this.dsPrescription.SelectCommand = "dbo.sp_get_prescription_for_print";
            this.dsPrescription.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1D);
            this.pageHeader.Name = "pageHeader";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(1.119D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox,
            this.textBox3,
            this.textBox4,
            this.textBox16,
            this.textBox17,
            this.textBox18,
            this.textBox19,
            this.textBox20,
            this.textBox21,
            this.textBox25,
            this.textBox24,
            this.textBox23,
            this.textBox22});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.468D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.currentTimeTextBox.Style.Font.Bold = true;
            this.currentTimeTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "Prescriber\'s";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.509D), Telerik.Reporting.Drawing.Unit.Inch(0.021D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.391D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.pageInfoTextBox.Style.Font.Bold = true;
            this.pageInfoTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "Dispenser\'s";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.221D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.879D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox3.Value = "Fullname";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.421D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.879D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox4.Value = "Qualification";
            // 
            // textBox16
            // 
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.619D));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.879D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox16.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox16.Value = "Registration";
            // 
            // textBox17
            // 
            this.textBox17.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021D), Telerik.Reporting.Drawing.Unit.Inch(0.819D));
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.879D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox17.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox17.Value = "Signature";
            // 
            // textBox18
            // 
            this.textBox18.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.221D));
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox18.Value = "";
            // 
            // textBox19
            // 
            this.textBox19.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.421D));
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox19.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox19.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox19.Value = "";
            // 
            // textBox20
            // 
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.621D));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox20.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox20.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox20.Value = "";
            // 
            // textBox21
            // 
            this.textBox21.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.821D));
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox21.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox21.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox21.Value = "";
            // 
            // textBox25
            // 
            this.textBox25.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3D), Telerik.Reporting.Drawing.Unit.Inch(0.221D));
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox25.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox25.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox25.Value = "";
            // 
            // textBox24
            // 
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3D), Telerik.Reporting.Drawing.Unit.Inch(0.421D));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox24.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox24.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox24.Value = "";
            // 
            // textBox23
            // 
            this.textBox23.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3D), Telerik.Reporting.Drawing.Unit.Inch(0.621D));
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox23.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox23.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox23.Value = "";
            // 
            // textBox22
            // 
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3D), Telerik.Reporting.Drawing.Unit.Inch(0.821D));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox22.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox22.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox22.Value = "";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(3.171D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox5,
            this.textBox6,
            this.pcbLogo,
            this.textBox1,
            this.textBox2,
            this.textBox7,
            this.fullnameCaptionTextBox1,
            this.fullnameDataTextBox,
            this.textBox8,
            this.textBox9,
            this.textBox10,
            this.textBox11,
            this.textBox12,
            this.textBox13,
            this.textBox14,
            this.textBox15,
            this.chkOutPatient,
            this.dateCaptionTextBox,
            this.treatmentCaptionTextBox,
            this.textBox27,
            this.textBox26});
            this.reportHeader.Name = "reportHeader";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.6D), Telerik.Reporting.Drawing.Unit.Inch(0.771D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.textBox5.Style.Color = System.Drawing.Color.Goldenrod;
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.Value = "Huderma Dermatology Specialty Clinic          ሁደርማ የቆዳ ልዩ ክሊኒክ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5D), Telerik.Reporting.Drawing.Unit.Inch(1.271D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2D), Telerik.Reporting.Drawing.Unit.Inch(0.219D));
            this.textBox6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox6.Value = "+251 949 74 44 44/+251 949 54 44 44";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchoring = Telerik.Reporting.AnchoringStyles.Top;
            this.pcbLogo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.367D), Telerik.Reporting.Drawing.Unit.Inch(0.1D));
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9D), Telerik.Reporting.Drawing.Unit.Inch(0.6D));
            this.pcbLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.pcbLogo.Style.BackgroundImage.ImageData = global::Onana_Hospital_Management_System.Properties.Resources.output_onlinepngtools;
            this.pcbLogo.Style.BackgroundImage.MimeType = "image/png";
            this.pcbLogo.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(1.49D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.389D), Telerik.Reporting.Drawing.Unit.Inch(0.31D));
            this.textBox7.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Style.Font.Name = "Georgia";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14D);
            this.textBox7.Value = "Prescription Paper";
            // 
            // fullnameCaptionTextBox1
            // 
            this.fullnameCaptionTextBox1.CanGrow = true;
            this.fullnameCaptionTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(1.866D));
            this.fullnameCaptionTextBox1.Name = "fullnameCaptionTextBox1";
            this.fullnameCaptionTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.979D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameCaptionTextBox1.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.fullnameCaptionTextBox1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.fullnameCaptionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.fullnameCaptionTextBox1.StyleName = "Caption";
            this.fullnameCaptionTextBox1.Value = "Patient\'s Name";
            // 
            // fullnameDataTextBox
            // 
            this.fullnameDataTextBox.CanGrow = true;
            this.fullnameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1.871D));
            this.fullnameDataTextBox.Name = "fullnameDataTextBox";
            this.fullnameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameDataTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.fullnameDataTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.fullnameDataTextBox.StyleName = "Data";
            this.fullnameDataTextBox.Value = "= Fields.Fullname";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2D), Telerik.Reporting.Drawing.Unit.Inch(1.875D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox8.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox8.Value = "Sex";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5D), Telerik.Reporting.Drawing.Unit.Inch(1.875D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox9.Value = "= Fields.Sex";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1D), Telerik.Reporting.Drawing.Unit.Inch(1.875D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox10.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox10.Value = "Age";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5D), Telerik.Reporting.Drawing.Unit.Inch(1.875D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox11.Value = "= Fields.Age";
            // 
            // textBox12
            // 
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(2.171D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox12.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox12.Value = "Weight";
            // 
            // textBox13
            // 
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(2.171D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox13.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox13.Value = "";
            // 
            // textBox14
            // 
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8D), Telerik.Reporting.Drawing.Unit.Inch(2.171D));
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox14.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox14.Value = "Card No.";
            // 
            // textBox15
            // 
            this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5D), Telerik.Reporting.Drawing.Unit.Inch(2.171D));
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox15.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox15.Value = "= Fields.[Card No]";
            // 
            // chkOutPatient
            // 
            this.chkOutPatient.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8D), Telerik.Reporting.Drawing.Unit.Inch(2.171D));
            this.chkOutPatient.Name = "chkOutPatient";
            this.chkOutPatient.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.chkOutPatient.Style.Visible = true;
            this.chkOutPatient.Text = "Outpatient";
            // 
            // dateCaptionTextBox
            // 
            this.dateCaptionTextBox.CanGrow = true;
            this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.354D), Telerik.Reporting.Drawing.Unit.Inch(2.671D));
            this.dateCaptionTextBox.Name = "dateCaptionTextBox";
            this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.646D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.dateCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.dateCaptionTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.dateCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            this.dateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.dateCaptionTextBox.StyleName = "Caption";
            this.dateCaptionTextBox.Value = "Price of each item            (for dispenser use only)";
            // 
            // treatmentCaptionTextBox
            // 
            this.treatmentCaptionTextBox.CanGrow = true;
            this.treatmentCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(2.671D));
            this.treatmentCaptionTextBox.Name = "treatmentCaptionTextBox";
            this.treatmentCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.3D), Telerik.Reporting.Drawing.Unit.Inch(0.4D));
            this.treatmentCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.Empty;
            this.treatmentCaptionTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.treatmentCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            this.treatmentCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.treatmentCaptionTextBox.StyleName = "Caption";
            this.treatmentCaptionTextBox.Value = "Treatment Given                                                                  " +
    "   (Drug name, strength, dosage, form, dose, duration and quantity)";
            // 
            // textBox27
            // 
            this.textBox27.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(2.471D));
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox27.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox27.Value = "Diagnosis";
            // 
            // textBox26
            // 
            this.textBox26.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.8D), Telerik.Reporting.Drawing.Unit.Inch(2.471D));
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.177D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.textBox26.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox26.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.textBox26.Value = "= Fields.Diagnosis";
            // 
            // treatmentDataTextBox
            // 
            this.treatmentDataTextBox.CanGrow = true;
            this.treatmentDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.2D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.treatmentDataTextBox.Name = "treatmentDataTextBox";
            this.treatmentDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.treatmentDataTextBox.StyleName = "Data";
            this.treatmentDataTextBox.Value = "= Fields.Treatment";
            // 
            // dateDataTextBox
            // 
            this.dateDataTextBox.CanGrow = true;
            this.dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.3D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.dateDataTextBox.Name = "dateDataTextBox";
            this.dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.177D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.dateDataTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.dateDataTextBox.StyleName = "Data";
            this.dateDataTextBox.Value = "";
            // 
            // fullnameDataTextBox1
            // 
            this.fullnameDataTextBox1.CanGrow = true;
            this.fullnameDataTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.fullnameDataTextBox1.Name = "fullnameDataTextBox1";
            this.fullnameDataTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.423D), Telerik.Reporting.Drawing.Unit.Inch(0.2D));
            this.fullnameDataTextBox1.StyleName = "Data";
            this.fullnameDataTextBox1.Value = "";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.2D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.treatmentDataTextBox,
            this.dateDataTextBox,
            this.fullnameDataTextBox1});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Onana_Hospital_Management_System.Properties.Settings.dbOHMSConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@fullname", System.Data.DbType.String, "= Parameters.fullname.Value"));
            this.sqlDataSource1.Parameters.Add(new Telerik.Reporting.SqlDataSourceParameter("@prescriptionid", System.Data.DbType.Int32, "= Parameters.prescriptionid.Value"));
            this.sqlDataSource1.SelectCommand = "dbo.sp_get_select_prescription_patname";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // rptPrescription
            // 
            this.DataSource = this.dsPrescription;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.detail});
            this.Name = "rptPrescription";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A5;
            reportParameter1.Name = "patname";
            reportParameter1.Text = "Fullname";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(5D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dsPrescription;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.PictureBox pcbLogo;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox25;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.CheckBox chkOutPatient;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox fullnameDataTextBox;
        private Telerik.Reporting.TextBox fullnameCaptionTextBox1;
        private Telerik.Reporting.TextBox fullnameDataTextBox1;
        private Telerik.Reporting.TextBox dateDataTextBox;
        private Telerik.Reporting.TextBox treatmentDataTextBox;
        private Telerik.Reporting.TextBox treatmentCaptionTextBox;
        private Telerik.Reporting.TextBox dateCaptionTextBox;
        private Telerik.Reporting.TextBox textBox27;
        private Telerik.Reporting.TextBox textBox26;
        private Telerik.Reporting.SqlDataSource sqlDataSource1;
    }
}