using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodCatering2.Controllers
{
    public class BillingController : Controller
    {
        // GET: Billing
        public ActionResult Billing()
        {
            ViewBag.Message = "Your Billing page.";
            return View();
        }
    }
}