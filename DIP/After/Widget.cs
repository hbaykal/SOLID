using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After
{
    public class Widget : IWidget
    {
        ILogger log;
        public int Length { get; set; }
        public int Width { get; set; }
        public string OtherStuffNotPersisted { get; set; }

        public Widget(ILogger _log)
        {
            log = _log;
        }

        public bool DoWork()
        {
            log.LogMessage("Hello World");
            return true;
        }
    }
}
