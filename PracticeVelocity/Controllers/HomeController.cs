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
        // Index Action to main view
        public ActionResult Index()
        {
            return View();
        }

        // Action based on Home
        // Parameter is string of event being called
        public ActionResult PatientResult(String eventType)
        {
            // Add eventType to view
            ViewBag.Message = eventType;

            // Call factory to create object needed
            EventProcessor eventProcessor = EventProcessorFactory.createFromEvent(eventType);

            // Check if object was successfully created
            if(eventProcessor != null)
            {
                // Process the Event and add it to the view for use
                ViewBag.Results = eventProcessor.Process();
            }
            else
            {
                // Event has not been implemented yet
                ViewBag.Error = "No Results at this time.";
            }

            // Return view
            return View();
        }
    }
}