namespace Onana_Hospital_Management_System
{
    partial class frmServiceSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceSetting));
            this.dgServices = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtServiceCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDServiceCode = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnPostService = new System.Windows.Forms.Button();
            this.Posted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgServices
            // 
            this.dgServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Description,
            this.Price,
            this.category,
            this.Active,
            this.Posted});
            this.dgServices.Location = new System.Drawing.Point(14, 188);
            this.dgServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgServices.MultiSelect = false;
            this.dgServices.Name = "dgServices";
            this.dgServices.ReadOnly = true;
            this.dgServices.RowHeadersWidth = 51;
            this.dgServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgServices.Size = new System.Drawing.Size(1181, 519);
            this.dgServices.TabIndex = 0;
            this.dgServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_Clicked);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(1066, 106);
            this.btnAddUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(128, 50);
            this.btnAddUpdate.TabIndex = 1;
            this.btnAddUpdate.Text = "Add/Update Service";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Service";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtServiceCode
            // 
            this.txtServiceCode.Location = new System.Drawing.Point(106, 98);
            this.txtServiceCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceCode.Name = "txtServiceCode";
            this.txtServiceCode.Size = new System.Drawing.Size(170, 23);
            this.txtServiceCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Service Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Service Name";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(373, 98);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceName.Multiline = true;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(428, 61);
            this.txtServiceName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(884, 98);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(176, 23);
            this.txtPrice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service Code";
            // 
            // txtDServiceCode
            // 
            this.txtDServiceCode.Location = new System.Drawing.Point(106, 28);
            this.txtDServiceCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtDServiceCode.Name = "txtDServiceCode";
            this.txtDServiceCode.Size = new System.Drawing.Size(170, 23);
            this.txtDServiceCode.TabIndex = 10;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Consultation",
            "Laboratory",
            "Procedure",
            "Pharmacy"});
            this.cmbCategory.Location = new System.Drawing.Point(884, 132);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(176, 24);
            this.cmbCategory.TabIndex = 12;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(817, 139);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 16);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category";
            // 
            // btnPostService
            // 
            this.btnPostService.Location = new System.Drawing.Point(1032, 15);
            this.btnPostService.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostService.Name = "btnPostService";
            this.btnPostService.Size = new System.Drawing.Size(164, 50);
            this.btnPostService.TabIndex = 14;
            this.btnPostService.Text = "Post Service";
            this.btnPostService.UseVisualStyleBackColor = true;
            this.btnPostService.Click += new System.EventHandler(this.btnPostService_Click);
            // 
            // Posted
            // 
            this.Posted.HeaderText = "Posted";
            this.Posted.MinimumWidth = 6;
            this.Posted.Name = "Posted";
            this.Posted.ReadOnly = true;
            // 
            // frmServiceSetting
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 722);
            this.Controls.Add(this.btnPostService);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDServiceCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServiceCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.dgServices);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmServiceSetting.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmServiceSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Setting";
            this.Load += new System.EventHandler(this.frmServiceSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgServices;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtServiceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDServiceCode;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.Button btnPostService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posted;
    }
}