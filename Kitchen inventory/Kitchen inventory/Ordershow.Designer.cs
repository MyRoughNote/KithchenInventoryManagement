namespace Kitchen_inventory
{
    partial class Ordershow
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
            this.grd_ordershow = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_datesearch = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_datesearch = new System.Windows.Forms.TextBox();
            this.lbl_totPrice = new System.Windows.Forms.Label();
            this.txt_totprice = new System.Windows.Forms.TextBox();
            this.txt_needqty = new System.Windows.Forms.TextBox();
            this.txt_dishname = new System.Windows.Forms.TextBox();
            this.txt_dishid = new System.Windows.Forms.TextBox();
            this.txt_orderno = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.lbl_needqty = new System.Windows.Forms.Label();
            this.lbl_dishname = new System.Windows.Forms.Label();
            this.lbl_dishid = new System.Windows.Forms.Label();
            this.lbl_orderno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ordershow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_ordershow
            // 
            this.grd_ordershow.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_ordershow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ordershow.Location = new System.Drawing.Point(683, 130);
            this.grd_ordershow.Name = "grd_ordershow";
            this.grd_ordershow.ReadOnly = true;
            this.grd_ordershow.Size = new System.Drawing.Size(675, 578);
            this.grd_ordershow.TabIndex = 27;
            this.grd_ordershow.SelectionChanged += new System.EventHandler(this.grd_ordershow_SelectionChanged);
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
            this.label1.Text = "      Kitchen Inventory System";
            // 
            // btn_datesearch
            // 
            this.btn_datesearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datesearch.Location = new System.Drawing.Point(459, 127);
            this.btn_datesearch.Name = "btn_datesearch";
            this.btn_datesearch.Size = new System.Drawing.Size(172, 33);
            this.btn_datesearch.TabIndex = 38;
            this.btn_datesearch.Text = "Show Order Details";
            this.btn_datesearch.UseVisualStyleBackColor = true;
            this.btn_datesearch.Click += new System.EventHandler(this.btn_datesearch_Click_1);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(41, 130);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(267, 19);
            this.lbl_date.TabIndex = 37;
            this.lbl_date.Text = "Enter the Date to Show Orders Details";
            // 
            // txt_datesearch
            // 
            this.txt_datesearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datesearch.Location = new System.Drawing.Point(330, 127);
            this.txt_datesearch.Name = "txt_datesearch";
            this.txt_datesearch.ReadOnly = true;
            this.txt_datesearch.Size = new System.Drawing.Size(110, 26);
            this.txt_datesearch.TabIndex = 36;
            // 
            // lbl_totPrice
            // 
            this.lbl_totPrice.AutoSize = true;
            this.lbl_totPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totPrice.Location = new System.Drawing.Point(318, 423);
            this.lbl_totPrice.Name = "lbl_totPrice";
            this.lbl_totPrice.Size = new System.Drawing.Size(81, 19);
            this.lbl_totPrice.TabIndex = 61;
            this.lbl_totPrice.Text = "Total Price";
            // 
            // txt_totprice
            // 
            this.txt_totprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totprice.Location = new System.Drawing.Point(459, 416);
            this.txt_totprice.Name = "txt_totprice";
            this.txt_totprice.Size = new System.Drawing.Size(100, 26);
            this.txt_totprice.TabIndex = 60;
            // 
            // txt_needqty
            // 
            this.txt_needqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_needqty.Location = new System.Drawing.Point(459, 374);
            this.txt_needqty.Name = "txt_needqty";
            this.txt_needqty.Size = new System.Drawing.Size(100, 26);
            this.txt_needqty.TabIndex = 58;
            // 
            // txt_dishname
            // 
            this.txt_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishname.Location = new System.Drawing.Point(459, 322);
            this.txt_dishname.Name = "txt_dishname";
            this.txt_dishname.Size = new System.Drawing.Size(166, 26);
            this.txt_dishname.TabIndex = 57;
            // 
            // txt_dishid
            // 
            this.txt_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishid.Location = new System.Drawing.Point(459, 274);
            this.txt_dishid.Name = "txt_dishid";
            this.txt_dishid.Size = new System.Drawing.Size(130, 26);
            this.txt_dishid.TabIndex = 56;
            // 
            // txt_orderno
            // 
            this.txt_orderno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderno.Location = new System.Drawing.Point(459, 228);
            this.txt_orderno.Name = "txt_orderno";
            this.txt_orderno.Size = new System.Drawing.Size(65, 26);
            this.txt_orderno.TabIndex = 55;
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(459, 187);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 26);
            this.txt_date.TabIndex = 54;
            // 
            // lbl_needqty
            // 
            this.lbl_needqty.AutoSize = true;
            this.lbl_needqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_needqty.Location = new System.Drawing.Point(317, 381);
            this.lbl_needqty.Name = "lbl_needqty";
            this.lbl_needqty.Size = new System.Drawing.Size(123, 19);
            this.lbl_needqty.TabIndex = 52;
            this.lbl_needqty.Text = "Needed Quantity";
            // 
            // lbl_dishname
            // 
            this.lbl_dishname.AutoSize = true;
            this.lbl_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishname.Location = new System.Drawing.Point(317, 329);
            this.lbl_dishname.Name = "lbl_dishname";
            this.lbl_dishname.Size = new System.Drawing.Size(84, 19);
            this.lbl_dishname.TabIndex = 51;
            this.lbl_dishname.Text = "Dish Name";
            // 
            // lbl_dishid
            // 
            this.lbl_dishid.AutoSize = true;
            this.lbl_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishid.Location = new System.Drawing.Point(317, 277);
            this.lbl_dishid.Name = "lbl_dishid";
            this.lbl_dishid.Size = new System.Drawing.Size(62, 19);
            this.lbl_dishid.TabIndex = 50;
            this.lbl_dishid.Text = "Dish ID";
            // 
            // lbl_orderno
            // 
            this.lbl_orderno.AutoSize = true;
            this.lbl_orderno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderno.Location = new System.Drawing.Point(317, 228);
            this.lbl_orderno.Name = "lbl_orderno";
            this.lbl_orderno.Size = new System.Drawing.Size(73, 19);
            this.lbl_orderno.TabIndex = 49;
            this.lbl_orderno.Text = "Order No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Date";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(362, 475);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 37);
            this.btn_update.TabIndex = 62;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(444, 548);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(145, 37);
            this.btn_search.TabIndex = 63;
            this.btn_search.Text = "Search !";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(480, 475);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(79, 37);
            this.btn_Clear.TabIndex = 64;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(280, 554);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(132, 26);
            this.txt_search.TabIndex = 65;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(41, 557);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(202, 19);
            this.lbl_search.TabIndex = 66;
            this.lbl_search.Text = "Enter the order No to Search";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(45, 187);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 67;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Green;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Ordershow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_totPrice);
            this.Controls.Add(this.txt_totprice);
            this.Controls.Add(this.txt_needqty);
            this.Controls.Add(this.txt_dishname);
            this.Controls.Add(this.txt_dishid);
            this.Controls.Add(this.txt_orderno);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.lbl_needqty);
            this.Controls.Add(this.lbl_dishname);
            this.Controls.Add(this.lbl_dishid);
            this.Controls.Add(this.lbl_orderno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_datesearch);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_datesearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_ordershow);
            this.Name = "Ordershow";
            this.Text = "Ordershow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ordershow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ordershow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_ordershow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_datesearch;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_datesearch;
        private System.Windows.Forms.Label lbl_totPrice;
        private System.Windows.Forms.TextBox txt_totprice;
        private System.Windows.Forms.TextBox txt_needqty;
        private System.Windows.Forms.TextBox txt_dishname;
        private System.Windows.Forms.TextBox txt_dishid;
        private System.Windows.Forms.TextBox txt_orderno;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label lbl_needqty;
        private System.Windows.Forms.Label lbl_dishname;
        private System.Windows.Forms.Label lbl_dishid;
        private System.Windows.Forms.Label lbl_orderno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}