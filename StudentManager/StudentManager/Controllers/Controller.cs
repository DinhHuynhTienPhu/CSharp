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
                Student student = AddNewStudent();
                var de = new Department();
                var cls = new Class();

                cls.Students = new List<Student>();
                cls.Students.Add(student);

                de.Classes = new List<Class>();

                de.Classes.Add(cls);

                dataContext.
                    University.
                    Departments.Add(de);

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
                RemoveStudent(deleteID);
                Console.WriteLine("Deleted");
            }

            else if (option == "4") {
                foreach (var d in dataContext.University.Departments)
                {
                    foreach (var c in d.Classes)
                    {
                        foreach (var s in c.Students)
                        {
                            Console.WriteLine("Name: "+s.Name + "\t\tID:  "+s.ID1+"\t\tAge: "+s.Age);
                        }
                    }
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
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
            RemoveStudent(studentID);
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


        //public static Student Add(string _universityname, string _departmentname, string _classname,Student student) {
        //    find the university
        //    University university = Universities.Find(x => x.Name == _universityname);
        //    if (university == null) {
        //        university = new University();
        //        university.Name = _universityname;
        //        Universities.Add(university);
        //    }
        //    university = Universities.Find(x => x.Name == _universityname);
        //    find the department
        //    Department department = university.Departments.Find(x => x.Name == _departmentname);
        //    if (department == null) {
        //        department = new Department();
        //        department.Name = _departmentname;
        //        university.Departments.Add(department);
        //    }
        //    department = university.Departments.Find(x => x.Name == _departmentname);
        //    find the class
        //    Class theclass = department.Classes.Find(x => x.Name == _classname);
        //    if (theclass == null) {
        //        theclass = new Class();
        //        theclass.Name = _classname;
        //        department.Classes.Add(theclass);

        //    }
        //    theclass = department.Classes.Find(x => x.Name == _classname);
        //    theclass.Students.Add(student);
        //    return student;
        //}

        public static void RemoveStudent(String id)
        {

                foreach (Department department in dataContext.University.Departments)
                {
                    foreach (Class @class in department.Classes)
                    {
                        @class.Students.RemoveAll(x=>x.ID1==id);
                    }
                }
            
        }
        //public static void UpdateStudent( Student old_student) {
        //    foreach (University university in Universities)
        //    {
        //        foreach (Department department in university.Departments)
        //        {
        //            foreach (Class @class in department.Classes)
        //            {
        //                /*if(*/
        //                @class.Students.Remove(old_student);//)Console.WriteLine("removed "+old_student.Name) ;
        //            }
        //        }
        //    }
        //   old_student=Controller.Add(old_student.University, old_student.Department, old_student.Class_name, old_student);
        //   CleanEmpty();
        //}
        //public static void CleanEmpty() {
        //    foreach (University university in Universities)
        //    {
        //        foreach (Department department in university.Departments)
        //        {
        //            department.Classes.RemoveAll(x => x.Students.Count() == 0);
        //            foreach (Class @class in department.Classes) Console.WriteLine(@class.Name + " count: " + @class.Students.Count());
        //        }
        //    }
        //    foreach (University university in Universities)
        //    {
        //        foreach (Department department in university.Departments)
        //        {
        //            department.Classes.RemoveAll(x => x.Students.Count() == 0);
        //        }
        //    }

        //    foreach (University university in Universities)
        //    {
        //        university.Departments.RemoveAll(x => x.Classes.Count() == 0);
        //    }
        //    Universities.RemoveAll(x => x.Departments.Count() == 0);
        //}

        //public static void Saver() {
        //    StreamWriter sw = new StreamWriter("StudentsList.txt");

        //    foreach (University university in Universities)
        //    {
        //        foreach (Department department in university.Departments)
        //        {
        //            foreach (Class @class in department.Classes)
        //            {
        //                foreach (Student student in @class.Students)
        //                {
        //                    sw.WriteLine(student.Name + "\n" + student.ID1 + "\n" + student.Age+(student.Age == Math.Floor(student.Age) ?".0":"")+"\n"+student.University+"\n"+student.Department+"\n"+student.Class_name);
        //                }
        //            }
        //        }
        //    }
        //    sw.Close();

        //}

        //public static void Loader() {
        //    String line;
        //    StreamReader sr = new StreamReader("StudentsList.txt");
        //    line = sr.ReadLine();
        //    while (line != null)
        //    {
        //        Student student = new Student();
        //        student.Name= sr.ReadLine();
        //        student.ID1 = sr.ReadLine();
        //        student.Age = float.Parse(sr.ReadLine());
        //        student.University = sr.ReadLine();
        //        student.Department = sr.ReadLine();
        //        student.Class_name = sr.ReadLine();
        //        Add(student.University, student.Department, student.Class_name, student);
        //    }
        //    sr.Close();
        //    Console.ReadLine();
        //}

    }
}
