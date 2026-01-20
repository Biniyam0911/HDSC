namespace Onana_Hospital_Management_System
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dtpDateJoined = new System.Windows.Forms.DateTimePicker();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtQaulification = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtResAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOname);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtEmpCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboDepartment);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.dtpDateJoined);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtQaulification);
            this.groupBox1.Controls.Add(this.txtDesignation);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.txtResAddress);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info.";
            // 
            // txtOname
            // 
            this.txtOname.Location = new System.Drawing.Point(365, 52);
            this.txtOname.MaxLength = 40;
            this.txtOname.Name = "txtOname";
            this.txtOname.Size = new System.Drawing.Size(146, 21);
            this.txtOname.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "G. Father Name";
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Location = new System.Drawing.Point(130, 19);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.ReadOnly = true;
            this.txtEmpCode.Size = new System.Drawing.Size(133, 21);
            this.txtEmpCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownHeight = 95;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.IntegralHeight = false;
            this.cboDepartment.Location = new System.Drawing.Point(130, 158);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(133, 21);
            this.cboDepartment.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(365, 89);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(146, 21);
            this.txtAge.TabIndex = 6;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // dtpDateJoined
            // 
            this.dtpDateJoined.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateJoined.Location = new System.Drawing.Point(365, 197);
            this.dtpDateJoined.Name = "dtpDateJoined";
            this.dtpDateJoined.Size = new System.Drawing.Size(146, 21);
            this.dtpDateJoined.TabIndex = 5;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(130, 88);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(133, 21);
            this.cboGender.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 235);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(381, 21);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtQaulification
            // 
            this.txtQaulification.Location = new System.Drawing.Point(365, 121);
            this.txtQaulification.MaxLength = 30;
            this.txtQaulification.Name = "txtQaulification";
            this.txtQaulification.Size = new System.Drawing.Size(146, 21);
            this.txtQaulification.TabIndex = 3;
            this.txtQaulification.TextChanged += new System.EventHandler(this.txtQaulification_TextChanged);
            this.txtQaulification.Leave += new System.EventHandler(this.txtQaulification_Leave);
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(365, 161);
            this.txtDesignation.MaxLength = 30;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(146, 21);
            this.txtDesignation.TabIndex = 3;
            this.txtDesignation.TextChanged += new System.EventHandler(this.txtDesignation_TextChanged);
            this.txtDesignation.Leave += new System.EventHandler(this.txtDesignation_Leave);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(130, 124);
            this.txtContact.MaxLength = 10;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(133, 21);
            this.txtContact.TabIndex = 3;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            this.txtContact.Leave += new System.EventHandler(this.txtContact_Leave);
            // 
            // txtResAddress
            // 
            this.txtResAddress.Location = new System.Drawing.Point(130, 193);
            this.txtResAddress.MaxLength = 80;
            this.txtResAddress.Name = "txtResAddress";
            this.txtResAddress.Size = new System.Drawing.Size(133, 21);
            this.txtResAddress.TabIndex = 3;
            this.txtResAddress.TextChanged += new System.EventHandler(this.txtResAddress_TextChanged);
            this.txtResAddress.Leave += new System.EventHandler(this.txtResAddress_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(130, 53);
            this.txtLastName.MaxLength = 40;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 21);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(365, 19);
            this.txtFirstName.MaxLength = 40;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(146, 21);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(280, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Qualification";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(280, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Designation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date Joined";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Residence Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.picImage);
            this.groupBox2.Location = new System.Drawing.Point(556, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(10, 184);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(140, 37);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Image = global::Onana_Hospital_Management_System.Properties.Resources.index;
            this.picImage.Location = new System.Drawing.Point(6, 19);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(145, 155);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(101, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(335, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 83);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frmEmployee
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmEmployee.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Registration";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmpCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DateTimePicker dtpDateJoined;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtResAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtQaulification;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtOname;
        private System.Windows.Forms.Label label13;


    }
}