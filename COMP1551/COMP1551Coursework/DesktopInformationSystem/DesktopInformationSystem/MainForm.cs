using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void btn_group_by_teacher_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    // Inner joining can make a specific view for a table it only related
                    cn.Open();
                    string query = "SELECT Holder.name, Holder.phone, Holder.email, Teacher.salary, Teacher.subject1, Teacher.subject2 FROM Holder INNER JOIN Teacher ON Holder.Id = Teacher.holderId";
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

        private void btn_group_by_admin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    string query = "SELECT Holder.name, Holder.phone, Holder.email, Admin.salary, Admin.fulltime, Admin.workinghours FROM Holder INNER JOIN Admin ON Holder.Id = Admin.holderId";
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

        private void btn_group_by_student_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    string query = "SELECT Holder.Id, Holder.name, Holder.phone, Holder.email, Student.subject1, Student.subject2, Student.prevsub1, Student.prevsub2 FROM Holder INNER JOIN Student ON Holder.Id = Student.holderid";
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

        private void btn_manage_teacher_Click(object sender, EventArgs e)
        {

        }

        private void btn_manage_admin_Click(object sender, EventArgs e)
        {

        }

        private void btn_manage_student_Click(object sender, EventArgs e)
        {
            StudentForm studentform = new StudentForm();
            studentform.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
