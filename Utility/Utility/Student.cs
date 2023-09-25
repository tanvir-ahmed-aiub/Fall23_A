using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    class Student
    {
        public int id;
        string name;
        const string ins = "AIUB";
        public float Cgpa { get; }
        readonly public int studentSl;
      
        public string Name { 
            set { name = value; }
            get { return name; }
        }
        internal Student() {
            Cgpa = 3.5f;
            studentSl = 45;
        }
        

    }
}
