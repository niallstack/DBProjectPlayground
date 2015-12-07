using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Home
{
    class School
    {
        private int id;
        private String name;
        private List<Message> messages;

        public School(int id, string name, List<Message> messages)
        {
            this.id = id;
            this.name = name;
            this.messages = messages;
        }

        public String Name 
        {
            get { return name; }
            set { name = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Message> Messages
        {
            get
            {
                return messages;
            }

            set
            {
                messages = value;
            }
        }


    }
}
