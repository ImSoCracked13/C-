using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    public class Holder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }


    public class Teacher : Holder
    {
        public string Salary { get; set; }
        public string TeacherSubject1 { get; set; }
        public string TeacherSubject2 { get; set; }
    }


    public class Admin : Holder
    {
        public string Salary { get; set; }
        public string Fulltime { get; set; }
        public string Workinghours { get; set; }
    }

    public class Student : Holder
    {
        public string StudentSubject1 { get; set; }
        public string StudentSubject2 { get; set; }
        public string Prevsub1 { get; set; }
        public string Prevsub2 { get; set; }
    }


    public class DatabaseFunctions
    {
        private string connectionString;

        public DatabaseFunctions(string connectionString)
        {
            this.connectionString = connectionString;
        }






        // Student
        public void AddStudent(Student student)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string mainQuery = "INSERT INTO Holder (name, phone, email, role) VALUES (@name, @phone, @email, 'Student'); SELECT SCOPE_IDENTITY();";
                SqlCommand mainCommand = new SqlCommand(mainQuery, cn);

                mainCommand.Parameters.AddWithValue("@name", student.Name);
                mainCommand.Parameters.AddWithValue("@phone", student.Phone);
                mainCommand.Parameters.AddWithValue("@email", student.Email);

                int holderid = Convert.ToInt32(mainCommand.ExecuteScalar());

                string studentQuery = "INSERT INTO Student (subject1, subject2, prevsub1, prevsub2, holderid) VALUES (@subject1, @subject2, @prevsub1, @prevsub2, @holderid)";
                SqlCommand studentCommand = new SqlCommand(studentQuery, cn);

                studentCommand.Parameters.AddWithValue("@subject1", student.StudentSubject1);
                studentCommand.Parameters.AddWithValue("@subject2", student.StudentSubject2);
                studentCommand.Parameters.AddWithValue("@prevsub1", student.Prevsub1);
                studentCommand.Parameters.AddWithValue("@prevsub2", student.Prevsub2);
                studentCommand.Parameters.AddWithValue("@HolderId", holderid);

                studentCommand.ExecuteNonQuery();
            }
        }


        public void EditStudent(Student student)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string mainQuery = "UPDATE Holder SET Name = @Name, Phone = @Phone, Email = @Email WHERE Id = @Id";
                SqlCommand mainCommand = new SqlCommand(mainQuery, cn);
                mainCommand.Parameters.AddWithValue("@Id", student.Id);
                mainCommand.Parameters.AddWithValue("@Name", student.Name);
                mainCommand.Parameters.AddWithValue("@Phone", student.Phone);
                mainCommand.Parameters.AddWithValue("@Email", student.Email);
                mainCommand.ExecuteNonQuery();

                string studentQuery = "UPDATE Student SET Subject1 = @Subject1, Subject2 = @Subject2, Prevsub1 = @Prevsub1, Prevsub2 = @Prevsub2 WHERE holderid = @Id";
                SqlCommand studentCommand = new SqlCommand(studentQuery, cn);
                studentCommand.Parameters.AddWithValue("@Id", student.Id);
                studentCommand.Parameters.AddWithValue("@Subject1", student.StudentSubject1);
                studentCommand.Parameters.AddWithValue("@Subject2", student.StudentSubject2);
                studentCommand.Parameters.AddWithValue("@Prevsub1", student.Prevsub1);
                studentCommand.Parameters.AddWithValue("@Prevsub2", student.Prevsub2);
                studentCommand.ExecuteNonQuery();
            }
        }


        public void RemoveStudent(Student student)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string mainQuery = "DELETE FROM Holder WHERE Id = @Id";
                SqlCommand mainCommand = new SqlCommand(mainQuery, cn);
                mainCommand.Parameters.AddWithValue("@Id", student.Id);
                mainCommand.ExecuteNonQuery();

                string studentQuery = "DELETE FROM Student WHERE holderid = @Id";
                SqlCommand studentCommand = new SqlCommand(studentQuery, cn);
                studentCommand.Parameters.AddWithValue("@Id", student.Id);
                studentCommand.ExecuteNonQuery();
            }
        }
    }
}

