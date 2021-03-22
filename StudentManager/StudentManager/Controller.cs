using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Controller
    {
        private static List<University> universities = new List<University>();

        internal static List<University> Universities { get => universities; set => universities = value; }

        public static Student Add(string _universityname, string _departmentname, string _classname,Student student) {
            //find the university
            University university = Universities.Find(x => x.Name == _universityname);
            if (university == null) {
                university = new University();
                university.Name = _universityname;
                Universities.Add(university);
            }
            university = Universities.Find(x => x.Name == _universityname);
            //find the department
            Department department = university.Departments.Find(x => x.Name == _departmentname);
            if (department == null) {
                department = new Department();
                department.Name = _departmentname;
                university.Departments.Add(department);
            }
            department = university.Departments.Find(x => x.Name == _departmentname);
            //find the class
            Class theclass = department.Classes.Find(x => x.Name == _classname);
            if (theclass == null) {
                theclass = new Class();
                theclass.Name = _classname;
                department.Classes.Add(theclass);

            }
            theclass = department.Classes.Find(x => x.Name == _classname);
            theclass.Students.Add(student);
            return student;
        }

        public static void RemoveStudent(Student _student)
        {
            string _universityname, _departmentname, _classname;

            foreach (University university in Universities)
            {
                _universityname = university.Name;
                foreach (Department department in university.Departments)
                {
                    _departmentname = department.Name;
                    foreach (Class @class in department.Classes)
                    {
                        _classname = @class.Name;
                        @class.Students.Remove(_student);
                    }
                }
            }
        }
        public static void UpdateStudent( Student old_student) {
            foreach (University university in Universities)
            {
                foreach (Department department in university.Departments)
                {
                    foreach (Class @class in department.Classes)
                    {
                        /*if(*/
                        @class.Students.Remove(old_student);//)Console.WriteLine("removed "+old_student.Name) ;
                    }
                }
            }
           old_student=Controller.Add(old_student.University, old_student.Department, old_student.Class_name, old_student);
           CleanEmpty();
        }
        public static void CleanEmpty() {
            foreach (University university in Universities)
            {
                foreach (Department department in university.Departments)
                {
                    department.Classes.RemoveAll(x => x.Students.Count() == 0);
                   // foreach (Class @class in department.Classes) Console.WriteLine(@class.Name + " count: " + @class.Students.Count());
                }
            }
            foreach (University university in Universities)
            {
                foreach (Department department in university.Departments)
                {
                    department.Classes.RemoveAll(x => x.Students.Count() == 0);
                }
            }

            foreach (University university in Universities)
            {
                university.Departments.RemoveAll(x => x.Classes.Count() == 0);
            }
            Universities.RemoveAll(x => x.Departments.Count() == 0);
        }
        public static void PrintAll() {
            foreach (University university in Universities) {
                Console.WriteLine(university.Name);
                foreach (Department department in university.Departments) {
                    Console.WriteLine("  "+department.Name);
                    foreach (Class @class in department.Classes) {
                        Console.WriteLine("    "+@class.Name);
                        foreach (Student student in @class.Students) {
                            Console.WriteLine("      #"+student.Name+" "+student.ID1+" "+student.Score);
                        }
                    }
                }
            }
        }
    }
}
