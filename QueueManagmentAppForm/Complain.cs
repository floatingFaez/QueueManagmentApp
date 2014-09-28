using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueManagmentAppForm
{
    class Complain
    {
        private string serial;
        private string name;
        private string complain;

        public string Serial 
        {
            get { return serial; } 
            set { serial = value; } 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string NewComplain
        {
            get { return complain; }
            set { complain = value; }
        }
    }
}
