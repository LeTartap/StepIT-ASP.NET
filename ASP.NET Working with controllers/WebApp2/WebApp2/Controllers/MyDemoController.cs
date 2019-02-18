using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp2.Controllers
{

    public class MyDemoController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyIndex()
        {
            return View("Index");
        }
        [Route("Home/About")]
        public ActionResult About()
        {
            return View("About");
        }
        [Route("Home/Contact")]
        public ActionResult MyContact()
        {
            return View("Contact");
        }
        public ActionResult Article(int id)
        {
            ViewData["id"] =id;

            if (id == 1)
            {
                return View("Index");
            }
            else if(id==0)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult david(int? noflines)
        {
            if(noflines==null)
            {
                noflines = 0;
            }
            ViewData["noflines"] = noflines;
            return View("RandomLines");
        }
    }
}