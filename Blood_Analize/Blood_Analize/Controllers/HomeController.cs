using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blood_Analize.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //передає інформацію у view
            ViewBag.Message = "Інформація про програму";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Сторінка контактів";

            return View();
        }
        public ActionResult Blood()
        {
            ViewBag.Message = "Правильна розшифровка біохімічного аналізу крові та знання нормальних показників" +
                              " дозволяє дуже точно визначити порушення в водно-сольовому обміні, дисбаланс мікроелементів," +
                              " запальні процеси і інфекції, а так само стан різних органів.";

            return View();
        }
        public ActionResult Children()
        {
            ViewBag.Message = "Сторінка маленьких дітей";

            return View();
        }
    }
}