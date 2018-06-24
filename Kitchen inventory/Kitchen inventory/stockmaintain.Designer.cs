namespace Kitchen_inventory
{
    partial class stockmaintain
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
            this.txt_stockdate = new System.Windows.Forms.TextBox();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_limit = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_stockdate = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_itemqty = new System.Windows.Forms.Label();
            this.lbl_limit = new System.Windows.Forms.Label();
            this.grd_stockdetails = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockManipulationUpdateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToBePurchasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_newitem = new System.Windows.Forms.Button();
            this.btn_showall = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_measure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_stockdetails)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stockdate
            // 
            this.txt_stockdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stockdate.Location = new System.Drawing.Point(273, 201);
            this.txt_stockdate.Name = "txt_stockdate";
            this.txt_stockdate.ReadOnly = true;
            this.txt_stockdate.Size = new System.Drawing.Size(140, 26);
            this.txt_stockdate.TabIndex = 0;
            // 
            // txt_itemid
            // 
            this.txt_itemid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemid.Location = new System.Drawing.Point(273, 253);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(242, 26);
            this.txt_itemid.TabIndex = 1;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemname.Location = new System.Drawing.Point(273, 296);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(242, 26);
            this.txt_itemname.TabIndex = 1;
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(273, 345);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(126, 26);
            this.txt_qty.TabIndex = 2;
            // 
            // txt_limit
            // 
            this.txt_limit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limit.Location = new System.Drawing.Point(273, 396);
            this.txt_limit.Name = "txt_limit";
            this.txt_limit.Size = new System.Drawing.Size(242, 26);
            this.txt_limit.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(273, 454);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 30);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save Detail";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(357, 454);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 30);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_stockdate
            // 
            this.lbl_stockdate.AutoSize = true;
            this.lbl_stockdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockdate.Location = new System.Drawing.Point(98, 201);
            this.lbl_stockdate.Name = "lbl_stockdate";
            this.lbl_stockdate.Size = new System.Drawing.Size(84, 19);
            this.lbl_stockdate.TabIndex = 10;
            this.lbl_stockdate.Text = "Stock Date";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.Location = new System.Drawing.Point(98, 253);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(62, 19);
            this.lbl_itemid.TabIndex = 11;
            this.lbl_itemid.Text = "Item ID";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.Location = new System.Drawing.Point(98, 303);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(84, 19);
            this.lbl_itemname.TabIndex = 12;
            this.lbl_itemname.Text = "Item Name";
            // 
            // lbl_itemqty
            // 
            this.lbl_itemqty.AutoSize = true;
            this.lbl_itemqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemqty.Location = new System.Drawing.Point(98, 352);
            this.lbl_itemqty.Name = "lbl_itemqty";
            this.lbl_itemqty.Size = new System.Drawing.Size(102, 19);
            this.lbl_itemqty.TabIndex = 13;
            this.lbl_itemqty.Text = "Item Quantity";
            // 
            // lbl_limit
            // 
            this.lbl_limit.AutoSize = true;
            this.lbl_limit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limit.Location = new System.Drawing.Point(98, 403);
            this.lbl_limit.Name = "lbl_limit";
            this.lbl_limit.Size = new System.Drawing.Size(107, 19);
            this.lbl_limit.TabIndex = 14;
            this.lbl_limit.Text = "Thersold Limit";
            // 
            // grd_stockdetails
            // 
            this.grd_stockdetails.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_stockdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_stockdetails.GridColor = System.Drawing.Color.Gray;
            this.grd_stockdetails.Location = new System.Drawing.Point(607, 202);
            this.grd_stockdetails.Name = "grd_stockdetails";
            this.grd_stockdetails.ReadOnly = true;
            this.grd_stockdetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_stockdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_stockdetails.Size = new System.Drawing.Size(545, 483);
            this.grd_stockdetails.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockManipulationUpdateDeleteToolStripMenuItem,
            this.itemsToBePurchasedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1365, 27);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockManipulationUpdateDeleteToolStripMenuItem
            // 
            this.stockManipulationUpdateDeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.stockManipulationUpdateDeleteToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockManipulationUpdateDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stockManipulationUpdateDeleteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.stockManipulationUpdateDeleteToolStripMenuItem.Name = "stockManipulationUpdateDeleteToolStripMenuItem";
            this.stockManipulationUpdateDeleteToolStripMenuItem.Size = new System.Drawing.Size(263, 23);
            this.stockManipulationUpdateDeleteToolStripMenuItem.Text = "Stock Manipulation [Update/Delete]";
            this.stockManipulationUpdateDeleteToolStripMenuItem.Click += new System.EventHandler(this.stockManipulationUpdateDeleteToolStripMenuItem_Click);
            // 
            // itemsToBePurchasedToolStripMenuItem
            // 
            this.itemsToBePurchasedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.itemsToBePurchasedToolStripMenuItem.Name = "itemsToBePurchasedToolStripMenuItem";
            this.itemsToBePurchasedToolStripMenuItem.Size = new System.Drawing.Size(169, 23);
            this.itemsToBePurchasedToolStripMenuItem.Text = "Items to be Purchased";
            this.itemsToBePurchasedToolStripMenuItem.Click += new System.EventHandler(this.itemsToBePurchasedToolStripMenuItem_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(941, 151);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 32);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(790, 155);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(133, 26);
            this.txt_search.TabIndex = 7;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(605, 155);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(170, 19);
            this.lbl_search.TabIndex = 19;
            this.lbl_search.Text = "Enter Item ID to Search";
            // 
            // btn_newitem
            // 
            this.btn_newitem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newitem.Location = new System.Drawing.Point(438, 454);
            this.btn_newitem.Name = "btn_newitem";
            this.btn_newitem.Size = new System.Drawing.Size(86, 30);
            this.btn_newitem.TabIndex = 5;
            this.btn_newitem.Text = "New Item";
            this.btn_newitem.UseVisualStyleBackColor = true;
            this.btn_newitem.Click += new System.EventHandler(this.btn_newitem_Click);
            // 
            // btn_showall
            // 
            this.btn_showall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showall.Location = new System.Drawing.Point(1036, 150);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(75, 32);
            this.btn_showall.TabIndex = 9;
            this.btn_showall.Text = "Show All";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(45, 39);
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
            this.label2.Location = new System.Drawing.Point(1043, 90);
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
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 91);
            this.label1.TabIndex = 33;
            this.label1.Text = "      Kitchen Inventory System";
            // 
            // lbl_measure
            // 
            this.lbl_measure.AutoSize = true;
            this.lbl_measure.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_measure.Location = new System.Drawing.Point(420, 356);
            this.lbl_measure.Name = "lbl_measure";
            this.lbl_measure.Size = new System.Drawing.Size(118, 13);
            this.lbl_measure.TabIndex = 55;
            this.lbl_measure.Text = "ML/KG/Grams/Pieces";
            // 
            // stockmaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1365, 750);
            this.Controls.Add(this.lbl_measure);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_newitem);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.grd_stockdetails);
            this.Controls.Add(this.lbl_limit);
            this.Controls.Add(this.lbl_itemqty);
            this.Controls.Add(this.lbl_itemname);
            this.Controls.Add(this.lbl_itemid);
            this.Controls.Add(this.lbl_stockdate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_limit);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.txt_itemid);
            this.Controls.Add(this.txt_stockdate);
            this.Controls.Add(this.menuStrip1);
            this.Name = "stockmaintain";
            this.Text = "Stock Maintainence";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.stockmaintain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_stockdetails)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_stockdate;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_limit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_stockdate;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_itemqty;
        private System.Windows.Forms.Label lbl_limit;
        private System.Windows.Forms.DataGridView grd_stockdetails;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockManipulationUpdateDeleteToolStripMenuItem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_newitem;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem itemsToBePurchasedToolStripMenuItem;
        private System.Windows.Forms.Label lbl_measure;
    }
}