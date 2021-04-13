using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Model;

namespace StudentManager.View
{
    class ViewManagement
    {
        public static void PrintAllStudent(University university ) {
            foreach (var d in university.Departments)
            {
                foreach (var c in d.Classes)
                {
                    foreach (var s in c.Students)
                    {
                        Console.WriteLine("Name: " + s.Name + "\t\tID:  " + s.ID1 + "\t\tAge: " + s.Age);
                    }
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static string InfoInput(string field)
        {
            Console.WriteLine("Xin nhap " + field);
            return Console.ReadLine();
        }
    }


}
