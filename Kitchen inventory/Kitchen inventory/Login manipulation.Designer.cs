namespace Kitchen_inventory
{
    partial class Loginmanipulation
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
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.grd_logindetail = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_logindetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(246, 141);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(162, 26);
            this.txt_date.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(246, 185);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(162, 26);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(246, 235);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(162, 26);
            this.txt_password.TabIndex = 2;
            // 
            // txt_role
            // 
            this.txt_role.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.Location = new System.Drawing.Point(246, 286);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(162, 26);
            this.txt_role.TabIndex = 3;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(135, 148);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(42, 19);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(135, 192);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(85, 19);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "User Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(135, 242);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(72, 19);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(135, 293);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(41, 19);
            this.lbl_role.TabIndex = 7;
            this.lbl_role.Text = "Role";
            // 
            // grd_logindetail
            // 
            this.grd_logindetail.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_logindetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_logindetail.Location = new System.Drawing.Point(466, 141);
            this.grd_logindetail.Name = "grd_logindetail";
            this.grd_logindetail.ReadOnly = true;
            this.grd_logindetail.Size = new System.Drawing.Size(449, 171);
            this.grd_logindetail.TabIndex = 8;
            this.grd_logindetail.SelectionChanged += new System.EventHandler(this.grd_logindetail_SelectionChanged);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(241, 345);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 32);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(333, 345);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 32);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(942, 91);
            this.label1.TabIndex = 58;
            this.label1.Text = "Kitchen Inventory System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(631, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 14);
            this.label2.TabIndex = 59;
            this.label2.Text = "Copy Rights Reserved  @ Easwari Engineering College";
            // 
            // Loginmanipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(962, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.grd_logindetail);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_date);
            this.Name = "Loginmanipulation";
            this.Text = "Authentication Manipulation";
            this.Load += new System.EventHandler(this.Loginmanipulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_logindetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.DataGridView grd_logindetail;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}