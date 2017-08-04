using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Data.After
{
    public class XmlSource : DataSource
    {
        public override void GetAllData()
        {
            Console.WriteLine("XmlSource.GetAllData...");
        }
    }
}
