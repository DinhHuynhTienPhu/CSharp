using DatabaseIO;
using DatabaseProvider;
using System;
using System.Collections.Generic;
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
        [HttpPost]
        public ActionResult PostName(string personName) {
            ViewBag.name = personName;
            return View("PostName");
        }
    }
}
