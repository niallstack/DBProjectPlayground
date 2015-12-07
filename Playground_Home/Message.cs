using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Home
{
    class Message
    {
        private String messageDetail;
        private Student autor;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String MessageDetail
        {
            get { return messageDetail; }
            set { messageDetail = value; }
        }

        public Student Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public Message(int id, Student student, String messageDetail)
        {
            MessageDetail = messageDetail;
            Autor = student;
            Id = id;
        }


    }
}
