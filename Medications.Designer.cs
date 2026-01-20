namespace Onana_Hospital_Management_System
{
    partial class Medications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medications));
            this.btnAddItems = new System.Windows.Forms.Button();
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMedname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItems
            // 
            this.btnAddItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItems.Location = new System.Drawing.Point(722, 108);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(119, 23);
            this.btnAddItems.TabIndex = 7;
            this.btnAddItems.Text = "Add Item";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // dgvMedications
            // 
            this.dgvMedications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.Location = new System.Drawing.Point(11, 171);
            this.dgvMedications.MultiSelect = false;
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.ReadOnly = true;
            this.dgvMedications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedications.Size = new System.Drawing.Size(830, 270);
            this.dgvMedications.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Frequency";
            // 
            // txtCMedname
            // 
            this.txtCMedname.Location = new System.Drawing.Point(80, 26);
            this.txtCMedname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMedname.Multiline = true;
            this.txtCMedname.Name = "txtCMedname";
            this.txtCMedname.Size = new System.Drawing.Size(761, 77);
            this.txtCMedname.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Additional Medication";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(80, 112);
            this.txtFrequency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFrequency.Multiline = true;
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(626, 42);
            this.txtFrequency.TabIndex = 34;
            // 
            // Medications
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCMedname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.dgvMedications);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Medications.IconOptions.Icon")));
            this.Name = "Medications";
            this.Text = "Medications";
            this.Load += new System.EventHandler(this.Medications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMedname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrequency;
    }
}