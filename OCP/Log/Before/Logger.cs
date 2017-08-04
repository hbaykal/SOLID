using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Log.Before
{
    public class Logger
    {
        private readonly string _whereToLog;
        public Logger(string whereToLog)
        {
            this._whereToLog = whereToLog.ToUpper();
        }

        public void LogError(string message)
        {
            switch (_whereToLog)
            {
                case "TEXTFILE":
                    TextLog.LogError(message);
                    break;
                case "EVENTLOG":
                    EventLog.LogError(message);
                    break;
                // case "DBLOG":
                //If we need DbLog, we must change LogError for switch case
                default:
                    throw new Exception("Unable to log error");
            }
        }

        public void LogInfo(string message)
        {
            switch (_whereToLog)
            {
                case "TEXTFILE":
                    TextLog.LogInfo(message);
                    break;
                case "EVENTLOG":
                    EventLog.LogInfo(message);
                    break;
                // case "DBLOG":
                //If we need DbLog, we must change LogInfo for switch case
                default:
                    throw new Exception("Unable to log error");
            }
        }
    }
}
