using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalQuizProgram.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult Charts()
        {
            return View();
        }

        public ActionResult Chart2()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        public ActionResult Show2()
        {
            return View();
        }
    }
}