namespace ArtCafe2
{
    partial class Home
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
            this.Button_panel = new System.Windows.Forms.Panel();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Category_btn = new System.Windows.Forms.Button();
            this.Menu_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_panel
            // 
            this.Button_panel.BackColor = System.Drawing.Color.Tan;
            this.Button_panel.Controls.Add(this.Logout_btn);
            this.Button_panel.Controls.Add(this.Menu_btn);
            this.Button_panel.Controls.Add(this.button1);
            this.Button_panel.Controls.Add(this.Category_btn);
            this.Button_panel.ForeColor = System.Drawing.Color.White;
            this.Button_panel.Location = new System.Drawing.Point(64, 68);
            this.Button_panel.Name = "Button_panel";
            this.Button_panel.Size = new System.Drawing.Size(350, 181);
            this.Button_panel.TabIndex = 1;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Logout_btn.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(67, 118);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(211, 42);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Category_btn
            // 
            this.Category_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Category_btn.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_btn.ForeColor = System.Drawing.Color.White;
            this.Category_btn.Location = new System.Drawing.Point(67, 61);
            this.Category_btn.Name = "Category_btn";
            this.Category_btn.Size = new System.Drawing.Size(211, 39);
            this.Category_btn.TabIndex = 1;
            this.Category_btn.Text = "Category";
            this.Category_btn.UseVisualStyleBackColor = false;
            this.Category_btn.Click += new System.EventHandler(this.Category_btn_Click);
            // 
            // Menu_btn
            // 
            this.Menu_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Menu_btn.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_btn.ForeColor = System.Drawing.Color.White;
            this.Menu_btn.Location = new System.Drawing.Point(67, 16);
            this.Menu_btn.Name = "Menu_btn";
            this.Menu_btn.Size = new System.Drawing.Size(211, 39);
            this.Menu_btn.TabIndex = 0;
            this.Menu_btn.Text = "Menu";
            this.Menu_btn.UseVisualStyleBackColor = false;
            this.Menu_btn.Click += new System.EventHandler(this.Menu_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Raleway Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.title_lbl.Image = global::ArtCafe2.Properties.Resources.coffee;
            this.title_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title_lbl.Location = new System.Drawing.Point(83, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(306, 71);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Artcafe POS System";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(67, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Category";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Category_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 290);
            this.Controls.Add(this.Button_panel);
            this.Controls.Add(this.title_lbl);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Button_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel Button_panel;
        private System.Windows.Forms.Button Category_btn;
        private System.Windows.Forms.Button Menu_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button button1;
    }
}