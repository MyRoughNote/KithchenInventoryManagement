namespace Kitchen_inventory
{
    partial class Purchase_Order
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_purchasedetails = new System.Windows.Forms.Button();
            this.grd_purchaseorder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_purchaseorder)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(436, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Copy Rights Reserved  @ Easwari Engineering College";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 100);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitchen Inventory System";
            // 
            // btn_purchasedetails
            // 
            this.btn_purchasedetails.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchasedetails.Location = new System.Drawing.Point(25, 144);
            this.btn_purchasedetails.Name = "btn_purchasedetails";
            this.btn_purchasedetails.Size = new System.Drawing.Size(272, 41);
            this.btn_purchasedetails.TabIndex = 18;
            this.btn_purchasedetails.Text = "Items To be Purchased";
            this.btn_purchasedetails.UseVisualStyleBackColor = true;
            this.btn_purchasedetails.Click += new System.EventHandler(this.btn_purchasedetails_Click);
            // 
            // grd_purchaseorder
            // 
            this.grd_purchaseorder.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_purchaseorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_purchaseorder.Location = new System.Drawing.Point(25, 208);
            this.grd_purchaseorder.Name = "grd_purchaseorder";
            this.grd_purchaseorder.Size = new System.Drawing.Size(533, 409);
            this.grd_purchaseorder.TabIndex = 19;
            // 
            // Purchase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(726, 659);
            this.Controls.Add(this.grd_purchaseorder);
            this.Controls.Add(this.btn_purchasedetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Purchase_Order";
            this.Text = "Items To be Purchased";
            this.Load += new System.EventHandler(this.Purchase_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_purchaseorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_purchasedetails;
        private System.Windows.Forms.DataGridView grd_purchaseorder;
    }
}