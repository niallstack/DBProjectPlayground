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
    public partial class Playground_frm : Form
    {
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            /* if ((userNameTxt.Text == "admin") && (passwordTxt.Text == "test123"))
             {
                 RegisterStudentFrm nf = new RegisterStudentFrm();
                 this.Close();
                 nf.Show();
             }
             else
                 this.Close();*/
            RegisterStudentFrm nf = new RegisterStudentFrm();
            this.Hide();
            nf.Show();
        }
    }
}
