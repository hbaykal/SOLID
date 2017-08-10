using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After
{
    public class CoordinatingService : ICoordinatingServices
    {
        ILogger log;
        public CoordinatingService(ILogger logger)
        {
            log = logger;
        }
        public void CoordinateTransaction(IList<IWidget> widgets)
        {
            //Begin Transaction
            foreach (var item in widgets)
            {
                item.DoWork();
            }
            //Commit...
        }
    }
}
