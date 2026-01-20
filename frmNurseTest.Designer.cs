namespace Onana_Hospital_Management_System
{
    partial class frmNurseTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNurseTest));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.txtPatHeight = new System.Windows.Forms.TextBox();
            this.txtPatWeight = new System.Windows.Forms.TextBox();
            this.txtpatBMI = new System.Windows.Forms.TextBox();
            this.txtpatPressure = new System.Windows.Forms.TextBox();
            this.txtPatTemperature = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtPatRespiratoryRate = new System.Windows.Forms.TextBox();
            this.txtPatPulseRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Height(m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Weight (Kg)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "BMI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pressure(mmHG)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Temperature(oC)";
            // 
            // txtPatName
            // 
            this.txtPatName.Location = new System.Drawing.Point(166, 124);
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.ReadOnly = true;
            this.txtPatName.Size = new System.Drawing.Size(237, 21);
            this.txtPatName.TabIndex = 1;
            this.txtPatName.TextChanged += new System.EventHandler(this.txtPatName_TextChanged);
            // 
            // txtPatID
            // 
            this.txtPatID.Location = new System.Drawing.Point(166, 81);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.Size = new System.Drawing.Size(162, 21);
            this.txtPatID.TabIndex = 0;
            this.txtPatID.TextChanged += new System.EventHandler(this.txtPatID_TextChanged);
            // 
            // txtPatHeight
            // 
            this.txtPatHeight.Location = new System.Drawing.Point(166, 159);
            this.txtPatHeight.Name = "txtPatHeight";
            this.txtPatHeight.ReadOnly = true;
            this.txtPatHeight.Size = new System.Drawing.Size(237, 21);
            this.txtPatHeight.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPatHeight, "To edit field highlight to change value");
            // 
            // txtPatWeight
            // 
            this.txtPatWeight.Location = new System.Drawing.Point(166, 206);
            this.txtPatWeight.Name = "txtPatWeight";
            this.txtPatWeight.ReadOnly = true;
            this.txtPatWeight.Size = new System.Drawing.Size(237, 21);
            this.txtPatWeight.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPatWeight, "To edit field highlight to change value\r\n");
            this.txtPatWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtPatWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatWeight_KeyPress);
            // 
            // txtpatBMI
            // 
            this.txtpatBMI.Location = new System.Drawing.Point(166, 243);
            this.txtpatBMI.Name = "txtpatBMI";
            this.txtpatBMI.ReadOnly = true;
            this.txtpatBMI.Size = new System.Drawing.Size(237, 21);
            this.txtpatBMI.TabIndex = 4;
            // 
            // txtpatPressure
            // 
            this.txtpatPressure.Location = new System.Drawing.Point(166, 353);
            this.txtpatPressure.Name = "txtpatPressure";
            this.txtpatPressure.ReadOnly = true;
            this.txtpatPressure.Size = new System.Drawing.Size(237, 21);
            this.txtpatPressure.TabIndex = 5;
            // 
            // txtPatTemperature
            // 
            this.txtPatTemperature.Location = new System.Drawing.Point(166, 389);
            this.txtPatTemperature.Name = "txtPatTemperature";
            this.txtPatTemperature.ReadOnly = true;
            this.txtPatTemperature.Size = new System.Drawing.Size(237, 21);
            this.txtPatTemperature.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictImage);
            this.groupBox1.Location = new System.Drawing.Point(449, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Image";
            // 
            // pictImage
            // 
            this.pictImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictImage.Image = global::Onana_Hospital_Management_System.Properties.Resources.index;
            this.pictImage.Location = new System.Drawing.Point(13, 19);
            this.pictImage.Name = "pictImage";
            this.pictImage.Size = new System.Drawing.Size(158, 156);
            this.pictImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictImage.TabIndex = 0;
            this.pictImage.TabStop = false;
            this.toolTip1.SetToolTip(this.pictImage, "Patient Image");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 47);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(316, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 47);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPatRespiratoryRate
            // 
            this.txtPatRespiratoryRate.Location = new System.Drawing.Point(166, 316);
            this.txtPatRespiratoryRate.Name = "txtPatRespiratoryRate";
            this.txtPatRespiratoryRate.ReadOnly = true;
            this.txtPatRespiratoryRate.Size = new System.Drawing.Size(237, 21);
            this.txtPatRespiratoryRate.TabIndex = 13;
            // 
            // txtPatPulseRate
            // 
            this.txtPatPulseRate.Location = new System.Drawing.Point(166, 280);
            this.txtPatPulseRate.Name = "txtPatPulseRate";
            this.txtPatPulseRate.ReadOnly = true;
            this.txtPatPulseRate.Size = new System.Drawing.Size(237, 21);
            this.txtPatPulseRate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pulse Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Respiratory Rate";
            // 
            // frmNurseTest
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 588);
            this.Controls.Add(this.txtPatRespiratoryRate);
            this.Controls.Add(this.txtPatPulseRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPatTemperature);
            this.Controls.Add(this.txtpatPressure);
            this.Controls.Add(this.txtpatBMI);
            this.Controls.Add(this.txtPatWeight);
            this.Controls.Add(this.txtPatHeight);
            this.Controls.Add(this.txtPatID);
            this.Controls.Add(this.txtPatName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmNurseTest.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNurseTest";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse Test - MediSphere";
            this.Load += new System.EventHandler(this.frmDiagnose_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPatName;
        private System.Windows.Forms.TextBox txtPatID;
        private System.Windows.Forms.TextBox txtPatHeight;
        private System.Windows.Forms.TextBox txtPatWeight;
        private System.Windows.Forms.TextBox txtpatBMI;
        private System.Windows.Forms.TextBox txtpatPressure;
        private System.Windows.Forms.TextBox txtPatTemperature;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPatRespiratoryRate;
        private System.Windows.Forms.TextBox txtPatPulseRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}