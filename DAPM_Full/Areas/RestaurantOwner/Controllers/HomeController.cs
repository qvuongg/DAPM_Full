using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAPM_Full.Areas.RestaurantOwner.Controllers
{
    public class HomeController : Controller
    {
        // GET: RestaurantOwner/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}