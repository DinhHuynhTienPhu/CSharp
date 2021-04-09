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

        private string name;
        private string ID;
        private string age;
        private string university_name;
        private string department_name;
        private string class_name;

        public string Name { get => name; set => name = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string Age { get => age; set => age = value; }
        public string University { get => university_name; set => university_name = value; }
        public string Department { get => department_name; set => department_name = value; }
        public string Class_name { get => class_name; set => class_name = value; }

        public Student(string _name, string _ID, float _score)
        {
            Name = _name;
            ID1 = _ID;
            Age = age;
        }
        public Student()
        {
            Name = "default name";
            ID1 = "defaultID";
            Age = "0";
            university_name = "";
            department_name = "";
            class_name = "";
        }
    }
}
