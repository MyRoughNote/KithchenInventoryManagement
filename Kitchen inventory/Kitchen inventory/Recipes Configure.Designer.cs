namespace Kitchen_inventory
{
    partial class RecipesConfigure
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
            this.txt_dishname = new System.Windows.Forms.TextBox();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.txt_needqty = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_dishid = new System.Windows.Forms.Label();
            this.lbl_dishname = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.lbl_needqty = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_showitems = new System.Windows.Forms.Button();
            this.grd_recipedetails = new System.Windows.Forms.DataGridView();
            this.cmb_dishid = new System.Windows.Forms.ComboBox();
            this.grd_dishdetails = new System.Windows.Forms.DataGridView();
            this.grd_recipeconfig = new System.Windows.Forms.DataGridView();
            this.lbl_itemshow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_stockmaintain = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_measure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_recipedetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dishdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_recipeconfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(171, 148);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(100, 26);
            this.txt_date.TabIndex = 30;
            // 
            // txt_dishname
            // 
            this.txt_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dishname.Location = new System.Drawing.Point(171, 252);
            this.txt_dishname.Name = "txt_dishname";
            this.txt_dishname.Size = new System.Drawing.Size(182, 26);
            this.txt_dishname.TabIndex = 32;
            // 
            // txt_itemid
            // 
            this.txt_itemid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemid.Location = new System.Drawing.Point(171, 304);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(182, 26);
            this.txt_itemid.TabIndex = 33;
            // 
            // txt_needqty
            // 
            this.txt_needqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_needqty.Location = new System.Drawing.Point(171, 358);
            this.txt_needqty.Name = "txt_needqty";
            this.txt_needqty.Size = new System.Drawing.Size(83, 26);
            this.txt_needqty.TabIndex = 34;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(27, 148);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(42, 19);
            this.lbl_date.TabIndex = 35;
            this.lbl_date.Text = "Date";
            // 
            // lbl_dishid
            // 
            this.lbl_dishid.AutoSize = true;
            this.lbl_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishid.Location = new System.Drawing.Point(27, 197);
            this.lbl_dishid.Name = "lbl_dishid";
            this.lbl_dishid.Size = new System.Drawing.Size(62, 19);
            this.lbl_dishid.TabIndex = 36;
            this.lbl_dishid.Text = "Dish ID";
            // 
            // lbl_dishname
            // 
            this.lbl_dishname.AutoSize = true;
            this.lbl_dishname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dishname.Location = new System.Drawing.Point(27, 252);
            this.lbl_dishname.Name = "lbl_dishname";
            this.lbl_dishname.Size = new System.Drawing.Size(84, 19);
            this.lbl_dishname.TabIndex = 37;
            this.lbl_dishname.Text = "Dish Name";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.Location = new System.Drawing.Point(27, 304);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(62, 19);
            this.lbl_itemid.TabIndex = 38;
            this.lbl_itemid.Text = "Item ID";
            // 
            // lbl_needqty
            // 
            this.lbl_needqty.AutoSize = true;
            this.lbl_needqty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_needqty.Location = new System.Drawing.Point(27, 358);
            this.lbl_needqty.Name = "lbl_needqty";
            this.lbl_needqty.Size = new System.Drawing.Size(123, 19);
            this.lbl_needqty.TabIndex = 39;
            this.lbl_needqty.Text = "Needed Quantity";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(31, 417);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(122, 417);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 34);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_showitems
            // 
            this.btn_showitems.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showitems.Location = new System.Drawing.Point(213, 417);
            this.btn_showitems.Name = "btn_showitems";
            this.btn_showitems.Size = new System.Drawing.Size(153, 34);
            this.btn_showitems.TabIndex = 42;
            this.btn_showitems.Text = "Show Recipe Items";
            this.btn_showitems.UseVisualStyleBackColor = true;
            this.btn_showitems.Click += new System.EventHandler(this.btn_showitems_Click);
            // 
            // grd_recipedetails
            // 
            this.grd_recipedetails.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_recipedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_recipedetails.Location = new System.Drawing.Point(391, 178);
            this.grd_recipedetails.Name = "grd_recipedetails";
            this.grd_recipedetails.ReadOnly = true;
            this.grd_recipedetails.Size = new System.Drawing.Size(263, 444);
            this.grd_recipedetails.TabIndex = 43;
            this.grd_recipedetails.SelectionChanged += new System.EventHandler(this.grd_recipedetails_SelectionChanged);
            // 
            // cmb_dishid
            // 
            this.cmb_dishid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dishid.FormattingEnabled = true;
            this.cmb_dishid.Location = new System.Drawing.Point(171, 198);
            this.cmb_dishid.Name = "cmb_dishid";
            this.cmb_dishid.Size = new System.Drawing.Size(182, 27);
            this.cmb_dishid.TabIndex = 44;
            this.cmb_dishid.SelectedIndexChanged += new System.EventHandler(this.cmb_dishid_SelectedIndexChanged);
            // 
            // grd_dishdetails
            // 
            this.grd_dishdetails.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_dishdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_dishdetails.Location = new System.Drawing.Point(679, 178);
            this.grd_dishdetails.Name = "grd_dishdetails";
            this.grd_dishdetails.ReadOnly = true;
            this.grd_dishdetails.Size = new System.Drawing.Size(265, 444);
            this.grd_dishdetails.TabIndex = 45;
            this.grd_dishdetails.SelectionChanged += new System.EventHandler(this.grd_dishdetails_SelectionChanged);
            // 
            // grd_recipeconfig
            // 
            this.grd_recipeconfig.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grd_recipeconfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_recipeconfig.Location = new System.Drawing.Point(965, 178);
            this.grd_recipeconfig.Name = "grd_recipeconfig";
            this.grd_recipeconfig.ReadOnly = true;
            this.grd_recipeconfig.Size = new System.Drawing.Size(350, 444);
            this.grd_recipeconfig.TabIndex = 46;
            // 
            // lbl_itemshow
            // 
            this.lbl_itemshow.AutoSize = true;
            this.lbl_itemshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_itemshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_itemshow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemshow.ForeColor = System.Drawing.Color.White;
            this.lbl_itemshow.Location = new System.Drawing.Point(391, 146);
            this.lbl_itemshow.Name = "lbl_itemshow";
            this.lbl_itemshow.Size = new System.Drawing.Size(159, 21);
            this.lbl_itemshow.TabIndex = 47;
            this.lbl_itemshow.Text = "Stock Inventory Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(679, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Dish Table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(965, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Recipe Items for the Dish";
            // 
            // btn_stockmaintain
            // 
            this.btn_stockmaintain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stockmaintain.Location = new System.Drawing.Point(31, 477);
            this.btn_stockmaintain.Name = "btn_stockmaintain";
            this.btn_stockmaintain.Size = new System.Drawing.Size(335, 34);
            this.btn_stockmaintain.TabIndex = 50;
            this.btn_stockmaintain.Text = "Stock Maintanence";
            this.btn_stockmaintain.UseVisualStyleBackColor = true;
            this.btn_stockmaintain.Click += new System.EventHandler(this.btn_stockmaintain_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kitchen_inventory.Properties.Resources.LogoImage;
            this.pictureBox2.Location = new System.Drawing.Point(45, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
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
            this.label2.TabIndex = 52;
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
            this.label1.TabIndex = 51;
            this.label1.Text = "      Kitchen Inventory System";
            // 
            // lbl_measure
            // 
            this.lbl_measure.AutoSize = true;
            this.lbl_measure.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_measure.Location = new System.Drawing.Point(267, 365);
            this.lbl_measure.Name = "lbl_measure";
            this.lbl_measure.Size = new System.Drawing.Size(118, 13);
            this.lbl_measure.TabIndex = 54;
            this.lbl_measure.Text = "ML/KG/Grams/Pieces";
            // 
            // RecipesConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1369, 695);
            this.Controls.Add(this.lbl_measure);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stockmaintain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_itemshow);
            this.Controls.Add(this.grd_recipeconfig);
            this.Controls.Add(this.grd_dishdetails);
            this.Controls.Add(this.cmb_dishid);
            this.Controls.Add(this.grd_recipedetails);
            this.Controls.Add(this.btn_showitems);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_needqty);
            this.Controls.Add(this.lbl_itemid);
            this.Controls.Add(this.lbl_dishname);
            this.Controls.Add(this.lbl_dishid);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_needqty);
            this.Controls.Add(this.txt_itemid);
            this.Controls.Add(this.txt_dishname);
            this.Controls.Add(this.txt_date);
            this.Name = "RecipesConfigure";
            this.Text = "Recipes Configure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RecipesConfigure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_recipedetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dishdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_recipeconfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_dishname;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.TextBox txt_needqty;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_dishid;
        private System.Windows.Forms.Label lbl_dishname;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Label lbl_needqty;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_showitems;
        private System.Windows.Forms.DataGridView grd_recipedetails;
        private System.Windows.Forms.ComboBox cmb_dishid;
        private System.Windows.Forms.DataGridView grd_dishdetails;
        private System.Windows.Forms.DataGridView grd_recipeconfig;
        private System.Windows.Forms.Label lbl_itemshow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_stockmaintain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_measure;
    }
}