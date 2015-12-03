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
    public partial class viewProfileFrm : Form
    {
        public viewProfileFrm()
        {
            InitializeComponent();
        }

        private void viewProfileFrm_Load(object sender, EventArgs e)

        {
            StudentDAOImpl student = new StudentDAOImpl();

            Playground_frm loginForm = new Playground_frm();

            int loggedStudentID;
            loggedStudentID = loginForm.returnStudentID();

            forenameVal.Text = student.read(loggedStudentID).getForename();
            surnameVal.Text = student.read(loggedStudentID).getSurname();
            dobVal.Text = student.read(loggedStudentID).getDOB();
            genderVal.Text = student.read(loggedStudentID).getGender();
            studentNumVal.Text = student.read(loggedStudentID).getStudentNumber();

        }



    }
}
