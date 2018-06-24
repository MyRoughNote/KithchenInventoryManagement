namespace Kitchen_inventory
{
    partial class reportstockinventory
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.stockinventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockinventoryDataSet = new Kitchen_inventory.stockinventoryDataSet();
            this.rpt_stockinventory = new Microsoft.Reporting.WinForms.ReportViewer();
            this.stockinventoryTableAdapter = new Kitchen_inventory.stockinventoryDataSetTableAdapters.stockinventoryTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockinventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockinventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // stockinventoryBindingSource
            // 
            this.stockinventoryBindingSource.DataMember = "stockinventory";
            this.stockinventoryBindingSource.DataSource = this.stockinventoryDataSet;
            // 
            // stockinventoryDataSet
            // 
            this.stockinventoryDataSet.DataSetName = "stockinventoryDataSet";
            this.stockinventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpt_stockinventory
            // 
            reportDataSource1.Name = "Stockinventory";
            reportDataSource1.Value = this.stockinventoryBindingSource;
            this.rpt_stockinventory.LocalReport.DataSources.Add(reportDataSource1);
            this.rpt_stockinventory.LocalReport.ReportEmbeddedResource = "Kitchen_inventory.Report1.rdlc";
            this.rpt_stockinventory.Location = new System.Drawing.Point(51, 139);
            this.rpt_stockinventory.Name = "rpt_stockinventory";
            this.rpt_stockinventory.Size = new System.Drawing.Size(1258, 567);
            this.rpt_stockinventory.TabIndex = 0;
            // 
            // stockinventoryTableAdapter
            // 
            this.stockinventoryTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(45, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1043, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "Copy Rights Reserved  @ Easwari Engineering College";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 91);
            this.label1.TabIndex = 33;
            this.label1.Text = "       Kitchen Inventory System";
            // 
            // reportstockinventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpt_stockinventory);
            this.Name = "reportstockinventory";
            this.Text = "Stock Inventory Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reportstockinventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockinventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockinventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_stockinventory;
        private System.Windows.Forms.BindingSource stockinventoryBindingSource;
        private stockinventoryDataSet stockinventoryDataSet;
        private stockinventoryDataSetTableAdapters.stockinventoryTableAdapter stockinventoryTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}