using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground_Home
{
    public partial class RegisterStudentFrm : Form
    {
        public RegisterStudentFrm()
        {
            InitializeComponent();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void delStuLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemoveStudentFrm nf = new RemoveStudentFrm();
            this.Close();
            nf.Show();
        }

        private void editStuLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditStudentFrm nf = new EditStudentFrm();
            this.Close();
            nf.Show();
        }

        private void regStuLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterStudentFrm nf = new RegisterStudentFrm();
            this.Close();
            nf.Show();
        }

        private void RegisterStudentFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            returnStudentValues();
        }
        //Author: Niall Stack
        private void returnStudentValues()
        {
            string studentIDAsString = studIDTxt.Text;
            string forename = forenameTxt.Text;
            string surname = surnameTxt.Text;
            string dob = dobTxt.Text;
            string schoolIDAsString = SchoolIDTxt.Text;
            string groupIDAsString = groupIDTxt.Text;
            string gender = genderTxt.Text;
            string pictureColAsString = imgTxt.Text;
            string password = passwordTxt.Text;
            string studentNumber = studNumTxt.Text;
            string status = statusTxt.Text;

            int studentIDAsInt;
            int schoolIDAsInt;
            int groupIDAsInt;
            Byte[] pictureAsByte;
            Boolean isConvertable = false;
            isConvertable = Int32.TryParse(studentIDAsString, out studentIDAsInt);
            isConvertable = Int32.TryParse(schoolIDAsString, out schoolIDAsInt);
            isConvertable = Int32.TryParse(groupIDAsString, out groupIDAsInt);
            pictureAsByte = System.Text.Encoding.UTF8.GetBytes(pictureColAsString);
            if (isConvertable == false)
            {
                MessageBox.Show("Field/s entered incorrectly ");
            }
            

            StudentDAOImpl student = new StudentDAOImpl();
            student.create(studentIDAsInt, forename, surname, dob, schoolIDAsInt, groupIDAsInt, gender, pictureAsByte, password, studentNumber, status);

            
        }

        
    }
}
