using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.After
{
    public interface IMessage
    {
        string From { get; set; }
        string To { get; set; }
        string MessageBody { get; set; }

        void SendMessage();
    }
}
