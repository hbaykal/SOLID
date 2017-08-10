using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After
{
    public class DbLogger : ILogger
    {
        public bool LogMessage(string message)
        {
            Console.WriteLine("DbLogger.LogMessage: {0}", message);
            return true;
        }

        public bool LogMessage(string message, string callStack)
        {
            throw new NotImplementedException();
        }
    }
}
