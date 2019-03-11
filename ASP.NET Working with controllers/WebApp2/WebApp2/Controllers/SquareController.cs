using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp2.Controllers
{
    public class SquareController : Controller
    {
        // GET: Square
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexAsync()
        {
            return View();
        }
        public string changeAColor()
        {
            var colors = new List<string> { "red", "blue", "green", "yellow", "cyan", "white", "pink", "black" };

            var finalColors = "";
            Random rnd = new Random();            
            int randomElem = rnd.Next(0, colors.Count - 1);
            finalColors = colors.ElementAt(randomElem);           
            return JsonConvert.SerializeObject(finalColors);
            //return JsonConvert.SerializeObject(new List<string> { "blue", "green", "yellow" });
        
        }
        public string changeColors()
        {
            var colors = new List<string> { "red", "blue", "green", "yellow", "cyan", "white", "pink", "black" };

            int numOfColors = 3;
            var finalColors = new List<string>();
            Random rnd = new Random();
            for(int i =0;i<numOfColors;i++)
            {
                int randomElem = rnd.Next(0, colors.Count - 1);
                finalColors.Add(colors.ElementAt(randomElem));
                colors.RemoveAt(randomElem);         
            }
            return JsonConvert.SerializeObject(finalColors);
            //return JsonConvert.SerializeObject(new List<string> { "blue", "green", "yellow" });
        }
    }
}