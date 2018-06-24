namespace Kitchen_inventory
{
    partial class CustomerDetail
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_newitem = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_showall = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_cusid = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_cusid = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.grd_customerdetail = new System.Windows.Forms.DataGridView();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerManipulationupdateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_customerdetail)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(296, 507);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 36);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(402, 507);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 36);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_newitem
            // 
            this.btn_newitem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newitem.Location = new System.Drawing.Point(496, 507);
            this.btn_newitem.Name = "btn_newitem";
            this.btn_newitem.Size = new System.Drawing.Size(93, 36);
            this.btn_newitem.TabIndex = 27;
            this.btn_newitem.Text = "New Item";
            this.btn_newitem.UseVisualStyleBackColor = true;
            this.btn_newitem.Click += new System.EventHandler(this.btn_newitem_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1059, 158);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 37);
            this.btn_search.TabIndex = 28;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showall.Location = new System.Drawing.Point(1156, 158);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(95, 37);
            this.btn_showall.TabIndex = 29;
            this.btn_showall.Text = "Show All";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(181, 188);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(42, 19);
            this.lbl_date.TabIndex = 30;
            this.lbl_date.Text = "Date";
            // 
            // lbl_cusid
            // 
            this.lbl_cusid.AutoSize = true;
            this.lbl_cusid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cusid.Location = new System.Drawing.Point(181, 229);
            this.lbl_cusid.Name = "lbl_cusid";
            this.lbl_cusid.Size = new System.Drawing.Size(96, 19);
            this.lbl_cusid.TabIndex = 31;
            this.lbl_cusid.Text = "Customer ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(181, 270);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 19);
            this.lbl_name.TabIndex = 32;
            this.lbl_name.Text = "Name";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(181, 310);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(74, 19);
            this.lbl_phone.TabIndex = 33;
            this.lbl_phone.Text = "Phone No";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(181, 352);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(64, 19);
            this.lbl_address.TabIndex = 34;
            this.lbl_address.Text = "Address";
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(297, 181);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(100, 26);
            this.txt_date.TabIndex = 35;
            // 
            // txt_cusid
            // 
            this.txt_cusid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusid.Location = new System.Drawing.Point(297, 222);
            this.txt_cusid.Name = "txt_cusid";
            this.txt_cusid.Size = new System.Drawing.Size(126, 26);
            this.txt_cusid.TabIndex = 36;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(297, 263);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 26);
            this.txt_name.TabIndex = 37;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(297, 307);
            this.txt_phone.MaxLength = 10;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(171, 26);
            this.txt_phone.TabIndex = 38;
            this.txt_phone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phone_Validating);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(297, 352);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(312, 136);
            this.txt_address.TabIndex = 39;
            // 
            // grd_customerdetail
            // 
            this.grd_customerdetail.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_customerdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_customerdetail.Location = new System.Drawing.Point(692, 222);
            this.grd_customerdetail.Name = "grd_customerdetail";
            this.grd_customerdetail.ReadOnly = true;
            this.grd_customerdetail.Size = new System.Drawing.Size(632, 476);
            this.grd_customerdetail.TabIndex = 40;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(688, 164);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(204, 19);
            this.lbl_search.TabIndex = 41;
            this.lbl_search.Text = "Enter Customer ID to Search";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(898, 164);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(144, 26);
            this.txt_search.TabIndex = 42;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerManipulationupdateDeleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 27);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerManipulationupdateDeleteToolStripMenuItem
            // 
            this.customerManipulationupdateDeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.customerManipulationupdateDeleteToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManipulationupdateDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerManipulationupdateDeleteToolStripMenuItem.Name = "customerManipulationupdateDeleteToolStripMenuItem";
            this.customerManipulationupdateDeleteToolStripMenuItem.Size = new System.Drawing.Size(287, 23);
            this.customerManipulationupdateDeleteToolStripMenuItem.Text = "Customer Manipulation [update/Delete]";
            this.customerManipulationupdateDeleteToolStripMenuItem.Click += new System.EventHandler(this.customerManipulationupdateDeleteToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(45, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1043, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 14);
            this.label2.TabIndex = 45;
            this.label2.Text = "Copy Rights Reserved  @ Easwari Engineering College";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 91);
            this.label1.TabIndex = 44;
            this.label1.Text = "      Kitchen Inventory System";
            // 
            // CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.grd_customerdetail);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_cusid);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_cusid);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_newitem);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerDetail";
            this.Text = "Customer Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_customerdetail)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_newitem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_cusid;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_cusid;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.DataGridView grd_customerdetail;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerManipulationupdateDeleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}