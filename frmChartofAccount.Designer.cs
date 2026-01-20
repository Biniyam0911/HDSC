namespace Onana_Hospital_Management_System
{
    partial class frmChartofAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChartofAccount));
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountReceivaleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spgetsalesfromtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOHMSDataSet4 = new Onana_Hospital_Management_System.dbOHMSDataSet4();
            this.tblOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbOHMSDataSet3 = new Onana_Hospital_Management_System.dbOHMSDataSet3();
            this.tblOrderTableAdapter = new Onana_Hospital_Management_System.dbOHMSDataSet3TableAdapters.tblOrderTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.sp_get_sales_from_toTableAdapter = new Onana_Hospital_Management_System.dbOHMSDataSet4TableAdapters.sp_get_sales_from_toTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetsalesfromtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOHMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOHMSDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(356, 459);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoGenerateColumns = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paidDateDataGridViewTextBoxColumn,
            this.accountReceivaleIDDataGridViewTextBoxColumn,
            this.jobIDDataGridViewTextBoxColumn,
            this.invoiceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvSales.DataSource = this.spgetsalesfromtoBindingSource;
            this.dgvSales.Location = new System.Drawing.Point(11, 65);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(785, 339);
            this.dgvSales.TabIndex = 1;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // paidDateDataGridViewTextBoxColumn
            // 
            this.paidDateDataGridViewTextBoxColumn.DataPropertyName = "Paid Date";
            this.paidDateDataGridViewTextBoxColumn.HeaderText = "Paid Date";
            this.paidDateDataGridViewTextBoxColumn.Name = "paidDateDataGridViewTextBoxColumn";
            // 
            // accountReceivaleIDDataGridViewTextBoxColumn
            // 
            this.accountReceivaleIDDataGridViewTextBoxColumn.DataPropertyName = "Account Receivale ID";
            this.accountReceivaleIDDataGridViewTextBoxColumn.HeaderText = "Account Receivale ID";
            this.accountReceivaleIDDataGridViewTextBoxColumn.Name = "accountReceivaleIDDataGridViewTextBoxColumn";
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "Job ID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "Job ID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            // 
            // invoiceDataGridViewTextBoxColumn
            // 
            this.invoiceDataGridViewTextBoxColumn.DataPropertyName = "Invoice";
            this.invoiceDataGridViewTextBoxColumn.HeaderText = "Invoice";
            this.invoiceDataGridViewTextBoxColumn.Name = "invoiceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // spgetsalesfromtoBindingSource
            // 
            this.spgetsalesfromtoBindingSource.DataMember = "sp_get_sales_from_to";
            this.spgetsalesfromtoBindingSource.DataSource = this.dbOHMSDataSet4;
            // 
            // dbOHMSDataSet4
            // 
            this.dbOHMSDataSet4.DataSetName = "dbOHMSDataSet4";
            this.dbOHMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrderBindingSource
            // 
            this.tblOrderBindingSource.DataMember = "tblOrder";
            this.tblOrderBindingSource.DataSource = this.dbOHMSDataSet3;
            // 
            // dbOHMSDataSet3
            // 
            this.dbOHMSDataSet3.DataSetName = "dbOHMSDataSet3";
            this.dbOHMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrderTableAdapter
            // 
            this.tblOrderTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(44, 21);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(182, 21);
            this.dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(280, 21);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(193, 21);
            this.dtpTo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(490, 18);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(62, 26);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // sp_get_sales_from_toTableAdapter
            // 
            this.sp_get_sales_from_toTableAdapter.ClearBeforeFill = true;
            // 
            // frmChartofAccount
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnSave);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmChartofAccount.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChartofAccount";
            this.Text = "Chart Of Account";
            this.Load += new System.EventHandler(this.frmChartofAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetsalesfromtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOHMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOHMSDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSales;
        private dbOHMSDataSet3 dbOHMSDataSet3;
        private System.Windows.Forms.BindingSource tblOrderBindingSource;
        private dbOHMSDataSet3TableAdapters.tblOrderTableAdapter tblOrderTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountReceivaleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spgetsalesfromtoBindingSource;
        private dbOHMSDataSet4 dbOHMSDataSet4;
        private dbOHMSDataSet4TableAdapters.sp_get_sales_from_toTableAdapter sp_get_sales_from_toTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}