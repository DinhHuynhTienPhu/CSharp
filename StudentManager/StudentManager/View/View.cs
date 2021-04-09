using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Model;

namespace StudentManager.View
{
    class View
    {
        public static void PrintAllStudent( ) {
            foreach (var d in Controller.dataContext.University.Departments)
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
    }
}
