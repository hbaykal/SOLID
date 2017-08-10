using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After
{
    public interface ILogger
    {
        bool LogMessage(string message);
        bool LogMessage(string message, string callStack);
    }
}
