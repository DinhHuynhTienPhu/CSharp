using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Model;
using StudentManager.View;

namespace StudentManager.Blo
{
    class BloStudentsManagement
    {

        public static University AddNewStudent(University university)
        {

            Student student = CreateNewStudent();

            

            var de = new Department();
            var cls = new Class();

            cls.Students = new List<Student>();
            cls.Students.Add(student);

            de.Classes = new List<Class>();

            de.Classes.Add(cls);


                 university.
                 Departments.Add(de);
            return university;
        }


        public static University RemoveStudent(String id,University university)
        {

            foreach (Department department in university.Departments)
            {
                foreach (Class cclass in department.Classes)
                {
                    cclass.Students.RemoveAll(x => x.ID1 == id);
                }
            }
            return university;
        }
        public static University UpdateStudent(string studentID,University university)
        {
            Student updateStudent = CreateNewStudent();
           university= RemoveStudent(studentID,university);
            var de = new Department();
            var cls = new Class();

            cls.Students = new List<Student>();
            cls.Students.Add(updateStudent);

            de.Classes = new List<Class>();
            de.Classes.Add(cls);

                university.
                Departments.Add(de);
            return university;
        }

        public static Student CreateNewStudent()
        {

            Student student = new Student();


            student.Name = ViewManagement.InfoInput("Ten");
            student.Age = ViewManagement.InfoInput("Tuoi");
            student.ID1 = ViewManagement.InfoInput("Id");

            return student;

        }
    }
}
