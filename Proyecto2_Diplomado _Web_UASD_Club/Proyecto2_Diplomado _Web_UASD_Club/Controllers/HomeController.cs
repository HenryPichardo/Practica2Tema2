using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto2_Diplomado__Web_UASD_Club.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Fundadores()
        {
            return View();
        }
        public ActionResult Campeonatos()
        {
            return View();
        }
    }
}