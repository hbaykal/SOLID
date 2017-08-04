using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Data.Before
{
    public abstract class DataSource
    {
        public abstract void GetAllData();
        public abstract void Save();
    }
}
