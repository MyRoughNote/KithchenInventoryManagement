namespace Kitchen_inventory
{
    partial class Dishmanipulation
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
            this.txt_dishdate = new System.Windows.Forms.TextBox();
            this.txt_dishid = new System.Windows.Forms.TextBox();
            this.txt_dishname = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_dishid = new System.Windows.Forms.Label();
            this.lbl_dishname = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_dishdelete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.grd_dishedit = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dishedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dishdate
            // 
            this.txt_dishdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishdate.Location = new System.Drawing.Point(269, 191);
            this.txt_dishdate.Name = "txt_dishdate";
            this.txt_dishdate.ReadOnly = true;
            this.txt_dishdate.Size = new System.Drawing.Size(121, 26);
            this.txt_dishdate.TabIndex = 36;
            // 
            // txt_dishid
            // 
            this.txt_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishid.Location = new System.Drawing.Point(269, 246);
            this.txt_dishid.Name = "txt_dishid";
            this.txt_dishid.Size = new System.Drawing.Size(153, 26);
            this.txt_dishid.TabIndex = 37;
            // 
            // txt_dishname
            // 
            this.txt_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishname.Location = new System.Drawing.Point(269, 301);
            this.txt_dishname.Name = "txt_dishname";
            this.txt_dishname.Size = new System.Drawing.Size(153, 26);
            this.txt_dishname.TabIndex = 38;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(269, 354);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 26);
            this.txt_price.TabIndex = 39;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(168, 194);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(42, 19);
            this.lbl_date.TabIndex = 40;
            this.lbl_date.Text = "Date";
            // 
            // lbl_dishid
            // 
            this.lbl_dishid.AutoSize = true;
            this.lbl_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishid.Location = new System.Drawing.Point(168, 249);
            this.lbl_dishid.Name = "lbl_dishid";
            this.lbl_dishid.Size = new System.Drawing.Size(62, 19);
            this.lbl_dishid.TabIndex = 41;
            this.lbl_dishid.Text = "Dish ID";
            // 
            // lbl_dishname
            // 
            this.lbl_dishname.AutoSize = true;
            this.lbl_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishname.Location = new System.Drawing.Point(168, 305);
            this.lbl_dishname.Name = "lbl_dishname";
            this.lbl_dishname.Size = new System.Drawing.Size(84, 19);
            this.lbl_dishname.TabIndex = 42;
            this.lbl_dishname.Text = "Dish Name";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(168, 357);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(89, 19);
            this.lbl_price.TabIndex = 43;
            this.lbl_price.Text = "Price / Plate";
            // 
            // btn_dishdelete
            // 
            this.btn_dishdelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dishdelete.Location = new System.Drawing.Point(269, 432);
            this.btn_dishdelete.Name = "btn_dishdelete";
            this.btn_dishdelete.Size = new System.Drawing.Size(75, 33);
            this.btn_dishdelete.TabIndex = 44;
            this.btn_dishdelete.Text = "Delete";
            this.btn_dishdelete.UseVisualStyleBackColor = true;
            this.btn_dishdelete.Click += new System.EventHandler(this.txt_dishdelete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(353, 432);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 33);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(434, 432);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 33);
            this.btn_clear.TabIndex = 46;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // grd_dishedit
            // 
            this.grd_dishedit.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_dishedit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_dishedit.Location = new System.Drawing.Point(559, 191);
            this.grd_dishedit.Name = "grd_dishedit";
            this.grd_dishedit.ReadOnly = true;
            this.grd_dishedit.Size = new System.Drawing.Size(445, 467);
            this.grd_dishedit.TabIndex = 47;
            this.grd_dishedit.SelectionChanged += new System.EventHandler(this.grd_dishedit_SelectionChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(45, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
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
            this.label2.TabIndex = 49;
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
            this.label1.TabIndex = 48;
            this.label1.Text = "      Kitchen Inventory System";
            // 
            // Dishmanipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1368, 750);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_dishedit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_dishdelete);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_dishname);
            this.Controls.Add(this.lbl_dishid);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_dishname);
            this.Controls.Add(this.txt_dishid);
            this.Controls.Add(this.txt_dishdate);
            this.Name = "Dishmanipulation";
            this.Text = "Dish Recipe Manipulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dishmanipulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_dishedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dishdate;
        private System.Windows.Forms.TextBox txt_dishid;
        private System.Windows.Forms.TextBox txt_dishname;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_dishid;
        private System.Windows.Forms.Label lbl_dishname;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_dishdelete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView grd_dishedit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}