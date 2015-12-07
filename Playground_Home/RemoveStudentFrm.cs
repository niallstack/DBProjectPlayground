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
    public partial class RemoveStudentFrm : Form
    {
        public RemoveStudentFrm()
        {
            InitializeComponent();
        }

        private void RemoveStudentFrm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regStuLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterStudentFrm nf = new RegisterStudentFrm();
            this.Close();
            nf.Show();
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Playground_frm nf = new Playground_frm();
            this.Close();
            nf.Show();
        }

        private void studGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sortLbl_Click(object sender, EventArgs e)
        {

        }

        private void studIDBtn_Click(object sender, EventArgs e)
        {

        }

        private void surnameBtn_Click(object sender, EventArgs e)
        {

        }

        private void grpBtn_Click(object sender, EventArgs e)
        {

        }

        private void studnumBtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Author: Sean Gibbs 
        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to Remove this Student?", "Warning",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                remStudent();
            }
            else if (confirm == DialogResult.No)
            {
                
            }
            else if (confirm == DialogResult.Cancel)
            {
                
            }
        }
        private void remStudent()
        {
            string studentIDAsString = studIDTxt.Text;

            int studentIDAsInt;
            Boolean isConvertable = false;
            isConvertable = Int32.TryParse(studentIDAsString, out studentIDAsInt);
            if (isConvertable == false)
            {
                MessageBox.Show("Field/s entered incorrectly ");
            }
            StudentDAOImpl student = new StudentDAOImpl();
            student.delete(studentIDAsInt);
            MessageBox.Show("This Student has been removed");
        }
    }
}
