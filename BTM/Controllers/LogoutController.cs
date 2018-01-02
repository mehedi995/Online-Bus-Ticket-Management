using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTM.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            if (Session["username"] != null)
            {
                Session["username"] = null;
                Session["password"] = null;
                
            }
            return RedirectToAction("Index", "Login");
        }
    }
}