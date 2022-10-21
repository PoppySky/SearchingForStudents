using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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

        public List<Student> select()
        {
            List<Student> students = new List<Student>();




            return students;
        }
    }
}
