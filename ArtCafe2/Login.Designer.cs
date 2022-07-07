namespace ArtCafe2
{
    partial class Login
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
            this.User_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.User_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.icon1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_lbl
            // 
            this.User_lbl.AutoSize = true;
            this.User_lbl.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_lbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.User_lbl.Location = new System.Drawing.Point(17, 10);
            this.User_lbl.Name = "User_lbl";
            this.User_lbl.Size = new System.Drawing.Size(90, 22);
            this.User_lbl.TabIndex = 0;
            this.User_lbl.Text = "Username:";
            this.User_lbl.Click += new System.EventHandler(this.User_lbl_Click);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Password_lbl.Location = new System.Drawing.Point(17, 73);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(87, 22);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = "Password:";
            // 
            // User_txt
            // 
            this.User_txt.Location = new System.Drawing.Point(21, 35);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(133, 20);
            this.User_txt.TabIndex = 2;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(21, 98);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(133, 20);
            this.Password_txt.TabIndex = 3;
            this.Password_txt.UseSystemPasswordChar = true;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(44, 163);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(83, 27);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Cancel_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_btn.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btn.Location = new System.Drawing.Point(44, 213);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(83, 30);
            this.Cancel_btn.TabIndex = 5;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // icon1
            // 
            this.icon1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.icon1.Image = global::ArtCafe2.Properties.Resources.coffee;
            this.icon1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icon1.Location = new System.Drawing.Point(49, 19);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(177, 67);
            this.icon1.TabIndex = 6;
            this.icon1.Text = "Art Cafe\'";
            this.icon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.User_lbl);
            this.panel1.Controls.Add(this.User_txt);
            this.panel1.Controls.Add(this.Cancel_btn);
            this.panel1.Controls.Add(this.Password_lbl);
            this.panel1.Controls.Add(this.Login_btn);
            this.panel1.Controls.Add(this.Password_txt);
            this.panel1.Location = new System.Drawing.Point(46, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 262);
            this.panel1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(283, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.icon1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label User_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox User_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label icon1;
        private System.Windows.Forms.Panel panel1;
    }
}

