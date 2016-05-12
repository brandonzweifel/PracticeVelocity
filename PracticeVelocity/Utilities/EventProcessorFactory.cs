using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeVelocity.Utilities
{
    public class EventProcessorFactory
    {
        public static EventProcessor createFromEvent(string eventName)
        {
            if (eventName.Equals("register", StringComparison.InvariantCultureIgnoreCase))
            {
                return new RegisterEventProcessor();

            }
            else if (eventName.Equals("diagnose", StringComparison.InvariantCultureIgnoreCase))
            {
                return new DiagnoseEventProcessor();
            }

            return null;
        }
    }
}