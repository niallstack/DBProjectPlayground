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
    public partial class viewProfileFrm : Form
    {
        public viewProfileFrm()
        {
            InitializeComponent();
        }

        int loggedStudentID;
        private void viewProfileFrm_Load(object sender, EventArgs e)

        {
            StudentDAOImpl student = new StudentDAOImpl();

            Playground_frm loginForm = new Playground_frm();
           


            
            loggedStudentID = loginForm.returnID();
            MessageBox.Show(loggedStudentID.ToString() + " view");

            forenameVal.Text = student.read(34).getForename();
            surnameVal.Text = student.read(34).getSurname();
            dobVal.Text = student.read(34).getDOB();
            genderVal.Text = student.read(34).getGender();
            studentNumVal.Text = student.read(34).getStudentNumber();

        }

    }
}
