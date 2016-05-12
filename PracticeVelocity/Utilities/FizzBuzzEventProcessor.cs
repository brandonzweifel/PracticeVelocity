using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.Utilities
{
    /// <summary>
    /// Event Processor abstraction implementing the interface
    /// 
    /// Has common method that subclasses will all call
    /// as well as required methods from interface made abstract
    /// for subclass to define
    /// </summary>
    public abstract class FizzBuzzEventProcessor : EventProcessor
    {
        // Returns list of Fizz Buzz based on patientInt and eventInt
        public List<string> evaluate(int patientInt, int eventInt, int startInt, int endInt, string eventName)
        {
            List<string> result = new List<string>();

            // Loop through numbers to add to list
            for (int i = startInt; i <= endInt; i++)
            {
                if (i % eventInt == 0 && i % patientInt == 0)
                {
                    result.Add(eventName + " Patient");
                }
                else if (i % patientInt == 0)
                {
                    result.Add("Patient");
                }
                else if(i % eventInt == 0)
                {
                    result.Add(eventName);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }

        // inherticance of parent method
        // abstract since it doesn't provide an implementation
        public abstract List<string> process();

    } 
}
