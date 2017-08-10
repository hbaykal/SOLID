using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Before
{
    public interface IMessage
    {
        string From { get; set; }
        string To { get; set; }
        string MessageBody { get; set; }
        int ImageWith { get; set; }
        int ImageHeight { get; set; }
        int MovieDuration { get; set; }

        void SendMessage();
        void AttachImage();
        void AttachMovie();
    }
}
