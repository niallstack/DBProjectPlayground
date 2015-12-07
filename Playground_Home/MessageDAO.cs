using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Home
{
    class MessageDAO
    {
        private StudentDAOImpl studentDao;
        private OracleConnection connec;

     
        public MessageDAO()
        {
            studentDao = new StudentDAOImpl();
            connec = new OracleConnection("Data Source=cp3dbinstance.c4pxnpz4ojk8.us-east-1.rds.amazonaws.com:1521/cp3db;" + "User ID=sw4 ;Password=sw4");
        }

        static private string GetConnectionStringA(string username, String password)
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            // make sure to add your username and password here fgfg
            return "Data Source=cp3dbinstance.c4pxnpz4ojk8.us-east-1.rds.amazonaws.com:1521/cp3db;" + "User ID=" + username + ";Password=" + password;
        }

        public Boolean InsertMessage(Message message)
        {
            string connectionString = GetConnectionStringA("sw4", "sw4");
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                OracleCommand command = new OracleCommand("Insert into Message values(message_seq.nextval," + message.Autor.getStudentID() + "," + message.MessageDetail + ")", connection);

                connection.Close();

                return command.ExecuteNonQuery() > 0;
            }

        }
        
        public Message FindOne(int id)
        {

            connec.Open();
            OracleCommand command = new OracleCommand("Select * from Message where Message.id="+ id+")", connec);
            
            OracleDataReader reader;
            reader = command.ExecuteReader();

            reader.Read();
           

            Student stu = studentDao.read((int)reader.GetOracleNumber(1));

            return new Message((int)reader.GetOracleNumber(0),stu, reader.GetString(2));
        }
        
        public List<Message> findAllSchool(int id)
        {
            string connectionString = GetConnectionStringA("sw4", "sw4");
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;

               
                OracleCommand command = new OracleCommand("Select * from MESSAGE where Message.messageid = (select MESSAGEID from SCHOOLMESSAGE where SCHOOLMESSAGE.SCHOOLID = " + id + ")", connection);
                OracleDataReader reader;
                reader = command.ExecuteReader();
                Student stu;
                List<Message> list = new List<Message>();
                while (reader.Read())
                {
                    stu = studentDao.read((int)reader.GetOracleNumber(1));
                    list.Add(new Message((int)reader.GetOracleNumber(0), stu, reader.GetString(2)));

                }
                connection.Close();
                return list;

            }
        }

    
        
    }
}
