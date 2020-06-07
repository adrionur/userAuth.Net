using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginApp.Entity;

namespace LoginApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private User currentUser;
        public User CurrentUser
        {
            get
            {
                if (currentUser == null)
                {
                    var item = User.Identity.Name;
                    currentUser = null;//repo'dan çek
                }
                return currentUser;
            }
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}