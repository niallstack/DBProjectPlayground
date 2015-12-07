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

        private OracleConnection connection=null;

        public OracleConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

     
        public MessageDAO(String username, String password)
        {
            Connection = new OracleConnection("Data Source=cp3dbinstance.c4pxnpz4ojk8.us-east-1.rds.amazonaws.com:1521/cp3db;" + "User ID=sw4 ;Password=sw4");
            Connection.Open();
        }
      




        public Boolean InsertMessage(Message message)
        {
            OracleCommand command = Connection.CreateCommand();
            OracleCommand co = new OracleCommand("Select * from truc", Connection);

            return true;
        }
    }
}
