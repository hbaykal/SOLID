using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Log.After
{
    public class TextLog : Logger
    {
        public override void LogError(string message)
        {
            Console.WriteLine("TextLog.LogError....");
        }

        public override void LogInfo(string message)
        {
            Console.WriteLine("TextLog.LogInfo....");
        }

        public override void LogWarn(string message)
        {
            Console.WriteLine("TextLog.LogWarn....");
        }
    }
}
