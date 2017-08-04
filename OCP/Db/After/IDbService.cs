using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Db.After
{
    public interface IDbService
    {
        bool Create();
        List<String> Select();
        int Upsert();
        bool Delete();
    }
}
