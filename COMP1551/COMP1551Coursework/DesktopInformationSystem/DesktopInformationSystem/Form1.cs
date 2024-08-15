using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DesktopInformationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Spare function that accidentially created, no usage from its presence
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // Add Function
        private void btn_add_Click(object sender, EventArgs e)
        {
            // Defining variables
            string name = tb_name.Text;
            int phone = Convert.ToInt32(tb_phone.Text);
            string email = tb_email.Text;
            string role = tb_role.Text;

            // A connection to load up local databases data
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    // A cmd line from sql library to assign a data that its defined from the parameters/text written on form, so as we get the value from it.
                    cn.Open();
                    string query = "INSERT INTO Holder (name, phone, email, role) VALUES (@name, @phone, @email, @role)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
                    // We have certain cases to divide when the role textbox its typed
                    if (tb_role.Text == "Student")
                    {
                        query = "INSERT INTO Student (studentrole) VALUES (@studentrole)";
                        cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@studentrole", role);
                        cmd.ExecuteNonQuery();
                    }
                    else if (tb_role.Text == "Teacher")
                    {
                        query = "INSERT INTO Teacher (teacherrole) VALUES (@teacherrole)";
                        cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@teacherrole", role);
                        cmd.ExecuteNonQuery();
                    }
                    else if (tb_role.Text == "Admin")
                    {
                        query = "INSERT INTO Admin (adminrole) VALUES (@adminrole)";
                        cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@adminrole", role);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // Currently, i have no clue to make a correct exclusion lines
                        throw new ArgumentException("Only Student/Teacher/Admin are accepted roles!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            btn_load_Click(sender, e);
        }
        // Load Function
        private void btn_load_Click(object sender, EventArgs e)
        {
            // Connecting to the local database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    // Shows all data
                    cn.Open();
                    string query = "SELECT * FROM Holder";
                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        // Edit Function
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string name = tb_name.Text;
                int phone = Convert.ToInt32(tb_phone.Text);
                string email = tb_email.Text;
                string role = tb_role.Text;

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

                try
                {
                    using (SqlConnection cn = new SqlConnection(connectionString))
                    {
                        // Assigning all data variables to replace its chosen new one
                        cn.Open();
                        string query = "UPDATE Holder SET name = @name, phone = @phone, email = @email, role = @role WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                btn_load_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a row to edit!");
            }
        }
        // Delete Function
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

                try
                {
                    using (SqlConnection cn = new SqlConnection(connectionString))
                    {
                        // Remove the chosen row so as its links to the database SQL Query
                        cn.Open();
                        string query = "DELETE FROM Holder WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        btn_load_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                // No Rows Selected
                MessageBox.Show("Please select a row to remove.");
            }
        }
        // Text Appearing Selective Row Function
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract data from the selected row and populate textboxes
                tb_name.Text = selectedRow.Cells["name"].Value.ToString();
                tb_phone.Text = selectedRow.Cells["salary"].Value.ToString();
                tb_email.Text = selectedRow.Cells["email"].Value.ToString();
                tb_role.Text = selectedRow.Cells["role"].Value.ToString();
            }
            else
            {
                // Clear textboxes if no row is selected
                btn_clear_Click(null, null);
            }
        }
        // Clear textbox function
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_phone.Text = "";
            tb_email.Text = "";
            tb_role.Text = "";
        }
        // Links to a Form that is seperated for checking Holders By their own properties
        private void btn_group_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
