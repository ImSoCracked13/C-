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

namespace DesktopInformationSystemProgram
{
    public class Holder
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string role { get; set; }
    }


    public class Teacher : Holder
    {
        public string salary { get; set; }
        public string subject1 { get; set; }
        public string subject2 { get; set; }
    }


    public class Admin : Holder
    {
        public string salary { get; set; }
        public string fulltime { get; set; }
        public string workinghours { get; set; }
    }

    public class Student : Holder
    {
        public string subject1 { get; set; }
        public string subject2 { get; set; }
        public string prevsub1 { get; set; }
        public string prevsub2 { get; set; }
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

                mainCommand.Parameters.AddWithValue("@name", student.name);
                mainCommand.Parameters.AddWithValue("@phone", student.phone);
                mainCommand.Parameters.AddWithValue("@email", student.email);

                int holderid = Convert.ToInt32(mainCommand.ExecuteScalar());

                string studentQuery = "INSERT INTO Student (subject1, subject2, prevsub1, prevsub2, holderid) VALUES (@subject1, @subject2, @prevsub1, @prevsub2, @holderid)";
                SqlCommand studentCommand = new SqlCommand(studentQuery, cn);

                studentCommand.Parameters.AddWithValue("@subject1", student.subject1);
                studentCommand.Parameters.AddWithValue("@subject2", student.subject2);
                studentCommand.Parameters.AddWithValue("@prevsub1", student.prevsub1);
                studentCommand.Parameters.AddWithValue("@prevsub2", student.prevsub2);
                studentCommand.Parameters.AddWithValue("@HolderId", holderid);

                studentCommand.ExecuteNonQuery();
            }
        }


        public void EditStudent(Student student)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string mainQuery = "UPDATE Holder SET name = @name, phone = @phone, email = @email WHERE Id = @Id";
                SqlCommand mainCommand = new SqlCommand(mainQuery, cn);
                mainCommand.Parameters.AddWithValue("@Id", student.Id);
                mainCommand.Parameters.AddWithValue("@name", student.name);
                mainCommand.Parameters.AddWithValue("@phone", student.phone);
                mainCommand.Parameters.AddWithValue("@email", student.email);
                mainCommand.ExecuteNonQuery();

                string studentQuery = "UPDATE Student SET subject1 = @subject1, subject2 = @subject2, prevsub1 = @prevsub1, prevsub2 = @prevsub2 WHERE holderid = @Id";
                SqlCommand studentCommand = new SqlCommand(studentQuery, cn);
                studentCommand.Parameters.AddWithValue("@Id", student.Id);
                studentCommand.Parameters.AddWithValue("@subject1", student.subject1);
                studentCommand.Parameters.AddWithValue("@subject2", student.subject2);
                studentCommand.Parameters.AddWithValue("@prevsub1", student.prevsub1);
                studentCommand.Parameters.AddWithValue("@prevsub2", student.prevsub2);
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

