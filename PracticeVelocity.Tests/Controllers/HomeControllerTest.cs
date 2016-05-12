using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeVelocity;
using PracticeVelocity.Controllers;
using PracticeVelocity.Utilities;


namespace PracticeVelocity.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PatientResultsRegister()
        {
            // Arrange
            HomeController controller = new HomeController();

            RegisterEventProcessor eventType = new RegisterEventProcessor();

            // Act
            ViewResult result = controller.PatientResult(eventType.eventName) as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            Assert.AreEqual("register", eventType.eventName.ToLower());
            List<string> eval = result.ViewBag.Results;

            Assert.AreEqual(eval.Count, (eventType.endInt - eventType.startInt)+1);

            int i = eventType.startInt;

            foreach (string temp in eval)
            {
                if (i % eventType.registerInt == 0 && i % eventType.patientInt == 0)
                {
                    Assert.AreEqual("Register Patient", temp);
                }
                else if (i % eventType.patientInt == 0)
                {
                    Assert.AreEqual("Patient", temp);
                }
                else if (i % eventType.registerInt == 0)
                {
                    Assert.AreEqual(eventType.eventName, temp);
                }
                else
                {
                    Assert.AreEqual(i.ToString(), temp);
                }

                i++;
            }
        }

        [TestMethod]
        public void PatientResultsDiagnose()
        {
            // Arrange
            HomeController controller = new HomeController();
            DiagnoseEventProcessor eventType = new DiagnoseEventProcessor();

            // Act
            ViewResult result = controller.PatientResult(eventType.eventName) as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            Assert.AreEqual("diagnose", eventType.eventName.ToLower());
            List<string> eval = result.ViewBag.Results;

            Assert.AreEqual(eval.Count, (eventType.endInt - eventType.startInt)+1);

            int i = eventType.startInt;
               
            foreach(string temp in eval)
            {
                if(i % eventType.diagnoseInt == 0 && i % eventType.patientInt == 0)
                {
                    Assert.AreEqual("Diagnose Patient", temp);
                }
                else if (i % eventType.patientInt == 0)
                {
                    Assert.AreEqual("Patient", temp);
                }
                else if (i % eventType.diagnoseInt == 0)
                {
                    Assert.AreEqual(eventType.eventName, temp);
                }
                else
                {
                    Assert.AreEqual(i.ToString(), temp);
                }

                i++;
            }
            
        }

        [TestMethod]
        public void PatientResultsNotExists()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.PatientResult("DOES_NOT_EXIST") as ViewResult;

            // Assert
            Assert.IsNotNull(result);

            Assert.AreEqual("No Results at this time.", result.ViewBag.Error);
        }
    }
}
