using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Authentication.Controllers
{
    public class PasswordHasherController : Controller
    {
        // GET: PasswordHasher
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEncryptedStrings(String unencryptedString)
        {

            var sha256Result = sha256(unencryptedString);
            var saltedResult = sha256(salFunction(unencryptedString));
            return Json(new { sha256 = sha256Result, salted =saltedResult },
                JsonRequestBehavior.AllowGet);
        }
        private string salFunction(string unencryptedString)
        {
            string returnedString="";
            for (int i = 0; i < unencryptedString.Length;i++)
            {
                if(i!=0 && i%2==0)
                {
                    returnedString += "12";
                }
                returnedString += unencryptedString.ElementAt(i);               
                
            }
            return returnedString;
        }



        [NonAction]
        private string sha256(string input)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(input));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
    }
}