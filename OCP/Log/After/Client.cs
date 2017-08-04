using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Log.After
{
    public class Client
    {
        public static void LogWrite()
        {
            //Burada hata var kontrol et
            //LogService logger = new LogService(new TextLog());
            //logger.LogError("test");
            Logger logger = LogService.GetLogger(new TextLog());
            logger.LogInfo("deneme");

            Logger logger2 = LogService.GetLogger(new EventLog());
            logger2.LogError("deneme");
            Console.ReadLine();
        }
    }
}
