﻿using System;
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
            MessageBox.Show("Student Has Been Added To The System");
           

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
            string pictureColAsString = imgTxt.Text.Trim();
            string studentpassword = passwordTxt.Text;
            string studentNumber = studNumTxt.Text.Trim();
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
            student.create(studentIDAsInt, forename, surname, dob, schoolIDAsInt, groupIDAsInt, gender, pictureAsByte, studentpassword, studentNumber, status);

            
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
