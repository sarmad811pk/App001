using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyApp.Controllers
{
    public class ParentTeacherController : Controller
    {
        //
        // GET: /ParentTeacher/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ParentTeacherAddEdit(int? ID)
        {
            return View(ID);
        }

    }
}
