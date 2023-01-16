using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.BL
{
    public class SQLServer: DataAccess
    {
       

        public override string GettingData()
        {
            return $"Getting Data from SQL Server {base.Server}";
        }
        public override string SavingData()
        {
            return $"Saving Data to SQL {base.Server}";
        }

    }
}
