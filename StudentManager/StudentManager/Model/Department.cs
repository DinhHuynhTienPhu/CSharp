using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class Department:University
    {
        private string _name;


        private List<Class> _classes = new List<Class>();

        public string Name { get => _name; set => _name = value; }
        internal List<Class> Classes { get => _classes; set => _classes = value; }
    }
}
