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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            uploadData();
            random();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void uploadData()
        {
            conn.ConnectionString = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "Select * from tbl_category ORDER BY CategoryID";

            rd = cmd.ExecuteReader();
            dt.Load(rd);
            rd.Close();
            conn.Close();
            DGVCAT.DataSource = dt;

        }
        private bool checkDuplicate()
        {
            for (int item = 0; item < DGVCAT.Rows.Count; item++)
            {
                if (Catname_txt.Text == DGVCAT.Rows[item].Cells[1].Value.ToString())
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        private bool checkDuplicateUpdate()
        {
            for (int item = 0; item < DGVCAT.Rows.Count; item++)
            {
                if (Catname_txt.Text == DGVCAT.Rows[item].Cells[1].Value.ToString() & Catname_txt.Text !=DGVCAT.CurrentRow.Cells[0].Value.ToString())
                {
                    return true;
                }
                
            }
            return false;

        }
        
        private void refresh()
        {
            conn.ConnectionString = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "Select * from tbl_category ORDER BY CategoryID";

            rd = cmd.ExecuteReader();
            dt.Load(rd);
            rd.Close();
            conn.Close();
            DGVCAT.DataSource = dt;

            CatID_txt2.Text = "";
            Catname_txt.Text = "";


        }
     
        private void random()
        {

            Random rnd = new Random();

            for (int j = 0; j < 1; j++)
            {
                CatID_txt2.Text = rnd.Next() + "";
            }


        }
        private void clearText()
        {
            CatID_txt2.Text = "";
            Catname_txt.Text = "";

        }
      
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter dta = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        MySqlDataReader rd;

        private void Active_lbl2_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Add_btn2_Click(object sender, EventArgs e)
        {

            if (CatID_txt2.Text == "" || Catname_txt.Text == "" || Active_cmb.Text == "")
            {

                MessageBox.Show("All fields are required. Please ensure all fields are completed");


            }


            else if (checkDuplicate())
            {
                MessageBox.Show("Category Name already exists in the database");
            }
            
            else
            {
                try
                {
                    string connection = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
                    string query = "INSERT INTO tbl_category(`CategoryID`, `CategoryName`, `IsActive`)VALUES" +
                    "('" + this.CatID_txt2.Text + "','" + this.Catname_txt.Text + "','" + this.Active_cmb.Text + "')";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("New menu category has been added");

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

        private void Update_btn2_Click(object sender, EventArgs e)
        {

            if (CatID_txt2.Text == "" || Catname_txt.Text == "" || Active_cmb.Text == "")
            {

                MessageBox.Show("All fields are required. Please ensure all fields are completed");


            }

            else if (checkDuplicateUpdate())
            {
                MessageBox.Show("Category name already exists in the database.");

            }
            else
            {
                string connection = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
                string query = "UPDATE tbl_category SET CategoryName='" + this.Catname_txt.Text + "',IsActive='" + this.Active_cmb.Text + "' WHERE CategoryID='" + this.CatID_txt2.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Category has been updated.");


                conn.Close();
                refresh();
                random();

            }
        }

        private void Delete_btn2_Click(object sender, EventArgs e)
        {
            if (CatID_txt2.Text == "" || Catname_txt.Text == "" || Active_cmb.Text == "")
            {

                MessageBox.Show("Form is empty");

            }
            else
            {
                try
                {
                    string connection = "server=localhost;user id=root;password=;database=db_restaurant_remoreras";
                    string query = "DELETE FROM tbl_category WHERE CategoryID='" + this.CatID_txt2.Text + "'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr;
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Category has been deleted.");


                    refresh();
                    random();
                    conn.Close();


                }
                catch (Exception ex)
                {
                  MessageBox.Show("Category cannot be deleted. This item is referred to by another object.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Clear_btn2_Click(object sender, EventArgs e)
        {
            clearText();
            random();
        }

        private void DGVCAT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CatID_txt2.Text = DGVCAT.SelectedRows[0].Cells[0].Value.ToString();
                Catname_txt.Text = DGVCAT.SelectedRows[0].Cells[1].Value.ToString();
                Active_cmb.Text = DGVCAT.SelectedRows[0].Cells[2].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Search_txt2_TextChanged(object sender, EventArgs e)
        {
            DataView dvs = new DataView(dt);
            dvs.RowFilter = string.Format("CategoryName LIKE '%{0}%'", Search_txt2.Text);
            DGVCAT.DataSource = dvs;
        }

        private void Search_txt2_KeyPress(object sender, KeyPressEventArgs e)
        {

                DataView dvs = new DataView(dt);
                dvs.RowFilter = string.Format("CategoryName LIKE '%{0}%'", Search_txt2.Text);
                DGVCAT.DataSource = dvs;

            }
        }
    }

    
 
    

