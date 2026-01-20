namespace Onana_Hospital_Management_System
{
    partial class frmLaboratory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratory));
            this.trvTests = new System.Windows.Forms.TreeView();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.chkRoutine = new System.Windows.Forms.CheckBox();
            this.lblClinicalData = new System.Windows.Forms.Label();
            this.txtClinicalData = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnOAdd = new System.Windows.Forms.Button();
            this.gridControlTests = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // trvTests
            // 
            this.trvTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvTests.CheckBoxes = true;
            this.trvTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvTests.Indent = 30;
            this.trvTests.ItemHeight = 25;
            this.trvTests.Location = new System.Drawing.Point(9, 111);
            this.trvTests.Margin = new System.Windows.Forms.Padding(2);
            this.trvTests.Name = "trvTests";
            this.trvTests.Size = new System.Drawing.Size(337, 444);
            this.trvTests.TabIndex = 0;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(83, 7);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(245, 21);
            this.txtFullname.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fullname";
            // 
            // txtCardno
            // 
            this.txtCardno.Location = new System.Drawing.Point(81, 40);
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.ReadOnly = true;
            this.txtCardno.Size = new System.Drawing.Size(247, 21);
            this.txtCardno.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Card No.";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(81, 76);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(247, 21);
            this.txtSex.TabIndex = 18;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(12, 79);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 17;
            this.lblSex.Text = "Sex";
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(344, 12);
            this.chkUrgent.Margin = new System.Windows.Forms.Padding(2);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(59, 17);
            this.chkUrgent.TabIndex = 19;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // chkRoutine
            // 
            this.chkRoutine.AutoSize = true;
            this.chkRoutine.Location = new System.Drawing.Point(344, 49);
            this.chkRoutine.Margin = new System.Windows.Forms.Padding(2);
            this.chkRoutine.Name = "chkRoutine";
            this.chkRoutine.Size = new System.Drawing.Size(63, 17);
            this.chkRoutine.TabIndex = 20;
            this.chkRoutine.Text = "Routine";
            this.chkRoutine.UseVisualStyleBackColor = true;
            // 
            // lblClinicalData
            // 
            this.lblClinicalData.AutoSize = true;
            this.lblClinicalData.Location = new System.Drawing.Point(361, 562);
            this.lblClinicalData.Name = "lblClinicalData";
            this.lblClinicalData.Size = new System.Drawing.Size(65, 13);
            this.lblClinicalData.TabIndex = 21;
            this.lblClinicalData.Text = "Clinical Data";
            // 
            // txtClinicalData
            // 
            this.txtClinicalData.Location = new System.Drawing.Point(362, 578);
            this.txtClinicalData.Multiline = true;
            this.txtClinicalData.Name = "txtClinicalData";
            this.txtClinicalData.Size = new System.Drawing.Size(626, 62);
            this.txtClinicalData.TabIndex = 22;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(562, 12);
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(532, 110);
            this.txtOther.TabIndex = 24;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(449, 15);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(91, 13);
            this.lblOther.TabIndex = 23;
            this.lblOther.Text = "Other Lab Orders";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(358, 111);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 30);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(993, 610);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 30);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Save and Print";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnOAdd
            // 
            this.btnOAdd.Location = new System.Drawing.Point(988, 127);
            this.btnOAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnOAdd.Name = "btnOAdd";
            this.btnOAdd.Size = new System.Drawing.Size(106, 30);
            this.btnOAdd.TabIndex = 27;
            this.btnOAdd.Text = "Add Custom Order";
            this.btnOAdd.UseVisualStyleBackColor = true;
            this.btnOAdd.Click += new System.EventHandler(this.btnOAdd_Click);
            // 
            // gridControlTests
            // 
            this.gridControlTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlTests.Location = new System.Drawing.Point(364, 162);
            this.gridControlTests.MainView = this.gridView1;
            this.gridControlTests.Name = "gridControlTests";
            this.gridControlTests.Size = new System.Drawing.Size(733, 381);
            this.gridControlTests.TabIndex = 28;
            this.gridControlTests.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlTests;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmLaboratory
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 652);
            this.Controls.Add(this.gridControlTests);
            this.Controls.Add(this.btnOAdd);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.txtClinicalData);
            this.Controls.Add(this.lblClinicalData);
            this.Controls.Add(this.chkRoutine);
            this.Controls.Add(this.chkUrgent);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trvTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmLaboratory.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLaboratory";
            this.Text = "Request Laboratory Test";
            this.Load += new System.EventHandler(this.frmLaboratory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvTests;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.CheckBox chkRoutine;
        private System.Windows.Forms.Label lblClinicalData;
        private System.Windows.Forms.TextBox txtClinicalData;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnOAdd;
        private DevExpress.XtraGrid.GridControl gridControlTests;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}