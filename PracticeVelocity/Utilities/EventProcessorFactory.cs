using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeVelocity.Utilities
{
    /// <summary>
    /// Factory Design Pattern
    /// 
    /// One method to return the object needed
    /// </summary>
    public class EventProcessorFactory
    {
        public static EventProcessor createFromEvent(string eventName)
        {
            // Return correct object of Event based on eventName parameter
            if(eventName != null)
            {
                if (eventName.Equals("register", StringComparison.InvariantCultureIgnoreCase))
                {
                    return new RegisterEventProcessor();

                }
                else if (eventName.Equals("diagnose", StringComparison.InvariantCultureIgnoreCase))
                {
                    return new DiagnoseEventProcessor();
                }
            }

            return null;
        }
    }
}