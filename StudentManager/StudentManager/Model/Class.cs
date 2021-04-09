using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class Class:Department
    {
        private string name;
        public string Name { get => name; set => name = value; }
        internal List<Student> Students { get; set; } = new List<Student>();

    }
}
