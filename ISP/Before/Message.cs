using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Before
{
    public class Message : IMessage
    {
        //https://www.turkayurkmez.com/arayuzlerin-ayrimi-prensibi-isp-interface-segregation-principle/
        //Mesaj nesnesi her zaman bir resme ya da videoya sahip olacak mı? 
        //Yani istemci-sunucu arasında trafikte olacak bu nesne, sadece metin mesajı içeriyorsa ImageWidth, MovieDuration gibi özellikleri kullanmama gerek var mı sizce? 
        //Evet, bence de yok! IMessage interface’ini biraz daha sadeleştirerek bu mimari sorunu çözebiliriz sanırım.
        public string From { get; set; }

        public int ImageHeight { get; set; }

        public int ImageWith { get; set; }

        public string MessageBody { get; set; }

        public int MovieDuration { get; set; }

        public string To { get; set; }

        public void AttachImage()
        {
            throw new NotImplementedException();
        }

        public void AttachMovie()
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
