using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    
    class Student
    {
        
        private string name;
        private string ID;
        private float score;
        private string university_name;
        private string department_name;
        private string class_name;

        public string Name { get => name; set => name = value; }
        public string ID1 { get => ID; set => ID = value; }
        public float Score { get => score; set => score = value; }
        public string University { get => university_name; set => university_name = value; }
        public string Department { get => department_name; set => department_name = value; }
        public string Class_name { get => class_name; set => class_name = value; }

        public Student(string _name,string _ID,float _score) {
            Name = _name;
            ID1 = _ID;
            Score = _score;
        }
       public Student() {
            Name = "default name";
            ID1 = "defaultID";
            Score = 0;
            university_name = "";
            department_name = "";
            class_name = "";
       }
       public void Add(string _university,string _department,string _class) {
            university_name = _university;
            department_name = _department;
            class_name = _class;
            Controller.Add(_university, _department, _class,this);
       }
        public void Remove() {
            Controller.RemoveStudent(this);
        }
        public void Update(string _university="old", string _department="old", string _class="old",string _name="old",string _ID="old",float _score=-1) {
            if (_name != "old") name = _name;
            if (_ID != "old") ID = _ID;
            if (_score != -1) score = _score;
            if (_university != "old") university_name = _university;
            if (_department != "old") department_name = _department;
            if (_class != "old") Class_name = _class;
            if (_university != "old" || _department != "old" || _class != "old") {
                Controller.UpdateStudent(this);
            }
        }
    }
}
