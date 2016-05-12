using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeVelocity.Utilities
{
    /// <summary>
    /// Diagnose Event Processor
    /// 
    /// extends abstract class AbstactEventProcessor and implements
    /// the interface EventProcessor
    /// </summary>
    public class DiagnoseEventProcessor : FizzBuzzEventProcessor
    {
        public int patientInt { get; private set; }     // int divisor to print "Patient"
        public int diagnoseInt { get; private set; }    // int divisor to print "Diagnose"
        public int startInt { get; private set; }       // Start int of list
        public int endInt { get; private set; }         // End int of list
        public string eventName { get; private set; }   // Name of event

        // Initializes Variables in constructor
        public DiagnoseEventProcessor()
        {
            patientInt = 7;
            diagnoseInt = 2;
            startInt = 1;
            endInt = 100;
            eventName = "Diagnose";
        }

        // Calls parent's class method with objects parameters 
        public override List<string> process()
        {
            return Evaluate(patientInt, diagnoseInt, startInt, endInt, eventName);
        }
    }
}