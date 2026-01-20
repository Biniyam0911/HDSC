namespace Onana_Hospital_Management_System
{
    partial class frmViewProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewProcedure));
            this.grpProcedures = new System.Windows.Forms.GroupBox();
            this.dgvProcedures = new System.Windows.Forms.DataGridView();
            this.cmbFullname = new System.Windows.Forms.ComboBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.grpProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedures)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProcedures
            // 
            this.grpProcedures.Controls.Add(this.dgvProcedures);
            this.grpProcedures.Location = new System.Drawing.Point(9, 67);
            this.grpProcedures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProcedures.Name = "grpProcedures";
            this.grpProcedures.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProcedures.Size = new System.Drawing.Size(781, 342);
            this.grpProcedures.TabIndex = 0;
            this.grpProcedures.TabStop = false;
            this.grpProcedures.Text = "Procedures";
            // 
            // dgvProcedures
            // 
            this.dgvProcedures.AllowUserToAddRows = false;
            this.dgvProcedures.AllowUserToDeleteRows = false;
            this.dgvProcedures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcedures.Location = new System.Drawing.Point(2, 16);
            this.dgvProcedures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProcedures.Name = "dgvProcedures";
            this.dgvProcedures.ReadOnly = true;
            this.dgvProcedures.RowTemplate.Height = 24;
            this.dgvProcedures.Size = new System.Drawing.Size(777, 324);
            this.dgvProcedures.TabIndex = 0;
            // 
            // cmbFullname
            // 
            this.cmbFullname.FormattingEnabled = true;
            this.cmbFullname.Location = new System.Drawing.Point(106, 24);
            this.cmbFullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFullname.Name = "cmbFullname";
            this.cmbFullname.Size = new System.Drawing.Size(239, 21);
            this.cmbFullname.TabIndex = 1;
            this.cmbFullname.SelectedIndexChanged += new System.EventHandler(this.cmbFullName_SelectionChanged);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(9, 27);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(50, 13);
            this.lblFullname.TabIndex = 2;
            this.lblFullname.Text = "FullName";
            // 
            // frmViewProcedure
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 418);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.cmbFullname);
            this.Controls.Add(this.grpProcedures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmViewProcedure.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewProcedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Procedure";
            this.Load += new System.EventHandler(this.frmViewProcedure_Load);
            this.grpProcedures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProcedures;
        private System.Windows.Forms.ComboBox cmbFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.DataGridView dgvProcedures;
    }
}