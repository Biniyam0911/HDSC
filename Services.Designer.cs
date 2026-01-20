namespace Onana_Hospital_Management_System
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServices
            // 
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(14, 37);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(830, 375);
            this.dgvServices.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(137, 444);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(146, 21);
            this.txtQuantity.TabIndex = 1;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(66, 444);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(724, 444);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(118, 23);
            this.btnAddItems.TabIndex = 3;
            this.btnAddItems.Text = "Add Item";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // Services
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 484);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dgvServices);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Services.IconOptions.Icon")));
            this.Name = "Services";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddItems;
    }
}