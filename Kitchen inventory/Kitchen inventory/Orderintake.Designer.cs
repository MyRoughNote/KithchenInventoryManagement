namespace Kitchen_inventory
{
    partial class Orderintake
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
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_orderno = new System.Windows.Forms.Label();
            this.lbl_dishid = new System.Windows.Forms.Label();
            this.lbl_dishname = new System.Windows.Forms.Label();
            this.lbl_needqty = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_itemadd = new System.Windows.Forms.Button();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_orderno = new System.Windows.Forms.TextBox();
            this.txt_dishid = new System.Windows.Forms.TextBox();
            this.txt_dishname = new System.Windows.Forms.TextBox();
            this.txt_needqty = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.grd_dishdetails = new System.Windows.Forms.DataGridView();
            this.grd_reorderitems = new System.Windows.Forms.DataGridView();
            this.txt_totprice = new System.Windows.Forms.TextBox();
            this.lbl_totPrice = new System.Windows.Forms.Label();
            this.btn_neworder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dishdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_reorderitems)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(180, 199);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(42, 19);
            this.lbl_date.TabIndex = 28;
            this.lbl_date.Text = "Date";
            // 
            // lbl_orderno
            // 
            this.lbl_orderno.AutoSize = true;
            this.lbl_orderno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderno.Location = new System.Drawing.Point(180, 240);
            this.lbl_orderno.Name = "lbl_orderno";
            this.lbl_orderno.Size = new System.Drawing.Size(73, 19);
            this.lbl_orderno.TabIndex = 29;
            this.lbl_orderno.Text = "Order No";
            // 
            // lbl_dishid
            // 
            this.lbl_dishid.AutoSize = true;
            this.lbl_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishid.Location = new System.Drawing.Point(180, 289);
            this.lbl_dishid.Name = "lbl_dishid";
            this.lbl_dishid.Size = new System.Drawing.Size(62, 19);
            this.lbl_dishid.TabIndex = 30;
            this.lbl_dishid.Text = "Dish ID";
            // 
            // lbl_dishname
            // 
            this.lbl_dishname.AutoSize = true;
            this.lbl_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishname.Location = new System.Drawing.Point(180, 341);
            this.lbl_dishname.Name = "lbl_dishname";
            this.lbl_dishname.Size = new System.Drawing.Size(84, 19);
            this.lbl_dishname.TabIndex = 31;
            this.lbl_dishname.Text = "Dish Name";
            // 
            // lbl_needqty
            // 
            this.lbl_needqty.AutoSize = true;
            this.lbl_needqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_needqty.Location = new System.Drawing.Point(180, 435);
            this.lbl_needqty.Name = "lbl_needqty";
            this.lbl_needqty.Size = new System.Drawing.Size(123, 19);
            this.lbl_needqty.TabIndex = 32;
            this.lbl_needqty.Text = "Needed Quantity";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(180, 389);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(81, 19);
            this.lbl_price.TabIndex = 33;
            this.lbl_price.Text = "Price/Plate";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(300, 530);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 36);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_itemadd
            // 
            this.btn_itemadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemadd.Location = new System.Drawing.Point(184, 530);
            this.btn_itemadd.Name = "btn_itemadd";
            this.btn_itemadd.Size = new System.Drawing.Size(100, 36);
            this.btn_itemadd.TabIndex = 35;
            this.btn_itemadd.Text = "Add Item";
            this.btn_itemadd.UseVisualStyleBackColor = true;
            this.btn_itemadd.Click += new System.EventHandler(this.btn_itemadd_Click);
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(322, 199);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 26);
            this.txt_date.TabIndex = 36;
            // 
            // txt_orderno
            // 
            this.txt_orderno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderno.Location = new System.Drawing.Point(322, 240);
            this.txt_orderno.Name = "txt_orderno";
            this.txt_orderno.Size = new System.Drawing.Size(65, 26);
            this.txt_orderno.TabIndex = 37;
            // 
            // txt_dishid
            // 
            this.txt_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishid.Location = new System.Drawing.Point(322, 286);
            this.txt_dishid.Name = "txt_dishid";
            this.txt_dishid.Size = new System.Drawing.Size(130, 26);
            this.txt_dishid.TabIndex = 38;
            // 
            // txt_dishname
            // 
            this.txt_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishname.Location = new System.Drawing.Point(322, 334);
            this.txt_dishname.Name = "txt_dishname";
            this.txt_dishname.Size = new System.Drawing.Size(166, 26);
            this.txt_dishname.TabIndex = 39;
            // 
            // txt_needqty
            // 
            this.txt_needqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_needqty.Location = new System.Drawing.Point(322, 428);
            this.txt_needqty.Name = "txt_needqty";
            this.txt_needqty.Size = new System.Drawing.Size(100, 26);
            this.txt_needqty.TabIndex = 40;
            this.txt_needqty.Leave += new System.EventHandler(this.txt_needqty_Leave);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(322, 382);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 26);
            this.txt_price.TabIndex = 41;
            // 
            // grd_dishdetails
            // 
            this.grd_dishdetails.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_dishdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_dishdetails.Location = new System.Drawing.Point(552, 199);
            this.grd_dishdetails.Name = "grd_dishdetails";
            this.grd_dishdetails.ReadOnly = true;
            this.grd_dishdetails.Size = new System.Drawing.Size(348, 344);
            this.grd_dishdetails.TabIndex = 42;
            this.grd_dishdetails.SelectionChanged += new System.EventHandler(this.grd_dishdetails_SelectionChanged);
            // 
            // grd_reorderitems
            // 
            this.grd_reorderitems.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_reorderitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_reorderitems.Location = new System.Drawing.Point(925, 199);
            this.grd_reorderitems.Name = "grd_reorderitems";
            this.grd_reorderitems.ReadOnly = true;
            this.grd_reorderitems.Size = new System.Drawing.Size(398, 344);
            this.grd_reorderitems.TabIndex = 45;
            // 
            // txt_totprice
            // 
            this.txt_totprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totprice.Location = new System.Drawing.Point(322, 470);
            this.txt_totprice.Name = "txt_totprice";
            this.txt_totprice.Size = new System.Drawing.Size(100, 26);
            this.txt_totprice.TabIndex = 46;
            // 
            // lbl_totPrice
            // 
            this.lbl_totPrice.AutoSize = true;
            this.lbl_totPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totPrice.Location = new System.Drawing.Point(181, 477);
            this.lbl_totPrice.Name = "lbl_totPrice";
            this.lbl_totPrice.Size = new System.Drawing.Size(81, 19);
            this.lbl_totPrice.TabIndex = 47;
            this.lbl_totPrice.Text = "Total Price";
            // 
            // btn_neworder
            // 
            this.btn_neworder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_neworder.Location = new System.Drawing.Point(390, 530);
            this.btn_neworder.Name = "btn_neworder";
            this.btn_neworder.Size = new System.Drawing.Size(98, 36);
            this.btn_neworder.TabIndex = 48;
            this.btn_neworder.Text = "New Order";
            this.btn_neworder.UseVisualStyleBackColor = true;
            this.btn_neworder.Click += new System.EventHandler(this.btn_neworder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOrdersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 27);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showOrdersToolStripMenuItem
            // 
            this.showOrdersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOrdersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showOrdersToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.showOrdersToolStripMenuItem.Name = "showOrdersToolStripMenuItem";
            this.showOrdersToolStripMenuItem.Size = new System.Drawing.Size(152, 23);
            this.showOrdersToolStripMenuItem.Text = "Show Order Details";
            this.showOrdersToolStripMenuItem.Click += new System.EventHandler(this.showOrdersToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(45, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1043, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 14);
            this.label2.TabIndex = 51;
            this.label2.Text = "Copy Rights Reserved  @ Easwari Engineering College";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 91);
            this.label1.TabIndex = 50;
            this.label1.Text = "      Kitchen Inventory System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(549, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Dish Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(922, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Insufficient Items ";
            // 
            // Orderintake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_neworder);
            this.Controls.Add(this.lbl_totPrice);
            this.Controls.Add(this.txt_totprice);
            this.Controls.Add(this.grd_reorderitems);
            this.Controls.Add(this.grd_dishdetails);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_needqty);
            this.Controls.Add(this.txt_dishname);
            this.Controls.Add(this.txt_dishid);
            this.Controls.Add(this.txt_orderno);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_itemadd);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_needqty);
            this.Controls.Add(this.lbl_dishname);
            this.Controls.Add(this.lbl_dishid);
            this.Controls.Add(this.lbl_orderno);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Orderintake";
            this.Text = "Orderintake";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Orderintake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_dishdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_reorderitems)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_orderno;
        private System.Windows.Forms.Label lbl_dishid;
        private System.Windows.Forms.Label lbl_dishname;
        private System.Windows.Forms.Label lbl_needqty;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_itemadd;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_orderno;
        private System.Windows.Forms.TextBox txt_dishid;
        private System.Windows.Forms.TextBox txt_dishname;
        private System.Windows.Forms.TextBox txt_needqty;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DataGridView grd_dishdetails;
        private System.Windows.Forms.DataGridView grd_reorderitems;
        private System.Windows.Forms.TextBox txt_totprice;
        private System.Windows.Forms.Label lbl_totPrice;
        private System.Windows.Forms.Button btn_neworder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showOrdersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}