namespace ArtCafe2
{
    partial class Menu
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
            this.form_panel1 = new System.Windows.Forms.GroupBox();
            this.Category_cmb1 = new System.Windows.Forms.ComboBox();
            this.Active_cmb = new System.Windows.Forms.ComboBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Menuprice_txt = new System.Windows.Forms.TextBox();
            this.Menudesc_txt = new System.Windows.Forms.TextBox();
            this.Menuname_txt = new System.Windows.Forms.TextBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Menuid_txt = new System.Windows.Forms.TextBox();
            this.Active_lbl = new System.Windows.Forms.Label();
            this.CatID_lbl = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Menuprice_lbl = new System.Windows.Forms.Label();
            this.MenuDesc_lbl = new System.Windows.Forms.Label();
            this.Menuname_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVM = new System.Windows.Forms.DataGridView();
            this.Search_lbl = new System.Windows.Forms.Label();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Back_btn1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.form_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVM)).BeginInit();
            this.SuspendLayout();
            // 
            // form_panel1
            // 
            this.form_panel1.BackColor = System.Drawing.Color.White;
            this.form_panel1.Controls.Add(this.Category_cmb1);
            this.form_panel1.Controls.Add(this.Active_cmb);
            this.form_panel1.Controls.Add(this.Clear_btn);
            this.form_panel1.Controls.Add(this.Menuprice_txt);
            this.form_panel1.Controls.Add(this.Menudesc_txt);
            this.form_panel1.Controls.Add(this.Menuname_txt);
            this.form_panel1.Controls.Add(this.Update_btn);
            this.form_panel1.Controls.Add(this.Delete_btn);
            this.form_panel1.Controls.Add(this.Menuid_txt);
            this.form_panel1.Controls.Add(this.Active_lbl);
            this.form_panel1.Controls.Add(this.CatID_lbl);
            this.form_panel1.Controls.Add(this.Add_btn);
            this.form_panel1.Controls.Add(this.Menuprice_lbl);
            this.form_panel1.Controls.Add(this.MenuDesc_lbl);
            this.form_panel1.Controls.Add(this.Menuname_lbl);
            this.form_panel1.Controls.Add(this.label1);
            this.form_panel1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_panel1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.form_panel1.Location = new System.Drawing.Point(22, 70);
            this.form_panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.form_panel1.Name = "form_panel1";
            this.form_panel1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.form_panel1.Size = new System.Drawing.Size(336, 375);
            this.form_panel1.TabIndex = 1;
            this.form_panel1.TabStop = false;
            this.form_panel1.Text = "CREATE Menu";
            // 
            // Category_cmb1
            // 
            this.Category_cmb1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_cmb1.FormattingEnabled = true;
            this.Category_cmb1.Location = new System.Drawing.Point(123, 168);
            this.Category_cmb1.Name = "Category_cmb1";
            this.Category_cmb1.Size = new System.Drawing.Size(100, 29);
            this.Category_cmb1.TabIndex = 16;
            this.Category_cmb1.SelectedIndexChanged += new System.EventHandler(this.Category_cmb_SelectedIndexChanged);
            this.Category_cmb1.SelectedValueChanged += new System.EventHandler(this.Category_cmb_SelectedValueChanged);
            // 
            // Active_cmb
            // 
            this.Active_cmb.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active_cmb.FormattingEnabled = true;
            this.Active_cmb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Active_cmb.Location = new System.Drawing.Point(123, 203);
            this.Active_cmb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Active_cmb.Name = "Active_cmb";
            this.Active_cmb.Size = new System.Drawing.Size(66, 29);
            this.Active_cmb.TabIndex = 11;
            this.Active_cmb.Text = "Yes";
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.Location = new System.Drawing.Point(128, 304);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(64, 28);
            this.Clear_btn.TabIndex = 15;
            this.Clear_btn.Text = "CLEAR";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Menuprice_txt
            // 
            this.Menuprice_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menuprice_txt.Location = new System.Drawing.Point(123, 136);
            this.Menuprice_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Menuprice_txt.Name = "Menuprice_txt";
            this.Menuprice_txt.Size = new System.Drawing.Size(100, 26);
            this.Menuprice_txt.TabIndex = 9;
            // 
            // Menudesc_txt
            // 
            this.Menudesc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menudesc_txt.Location = new System.Drawing.Point(123, 100);
            this.Menudesc_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Menudesc_txt.Name = "Menudesc_txt";
            this.Menudesc_txt.Size = new System.Drawing.Size(209, 26);
            this.Menudesc_txt.TabIndex = 8;
            // 
            // Menuname_txt
            // 
            this.Menuname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menuname_txt.Location = new System.Drawing.Point(123, 67);
            this.Menuname_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Menuname_txt.Name = "Menuname_txt";
            this.Menuname_txt.Size = new System.Drawing.Size(148, 26);
            this.Menuname_txt.TabIndex = 7;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.Color.White;
            this.Update_btn.Location = new System.Drawing.Point(128, 258);
            this.Update_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(64, 28);
            this.Update_btn.TabIndex = 14;
            this.Update_btn.Text = "UPDATE";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(206, 258);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(64, 28);
            this.Delete_btn.TabIndex = 13;
            this.Delete_btn.Text = "DELETE";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Menuid_txt
            // 
            this.Menuid_txt.Enabled = false;
            this.Menuid_txt.Location = new System.Drawing.Point(123, 33);
            this.Menuid_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Menuid_txt.Name = "Menuid_txt";
            this.Menuid_txt.ReadOnly = true;
            this.Menuid_txt.Size = new System.Drawing.Size(100, 28);
            this.Menuid_txt.TabIndex = 6;
            // 
            // Active_lbl
            // 
            this.Active_lbl.AutoSize = true;
            this.Active_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active_lbl.Location = new System.Drawing.Point(58, 207);
            this.Active_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Active_lbl.Name = "Active_lbl";
            this.Active_lbl.Size = new System.Drawing.Size(60, 18);
            this.Active_lbl.TabIndex = 5;
            this.Active_lbl.Text = "Is Active:";
            // 
            // CatID_lbl
            // 
            this.CatID_lbl.AutoSize = true;
            this.CatID_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatID_lbl.Location = new System.Drawing.Point(38, 172);
            this.CatID_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CatID_lbl.Name = "CatID_lbl";
            this.CatID_lbl.Size = new System.Drawing.Size(81, 18);
            this.CatID_lbl.TabIndex = 4;
            this.CatID_lbl.Text = "Category ID:";
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(38, 258);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(64, 28);
            this.Add_btn.TabIndex = 12;
            this.Add_btn.Text = "ADD";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Menuprice_lbl
            // 
            this.Menuprice_lbl.AutoSize = true;
            this.Menuprice_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menuprice_lbl.Location = new System.Drawing.Point(40, 140);
            this.Menuprice_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Menuprice_lbl.Name = "Menuprice_lbl";
            this.Menuprice_lbl.Size = new System.Drawing.Size(79, 18);
            this.Menuprice_lbl.TabIndex = 3;
            this.Menuprice_lbl.Text = "Menu Price:";
            // 
            // MenuDesc_lbl
            // 
            this.MenuDesc_lbl.AutoSize = true;
            this.MenuDesc_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDesc_lbl.Location = new System.Drawing.Point(2, 104);
            this.MenuDesc_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuDesc_lbl.Name = "MenuDesc_lbl";
            this.MenuDesc_lbl.Size = new System.Drawing.Size(117, 18);
            this.MenuDesc_lbl.TabIndex = 2;
            this.MenuDesc_lbl.Text = "Menu Description:";
            // 
            // Menuname_lbl
            // 
            this.Menuname_lbl.AutoSize = true;
            this.Menuname_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menuname_lbl.Location = new System.Drawing.Point(34, 71);
            this.Menuname_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Menuname_lbl.Name = "Menuname_lbl";
            this.Menuname_lbl.Size = new System.Drawing.Size(85, 18);
            this.Menuname_lbl.TabIndex = 1;
            this.Menuname_lbl.Text = "Menu Name:";
            this.Menuname_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGVM
            // 
            this.DGVM.BackgroundColor = System.Drawing.Color.White;
            this.DGVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVM.GridColor = System.Drawing.Color.SaddleBrown;
            this.DGVM.Location = new System.Drawing.Point(366, 125);
            this.DGVM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVM.Name = "DGVM";
            this.DGVM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVM.Size = new System.Drawing.Size(518, 265);
            this.DGVM.TabIndex = 12;
            this.DGVM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVM_CellContentClick);
            // 
            // Search_lbl
            // 
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_lbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Search_lbl.Location = new System.Drawing.Point(362, 83);
            this.Search_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(65, 22);
            this.Search_lbl.TabIndex = 13;
            this.Search_lbl.Text = "Search:";
            // 
            // Search_txt
            // 
            this.Search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt.Location = new System.Drawing.Point(431, 84);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(150, 26);
            this.Search_txt.TabIndex = 14;
            this.Search_txt.TextChanged += new System.EventHandler(this.Search_txt_TextChanged);
            // 
            // Back_btn1
            // 
            this.Back_btn1.BackColor = System.Drawing.Color.SaddleBrown;
            this.Back_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn1.ForeColor = System.Drawing.Color.White;
            this.Back_btn1.Location = new System.Drawing.Point(847, 25);
            this.Back_btn1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Back_btn1.Name = "Back_btn1";
            this.Back_btn1.Size = new System.Drawing.Size(64, 28);
            this.Back_btn1.TabIndex = 16;
            this.Back_btn1.Text = "BACK";
            this.Back_btn1.UseVisualStyleBackColor = false;
            this.Back_btn1.Click += new System.EventHandler(this.Back_btn1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Image = global::ArtCafe2.Properties.Resources.coffee;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(19, -4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 71);
            this.label3.TabIndex = 0;
            this.label3.Text = "Art Cafe\'";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(936, 479);
            this.Controls.Add(this.Back_btn1);
            this.Controls.Add(this.Search_lbl);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.form_panel1);
            this.Controls.Add(this.DGVM);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.form_panel1.ResumeLayout(false);
            this.form_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox form_panel1;
        private System.Windows.Forms.Label Active_lbl;
        private System.Windows.Forms.Label CatID_lbl;
        private System.Windows.Forms.Label Menuprice_lbl;
        private System.Windows.Forms.Label MenuDesc_lbl;
        private System.Windows.Forms.Label Menuname_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Active_cmb;
        private System.Windows.Forms.TextBox Menuprice_txt;
        private System.Windows.Forms.TextBox Menudesc_txt;
        private System.Windows.Forms.TextBox Menuname_txt;
        private System.Windows.Forms.TextBox Menuid_txt;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.DataGridView DGVM;
        private System.Windows.Forms.Label Search_lbl;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Button Back_btn1;
        private System.Windows.Forms.ComboBox Category_cmb1;
        private System.Windows.Forms.Label label3;
    }
}