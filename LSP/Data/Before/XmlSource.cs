using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Data.Before
{
    public class XmlSource : DataSource
    {
        public override void GetAllData()
        {
            //It is OK
        }

        public override void Save()
        {
            //It is NOT OK. Xmlsource don't use Save method.
        }
    }
}
