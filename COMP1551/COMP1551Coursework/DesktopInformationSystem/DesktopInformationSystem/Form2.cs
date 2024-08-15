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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Spare function that accidentially created, no usage from its presence
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        // Grouping in teacher role so its can sole be visible as its own same role
        private void btn_teacher_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    // Inner joining can make a specific view for a table it only related
                    cn.Open();
                    string query = "SELECT Holder.name, Holder.phone, Holder.email, Teacher.salary, Teacher.subject1, Teacher.subject2 FROM Holder INNER JOIN Teacher ON Holder.role = Teacher.teacherrole";
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
        // Admin role case
        private void btn_admin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    string query = "SELECT Holder.name, Holder.phone, Holder.email, Admin.adminname, Admin.salary, Admin.fulltime, Admin.workinghours FROM Holder INNER JOIN Admin ON Holder.role = Admin.adminrole";
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
        // Then, the Student case
        private void btn_student_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    string query = "SELECT Holder.name, Holder.phone, Holder.email, Student.subject1, Student.subject2, Student.prevsub1, Student.prevsub2 FROM Holder INNER JOIN Student ON Holder.role = Student.studentrole";
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
        // A replicated function from Form1 to ensure if all the data loaded correctly
        private void btn_load_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
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
    } 
}
