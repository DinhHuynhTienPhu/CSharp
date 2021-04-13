using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class Student : Class
    {

        private string _name;
        private string _ID;
        private string _age;
        private string _university_name;
        private string _department_name;
        private string _class_name;

        public string Name { get => _name; set => _name = value; }
        public string ID1 { get => _ID; set => _ID = value; }
        public string Age { get => _age; set => _age = value; }

        public Student()
        {
            Name = string.Empty;
            ID1 = string.Empty;
            Age = string.Empty;
            _university_name = string.Empty;
            _department_name = string.Empty;
            _class_name = string.Empty;
        }
    }
}
