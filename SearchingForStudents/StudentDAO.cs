using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace SearchingForStudents
{
    internal class StudentDAO
    {
        public void connectToDatabase()
        {
            
        }

        public void create(Student student)
        {
            String str = "Server=localhost\\SQLEXPRESS2019;Integrated Security=True;Database=StudentsDatabase";

            SqlConnection con = new SqlConnection(str);

            String query = $"INSERT INTO StudentsData (Name, Surname, Class) VALUES ('{student.Name}', '{student.Surname}', '{student.Class}')";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dbr;
            try
            {
                con.Open();
                MessageBox.Show("connected with sql server");
                dbr = cmd.ExecuteReader();
                MessageBox.Show("saved");
                while (dbr.Read())
                {
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public List<Student> select(string column, string condition)
        {
            List<Student> students = new List<Student>();

            String str = "Server=localhost\\SQLEXPRESS2019;Integrated Security=True;Database=StudentsDatabase";

            SqlConnection con = new SqlConnection(str);

            String query = $"SELECT * FROM StudentsData WHERE {column} LIKE {condition}";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    string sID = dbr["Id"].ToString();
                    string sname = (string)dbr["Name"]; // name is string value
                    string ssurname = (string)dbr["Surname"];
                    string sclass = dbr["Class"].ToString();
                    students.Append<Student>(new Student
                    {
                        Name = sname,
                        Surname = ssurname,
                        Class = sclass
                    });
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }


            return students;
        }
    }
}
