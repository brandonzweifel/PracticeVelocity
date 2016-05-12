using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeVelocity.Utilities
{
    /// <summary>
    /// Register Event Processor
    /// 
    /// extends abstract class AbstactEventProcessor and implements
    /// the interface EventProcessor
    /// </summary>
    public class RegisterEventProcessor : FizzBuzzEventProcessor
    {
        public int patientInt { get; private set; }     // int divisor to print "Patient"
        public int registerInt { get; private set; }    // int divisor to print "Register"
        public int startInt { get; private set; }       // Start int of list
        public int endInt { get; private set; }         // End int of list
        public string eventName { get; private set; }   // Name of event

        // Initializes Variables in constructor
        public RegisterEventProcessor()
        {
            patientInt = 5;
            registerInt = 3;
            startInt = 1;
            endInt = 100;
            eventName = "Register";
        }

        // Calls parent's class method with objects parameters 
        public override List<string> process()
        {
            return evaluate(patientInt, registerInt, startInt, endInt, eventName);
        }

    }
}