using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeVelocity.Utilities
{
    public class DiagnoseEventProcessor : AbstractEventProcessor
    {
        public int patientInt { get; private set; }
        public int diagnoseInt { get; private set; }
        public int startInt { get; private set; }
        public int endInt { get; private set; }
        public string eventName { get; private set; }

        public DiagnoseEventProcessor()
        {
            patientInt = 7;
            diagnoseInt = 2;
            startInt = 1;
            endInt = 100;
            eventName = "Diagnose";
        }

        public override List<string> Process()
        {
            return Evaluate(patientInt, diagnoseInt, startInt, endInt, eventName);
        }
    }
}