using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Playground_Home
{
    public partial class EditStudentFrm : Form
    {
        public EditStudentFrm()
        {
            InitializeComponent();
        }

        private void editStuLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditStudentFrm nf = new EditStudentFrm();
            this.Close();
            nf.Show();
        }

        private void delStuLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemoveStudentFrm nf = new RemoveStudentFrm();
            this.Close();
            nf.Show();
        }

        private void regStuLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterStudentFrm nf = new RegisterStudentFrm();
            this.Close();
            nf.Show();
        }

        private void EditStudentFrm_Load(object sender, EventArgs e)
        {
            //Author: Niall Stack - t00174406 
            string CloudDB = "Data Source=cp3dbinstance.c4pxnpz4ojk8.us-east-1.rds.amazonaws.com:1521/cp3db;User Id=sw4;Password=sw4;";
            try
            {
                OracleConnection conn = new OracleConnection(CloudDB);

                OracleCommand cmd = new OracleCommand("SELECT * FROM Students", conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                studGrd.DataSource = ds.Tables["ss"];

                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Playground_frm nf = new Playground_frm();
            this.Close();
            nf.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewProfileFrm nf = new viewProfileFrm();
            this.Close();
            nf.Show();
        }

        private void schoolWallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolMessageFrm nf = new SchoolMessageFrm();
            this.Close();
            nf.Show();
        }

        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrivateMessageFrm nf = new PrivateMessageFrm();
            this.Close();
            nf.Show();
        }
    }
}
