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
            return "Data Source=cp3dbinstance.c4pxnpz4ojk8.us-east-1.rds.amazonaws.com:1521/cp3db;" + "User ID=" + username + ";Password=" + password;
        }

        public StudentImpl create(int studentID, string forename, string surname, string dob, int schoolID, int groupID,
                           string gender, Byte[] pictureCol, string password, string studentNumber, string status)
        {
            //throw new NotImplementedException();
            try
            {


                if (studentID == null)
                {
                    throw new ArgumentNullException("Student ID");
                }


                string connectionString = GetConnectionString("sw4", "sw4");
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;

                    connection.Open();

                    OracleCommand command = connection.CreateCommand();

                    string sql = "INSERT INTO Students (studentID, forename, surname, dob, schoolID, groupID, gender, pictureCol, password, studentNumber, status) VALUES (" + studentID + ",'" + forename +
                "','" + surname + "','" + dob + "'," + schoolID + "," + groupID + ",'" + gender + "'," + pictureCol + ",'" + password + "'," + studentNumber + ",'" + status + "')";

                    command.CommandText = sql;

                    command.ExecuteNonQuery();
                    StudentImpl student = new StudentImpl(studentID, forename, surname, dob, schoolID, groupID, gender, pictureCol, password, studentNumber, status);

                }
            }
            catch (NotImplementedException e)
            {

            }

        }



        public void delete(int studentID)
        {
            throw new NotImplementedException();
        }



        //Author: Aleksandar Zoric
        public StudentImpl read(int studentID)
        {

           
            try {
                StudentImpl student;

                if (studentID == null)
                {
                    throw new ArgumentNullException("Student ID");
                }
                

                string connectionString = GetConnectionString("sw4", "sw4");
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;

                    connection.Open();

                    OracleCommand command = connection.CreateCommand();

                    string sql = "SELECT * FROM Students WHERE StudentID = " + studentID;

                    command.CommandText = sql;

                    OracleDataReader reader;
                    reader = command.ExecuteReader();

                    reader.Read();

                    Int32 studentid = Convert.ToInt32(reader["studentID"]);
                    String forename = (string)reader["forename"];
                    String surname = (string)reader["surname"];
                    String dob = (string)reader["dob"].ToString();
                    Int32 schoolD = Convert.ToInt32(reader["schoolID"]);
                    Int32 classID = Convert.ToInt32(reader["classID"]);
                    String gender = (string)reader["gender"];
                    Byte[] image = null;
                    if (!Convert.IsDBNull(reader["image"]))
                    {
                        image = (Byte[])reader["image"];
                    }
                    String studentPassword = (string)reader["studentpassword"];
                    String studentnumber = (string)reader["studentnumber"].ToString();
                    String status = (string)reader["status"].ToString();

                     student = new StudentImpl(studentid, forename, surname, dob, schoolD, classID, gender, image,studentPassword, studentnumber, status);

                    command.ExecuteNonQuery();

                    connection.Close();
                    return student;

                }
               

            }
            catch(NotImplementedException e)
            {
                return null;
            }
          

        }




        public void update(string forename, string surname, string dob, int pictureCol, string password)
        {
            throw new NotImplementedException();

        }
    }
}
