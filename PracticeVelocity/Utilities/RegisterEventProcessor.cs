using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeVelocity.Utilities
{
    public class RegisterEventProcessor : AbstractEventProcessor
    {
        public int patientInt { get; private set; }
        public int registerInt { get; private set; }
        public int startInt { get; private set; }
        public int endInt { get; private set; }
        public string eventName { get; private set; }

        public RegisterEventProcessor()
        {
            patientInt = 5;
            registerInt = 3;
            startInt = 1;
            endInt = 100;
            eventName = "Register";
        }
        public override List<string> Process()
        {
            return Evaluate(patientInt, registerInt, startInt, endInt, eventName);
        }

    }
}