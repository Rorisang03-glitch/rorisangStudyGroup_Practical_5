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
            students.Add(new Models.StudyGroupModel { StudentNr = "u22514407", FirstName = "Rorisang", LastName = "Maseko", Email = "u22514407@tuks.co.za", myLink = "C:\\Users\\lenovo\\source\\repos\\rorisangStudyGroup\\rorisangStudyGroup\\Views\\HTML\\Rorisang.cshtml" });
            students.Add(new Models.StudyGroupModel { StudentNr = "u22753436", FirstName = "Asanda", LastName = "Mokobi", Email = "u22854152@tuks.co.za", myLink = "C:\\Users\\lenovo\\source\\repos\\rorisangStudyGroup\\rorisangStudyGroup\\Views\\HTML\\Bokang.cshtml" });
            students.Add(new Models.StudyGroupModel { StudentNr = "u22496786", FirstName = "Gontlafetse", LastName = "Phetla", Email = "u22768492@tuks.co.za", myLink = "C:\\Users\\lenovo\\source\\repos\\rorisangStudyGroup\\rorisangStudyGroup\\Views\\HTML\\Alex.cshtml" });
            students.Add(new Models.StudyGroupModel { StudentNr = "u24717739", FirstName = "Tumisang", LastName = "Mphahlele", Email = "u22532715@tuks.co.za", myLink = "C:\\Users\\lenovo\\source\\repos\\rorisangStudyGroup\\rorisangStudyGroup\\Views\\HTML\\Ritshi.cshtml" });
            students.Add(new Models.StudyGroupModel { StudentNr = "u22714228", FirstName = "Adivhaho", LastName = "Makwarela", Email = "u22114228@tuks.co.za", myLink = "C:\\Users\\lenovo\\source\\repos\\rorisangStudyGroup\\rorisangStudyGroup\\Views\\HTML\\Adi.cshtml" });
            return View(students);

        }
    }
}