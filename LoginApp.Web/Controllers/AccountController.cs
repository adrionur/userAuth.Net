using LoginApp.Web.Facades.Interfaces;
using LoginApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoginApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserFacade userFacade;

        public AccountController(IUserFacade userFacade)
        {
            this.userFacade = userFacade;
        }

        // GET: Account
        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View(new LoginUserViewModel());
        }

        [HttpPost]
        public ActionResult Login(LoginUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userFacade.Authenticate(model.UserName, model.Password);
                if(user != null)
                    FormsAuthentication.SetAuthCookie(user.ID.ToString(CultureInfo.InvariantCulture), true);
                HttpContext.User = user.Principal;
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}