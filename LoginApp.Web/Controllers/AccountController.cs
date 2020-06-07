using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
                return View("Home", "Index");
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }
    }
}