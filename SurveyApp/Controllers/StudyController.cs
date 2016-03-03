using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyApp.Controllers
{
    public class StudyController : Controller
    {
        //
        // GET: /Study/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StudyAddEdit(int? id)
        {
            return View(id);
        }

    }
}
