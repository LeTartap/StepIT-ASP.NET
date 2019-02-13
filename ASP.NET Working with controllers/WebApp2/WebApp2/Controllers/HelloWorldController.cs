using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode($"Hello {name}, NumTimes is: {numTimes}");
        //}
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode($"Hello {name}, ID: {ID}");
        }
    }
}