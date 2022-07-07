namespace ArtCafe2
{
    partial class Category
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Active_cmb = new System.Windows.Forms.ComboBox();
            this.Delete_btn2 = new System.Windows.Forms.Button();
            this.Clear_btn2 = new System.Windows.Forms.Button();
            this.Update_btn2 = new System.Windows.Forms.Button();
            this.Add_btn2 = new System.Windows.Forms.Button();
            this.Catname_txt = new System.Windows.Forms.TextBox();
            this.CatID_txt2 = new System.Windows.Forms.TextBox();
            this.Active_lbl2 = new System.Windows.Forms.Label();
            this.Catname_lbl = new System.Windows.Forms.Label();
            this.CatID_lbl2 = new System.Windows.Forms.Label();
            this.Search_txt2 = new System.Windows.Forms.TextBox();
            this.Search_lbl2 = new System.Windows.Forms.Label();
            this.DGVCAT = new System.Windows.Forms.DataGridView();
            this.Back_btn2 = new System.Windows.Forms.Button();
            this.title_lbl2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCAT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Active_cmb);
            this.groupBox1.Controls.Add(this.Delete_btn2);
            this.groupBox1.Controls.Add(this.Clear_btn2);
            this.groupBox1.Controls.Add(this.Update_btn2);
            this.groupBox1.Controls.Add(this.Add_btn2);
            this.groupBox1.Controls.Add(this.Catname_txt);
            this.groupBox1.Controls.Add(this.CatID_txt2);
            this.groupBox1.Controls.Add(this.Active_lbl2);
            this.groupBox1.Controls.Add(this.Catname_lbl);
            this.groupBox1.Controls.Add(this.CatID_lbl2);
            this.groupBox1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD Category";
            // 
            // Active_cmb
            // 
            this.Active_cmb.AutoCompleteCustomSource.AddRange(new string[] {
            "YES",
            "NO"});
            this.Active_cmb.FormattingEnabled = true;
            this.Active_cmb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.Active_cmb.Location = new System.Drawing.Point(129, 131);
            this.Active_cmb.Name = "Active_cmb";
            this.Active_cmb.Size = new System.Drawing.Size(58, 29);
            this.Active_cmb.TabIndex = 12;
            this.Active_cmb.Text = "YES";
            // 
            // Delete_btn2
            // 
            this.Delete_btn2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Delete_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn2.ForeColor = System.Drawing.Color.White;
            this.Delete_btn2.Location = new System.Drawing.Point(206, 188);
            this.Delete_btn2.Name = "Delete_btn2";
            this.Delete_btn2.Size = new System.Drawing.Size(75, 32);
            this.Delete_btn2.TabIndex = 8;
            this.Delete_btn2.Text = "DELETE";
            this.Delete_btn2.UseVisualStyleBackColor = false;
            this.Delete_btn2.Click += new System.EventHandler(this.Delete_btn2_Click);
            // 
            // Clear_btn2
            // 
            this.Clear_btn2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Clear_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn2.ForeColor = System.Drawing.Color.White;
            this.Clear_btn2.Location = new System.Drawing.Point(112, 239);
            this.Clear_btn2.Name = "Clear_btn2";
            this.Clear_btn2.Size = new System.Drawing.Size(75, 35);
            this.Clear_btn2.TabIndex = 8;
            this.Clear_btn2.Text = "CLEAR";
            this.Clear_btn2.UseVisualStyleBackColor = false;
            this.Clear_btn2.Click += new System.EventHandler(this.Clear_btn2_Click);
            // 
            // Update_btn2
            // 
            this.Update_btn2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Update_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn2.ForeColor = System.Drawing.Color.White;
            this.Update_btn2.Location = new System.Drawing.Point(112, 188);
            this.Update_btn2.Name = "Update_btn2";
            this.Update_btn2.Size = new System.Drawing.Size(75, 32);
            this.Update_btn2.TabIndex = 7;
            this.Update_btn2.Text = "UPDATE";
            this.Update_btn2.UseVisualStyleBackColor = false;
            this.Update_btn2.Click += new System.EventHandler(this.Update_btn2_Click);
            // 
            // Add_btn2
            // 
            this.Add_btn2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Add_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn2.ForeColor = System.Drawing.Color.White;
            this.Add_btn2.Location = new System.Drawing.Point(19, 188);
            this.Add_btn2.Name = "Add_btn2";
            this.Add_btn2.Size = new System.Drawing.Size(75, 32);
            this.Add_btn2.TabIndex = 6;
            this.Add_btn2.Text = "ADD";
            this.Add_btn2.UseVisualStyleBackColor = false;
            this.Add_btn2.Click += new System.EventHandler(this.Add_btn2_Click);
            // 
            // Catname_txt
            // 
            this.Catname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catname_txt.Location = new System.Drawing.Point(128, 86);
            this.Catname_txt.Name = "Catname_txt";
            this.Catname_txt.Size = new System.Drawing.Size(153, 26);
            this.Catname_txt.TabIndex = 4;
            // 
            // CatID_txt2
            // 
            this.CatID_txt2.Enabled = false;
            this.CatID_txt2.Location = new System.Drawing.Point(128, 43);
            this.CatID_txt2.Name = "CatID_txt2";
            this.CatID_txt2.ReadOnly = true;
            this.CatID_txt2.Size = new System.Drawing.Size(87, 28);
            this.CatID_txt2.TabIndex = 3;
            // 
            // Active_lbl2
            // 
            this.Active_lbl2.AutoSize = true;
            this.Active_lbl2.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active_lbl2.Location = new System.Drawing.Point(62, 135);
            this.Active_lbl2.Name = "Active_lbl2";
            this.Active_lbl2.Size = new System.Drawing.Size(60, 18);
            this.Active_lbl2.TabIndex = 2;
            this.Active_lbl2.Text = "Is Active:";
            this.Active_lbl2.Click += new System.EventHandler(this.Active_lbl2_Click);
            // 
            // Catname_lbl
            // 
            this.Catname_lbl.AutoSize = true;
            this.Catname_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catname_lbl.Location = new System.Drawing.Point(16, 90);
            this.Catname_lbl.Name = "Catname_lbl";
            this.Catname_lbl.Size = new System.Drawing.Size(106, 18);
            this.Catname_lbl.TabIndex = 1;
            this.Catname_lbl.Text = "Category Name:";
            // 
            // CatID_lbl2
            // 
            this.CatID_lbl2.AutoSize = true;
            this.CatID_lbl2.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatID_lbl2.Location = new System.Drawing.Point(41, 46);
            this.CatID_lbl2.Name = "CatID_lbl2";
            this.CatID_lbl2.Size = new System.Drawing.Size(81, 18);
            this.CatID_lbl2.TabIndex = 0;
            this.CatID_lbl2.Text = "Category ID:";
            // 
            // Search_txt2
            // 
            this.Search_txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt2.Location = new System.Drawing.Point(413, 85);
            this.Search_txt2.Name = "Search_txt2";
            this.Search_txt2.Size = new System.Drawing.Size(165, 26);
            this.Search_txt2.TabIndex = 11;
            this.Search_txt2.TextChanged += new System.EventHandler(this.Search_txt2_TextChanged);
            this.Search_txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_txt2_KeyPress);
            // 
            // Search_lbl2
            // 
            this.Search_lbl2.AutoSize = true;
            this.Search_lbl2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_lbl2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Search_lbl2.Location = new System.Drawing.Point(342, 86);
            this.Search_lbl2.Name = "Search_lbl2";
            this.Search_lbl2.Size = new System.Drawing.Size(65, 22);
            this.Search_lbl2.TabIndex = 10;
            this.Search_lbl2.Text = "Search:";
            // 
            // DGVCAT
            // 
            this.DGVCAT.BackgroundColor = System.Drawing.Color.White;
            this.DGVCAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCAT.GridColor = System.Drawing.Color.SaddleBrown;
            this.DGVCAT.Location = new System.Drawing.Point(346, 122);
            this.DGVCAT.Name = "DGVCAT";
            this.DGVCAT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCAT.Size = new System.Drawing.Size(347, 212);
            this.DGVCAT.TabIndex = 9;
            this.DGVCAT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCAT_CellContentClick);
            // 
            // Back_btn2
            // 
            this.Back_btn2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Back_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn2.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn2.ForeColor = System.Drawing.Color.White;
            this.Back_btn2.Location = new System.Drawing.Point(634, 21);
            this.Back_btn2.Name = "Back_btn2";
            this.Back_btn2.Size = new System.Drawing.Size(75, 32);
            this.Back_btn2.TabIndex = 12;
            this.Back_btn2.Text = "BACK";
            this.Back_btn2.UseVisualStyleBackColor = false;
            this.Back_btn2.Click += new System.EventHandler(this.Back_btn2_Click);
            // 
            // title_lbl2
            // 
            this.title_lbl2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.title_lbl2.Image = global::ArtCafe2.Properties.Resources.coffee;
            this.title_lbl2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title_lbl2.Location = new System.Drawing.Point(12, 8);
            this.title_lbl2.Name = "title_lbl2";
            this.title_lbl2.Size = new System.Drawing.Size(194, 65);
            this.title_lbl2.TabIndex = 0;
            this.title_lbl2.Text = "Art Cafe\'";
            this.title_lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(721, 407);
            this.Controls.Add(this.Back_btn2);
            this.Controls.Add(this.Search_lbl2);
            this.Controls.Add(this.Search_txt2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_lbl2);
            this.Controls.Add(this.DGVCAT);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Catname_txt;
        private System.Windows.Forms.TextBox CatID_txt2;
        private System.Windows.Forms.Label Active_lbl2;
        private System.Windows.Forms.Label Catname_lbl;
        private System.Windows.Forms.Label CatID_lbl2;
        private System.Windows.Forms.DataGridView DGVCAT;
        private System.Windows.Forms.Button Delete_btn2;
        private System.Windows.Forms.Button Clear_btn2;
        private System.Windows.Forms.Button Update_btn2;
        private System.Windows.Forms.Button Add_btn2;
        private System.Windows.Forms.TextBox Search_txt2;
        private System.Windows.Forms.Label Search_lbl2;
        private System.Windows.Forms.Button Back_btn2;
        private System.Windows.Forms.ComboBox Active_cmb;
    }
}