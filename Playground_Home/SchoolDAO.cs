using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Home
{
    class SchoolDAO
    {

        private OracleConnection connection = null;

        public OracleConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }


        public SchoolDAO(String username, String password)
        {
            Connection = new OracleConnection("Data Source=cp3dbinstance.c4pxnpz4ojk8.us-east-1.rds.amazonaws.com:1521/cp3db;" + "User ID=sw4 ;Password=sw4");
            Connection.Open();
        }

        public School FindOne(int id)
        {
            OracleCommand command = Connection.CreateCommand();
            OracleCommand co = new OracleCommand("Select * from Message where School.id=" + id + ")", Connection);

            OracleDataReader reader;
            reader = command.ExecuteReader();

            reader.Read();
            StudentDAOImpl studentDao = new StudentDAOImpl();

            List<Message> list = new List();

            School school = new School((int)reader.GetOracleNumber(0), reader.GetString(1), list);

            return school;
        }

        

    }
}
