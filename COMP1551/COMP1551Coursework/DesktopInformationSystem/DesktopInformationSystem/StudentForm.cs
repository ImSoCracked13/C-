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
    public partial class StudentForm : Form
    {
        private DatabaseFunctions dbFunctions;
        public StudentForm()
        {
            InitializeComponent();
            dbFunctions = new DatabaseFunctions(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COMP1551Coursework\DesktopInformationSystem\DesktopInformationSystem\Database1.mdf;Integrated Security=True");
        }

        private void btn_load_Click(object sender, EventArgs e)
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Create a Student object from user input
            Student student = new Student
            {
                // Defining variables
                Name = tb_name.Text,
                Phone = tb_phone.Text,
                Email = tb_email.Text,
                StudentSubject1 = tb_subject1.Text,
                StudentSubject2 = tb_subject2.Text,
                Prevsub1 = tb_prevsub1.Text,
                Prevsub2 = tb_prevsub2.Text
            };

            try
            {
                // Add the student to the database using DatabaseFunctions library
                dbFunctions.AddStudent(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            btn_load_Click(sender, e);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                // Defining variables
                Id = Convert.ToInt32(tb_id.Text),
                Name = tb_name.Text,
                Phone = tb_phone.Text,
                Email = tb_email.Text,
                StudentSubject1 = tb_subject1.Text,
                StudentSubject2 = tb_subject2.Text,
                Prevsub1 = tb_prevsub1.Text,
                Prevsub2 = tb_prevsub2.Text
            };

            try
            {
                dbFunctions.EditStudent(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            btn_load_Click(sender, e);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Id = Convert.ToInt32(tb_id.Text),
            };

            try
            {
                dbFunctions.RemoveStudent(student);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            btn_load_Click(sender, e);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_phone.Text = "";
            tb_email.Text = "";
            tb_subject1.Text = "";
            tb_subject2.Text = "";
            tb_prevsub1.Text = "";
            tb_prevsub2.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                tb_id.Text = selectedRow.Cells["Id"].Value.ToString();
                tb_name.Text = selectedRow.Cells["name"].Value.ToString();
                tb_phone.Text = selectedRow.Cells["phone"].Value.ToString();
                tb_email.Text = selectedRow.Cells["email"].Value.ToString();
                tb_subject1.Text = selectedRow.Cells["subject1"].Value.ToString();
                tb_subject2.Text = selectedRow.Cells["subject2"].Value.ToString();
                tb_prevsub1.Text = selectedRow.Cells["prevsub1"].Value.ToString();
                tb_prevsub2.Text = selectedRow.Cells["prevsub2"].Value.ToString();
            }
            else
            {
                btn_clear_Click(sender, e);
            }
        }
    }
}
