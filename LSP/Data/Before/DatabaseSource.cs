using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Data.Before
{
    public class DatabaseSource : DataSource
    {
        public override void GetAllData()
        {
           //It is OK
        }

        public override void Save()
        {
           //It is OK
        }
    }
}
