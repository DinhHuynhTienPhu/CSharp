

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Model;
namespace StudentManager.Blo
{
    class ObjectInOut
    {
        private const string DATA_FILE = "StudentManager.SM";
        public static int Save(DataContext dataContext)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(DATA_FILE, FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, dataContext);
                stream.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                return -1;
            }
            return 1;
        }

        public static DataContext Read()
        {
            DataContext objnew = null;
            try
            {
                if (File.Exists(DATA_FILE) == false) return null;

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(DATA_FILE, FileMode.Open, FileAccess.Read);
                objnew = (DataContext)formatter.Deserialize(stream);
                //foreach (var d in objnew.University.Departments)
                //{
                //    foreach (var c in d.Classes)
                //    {
                //        foreach (var s in c.Students)
                //        {
                //            Console.WriteLine(s.Name + "\n");
                //        }
                //    }
                //}
                stream.Close();

                //Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                return null;
            }

            return objnew;
        }
    }
}

