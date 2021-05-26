using DatabaseIO;
using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EditorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit() {
            ViewBag.Message = "Edit page";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "login page";

            return View("Edit");
        }
        public ActionResult QueryPage() {
            return View();
        }
        #region student
        public ActionResult ReturnStudentByID( string studentID) {
            DBIO dbio = new DBIO();
            Student stu = dbio.GetStudentByID(studentID);
            return View(stu);
        }
        public ActionResult AddStudent(string id, string name, string date, string cclass, string school, string department) {
            DBIO dbio = new DBIO();

            dbio.AddStudent(id, name, date, cclass, school, department);

            ViewBag.notification = "Added student with id= " + id;
            return View("Notify");
        }
        public ActionResult DeleteStudent(string studentID,string school) {
            DBIO dbio = new DBIO();
            dbio.DeleteStudent(studentID,school);
            ViewBag.notification = "removed student with id= " + studentID;
            return View("Notify");
        }
        public ActionResult GetAllStudent() {
            DBIO dbio = new DBIO();
           return View("ReturnAllStudent",dbio.GetAllStudent());
            
        }
        public ActionResult EditStudent(string studentID) {
            DBIO dbio = new DBIO();
            Student stu = dbio.GetStudentByID(studentID);
            return View(stu);
        }
        public ActionResult DoneEditStudent(string id, string name, string date, string cclass, string school, string department) {


            DBIO dbio = new DBIO();
            dbio.EditStudent(id, name, date, cclass, school, department);
            ViewBag.notification = "Updated your changes";
            return View("Notify");
        }
        #endregion
        #region class
        public ActionResult ReturnClassByID( string classID) {
            DBIO dbio = new DBIO();
            Class cclass = dbio.GetClassByID(classID);
            return View(cclass);
        }
        public ActionResult AddClass(string id, string name,  string school, string department) {
            DBIO dbio = new DBIO();

            dbio.AddClass(id, name,  school, department);

            ViewBag.notification = "Added class with id= " + id;
            return View("Notify");
        }
        public ActionResult DeleteClass(string classID,string school, string department) {
            DBIO dbio = new DBIO();
            dbio.DeleteClass(classID);
            ViewBag.notification = "removed class with id= " + classID;
            return View("Notify");
        }
        public ActionResult GetAllClass() {
            DBIO dbio = new DBIO();
           return View("ReturnAllClass",dbio.GetAllClass());
            
        }
        public ActionResult EditClass(string classID,string school,string department) {
            DBIO dbio = new DBIO();
            Class c = dbio.GetClassByID(classID);
            return View(c);
        }
        public ActionResult DoneEditClass(string id, string name, string school, string department) {


            DBIO dbio = new DBIO();
            dbio.EditClass(id, name, school, department);
            ViewBag.notification = "Updated your changes";
            return View("Notify");
        }
        #endregion 
        #region department
        public ActionResult ReturnDepartmentByID( string departmentID) {
            DBIO dbio = new DBIO();
            Department d = dbio.GetDepartmentByID(departmentID);
            return View(d);
        }
        public ActionResult AddDepartment(string id, string name,  string school) {
            DBIO dbio = new DBIO();

            dbio.AddDepartment(id, name,  school);

            ViewBag.notification = "Added department with id= " + id;
            return View("Notify");
        }
        public ActionResult DeleteDepartment(string school, string department) {
            DBIO dbio = new DBIO();
            dbio.DeleteDepartment(department);
            ViewBag.notification = "removed depatment with id= " + department;
            return View("Notify");
        }
        public ActionResult GetAllDepartment() {
            DBIO dbio = new DBIO();
           return View("ReturnAllDepartment",dbio.GetAllDepartment());
            
        }
        public ActionResult EditDepartment(string departmentID,string school) {
            DBIO dbio = new DBIO();
            Department  c = dbio.GetDepartmentByID(departmentID);
            return View(c);
        }
        public ActionResult DoneEditDepartment(string id, string name, string school) {


            DBIO dbio = new DBIO();
            dbio.EditDepartment(id, name,  school);
            ViewBag.notification = "Updated your changes";
            return View("Notify");
        }
        #endregion
        #region university/school
        public ActionResult ReturnUniversityByID( string universityID)
        {
            DBIO dbio = new DBIO();
            University d = dbio.GetUniversityByID(universityID);
            return View(d);
        }
        public ActionResult AddUniversity(string id, string name)
        {
            DBIO dbio = new DBIO();

            dbio.AddUniversity(id, name);

            ViewBag.notification = "Added university with id= " + id;
            return View("Notify");
        }
        public ActionResult DeleteUniversity(string id)
        {
            DBIO dbio = new DBIO();
            dbio.DeleteUniversity(id);
            ViewBag.notification = "removed university with id= " + id;
            return View("Notify");
        }
        public ActionResult GetAllUniversity()
        {
            DBIO dbio = new DBIO();
            return View("ReturnAllUniversity", dbio.GetAllUniversity());

        }
        public ActionResult EditUniversity(string universityID)
        {
            DBIO dbio = new DBIO();
            University c = dbio.GetUniversityByID(universityID);
            return View(c);
        }
        public ActionResult DoneEditUniversity(string id, string name)
        {


            DBIO dbio = new DBIO();
            dbio.EditUniversity(id, name);
            ViewBag.notification = "Updated your changes";
            return View("Notify");
        }
        #endregion
        public ActionResult Notify() {

            return View();
        }

        [HttpPost]
        public ActionResult PostName(string personName) {
            ViewBag.name = personName;
            return View("PostName");
        }
    }
}
