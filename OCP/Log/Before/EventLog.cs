﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Log.Before
{
    public class EventLog
    {
        public static void LogError(string message)
        {
            Console.WriteLine("EventLog.LogError method...");
        }

        public static void LogInfo(string message)
        {
            Console.WriteLine("EventLog.LogInfo method...");
        }
    }
}
