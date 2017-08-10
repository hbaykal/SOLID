using ISP.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMovieMessage();

            Console.Read();
                
        }

        public static void SendMovieMessage()
        {
            MovieMessage msg = new MovieMessage();
            msg.From = "A";
            msg.To = "B";
            msg.MessageBody = "Message Body";
            msg.MovieDuration = 12;

            MovieMessage.SendMessage(msg);

        }
    }
}
