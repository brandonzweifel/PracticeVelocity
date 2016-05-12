using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.Utilities
{
    public abstract class AbstractEventProcessor : EventProcessor
    {

        public List<string> Evaluate(int patientInt, int eventInt, int startInt, int endInt, string eventName)
        {
            List<string> result = new List<string>();

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

        public abstract List<string> Process();

    } 
}
