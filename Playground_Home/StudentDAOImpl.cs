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
        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            // make sure to add your username and password here
            return "Data Source=studentoracle.students.ittralee.ie:1521/orcl;" +
                   "User ID=?;Password=?";
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

            string connectionString = GetConnectionString();

            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();
                Console.WriteLine("State: {0}", connection.State);

                Console.WriteLine("ConnectionString: {0}",
                                     connection.ConnectionString);

                OracleCommand command = connection.CreateCommand();
                string sql = "SELECT * FROM Students WHERE StudentID =" + studentID + "";
                command.CommandText = sql;

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string myField = (string)reader["student"];
                    Console.WriteLine(myField);
                }
                while (true) { }

                connection.Close();
            }
        }




        public void update(string forename, string surname, string dob, int pictureCol, string password)
        {
            throw new NotImplementedException();

        }
    }
}
