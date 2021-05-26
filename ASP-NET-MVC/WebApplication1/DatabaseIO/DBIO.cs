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
            DateTime.TryParseExact(date, "yyyy/MM/dd",
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
        public void EditStudent(string id,string name, string date, string cclass, string school, string department) {
            //myDB.Database.ExecuteSqlCommand("insert into Student values ('" + id + "',N'" + name + "','" + date + "','" + cclass + "','" + school + "','" + department + "')");

            myDB.Database.ExecuteSqlCommand("update Student set STU_NAME  = N'"+name+"' where Student.ID = '" + id+"'");

            myDB.Database.ExecuteSqlCommand("update Student set DATE_OF_BIRTH   = '" + date+"' where Student.ID = '" + id+"'");
            myDB.Database.ExecuteSqlCommand("update Student set CLA_ID   = '" + cclass+ "', UNI_ID   = '" + school + "' , DEP_ID   = '" + department + "' where Student.ID = '" + id+"'");
           // myDB.Database.ExecuteSqlCommand("update Student set UNI_ID   = '" + school+"' where Student.ID = '" + id+"'");
            //myDB.Database.ExecuteSqlCommand("update Student set DEP_ID   = '" + department+"' where Student.ID = '" + id+"'");
        }
        #region class
        public Class GetClassByID(string id) {
            string SQL = "select * from class where ID='" + id + "'";// and UNI_ID='"+school+"' and DEP_ID='"+ department+"'";
           return myDB.Database.SqlQuery<Class>(SQL).FirstOrDefault();
        }
        public void AddClass(string id, string name,  string school, string department) {
            string sql = "insert into Class(ID,CLA_NAME,UNI_ID,DEP_ID) values ('" + id + " ',N'" + name + " ','" + school + " ','" + department + "')";
            myDB.Database.ExecuteSqlCommand(sql);
        }
        public List<Class> GetAllClass() {
            return myDB.Database.SqlQuery<Class>("select* from CLASS").ToList();
        }
        public void DeleteClass(string id) {
            myDB.Database.ExecuteSqlCommand("DELETE FROM CLASS WHERE id='" + id + "'");// AND UNI_ID='"+school+"' and DEP_ID='"+department+"'" );

        }
        public void EditClass(string id,string name, string school, string department) {
            //myDB.Database.ExecuteSqlCommand("insert into Student values ('" + id + "',N'" + name + "','" + date + "','" + cclass + "','" + school + "','" + department + "')");

            myDB.Database.ExecuteSqlCommand("update Class set CLA_NAME  = N'"+name+ "', UNI_ID   = '" + school + "' , DEP_ID   = '" + department+"'  where ID = '" + id+"'");

            //myDB.Database.ExecuteSqlCommand("update Class set UNI_ID   = '" + school+"' where ID = '" + id+"'");
            //.myDB.Database.ExecuteSqlCommand("update Class set DEP_ID   = '" + department+"' where ID = '" + id+"'");
        }
        #endregion

        #region department
        public Department GetDepartmentByID(string id)
        {
            string SQL = "select * from Department where ID='" + id + "'";
            return myDB.Database.SqlQuery<Department>(SQL).FirstOrDefault();
        }
        public void AddDepartment(string id, string name, string school)
        {
            string sql = "insert into department(ID,DEP_NAME,UNI_ID) values ('" + id + " ',N'" + name + " ','" + school + "')";
            myDB.Database.ExecuteSqlCommand(sql);
        }
        public List<Department> GetAllDepartment()
        {
            return myDB.Database.SqlQuery<Department>("select* from department").ToList();
        }
        public void DeleteDepartment(string id)
        {
            myDB.Database.ExecuteSqlCommand("DELETE FROM department WHERE id='" + id + "'");

        }
        public void EditDepartment(string id, string name, string school)
        {
            //myDB.Database.ExecuteSqlCommand("insert into Student values ('" + id + "',N'" + name + "','" + date + "','" + cclass + "','" + school + "','" + department + "')");

            myDB.Database.ExecuteSqlCommand("update department set DEP_NAME  = N'" + name + "' where ID = '" + id + "' and UNI_ID='"+school+"'");

        }
        #endregion

        #region university/school
        public University GetUniversityByID(string id)
        {
            string SQL = "select * from University where ID='" + id + "'";// and UNI_ID='" + school + "'";
            return myDB.Database.SqlQuery<University>(SQL).FirstOrDefault();
        }
        public void AddUniversity(string id, string name)
        {
            string sql = "insert into University(ID,UNI_NAME) values ('" + id + "',N'" + name + "')";
            myDB.Database.ExecuteSqlCommand(sql);
        }
        public List<University> GetAllUniversity()
        {
            return myDB.Database.SqlQuery<University>("select* from University").ToList();
        }
        public void DeleteUniversity(string id)
        {
            myDB.Database.ExecuteSqlCommand("DELETE FROM University WHERE id='" + id + "'");

        }
        public void EditUniversity(string id, string name)
        {
            //myDB.Database.ExecuteSqlCommand("insert into Student values ('" + id + "',N'" + name + "','" + date + "','" + cclass + "','" + school + "','" + department + "')");

            myDB.Database.ExecuteSqlCommand("update University set UNI_NAME  = N'" + name + "' where ID = '" + id + "' ");// and UNI_ID='" + school + "'");

        }
        #endregion
    }
}
