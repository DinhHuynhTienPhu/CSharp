using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using StudentManager.Model;
using StudentManager.Blo;


namespace StudentManager
{
    class Controller
    {
        private static List<University> universities = new List<University>();

        internal static List<University> Universities { get => universities; set => universities = value; }


        public static DataContext dataContext = new DataContext();

        public static void InfoManagerment()
        {
            dataContext = ObjectInOut.Read();
            if (dataContext == null) dataContext = new DataContext();
            Console.WriteLine("\nType to select: \n1: Add student\n2: Update Student \n3: Delete Student\n4: Print All Students\n5: exit");
            string option = Console.ReadLine();
            if (option == "1")
            {
                Blo.BloStudentsManagement.UpdateStudent();

                ObjectInOut.Save(dataContext);
            }
            else if (option == "2")
            {
                UpdateStudent();

            }
            else if (option == "3")
            {
                Console.WriteLine("Please input student's ID you want to delete: ");
                string deleteID = Console.ReadLine();
               Blo.BloStudentsManagement.RemoveStudent(deleteID);
            }

            else if (option == "4") {
                View.View.PrintAllStudent();
            }
            else if (option == "5") return;
            //Auto save here
            ObjectInOut.Save(dataContext);
            Console.Clear();
            InfoManagerment();
        }


        public static void UpdateStudent() {
            Console.WriteLine("Please input student's ID you want to update: ");
            string studentID = Console.ReadLine();
            Student updateStudent = AddNewStudent();
            Console.WriteLine("Updating...");
           Blo.BloStudentsManagement.RemoveStudent(studentID);
            var de = new Department();
            var cls = new Class();

            cls.Students = new List<Student>();
            cls.Students.Add(updateStudent);

            de.Classes = new List<Class>();
            de.Classes.Add(cls);

            dataContext.
                University.
                Departments.Add(de);
            Console.WriteLine("Done!");
        }
        public static Student AddNewStudent() {

            Student student = new Student();


                student.Name = InfoInput("Ten");
                student.Age = InfoInput("Tuoi");
                student.ID1 = InfoInput("Id");

                return student;
            
       }
        private static string InfoInput(string field)
        {
            Console.WriteLine("Xin nhap " + field);
            return Console.ReadLine();
        }

        

    }
}
