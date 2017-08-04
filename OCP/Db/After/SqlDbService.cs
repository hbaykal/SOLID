using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Db.After
{
    public class SqlDbService : IDbService
    {
        public bool Create()
        {
            throw new NotImplementedException();
        }

        public List<string> Select()
        {
            throw new NotImplementedException();
        }

        public int Upsert()
        {
            int count = 1;
            if (this.Select().Count() > 0)
            {
                count = this.Delete();
            }
            this.Create();
            return count;
        }


        public int Delete()
        {
            throw new NotImplementedException();
        }

        bool IDbService.Delete()
        {
            throw new NotImplementedException();
        }
    }
}
