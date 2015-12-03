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
            
            forenameVal.Text = student.read(1).getForename();
            surnameVal.Text = student.read(1).getSurname();
            dobVal.Text = student.read(1).getDOB();
            genderVal.Text = student.read(1).getGender();


        }

        private void forenameLbl_Click(object sender, EventArgs e)
        {

        }

        private void forenameVal_Click(object sender, EventArgs e)
        {

        }

        private void surnameVal_Click(object sender, EventArgs e)
        {

        }

        private void surnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
