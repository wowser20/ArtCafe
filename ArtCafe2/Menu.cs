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
using MySql.Data.MySqlClient;




namespace ArtCafe2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            uploadData();
            random();
            fillCombobox();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void uploadData()
        {
            conn.ConnectionString = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "Select * from tbl_menu ORDER BY MenuID";

            rd = cmd.ExecuteReader();
            dt.Load(rd);
            rd.Close();
            conn.Close();
            DGVM.DataSource = dt;

        }
        private void refresh()
        {
            conn.ConnectionString = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "Select * from tbl_menu ORDER BY MenuID";

            rd = cmd.ExecuteReader();
            dt.Load(rd);
            rd.Close();
            conn.Close();
            DGVM.DataSource = dt;

            Menuid_txt.Text = "";
            Menuname_txt.Text = "";
            Menudesc_txt.Text = "";
            Menuprice_txt.Text = "";
            Search_txt.Text = "";
            Category_cmb1.Text = "";


        }
        private void clearText()
        {
            Menuname_txt.Text = "";
            Menudesc_txt.Text = "";
            Menuprice_txt.Text = "";
            Search_txt.Text = "";
            Category_cmb1.Text = "";
        }
        private void random()
        {

            Random rnd = new Random();

            for (int j = 0; j < 1; j++)
            {
                Menuid_txt.Text = rnd.Next() + "";
            }
        }
        private void fillCombobox()
        {
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; password =; database = db_restaurant_remoreras");
            MySqlCommand cmd = new MySqlCommand("SELECT CategoryID from tbl_category", conn);
            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            Category_cmb1.DataSource = dt;
            Category_cmb1.DisplayMember = "CategoryID";

        }
        private bool checkDuplicate()
        { 
            for (int item = 0; item < DGVM.Rows.Count; item++)
            {
                if (Menuname_txt.Text == DGVM.Rows[item].Cells[1].Value.ToString())
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        private bool checkDuplicateUpdate()
        {
            for (int item = 0; item < DGVM.Rows.Count; item++)
            {
                if (Menuname_txt.Text == DGVM.Rows[item].Cells[1].Value.ToString() & Menuname_txt.Text != DGVM.CurrentRow.Cells[0].Value.ToString())
                {
                    return true;
                }
            }
            return false;

        }
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter dta = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlDataReader rd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Back_btn1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Menuname_txt.Text == "" || Menudesc_txt.Text == "" || Menuprice_txt.Text == "")
            {

                MessageBox.Show("Kindly fill up all the spaces");


            }
            else if (checkDuplicate())
            {
                MessageBox.Show("Menu name already exists in the database");

            }
            else
            {
                try
                {
                    string connection = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
                    string query = "INSERT INTO tbl_menu(`MenuID`, `MenuName`,`MenuDescription`,`MenuPrice`,`CategoryID`,`IsActive`)VALUES" +
                    "('" + this.Menuid_txt.Text + "','" + this.Menuname_txt.Text + "','" + this.Menudesc_txt.Text + "','" + this.Menuprice_txt.Text + "','" + this.Category_cmb1.Text + "','" + this.Active_cmb.Text + "')";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("New menu has been added.");

                    conn.Close();
                    refresh();
                    random();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("" + ex);
                }

            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (Menuname_txt.Text == "" || Menudesc_txt.Text == "" || Menuprice_txt.Text == "" || Active_cmb.Text == "")
            {

                MessageBox.Show("Kindly fill up all the spaces");
            }
            else if (checkDuplicateUpdate())
            {
                MessageBox.Show("Menu name already exists in the database.");

            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
                string query = "UPDATE tbl_menu SET MenuName='" + this.Menuname_txt.Text + "',MenuDescription='" + this.Menudesc_txt.Text + "',MenuPrice='" + this.Menuprice_txt.Text + "',CategoryID='" + this.Category_cmb1.Text + "',IsActive='" + this.Active_cmb.Text + "' WHERE MenuID='" + this.Menuid_txt.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Record has been updated successfully");


                conn.Close();
                refresh();
                random();

            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (Menuname_txt.Text == "" || Menudesc_txt.Text == "" || Menuprice_txt.Text == "" || Active_cmb.Text == "")
            {

                MessageBox.Show("form is empty");
            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
                string query = "DELETE FROM tbl_menu WHERE MenuID='" + this.Menuid_txt.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Menu has been deleted.");


                conn.Close();
                refresh();
                random();

            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            clearText();
            random();
        }

        private void Category_cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Category_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGVM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Menuid_txt.Text = DGVM.SelectedRows[0].Cells[0].Value.ToString();
                Menuname_txt.Text = DGVM.SelectedRows[0].Cells[1].Value.ToString();
                Menudesc_txt.Text = DGVM.SelectedRows[0].Cells[2].Value.ToString();
                Menuprice_txt.Text = DGVM.SelectedRows[0].Cells[3].Value.ToString();
                Category_cmb1.Text = DGVM.SelectedRows[0].Cells[4].Value.ToString();
                Active_cmb.Text = DGVM.SelectedRows[0].Cells[5].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            DataView dvs = new DataView(dt);
            dvs.RowFilter = string.Format("MenuName LIKE '%{0}%'", Search_txt.Text);
            
            DGVM.DataSource = dvs;
        }
    }
    }


