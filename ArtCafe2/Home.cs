using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtCafe2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Category_btn_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this program!", "POS SYSTEM");
            Login login = new Login();
            login.Show();
            this.Hide();
           
        }
    }
}
