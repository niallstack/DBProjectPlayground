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
    public partial class SchoolMessageFrm : Form
    {
        StudentImpl stu;
        School school;
        StudentDAOImpl studao = new StudentDAOImpl();
        MessageDAO mesdao = new MessageDAO();
        SchoolDAO schodao = new SchoolDAO();

        public SchoolMessageFrm()
        {
            
            InitializeComponent();

     
            stu = studao.read(4);
            school = schodao.FindOne(stu.getSchoolID());

            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            listView1.Columns.Add("AUTHOR", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("MESSAGE", -2, HorizontalAlignment.Left);
            
            List<Message> list = mesdao.findAllSchool(1);
            ListViewItem item;
            foreach (Message m in list)
            {
                item = new ListViewItem(m.Autor.getForename(), 1);
                item.SubItems.Add(m.MessageDetail);
                listView1.Items.AddRange(new ListViewItem[] { item });

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message message = new Message(-1, stu, richTextBox1.Text);
            schodao.AddSchoolMessage(message, school);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
