using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public void AddStudent(string id, string name, string date, string cclass, string school, string department) {
            Student student = new Student();
            student.ID = id;
            student.STU_NAME = name;
            DateTime dt;
            DateTime.TryParseExact(date, "yyyyMMdd",
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None, out dt);

            student.DATE_OF_BIRTH = dt;
            student.CLA_ID = cclass;
            student.UNI_ID = school;
            student.DEP_ID = department;
            myDB.Database.ExecuteSqlCommand("insert into Student values ('" + id + "',N'" + name + "','" + date + "','" + cclass + "','" + school + "','" + department + "')");
        }
        public List<Student> GetAllStudent() {
            return myDB.Database.SqlQuery<Student>("select* from STUDENT").ToList();
        }

        public void DeleteStudent(string id,string school) {
            myDB.Database.ExecuteSqlCommand("DELETE FROM STUDENT WHERE id='"+id+"'AND UNI_ID='"+school+"'");

        }
    }
}
