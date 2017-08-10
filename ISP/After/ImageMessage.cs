using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.After
{
    public class ImageMessage : IMessage
    {
        public string From { get; set; }
        public string MessageBody { get; set; }
        public string To { get; set; }
        public int ImageWidth { get; set; }
        public int Height { get; set; }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }

        public void AttachImage(byte[] stream)
        { }
    }
}
