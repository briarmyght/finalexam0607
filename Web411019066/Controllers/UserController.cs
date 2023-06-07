using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411019066.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music(string name,float? number)
        {
            var result = "";

            if (number.HasValue)
            {
               

            }
            ViewBag.name = name;
            ViewBag.result = result;
            return View();
        }
        
    }
}