using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Log.After
{
    public abstract class Logger
    {
        public abstract void LogError(string message);
        public abstract void LogInfo(string message);
        public abstract void LogWarn(string message);
    }
}
