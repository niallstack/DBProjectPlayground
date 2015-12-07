using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Home
{
    class StudentImpl : Student
    {
       private int studentID;
       private String forename;
       private String surname;
       private String dob;
       private int schoolID;
       private int groupID;
       private String gender;
       private Byte[] pictureCol;
       private String password;
       private String studentNumber;
       private String status;


        public StudentImpl(int studentID, string forename, string surname, string dob, int schoolID, int groupID, 
                           string gender, Byte[] pictureCol, string password, string studentNumber, string status)
        {
            if(studentID == null)
            {
                throw new ArgumentNullException("Student ID");
            }

            if (forename == null)
            {
                throw new ArgumentNullException("Forename");
            }

            if (schoolID == null)
            {
                throw new ArgumentNullException("schoolID");
            }

            if (password == null)
            {
                throw new ArgumentNullException("Password");
            }

            if (groupID == null)
            {
                throw new ArgumentNullException("groupID");
            }

            if (studentNumber == null)
            {
                throw new ArgumentNullException("Student Number");
            }

            if (dob == null)
            {
                throw new ArgumentNullException("DOB");
            }

            if (status == null)
            {
                throw new ArgumentNullException("Status");
            }

            this.studentID = studentID;
            this.forename = forename;
            this.surname = surname;
            this.dob = dob;
            this.schoolID = schoolID;
            this.groupID = groupID;
            this.gender = gender;
            this.pictureCol = pictureCol;
            this.password = password;
            this.studentNumber = studentNumber;
        }

        public int getStudentID()
        {
            return studentID;
        }

        public string getForename()
        {
            return forename;
        }

        public string getSurname()
        {
            return surname; //Returns the surname of the student
        }

        public string getDOB()
        {
            return dob;
        }

        public int getSchoolID()
        {
            return schoolID;
        }

        public int getGroupID()
        {
            return groupID;
        }

        public string getGender()
        {
            return gender;
        }

        public Byte[] getImage()
        {
            return pictureCol;
        }

        public string getPassword()
        {
            return password;
        }

        public string getStudentNumber()
        {
            return studentNumber;
        }

        public string getStatus()
        {
            return studentNumber;
        }


        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Student ID = ");
            sb.Append(studentID);
            sb.Append("Forename = ");
            sb.Append(forename);
            sb.Append("Surname = ");
            sb.Append(surname);
            sb.Append("DOB = ");
            sb.Append(dob);
            sb.Append("SchoolID = ");
            sb.Append(schoolID);
            sb.Append("GroupID = ");
            sb.Append(groupID);
            sb.Append("Gender = ");
            sb.Append(gender);
            sb.Append("Image = ");
            sb.Append(pictureCol);
            sb.Append("Password = ");
            sb.Append(password);
            sb.Append("Student Number = ");
            sb.Append(studentNumber);
            sb.Append("Student Status = ");
            sb.Append(status);

            return sb.ToString();
        }
    }
}
