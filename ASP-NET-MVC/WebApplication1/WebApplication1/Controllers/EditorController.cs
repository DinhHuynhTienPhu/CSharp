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
