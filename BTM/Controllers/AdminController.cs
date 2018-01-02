using BTM.App_Start;
using BTMService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace BTM.Controllers
{
    
    public class AdminController : Controller
        {
        IBusService service;

        public AdminController()
        {
            this.service= Injector.Container.Resolve<IBusService>();
        }
        
    // GET: Admin
    public ActionResult Index()
        {
           if(Session["username"]!= null){
                ViewBag.busList = this.service.GetAll().ToList();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}