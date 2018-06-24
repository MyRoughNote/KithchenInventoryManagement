namespace Kitchen_inventory
{
    partial class Dish
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
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_dishname = new System.Windows.Forms.TextBox();
            this.txt_dishid = new System.Windows.Forms.TextBox();
            this.txt_dishdate = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_showdish = new System.Windows.Forms.Button();
            this.btn_searchdish = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_dishid = new System.Windows.Forms.Label();
            this.lbl_dishname = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.grd_dishdetail = new System.Windows.Forms.DataGridView();
            this.btn_newitem = new System.Windows.Forms.Button();
            this.txt_dishsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dishRecipeManipulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dishdetail)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(274, 358);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 26);
            this.txt_price.TabIndex = 25;
            // 
            // txt_dishname
            // 
            this.txt_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishname.Location = new System.Drawing.Point(274, 297);
            this.txt_dishname.Name = "txt_dishname";
            this.txt_dishname.Size = new System.Drawing.Size(191, 26);
            this.txt_dishname.TabIndex = 26;
            // 
            // txt_dishid
            // 
            this.txt_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishid.Location = new System.Drawing.Point(274, 245);
            this.txt_dishid.Name = "txt_dishid";
            this.txt_dishid.Size = new System.Drawing.Size(135, 26);
            this.txt_dishid.TabIndex = 27;
            // 
            // txt_dishdate
            // 
            this.txt_dishdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishdate.Location = new System.Drawing.Point(274, 193);
            this.txt_dishdate.Name = "txt_dishdate";
            this.txt_dishdate.ReadOnly = true;
            this.txt_dishdate.Size = new System.Drawing.Size(135, 26);
            this.txt_dishdate.TabIndex = 28;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(273, 423);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 32);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Save Detail";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(354, 423);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 32);
            this.btn_clear.TabIndex = 30;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_showdish
            // 
            this.btn_showdish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showdish.Location = new System.Drawing.Point(477, 512);
            this.btn_showdish.Name = "btn_showdish";
            this.btn_showdish.Size = new System.Drawing.Size(138, 32);
            this.btn_showdish.TabIndex = 31;
            this.btn_showdish.Text = "Show All Dishes";
            this.btn_showdish.UseVisualStyleBackColor = true;
            this.btn_showdish.Click += new System.EventHandler(this.btn_showdish_Click);
            // 
            // btn_searchdish
            // 
            this.btn_searchdish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchdish.Location = new System.Drawing.Point(390, 512);
            this.btn_searchdish.Name = "btn_searchdish";
            this.btn_searchdish.Size = new System.Drawing.Size(75, 32);
            this.btn_searchdish.TabIndex = 32;
            this.btn_searchdish.Text = "Search";
            this.btn_searchdish.UseVisualStyleBackColor = true;
            this.btn_searchdish.Click += new System.EventHandler(this.btn_searchdish_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(134, 200);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(42, 19);
            this.lbl_date.TabIndex = 33;
            this.lbl_date.Text = "Date";
            // 
            // lbl_dishid
            // 
            this.lbl_dishid.AutoSize = true;
            this.lbl_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishid.Location = new System.Drawing.Point(134, 252);
            this.lbl_dishid.Name = "lbl_dishid";
            this.lbl_dishid.Size = new System.Drawing.Size(62, 19);
            this.lbl_dishid.TabIndex = 34;
            this.lbl_dishid.Text = "Dish ID";
            // 
            // lbl_dishname
            // 
            this.lbl_dishname.AutoSize = true;
            this.lbl_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishname.Location = new System.Drawing.Point(134, 304);
            this.lbl_dishname.Name = "lbl_dishname";
            this.lbl_dishname.Size = new System.Drawing.Size(84, 19);
            this.lbl_dishname.TabIndex = 35;
            this.lbl_dishname.Text = "Dish Name";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(134, 365);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(89, 19);
            this.lbl_price.TabIndex = 36;
            this.lbl_price.Text = "Price / Plate";
            // 
            // grd_dishdetail
            // 
            this.grd_dishdetail.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_dishdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_dishdetail.Location = new System.Drawing.Point(668, 193);
            this.grd_dishdetail.Name = "grd_dishdetail";
            this.grd_dishdetail.ReadOnly = true;
            this.grd_dishdetail.Size = new System.Drawing.Size(448, 478);
            this.grd_dishdetail.TabIndex = 37;
            // 
            // btn_newitem
            // 
            this.btn_newitem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newitem.Location = new System.Drawing.Point(435, 423);
            this.btn_newitem.Name = "btn_newitem";
            this.btn_newitem.Size = new System.Drawing.Size(96, 32);
            this.btn_newitem.TabIndex = 38;
            this.btn_newitem.Text = "New Item";
            this.btn_newitem.UseVisualStyleBackColor = true;
            this.btn_newitem.Click += new System.EventHandler(this.btn_newitem_Click);
            // 
            // txt_dishsearch
            // 
            this.txt_dishsearch.CausesValidation = false;
            this.txt_dishsearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishsearch.Location = new System.Drawing.Point(214, 512);
            this.txt_dishsearch.Name = "txt_dishsearch";
            this.txt_dishsearch.Size = new System.Drawing.Size(159, 26);
            this.txt_dishsearch.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Enter Dish Id to Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dishRecipeManipulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 27);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dishRecipeManipulationToolStripMenuItem
            // 
            this.dishRecipeManipulationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dishRecipeManipulationToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishRecipeManipulationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dishRecipeManipulationToolStripMenuItem.Name = "dishRecipeManipulationToolStripMenuItem";
            this.dishRecipeManipulationToolStripMenuItem.Size = new System.Drawing.Size(312, 23);
            this.dishRecipeManipulationToolStripMenuItem.Text = "Dish Recipe Manipulation [update / Delete]";
            this.dishRecipeManipulationToolStripMenuItem.Click += new System.EventHandler(this.dishRecipeManipulationToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(46, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1043, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 14);
            this.label1.TabIndex = 43;
            this.label1.Text = "Copy Rights Reserved  @ Easwari Engineering College";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1346, 91);
            this.label3.TabIndex = 42;
            this.label3.Text = "      Kitchen Inventory System";
            // 
            // Dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1370, 747);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dishsearch);
            this.Controls.Add(this.btn_newitem);
            this.Controls.Add(this.grd_dishdetail);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_dishname);
            this.Controls.Add(this.lbl_dishid);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_searchdish);
            this.Controls.Add(this.btn_showdish);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_dishdate);
            this.Controls.Add(this.txt_dishid);
            this.Controls.Add(this.txt_dishname);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dish";
            this.Text = "Dish Recipe Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_dishdetail)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_dishname;
        private System.Windows.Forms.TextBox txt_dishid;
        private System.Windows.Forms.TextBox txt_dishdate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_showdish;
        private System.Windows.Forms.Button btn_searchdish;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_dishid;
        private System.Windows.Forms.Label lbl_dishname;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.DataGridView grd_dishdetail;
        private System.Windows.Forms.Button btn_newitem;
        private System.Windows.Forms.TextBox txt_dishsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dishRecipeManipulationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}