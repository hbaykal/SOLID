using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Data.Before
{
    public class DataSourceService
    {
        public void SaveAll(List<DataSource> sourceList)
        {
            //sourceList.ForEach(s => s.Save());
            sourceList.ForEach(s =>
            {
                if (s is XmlSource)
                    return;
                s.Save();
            }
            );
        }
    }
}
