using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Model;

namespace StudentManager.Blo
{
    class BloStudentsManagement
    {

        public static void UpdateStudent() {

            Student student =Controller.AddNewStudent();
            var de = new Department();
            var cls = new Class();

            cls.Students = new List<Student>();
            cls.Students.Add(student);

            de.Classes = new List<Class>();

            de.Classes.Add(cls);

           Controller.dataContext.
                University.
                Departments.Add(de);
        }


        public static void RemoveStudent(String id)
        {

            foreach (Department department in Controller.dataContext.University.Departments)
            {
                foreach (Class @class in department.Classes)
                {
                    @class.Students.RemoveAll(x => x.ID1 == id);
                }
            }
            Console.WriteLine("Deleted");
            Console.ReadKey();
        }
    }
}
