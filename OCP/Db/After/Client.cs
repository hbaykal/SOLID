using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Db.After
{
    public class Client
    {
        public void Save(List<IDbService> persitables)
        {
            foreach (var item in persitables)
            {
                item.Upsert();
                LogMessage("Somebody updated something");
            }
        }

        public void Delete(IDbService dbService)
        {
            dbService.Delete();
        }
        

        private void LogMessage(string msg)
        {
            //Log an audit record
        }
    }
}
