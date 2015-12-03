using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Home
{
    interface StudentDAO
    {
        StudentImpl create(int studentID, string forename, string surname, string dob, int schoolID, int groupID,
                           string gender, Byte[] pictureCol, string password, string studentNumber,string status);

        void delete(int studentID);

        StudentImpl read(int studentID);

        void update(string forename, string surname, string dob, int pictureCol, string password);


    }
}
