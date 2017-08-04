using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Data.After
{
    public class DataSourceService
    {
        public void SaveAll(List<IRecordable> sourceList)
        {
            sourceList.ForEach(s => s.Save());
        }
    }
}
