using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeVelocity.Utilities;

namespace PracticeVelocity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PatientResult(String eventType)
        {
            ViewBag.Message = eventType;

            EventProcessor eventProcessor = EventProcessorFactory.createFromEvent(eventType);

            if(eventProcessor != null)
            {
                ViewBag.Results = eventProcessor.Process();
            }
            else
            {
                ViewBag.Results = "No Results at this time.";
            }

            return View();
        }
    }
}