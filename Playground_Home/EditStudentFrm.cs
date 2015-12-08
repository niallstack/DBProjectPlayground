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
