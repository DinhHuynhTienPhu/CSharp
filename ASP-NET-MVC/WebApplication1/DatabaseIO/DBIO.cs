using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseIO
{
   public class DBIO
    {
        MyDB myDB = new MyDB();
        public Student GetStudentByID(string id) {
            string SQL = "select * from STUDENT where ID='" + id + "'";
           return myDB.Database.SqlQuery<Student>(SQL).FirstOrDefault();
        }
    }
}
