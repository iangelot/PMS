using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    public partial class Registerform : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\pharmacy1.mdf;Integrated Security=True;Connect Timeout=30";
        public Registerform()
        {
            InitializeComponent();
        }

        private void Registerform_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(register_username.Text == "" || register_password.Text == "" || register_confirmpassword.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkUserQuery = "SELECT * FROM users WHERE username = @usern";

                    using(SqlCommand checkUsern = new SqlCommand(checkUserQuery, connection))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                            MessageBox.Show(tempUsern + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }else if(register_password.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }else if(register_password.Text != register_confirmpassword.Text)
                        {
                            MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users(username, password, role, status, date_register) " +
                                "VALUES(@usern, @pass, @role, @status, @date)";

                            using(SqlCommand cmd = new SqlCommand(insertData, connection))
                            {
                                cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Cashier");
                                cmd.Parameters.AddWithValue("@status", "Approval");

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginform = new Form1();
                                loginform.Show();

                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpass.Checked ? '\0' : '*';
            register_confirmpassword.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }

        private void register_loginbtn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();

            this.Hide();
        }
    }
}
