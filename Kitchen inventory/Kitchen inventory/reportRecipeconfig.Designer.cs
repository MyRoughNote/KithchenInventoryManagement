namespace Kitchen_inventory
{
    partial class reportRecipeconfig
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
            this.reciepeconfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeconfigDataSet = new Kitchen_inventory.recipeconfigDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reciepeconfigTableAdapter = new Kitchen_inventory.recipeconfigDataSetTableAdapters.reciepeconfigTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reciepeconfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeconfigDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // reciepeconfigBindingSource
            // 
            this.reciepeconfigBindingSource.DataMember = "reciepeconfig";
            this.reciepeconfigBindingSource.DataSource = this.recipeconfigDataSet;
            // 
            // recipeconfigDataSet
            // 
            this.recipeconfigDataSet.DataSetName = "recipeconfigDataSet";
            this.recipeconfigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "recipeconfigDataSet1";
            reportDataSource1.Value = this.reciepeconfigBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kitchen_inventory.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 131);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1281, 565);
            this.reportViewer1.TabIndex = 16;
            // 
            // reciepeconfigTableAdapter
            // 
            this.reciepeconfigTableAdapter.ClearBeforeFill = true;
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
            // reportRecipeconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 750);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportRecipeconfig";
            this.Text = "Recipes Configure Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reportRecipeconfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reciepeconfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeconfigDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reciepeconfigBindingSource;
        private recipeconfigDataSet recipeconfigDataSet;
        private recipeconfigDataSetTableAdapters.reciepeconfigTableAdapter reciepeconfigTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}