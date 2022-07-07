using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtCafe2.Include;

namespace ArtCafe2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql;

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM users WHERE username='" + User_txt.Text + "' AND password='" + Password_txt.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                MessageBox.Show("WELCOME TO ART CAFE POS SYSTEM", "POS SYSTEM");
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Accounts does not exist! please contact administrator", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_lbl_Click(object sender, EventArgs e)
        {

        }
    }
    }

