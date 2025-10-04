using rorisangStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rorisangStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        private static List<StudyGroupModel> students = new List<StudyGroupModel>
        {
            new StudyGroupModel { StudentNr = "u22514407", FirstName = "Rorisang", LastName = "Maseko", Email = "u22514407@tuks.co.za" },
            new StudyGroupModel { StudentNr = "u22753436", FirstName = "Asanda", LastName = "Mokobi", Email = "u22854152@tuks.co.za" },
            new StudyGroupModel { StudentNr = "u22496786", FirstName = "Gontlafetse", LastName = "Phetla", Email = "u22768492@tuks.co.za" },
            new StudyGroupModel { StudentNr = "u24717739", FirstName = "Tumisang", LastName = "Mphahlele", Email = "u22532715@tuks.co.za" },
            new StudyGroupModel { StudentNr = "u22714228", FirstName = "Adivhaho", LastName = "Makwarela", Email = "u22114228@tuks.co.za" }
        };

        // GET: ListGroupMembers
        public ActionResult ListGroupMembers()
        {
            return View(students);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(StudyGroupModel newStudent)
        {
            if (ModelState.IsValid)
            {
                students.Add(newStudent);
                return RedirectToAction("ListGroupMembers");
            }
            return View(newStudent);
        }

        // DELETE: Delete
        public ActionResult Delete(string studentNr)
        {
            var student = students.FirstOrDefault(s => s.StudentNr == studentNr);
            if (student != null)
            {
                students.Remove(student);
            }
            return RedirectToAction("ListGroupMembers");
        }

        public ActionResult AdiPage()
        {
            return View("~/Views/HTML/Adi.cshtml");
        }

        public ActionResult AsandaPage()
        {
            return View("~/Views/HTML/Asanda.cshtml");
        }

        public ActionResult GontlaPage()
        {
            return View("~/Views/HTML/Gontla.cshtml");
        }

        public ActionResult RorisangPage()
        {
            return View("~/Views/HTML/Rorisang.cshtml");
        }

        public ActionResult TumisangPage()
        {
            return View("~/Views/HTML/Tumisang.cshtml");
        }

        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}