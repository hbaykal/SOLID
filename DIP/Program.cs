using DIP.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            DbLoggerTest();


            Console.Read();
        }

        private static void DbLoggerTest()
        {
            //Call the service layer for this
            var service = new CoordinatingService(new DbLogger());
            //Normally this would be Extracted from the request
            service.CoordinateTransaction(new List<IWidget>{
                new Widget(new DbLogger()){Length=3,Width=4},
                new Widget(new DbLogger()){Length=5,Width=6}
            });
        }
    }
}
