using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Log.After
{
    public class EventLog : Logger
    {
        public override void LogError(string message)
        {
            Console.WriteLine("EventLog.LogError....");
        }

        public override void LogInfo(string message)
        {
            Console.WriteLine("EventLog.LogInfo....");
        }

        public override void LogWarn(string message)
        {
            Console.WriteLine("EventLog.LogWarn....");
        }
    }
}
