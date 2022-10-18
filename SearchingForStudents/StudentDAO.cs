using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchingForStudents
{
    internal class StudentDAO
    {
        public List<Student> Students;

        public void connectToDatabase()
        {
            try

            {

                String str = "Server=localhost\\SQLEXPRESS2019;Integrated Security=True;Database=StudentsDatabase";

                String query = "select * from Students";

                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                DataSet ds = new DataSet();

                MessageBox.Show("connected with sql server");

                con.Close();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }
        }
    }
}
