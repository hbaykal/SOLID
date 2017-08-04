using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Data.After
{
    public class DatabaseSource : DataSource,IRecordable
    {
        public override void GetAllData()
        {
            Console.WriteLine("DbSource.GetAllData...");
        }

        public void Save()
        {
            Console.WriteLine("DbSource.Save...");
        }
    }
}
