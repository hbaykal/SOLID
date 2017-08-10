using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.After
{
    public class MovieMessage : IMessage
    {
        public string From { get; set; }
        public string MessageBody { get; set; }
        public string To { get; set; }
        public int MovieDuration { get; set; }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }

        public static void SendMessage(IMessage message)
        {
            Console.WriteLine("MovieMessage.SendMessage ->");
        }


        public void AttachMovie(byte[] stream)
        {
            Console.WriteLine("MovieMessage movie attached");
        }
    }
}
