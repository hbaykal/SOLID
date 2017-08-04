using LSP.Data.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            AfterTest();
            Console.ReadLine();
        }

        public static void AfterTest()
        {
            DataSourceService dbService = new DataSourceService();
            List<IRecordable> dbList = new List<IRecordable>();
            dbList.Add(new DatabaseSource());
            dbList.Add(new DatabaseSource());
            dbService.SaveAll(dbList);
        }
    }
}
