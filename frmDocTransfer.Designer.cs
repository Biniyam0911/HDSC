namespace Onana_Hospital_Management_System
{
    partial class frmDocTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocTransfer));
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblTransferFrom = new System.Windows.Forms.Label();
            this.lblTransferTo = new System.Windows.Forms.Label();
            this.cmbPatientName = new System.Windows.Forms.ComboBox();
            this.txtTransferFrom = new System.Windows.Forms.TextBox();
            this.cmbTransferTo = new System.Windows.Forms.ComboBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(57, 50);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblPatientName.TabIndex = 0;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblTransferFrom
            // 
            this.lblTransferFrom.AutoSize = true;
            this.lblTransferFrom.Location = new System.Drawing.Point(57, 99);
            this.lblTransferFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransferFrom.Name = "lblTransferFrom";
            this.lblTransferFrom.Size = new System.Drawing.Size(75, 13);
            this.lblTransferFrom.TabIndex = 1;
            this.lblTransferFrom.Text = "Transfer From";
            // 
            // lblTransferTo
            // 
            this.lblTransferTo.AutoSize = true;
            this.lblTransferTo.Location = new System.Drawing.Point(60, 158);
            this.lblTransferTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransferTo.Name = "lblTransferTo";
            this.lblTransferTo.Size = new System.Drawing.Size(63, 13);
            this.lblTransferTo.TabIndex = 2;
            this.lblTransferTo.Text = "Transfer To";
            // 
            // cmbPatientName
            // 
            this.cmbPatientName.FormattingEnabled = true;
            this.cmbPatientName.Location = new System.Drawing.Point(151, 48);
            this.cmbPatientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPatientName.Name = "cmbPatientName";
            this.cmbPatientName.Size = new System.Drawing.Size(202, 21);
            this.cmbPatientName.TabIndex = 3;
            this.cmbPatientName.SelectedIndexChanged += new System.EventHandler(this.cmbPatientName_SelectedIndexChanged);
            // 
            // txtTransferFrom
            // 
            this.txtTransferFrom.Location = new System.Drawing.Point(151, 97);
            this.txtTransferFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTransferFrom.Name = "txtTransferFrom";
            this.txtTransferFrom.ReadOnly = true;
            this.txtTransferFrom.Size = new System.Drawing.Size(202, 21);
            this.txtTransferFrom.TabIndex = 4;
            // 
            // cmbTransferTo
            // 
            this.cmbTransferTo.FormattingEnabled = true;
            this.cmbTransferTo.Location = new System.Drawing.Point(151, 156);
            this.cmbTransferTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTransferTo.Name = "cmbTransferTo";
            this.cmbTransferTo.Size = new System.Drawing.Size(202, 21);
            this.cmbTransferTo.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(200, 224);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(117, 45);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // frmDocTransfer
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 337);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.cmbTransferTo);
            this.Controls.Add(this.txtTransferFrom);
            this.Controls.Add(this.cmbPatientName);
            this.Controls.Add(this.lblTransferTo);
            this.Controls.Add(this.lblTransferFrom);
            this.Controls.Add(this.lblPatientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmDocTransfer.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDocTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docor Transfer";
            this.Load += new System.EventHandler(this.frmDocTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblTransferFrom;
        private System.Windows.Forms.Label lblTransferTo;
        private System.Windows.Forms.ComboBox cmbPatientName;
        private System.Windows.Forms.TextBox txtTransferFrom;
        private System.Windows.Forms.ComboBox cmbTransferTo;
        private System.Windows.Forms.Button btnTransfer;
    }
}