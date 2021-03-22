using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Class
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private List<Student> students = new List<Student>();
        internal List<Student> Students { get => students; set => students = value; }

    }
}
