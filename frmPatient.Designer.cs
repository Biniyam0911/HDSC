namespace Onana_Hospital_Management_System
{
    partial class frmPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtResAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOname = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(613, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Onana_Hospital_Management_System.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtResAddress);
            this.groupBox2.Controls.Add(this.txtContact);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtOname);
            this.groupBox2.Controls.Add(this.cboGender);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 244);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Details";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(320, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Address";
            // 
            // txtResAddress
            // 
            this.txtResAddress.Location = new System.Drawing.Point(404, 118);
            this.txtResAddress.MaxLength = 50;
            this.txtResAddress.Multiline = true;
            this.txtResAddress.Name = "txtResAddress";
            this.txtResAddress.Size = new System.Drawing.Size(180, 71);
            this.txtResAddress.TabIndex = 7;
            this.txtResAddress.TextChanged += new System.EventHandler(this.txtResAddress_TextChanged);
            this.txtResAddress.Leave += new System.EventHandler(this.txtResAddress_Leave);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(89, 169);
            this.txtContact.MaxLength = 10;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(204, 21);
            this.txtContact.TabIndex = 6;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            this.txtContact.Leave += new System.EventHandler(this.txtContact_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Phone";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 118);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(203, 21);
            this.txtAge.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "label8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "label8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Age";
            // 
            // txtOname
            // 
            this.txtOname.Location = new System.Drawing.Point(89, 67);
            this.txtOname.MaxLength = 25;
            this.txtOname.Name = "txtOname";
            this.txtOname.Size = new System.Drawing.Size(204, 21);
            this.txtOname.TabIndex = 3;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(404, 69);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(180, 21);
            this.cboGender.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(404, 22);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 21);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 26);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(204, 21);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "G. Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // txtPatCode
            // 
            this.txtPatCode.Location = new System.Drawing.Point(83, 15);
            this.txtPatCode.Name = "txtPatCode";
            this.txtPatCode.ReadOnly = true;
            this.txtPatCode.Size = new System.Drawing.Size(100, 21);
            this.txtPatCode.TabIndex = 11;
            this.txtPatCode.TextChanged += new System.EventHandler(this.txtPatCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Patient ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(362, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 55);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Details";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(521, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 55);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPatient
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 496);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatCode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmPatient.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPatient";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Registration Form";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOname;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPatCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtResAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}