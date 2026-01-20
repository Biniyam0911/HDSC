namespace Onana_Hospital_Management_System
{
    partial class ERPNextSettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblSecret = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.dgvSettings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(557, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(60, 55);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(30, 16);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key";
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(60, 102);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(46, 16);
            this.lblSecret.TabIndex = 2;
            this.lblSecret.Text = "Secret";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(60, 151);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(65, 16);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(138, 49);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(375, 22);
            this.txtKey.TabIndex = 4;
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(138, 96);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(375, 22);
            this.txtSecret.TabIndex = 5;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(138, 145);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(375, 22);
            this.txtCompany.TabIndex = 6;
            // 
            // dgvSettings
            // 
            this.dgvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSettings.Location = new System.Drawing.Point(63, 235);
            this.dgvSettings.Name = "dgvSettings";
            this.dgvSettings.RowHeadersWidth = 51;
            this.dgvSettings.RowTemplate.Height = 24;
            this.dgvSettings.Size = new System.Drawing.Size(702, 203);
            this.dgvSettings.TabIndex = 7;
            // 
            // ERPNextSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSettings);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnSave);
            this.Name = "ERPNextSettings";
            this.Text = "ERPNextSettings";
            this.Load += new System.EventHandler(this.ERPNextSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.DataGridView dgvSettings;
    }
}