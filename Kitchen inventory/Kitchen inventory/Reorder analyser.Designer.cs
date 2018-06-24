namespace Kitchen_inventory
{
    partial class Reorder_analyser
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
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_checkall = new System.Windows.Forms.Button();
            this.lbl_reorder = new System.Windows.Forms.Label();
            this.txt_reordersearch = new System.Windows.Forms.TextBox();
            this.grd_reorder = new System.Windows.Forms.DataGridView();
            this.btn_showall = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_reorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Location = new System.Drawing.Point(740, 190);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(139, 34);
            this.btn_check.TabIndex = 56;
            this.btn_check.Text = "Re-Order Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_checkall
            // 
            this.btn_checkall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkall.Location = new System.Drawing.Point(898, 190);
            this.btn_checkall.Name = "btn_checkall";
            this.btn_checkall.Size = new System.Drawing.Size(159, 34);
            this.btn_checkall.TabIndex = 57;
            this.btn_checkall.Text = "Re-Order Check All";
            this.btn_checkall.UseVisualStyleBackColor = true;
            this.btn_checkall.Click += new System.EventHandler(this.btn_checkall_Click);
            // 
            // lbl_reorder
            // 
            this.lbl_reorder.AutoSize = true;
            this.lbl_reorder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reorder.Location = new System.Drawing.Point(138, 190);
            this.lbl_reorder.Name = "lbl_reorder";
            this.lbl_reorder.Size = new System.Drawing.Size(263, 19);
            this.lbl_reorder.TabIndex = 58;
            this.lbl_reorder.Text = "Enter the Dish Id for Re-Order Check";
            // 
            // txt_reordersearch
            // 
            this.txt_reordersearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reordersearch.Location = new System.Drawing.Point(425, 190);
            this.txt_reordersearch.Name = "txt_reordersearch";
            this.txt_reordersearch.Size = new System.Drawing.Size(206, 26);
            this.txt_reordersearch.TabIndex = 59;
            // 
            // grd_reorder
            // 
            this.grd_reorder.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_reorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_reorder.Location = new System.Drawing.Point(142, 241);
            this.grd_reorder.Name = "grd_reorder";
            this.grd_reorder.ReadOnly = true;
            this.grd_reorder.Size = new System.Drawing.Size(562, 424);
            this.grd_reorder.TabIndex = 60;
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showall.Location = new System.Drawing.Point(740, 241);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(317, 34);
            this.btn_showall.TabIndex = 61;
            this.btn_showall.Text = "Show All Items";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(45, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
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
            this.label2.TabIndex = 63;
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
            this.label1.TabIndex = 62;
            this.label1.Text = "      Kitchen Inventory System";
            // 
            // Reorder_analyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.grd_reorder);
            this.Controls.Add(this.txt_reordersearch);
            this.Controls.Add(this.lbl_reorder);
            this.Controls.Add(this.btn_checkall);
            this.Controls.Add(this.btn_check);
            this.Name = "Reorder_analyser";
            this.Text = "Reorder Analyser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reorder_analyser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_reorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_checkall;
        private System.Windows.Forms.Label lbl_reorder;
        private System.Windows.Forms.TextBox txt_reordersearch;
        private System.Windows.Forms.DataGridView grd_reorder;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}