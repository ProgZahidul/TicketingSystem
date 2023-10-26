namespace TicketingSystem
{
    partial class InvoiceListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInvoiceListReport = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInvoiceListReport);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 597);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1200, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnInvoiceListReport
            // 
            this.btnInvoiceListReport.Location = new System.Drawing.Point(566, 12);
            this.btnInvoiceListReport.Name = "btnInvoiceListReport";
            this.btnInvoiceListReport.Size = new System.Drawing.Size(101, 34);
            this.btnInvoiceListReport.TabIndex = 1;
            this.btnInvoiceListReport.Text = "ViewReport";
            this.btnInvoiceListReport.UseVisualStyleBackColor = true;
            this.btnInvoiceListReport.Click += new System.EventHandler(this.btnInvoiceListReport_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(396, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 38);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(183, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIdDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.passengerNameDataGridViewTextBoxColumn,
            this.passengerAddressDataGridViewTextBoxColumn,
            this.phonNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceMasterBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 597);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // passengerNameDataGridViewTextBoxColumn
            // 
            this.passengerNameDataGridViewTextBoxColumn.DataPropertyName = "PassengerName";
            this.passengerNameDataGridViewTextBoxColumn.HeaderText = "PassengerName";
            this.passengerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passengerNameDataGridViewTextBoxColumn.Name = "passengerNameDataGridViewTextBoxColumn";
            this.passengerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.passengerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passengerAddressDataGridViewTextBoxColumn
            // 
            this.passengerAddressDataGridViewTextBoxColumn.DataPropertyName = "PassengerAddress";
            this.passengerAddressDataGridViewTextBoxColumn.HeaderText = "PassengerAddress";
            this.passengerAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passengerAddressDataGridViewTextBoxColumn.Name = "passengerAddressDataGridViewTextBoxColumn";
            this.passengerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.passengerAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phonNoDataGridViewTextBoxColumn
            // 
            this.phonNoDataGridViewTextBoxColumn.DataPropertyName = "PhonNo";
            this.phonNoDataGridViewTextBoxColumn.HeaderText = "PhonNo";
            this.phonNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phonNoDataGridViewTextBoxColumn.Name = "phonNoDataGridViewTextBoxColumn";
            this.phonNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceMasterBindingSource
            // 
            this.invoiceMasterBindingSource.DataSource = typeof(TicketingSystem.App_Data.InvoiceMaster);
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InvoiceListForm";
            this.Text = "InvoiceListForm";
            this.Load += new System.EventHandler(this.InvoiceListForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInvoiceListReport;
        private System.Windows.Forms.Button btnFilter;
    }
}