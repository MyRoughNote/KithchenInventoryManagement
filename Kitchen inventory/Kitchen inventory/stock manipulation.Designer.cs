namespace Kitchen_inventory
{
    partial class stock_manipulation
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
            this.lbl_limit = new System.Windows.Forms.Label();
            this.lbl_itemqty = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.lbl_stockdate = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_limit = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_stockdate = new System.Windows.Forms.TextBox();
            this.grd_stockedit = new System.Windows.Forms.DataGridView();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_needqty = new System.Windows.Forms.TextBox();
            this.lbl_needqty = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_stockedit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_limit
            // 
            this.lbl_limit.AutoSize = true;
            this.lbl_limit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limit.Location = new System.Drawing.Point(107, 354);
            this.lbl_limit.Name = "lbl_limit";
            this.lbl_limit.Size = new System.Drawing.Size(107, 19);
            this.lbl_limit.TabIndex = 26;
            this.lbl_limit.Text = "Thersold Limit";
            // 
            // lbl_itemqty
            // 
            this.lbl_itemqty.AutoSize = true;
            this.lbl_itemqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemqty.Location = new System.Drawing.Point(107, 303);
            this.lbl_itemqty.Name = "lbl_itemqty";
            this.lbl_itemqty.Size = new System.Drawing.Size(102, 19);
            this.lbl_itemqty.TabIndex = 25;
            this.lbl_itemqty.Text = "Item Quantity";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.Location = new System.Drawing.Point(107, 254);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(84, 19);
            this.lbl_itemname.TabIndex = 24;
            this.lbl_itemname.Text = "Item Name";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.Location = new System.Drawing.Point(107, 204);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(62, 19);
            this.lbl_itemid.TabIndex = 23;
            this.lbl_itemid.Text = "Item ID";
            // 
            // lbl_stockdate
            // 
            this.lbl_stockdate.AutoSize = true;
            this.lbl_stockdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockdate.Location = new System.Drawing.Point(107, 152);
            this.lbl_stockdate.Name = "lbl_stockdate";
            this.lbl_stockdate.Size = new System.Drawing.Size(84, 19);
            this.lbl_stockdate.TabIndex = 22;
            this.lbl_stockdate.Text = "Stock Date";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(485, 454);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 35);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(388, 454);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 35);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_limit
            // 
            this.txt_limit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limit.Location = new System.Drawing.Point(288, 347);
            this.txt_limit.Name = "txt_limit";
            this.txt_limit.Size = new System.Drawing.Size(242, 26);
            this.txt_limit.TabIndex = 3;
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(288, 296);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(242, 26);
            this.txt_qty.TabIndex = 2;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemname.Location = new System.Drawing.Point(288, 247);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(242, 26);
            this.txt_itemname.TabIndex = 1;
            // 
            // txt_stockdate
            // 
            this.txt_stockdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stockdate.Location = new System.Drawing.Point(288, 152);
            this.txt_stockdate.Name = "txt_stockdate";
            this.txt_stockdate.ReadOnly = true;
            this.txt_stockdate.Size = new System.Drawing.Size(140, 26);
            this.txt_stockdate.TabIndex = 15;
            // 
            // grd_stockedit
            // 
            this.grd_stockedit.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_stockedit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_stockedit.GridColor = System.Drawing.Color.Black;
            this.grd_stockedit.Location = new System.Drawing.Point(621, 152);
            this.grd_stockedit.Name = "grd_stockedit";
            this.grd_stockedit.ReadOnly = true;
            this.grd_stockedit.Size = new System.Drawing.Size(559, 531);
            this.grd_stockedit.TabIndex = 8;
            this.grd_stockedit.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txt_itemid
            // 
            this.txt_itemid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemid.Location = new System.Drawing.Point(288, 201);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(100, 26);
            this.txt_itemid.TabIndex = 30;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(287, 454);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 35);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_needqty
            // 
            this.txt_needqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_needqty.Location = new System.Drawing.Point(288, 392);
            this.txt_needqty.Name = "txt_needqty";
            this.txt_needqty.Size = new System.Drawing.Size(100, 26);
            this.txt_needqty.TabIndex = 4;
            // 
            // lbl_needqty
            // 
            this.lbl_needqty.AutoSize = true;
            this.lbl_needqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_needqty.Location = new System.Drawing.Point(107, 399);
            this.lbl_needqty.Name = "lbl_needqty";
            this.lbl_needqty.Size = new System.Drawing.Size(174, 19);
            this.lbl_needqty.TabIndex = 33;
            this.lbl_needqty.Text = "Updated/Added Quantity";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(45, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
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
            this.label2.TabIndex = 35;
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
            this.label1.TabIndex = 34;
            this.label1.Text = "      Kitchen Inventory System";
            // 
            // btn_purchase
            // 
            this.btn_purchase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.Location = new System.Drawing.Point(287, 516);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(273, 35);
            this.btn_purchase.TabIndex = 37;
            this.btn_purchase.Text = "Items to be Purchased";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // stock_manipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_needqty);
            this.Controls.Add(this.txt_needqty);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_itemid);
            this.Controls.Add(this.grd_stockedit);
            this.Controls.Add(this.lbl_limit);
            this.Controls.Add(this.lbl_itemqty);
            this.Controls.Add(this.lbl_itemname);
            this.Controls.Add(this.lbl_itemid);
            this.Controls.Add(this.lbl_stockdate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_limit);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.txt_stockdate);
            this.Name = "stock_manipulation";
            this.Text = "Stock Manipulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.stock_manipulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_stockedit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_limit;
        private System.Windows.Forms.Label lbl_itemqty;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_stockdate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_limit;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.TextBox txt_stockdate;
        private System.Windows.Forms.DataGridView grd_stockedit;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_needqty;
        private System.Windows.Forms.Label lbl_needqty;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_purchase;
    }
}