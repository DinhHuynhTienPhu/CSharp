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


        public  DataContext dataContext = new DataContext();

        public void InfoManagerment()
        {
            dataContext = ObjectInOut.Read();
            if (dataContext == null) dataContext = new DataContext();
            Console.WriteLine("\nType to select: \n1: Add student\n2: Update Student \n3: Delete Student\n4: Print All Students\n5: exit");
            string option = Console.ReadLine();
            if (option == "1")
            {
               dataContext.University= Blo.BloStudentsManagement.AddNewStudent(dataContext.University );
                ObjectInOut.Save(dataContext);
            }
            else if (option == "2")
            {
                Console.WriteLine("Please input student's ID you want to update: ");
                string studentID = Console.ReadLine();
             dataContext.University=  BloStudentsManagement.UpdateStudent(studentID,dataContext.University);

            }
            else if (option == "3")
            {
                Console.WriteLine("Please input student's ID you want to delete: ");
                string deleteID = Console.ReadLine();
             dataContext.University=  Blo.BloStudentsManagement.RemoveStudent(deleteID,dataContext.University);
            }

            else if (option == "4") {
                View.ViewManagement.PrintAllStudent(dataContext.University);
            }
            else if (option == "5") return;
            //Auto save here
            ObjectInOut.Save(dataContext);
            Console.Clear();
            InfoManagerment();
        }





        

    }
}
