using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Db.Before
{
    public class Client
    {
        public void Save(List<object> persitables)
        {

            foreach (var item in persitables)
            {
                if (item is AzureDbService)
                {
                    AzureSave((AzureDbService)item);
                }
                else if (item is SqlDbService)
                {
                    SqlDbSave((SqlDbService)item);
                }
                // If we need to use OracleDbService, we must new condition and OracleDbSave method for Oracle
                // OracleDbSave((OracleDbService)item);
                LogMessage("Somebody updated something");
            }
        }

        private void SqlDbSave(SqlDbService container)
        {

            if (container.Select().Count > 0)
            {
                container.Update();
            }
            else
            {
                container.Create();
            }

        }

        private void AzureSave(AzureDbService container)
        {

            if (container.Select().Count > 0)
            {
                container.Delete();
            }

            container.Create();

        }

        private void LogMessage(string msg)
        {
            //Log an audit record
        }

    }
}
