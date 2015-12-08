using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Playground_Home
{
    public partial class Playground_frm : Form
    {
        string studentIDasString;

        static private string GetConnectionString(String username, String password)
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            // make sure to add your username and password here fgfg
            return "Data Source=cp3dbinstance.c4pxnpz4ojk8.us-east-1.rds.amazonaws.com:1521/cp3db;" + "User ID=" + username + ";Password=" + password;
        }

        public Playground_frm()
        {
            InitializeComponent();
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Playground_frm_Load(object sender, EventArgs e)
        {
           
        }


        //Author: Aleksandar Zoric
        public void checkLogin()
        {
            string username = userNameTxt.Text;
            string password = passwordTxt.Text;


            string connectionString = GetConnectionString("sw4", "sw4");
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                OracleCommand command = connection.CreateCommand();
                OracleCommand command1 = connection.CreateCommand();

                

                string usernameCmd = "SELECT studentNumber FROM Students WHERE StudentNumber = '" + username + "'";
                string passwordCmd = "SELECT studentPassword FROM Students WHERE StudentNumber = '" + username + "'";

                command.CommandText = usernameCmd;
                command1.CommandText = passwordCmd;

                OracleDataReader usernameReader = command.ExecuteReader();
                OracleDataReader passwordReader = command1.ExecuteReader();

                if(usernameReader.HasRows && passwordReader.HasRows)
                {
                    OracleCommand command2 = connection.CreateCommand();
                    string studentIDcmd = "SELECT studentID FROM Students WHERE StudentNumber = '" + username + "' AND studentPassword = '" + password + "'";

                    command2.CommandText = studentIDcmd;

                    string extractStudentID = command2.ExecuteScalar().ToString();
                    if(extractStudentID != null)
                    {
                        studentIDasString = extractStudentID;
                        
                    }

                    //open profile form
                }
                else
                {
                    MessageBox.Show("Invalid Login. Try Again");
                }
            }
        }


        public int returnStudentID()
        {
            string studentIDString;

            studentIDString = studentIDasString;

            int studentIDasNum;

            bool isConvertible = false;

            isConvertible = int.TryParse(studentIDString, out studentIDasNum);

            if(isConvertible == false)
            {
                MessageBox.Show("Cannot convert to an Integer");
            }

            return studentIDasNum;
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            if ((userNameTxt.Text == "admin") && (passwordTxt.Text == "test123"))
            {
                RegisterStudentFrm nff = new RegisterStudentFrm();
                this.Hide();
                nff.Show();
            }
            else
            {
                viewProfileFrm nf = new viewProfileFrm();
                this.Hide();
                nf.Show();
                checkLogin();
            }
        }
    }
}
