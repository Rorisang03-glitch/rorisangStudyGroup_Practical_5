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
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<Models.StudyGroupModel> students = new List<Models.StudyGroupModel>();
            students.Add(new Models.StudyGroupModel { StudentNr = "u22514407", FirstName = "Rorisang", LastName = "Maseko", Email = "u22514407@tuks.co.za" });
            students.Add(new Models.StudyGroupModel { StudentNr = "u22753436", FirstName = "Bokang", LastName = "Seena", Email = "4227534369tuks.co.za" });
            students.Add(new Models.StudyGroupModel { StudentNr = "u22496786", FirstName = "Alex", LastName = "Steven", Email = "u22496786@tuks.co.za" });
            students.Add(new Models.StudyGroupModel { StudentNr = "u24717739", FirstName = "Ritshi", LastName = "Nedzimaul1", Email = "u247177399tuks.co.za" });
            students.Add(new Models.StudyGroupModel { StudentNr = "u22714228", FirstName = "Adivhaho", LastName = "Makmarela", Email = "u221142289tuks.co.za" });
            return View(students);

        }
    }
}