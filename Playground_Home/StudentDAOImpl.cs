using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Home
{
    class StudentDAOImpl : StudentDAO
    {
        static private string GetConnectionString(String username, String password)
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            // make sure to add your username and password here fgfg
            return "Data Source=cp3dbinstance.c4pxnpz4ojk8.us-east-1.rds.amazonaws.com;" + "User ID=" + username + ";Password=" + password;
        }

        public StudentImpl create(int studentID, string forename, string surname, string dob, int schoolID, 
                                  int groupID, string gender, int pictureCol, string password, string studentNumber)
        {
            throw new NotImplementedException();
        }



        public void delete(int studentID)
        {
            throw new NotImplementedException();
        }




        public StudentImpl read(int studentID)
        {
            throw new NotImplementedException();

            

            if(studentID == null)
            {
                throw new ArgumentNullException("Student ID");
            }

            string connectionString = GetConnectionString("sw4","sw4");

            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                OracleCommand command = connection.CreateCommand();

                string sql = "SELECT * FROM Students WHERE StudentID = ?";

                command.CommandText = sql;

                OracleParameter para = new OracleParameter("?", OracleType.Int32);
                para.Value = studentID;

                command.Parameters.Add(para);
                command.Prepare();
                command.ExecuteNonQuery();
              
                connection.Close();
            }
        }




        public void update(string forename, string surname, string dob, int pictureCol, string password)
        {
            throw new NotImplementedException();

        }
    }
}
