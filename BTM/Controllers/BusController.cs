using BTM.App_Start;
using BTMEntity;
using BTMService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTM.Controllers
{
    public class BusController : Controller
    {
       
        IBusService service;
        
        public BusController()
        {
            this.service = Injector.Container.Resolve<IBusService>();
        }

        // GET: Bus
        public ActionResult Index()
        {
            if (Session["username"] != null)
            {
                ViewBag.busList = this.service.GetAll().ToList();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }
        [HttpGet]
        public ActionResult Create()
        {
            if (Session["username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }

        [HttpPost,ActionName("Create")]
        public ActionResult Insert()
        {
            if (Session["username"] != null)
            {
                Bus bus = new Bus();
                bus.Name = Request.Form["bus_name"];

                service.Insert(bus);
                return RedirectToAction("Index", "Bus");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }
    }
}