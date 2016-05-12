using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.Utilities
{
    /// <summary>
    /// EventProcessor interace
    /// 
    /// All subclasses contain the methods provided
    /// </summary>
    public interface EventProcessor
    {
        List<string> Process();
    }
}
