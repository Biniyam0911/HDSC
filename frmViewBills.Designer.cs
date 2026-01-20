namespace Onana_Hospital_Management_System
{
    partial class frmViewBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBills));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRefundInvoice = new System.Windows.Forms.Label();
            this.txtRefundInvoice = new System.Windows.Forms.TextBox();
            this.btnRefundInvoice = new System.Windows.Forms.Button();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.txtInvoiceToCancel = new System.Windows.Forms.TextBox();
            this.chkShowPosted = new System.Windows.Forms.CheckBox();
            this.btnReversePost = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERPNextInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRefundInvoice);
            this.groupBox1.Controls.Add(this.txtRefundInvoice);
            this.groupBox1.Controls.Add(this.btnRefundInvoice);
            this.groupBox1.Controls.Add(this.lblInvoice);
            this.groupBox1.Controls.Add(this.txtInvoiceToCancel);
            this.groupBox1.Controls.Add(this.chkShowPosted);
            this.groupBox1.Controls.Add(this.btnReversePost);
            this.groupBox1.Controls.Add(this.btnPost);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1590, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Filtering";
            // 
            // lblRefundInvoice
            // 
            this.lblRefundInvoice.AutoSize = true;
            this.lblRefundInvoice.Location = new System.Drawing.Point(650, 113);
            this.lblRefundInvoice.Name = "lblRefundInvoice";
            this.lblRefundInvoice.Size = new System.Drawing.Size(161, 16);
            this.lblRefundInvoice.TabIndex = 23;
            this.lblRefundInvoice.Text = "ERPNext Invoice To Refund";
            // 
            // txtRefundInvoice
            // 
            this.txtRefundInvoice.Location = new System.Drawing.Point(880, 108);
            this.txtRefundInvoice.Name = "txtRefundInvoice";
            this.txtRefundInvoice.Size = new System.Drawing.Size(354, 23);
            this.txtRefundInvoice.TabIndex = 22;
            // 
            // btnRefundInvoice
            // 
            this.btnRefundInvoice.Location = new System.Drawing.Point(1260, 95);
            this.btnRefundInvoice.Name = "btnRefundInvoice";
            this.btnRefundInvoice.Size = new System.Drawing.Size(153, 53);
            this.btnRefundInvoice.TabIndex = 21;
            this.btnRefundInvoice.Text = "Refund Posted Invoice";
            this.btnRefundInvoice.UseVisualStyleBackColor = true;
            this.btnRefundInvoice.Click += new System.EventHandler(this.btnRefundInvoice_Click);
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(650, 48);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(159, 16);
            this.lblInvoice.TabIndex = 20;
            this.lblInvoice.Text = "ERPNext Invoice To Cancel";
            // 
            // txtInvoiceToCancel
            // 
            this.txtInvoiceToCancel.Location = new System.Drawing.Point(880, 43);
            this.txtInvoiceToCancel.Name = "txtInvoiceToCancel";
            this.txtInvoiceToCancel.Size = new System.Drawing.Size(354, 23);
            this.txtInvoiceToCancel.TabIndex = 19;
            // 
            // chkShowPosted
            // 
            this.chkShowPosted.AutoSize = true;
            this.chkShowPosted.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.chkShowPosted.Location = new System.Drawing.Point(66, 155);
            this.chkShowPosted.Name = "chkShowPosted";
            this.chkShowPosted.Size = new System.Drawing.Size(151, 20);
            this.chkShowPosted.TabIndex = 18;
            this.chkShowPosted.Text = "Show Posted Sales";
            this.chkShowPosted.UseVisualStyleBackColor = true;
            // 
            // btnReversePost
            // 
            this.btnReversePost.Location = new System.Drawing.Point(1260, 30);
            this.btnReversePost.Name = "btnReversePost";
            this.btnReversePost.Size = new System.Drawing.Size(153, 53);
            this.btnReversePost.TabIndex = 17;
            this.btnReversePost.Text = "Cancel Posted Invoice";
            this.btnReversePost.UseVisualStyleBackColor = true;
            this.btnReversePost.Click += new System.EventHandler(this.btnReversePost_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(389, 101);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(142, 53);
            this.btnPost.TabIndex = 16;
            this.btnPost.Text = "Post To ERPNext";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(389, 27);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 53);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(8, 108);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 16);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(8, 43);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(37, 16);
            this.lblFrom.TabIndex = 13;
            this.lblFrom.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(66, 101);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(277, 23);
            this.dtpTo.TabIndex = 12;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(66, 38);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(277, 23);
            this.dtpFrom.TabIndex = 11;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToOrderColumns = true;
            this.dgvSales.AllowUserToResizeColumns = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.InvoiceNumber,
            this.CustomerID,
            this.Customer,
            this.ItemCode,
            this.Item,
            this.Category,
            this.UnitPrice,
            this.Quantity,
            this.TotalPrice,
            this.Cashier,
            this.PostingDate,
            this.ERPNextInvoiceNo,
            this.Posted});
            this.dgvSales.Location = new System.Drawing.Point(13, 263);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSales.Size = new System.Drawing.Size(1590, 629);
            this.dgvSales.TabIndex = 5;
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "BillID";
            this.BillID.MinimumWidth = 6;
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            this.BillID.Width = 125;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumber.HeaderText = "InvoiceNumber";
            this.InvoiceNumber.MinimumWidth = 6;
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            this.InvoiceNumber.Width = 125;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 125;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 125;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 125;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 125;
            // 
            // Cashier
            // 
            this.Cashier.DataPropertyName = "Cashier";
            this.Cashier.HeaderText = "Cashier";
            this.Cashier.MinimumWidth = 6;
            this.Cashier.Name = "Cashier";
            this.Cashier.ReadOnly = true;
            this.Cashier.Width = 125;
            // 
            // PostingDate
            // 
            this.PostingDate.DataPropertyName = "PostingDate";
            this.PostingDate.HeaderText = "PostingDate";
            this.PostingDate.MinimumWidth = 6;
            this.PostingDate.Name = "PostingDate";
            this.PostingDate.ReadOnly = true;
            this.PostingDate.Width = 125;
            // 
            // ERPNextInvoiceNo
            // 
            this.ERPNextInvoiceNo.DataPropertyName = "ERPNextInvoiceNo";
            this.ERPNextInvoiceNo.HeaderText = "ERPNextInvoiceNo";
            this.ERPNextInvoiceNo.MinimumWidth = 6;
            this.ERPNextInvoiceNo.Name = "ERPNextInvoiceNo";
            this.ERPNextInvoiceNo.ReadOnly = true;
            this.ERPNextInvoiceNo.Width = 125;
            // 
            // Posted
            // 
            this.Posted.DataPropertyName = "Posted";
            this.Posted.HeaderText = "Posted";
            this.Posted.MinimumWidth = 6;
            this.Posted.Name = "Posted";
            this.Posted.ReadOnly = true;
            this.Posted.Width = 125;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1463, 900);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 49);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmViewBills
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(200)))), ((int)(((byte)(206)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 962);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmViewBills.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmViewBills";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Sales";
            this.Load += new System.EventHandler(this.frmViewBills_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnReversePost;
        private System.Windows.Forms.CheckBox chkShowPosted;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.TextBox txtInvoiceToCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERPNextInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posted;
        private System.Windows.Forms.Label lblRefundInvoice;
        private System.Windows.Forms.TextBox txtRefundInvoice;
        private System.Windows.Forms.Button btnRefundInvoice;
    }
}