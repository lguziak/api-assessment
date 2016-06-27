using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessemet.Business.Abstractions
{
    public abstract class ConsoleRequirement
    {
        abstract public Boolean WriteToConsole(string message);
    }
}
