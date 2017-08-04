using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Log.Before
{
    public class TextLog
    {
        public static void LogError(string message)
        {
            Console.WriteLine("TextLog.LogError method...");
        }

        public static void LogInfo(string message)
        {
            Console.WriteLine("TextLog.LogInfo method...");
        }
    }
}
