using BTM.App_Start;
using BTMService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTM.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login

        public ActionResult Index()
        {
            return View();
        }

        ISpecialUserService service;

        public LoginController()
        {
            this.service = Injector.Container.Resolve<ISpecialUserService>();
        }

        [HttpPost, ActionName("Index")]
        public ActionResult login()
        {
            String email = Request.Form["username"];
            String password = Request.Form["password"];

            var data = this.service.Validate(email,password);

            if(data != null)
            {
                Session["username"] = email;
                Session["password"] = password;
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }

    }


}